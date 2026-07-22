using System;
using System.Linq;
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
        var colorsUri = GetColorsUri();

        // Remove old Colors dictionary (Dark or Light)
        var oldDark = dictionaries.FirstOrDefault(d =>
            d.Source?.OriginalString == ColorsDarkPath);
        var oldLight = dictionaries.FirstOrDefault(d =>
            d.Source?.OriginalString == ColorsLightPath);

        if (oldDark != null) dictionaries.Remove(oldDark);
        if (oldLight != null) dictionaries.Remove(oldLight);

        // Add new Colors dictionary — DynamicResource bindings auto-update
        dictionaries.Add(new ResourceDictionary { Source = new Uri(colorsUri) });
    }

    public static string GetColorsFile()
    {
        var uri = GetColorsUri();
        return uri == ColorsDarkPath ? "Colors.Dark.xaml" : "Colors.Light.xaml";
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
