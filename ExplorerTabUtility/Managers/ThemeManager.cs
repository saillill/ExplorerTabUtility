using System;
using System.Windows;
using Microsoft.Win32;

namespace ExplorerTabUtility.Managers;

public enum AppTheme { System, Dark, Light }

public static class ThemeManager
{
    private const string ThemeKey = @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
    private const string AppsUseLightTheme = "AppsUseLightTheme";
    private const string ColorsDarkPath = "pack://application:,,,/ExplorerTabUtility;component/UI/Themes/Colors.Dark.xaml";
    private const string ColorsLightPath = "pack://application:,,,/ExplorerTabUtility;component/UI/Themes/Colors.Light.xaml";

    private static ResourceDictionary? _currentThemeDict;

    public static AppTheme CurrentTheme
    {
        get => (AppTheme)(SettingsManager.ThemeMode);
        set
        {
            if ((int)value == SettingsManager.ThemeMode) return;
            SettingsManager.ThemeMode = (int)value;
            ApplyTheme();
        }
    }

    public static void Initialize()
    {
        SystemEvents.UserPreferenceChanged += (s, e) =>
        {
            if (e.Category == UserPreferenceCategory.General && CurrentTheme == AppTheme.System)
                ApplyTheme();
        };
    }

    public static void ApplyTheme()
    {
        var dictionaries = Application.Current.Resources.MergedDictionaries;

        // Remove previously added theme dictionary (by reference, more reliable than URI matching)
        if (_currentThemeDict != null)
        {
            dictionaries.Remove(_currentThemeDict);
            _currentThemeDict = null;
        }

        // Add new Colors dictionary — DynamicResource bindings auto-update
        var newDict = new ResourceDictionary { Source = new Uri(GetColorsUri()) };
        dictionaries.Add(newDict);
        _currentThemeDict = newDict;
    }

    private static string GetColorsUri()
    {
        bool useDark = CurrentTheme switch
        {
            AppTheme.Light => false,
            AppTheme.Dark => true,
            _ => !IsSystemLightTheme()
        };
        return useDark ? ColorsDarkPath : ColorsLightPath;
    }

    private static bool IsSystemLightTheme()
    {
        try
        {
            using var key = Registry.CurrentUser.OpenSubKey(ThemeKey);
            return key?.GetValue(AppsUseLightTheme) is not 0;
        }
        catch { return true; }
    }
}
