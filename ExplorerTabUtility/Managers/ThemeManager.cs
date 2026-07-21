using System;
using System.Diagnostics;
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
            if ((int)value != SettingsManager.ThemeMode)
            {
                SettingsManager.ThemeMode = (int)value;
                // Need restart: StaticResource bindings don't update dynamically
                Restart();
            }
        }
    }

    public static void Initialize()
    {
        SystemEvents.UserPreferenceChanged += (s, e) =>
        {
            if (e.Category == UserPreferenceCategory.General && CurrentTheme == AppTheme.System)
                Restart();
        };
    }

    public static string GetColorsFile()
    {
        bool useDark = CurrentTheme switch
        {
            AppTheme.Light => false,
            AppTheme.Dark => true,
            _ => !IsSystemLightTheme()
        };
        return useDark ? "Colors.Dark.xaml" : "Colors.Light.xaml";
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

    public static void Restart()
    {
        SettingsManager.ForceSave();
        var exe = Process.GetCurrentProcess().MainModule?.FileName;
        if (exe != null)
        {
            Process.Start(exe);
            Application.Current.Shutdown();
        }
    }
}
