using System;
using System.Windows;
using Microsoft.Win32;

namespace ExplorerTabUtility.Managers;

public enum AppTheme { System, Dark, Light }

public static class ThemeManager
{
    private const string ThemeKey = @"Software\Microsoft\Windows\CurrentVersion\Themes\Personalize";
    private const string AppsUseLightTheme = "AppsUseLightTheme";

    public static AppTheme CurrentTheme
    {
        get => (AppTheme)(SettingsManager.ThemeMode);
        set
        {
            SettingsManager.ThemeMode = (int)value;
            ApplyTheme(value);
        }
    }

    public static void Initialize()
    {
        SystemEvents.UserPreferenceChanged += (s, e) =>
        {
            if (e.Category == UserPreferenceCategory.General && CurrentTheme == AppTheme.System)
                ApplyTheme(AppTheme.System);
        };
        ApplyTheme(CurrentTheme);
    }

    public static void ApplyTheme(AppTheme mode)
    {
        bool useDark;
        if (mode == AppTheme.System)
        {
            useDark = !IsSystemLightTheme();
        }
        else
        {
            useDark = mode == AppTheme.Dark;
        }
        ApplyColorTheme(useDark ? "Colors.Dark.xaml" : "Colors.Light.xaml");
    }

    private static bool IsSystemLightTheme()
    {
        try
        {
            using var key = Registry.CurrentUser.OpenSubKey(ThemeKey);
            var value = key?.GetValue(AppsUseLightTheme);
            return value is not 0;
        }
        catch { return true; }
    }

    private static void ApplyColorTheme(string colorsFile)
    {
        var app = Application.Current;
        if (app == null) return;

        var dict = app.Resources.MergedDictionaries;
        // Remove existing Colors dictionary
        for (int i = dict.Count - 1; i >= 0; i--)
        {
            if (dict[i].Source?.OriginalString?.Contains("Colors.") == true)
                dict.RemoveAt(i);
        }
        // Add new Colors dictionary
        dict.Add(new ResourceDictionary
        {
            Source = new Uri($"pack://application:,,,/ExplorerTabUtility;component/UI/Themes/{colorsFile}")
        });
    }
}
