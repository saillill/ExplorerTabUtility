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
            if ((int)value == SettingsManager.ThemeMode) return;
            SettingsManager.ThemeMode = (int)value;
            // Require restart: loaded theme colors are StaticResource-based
            Restart();
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

    /// <summary>Called once at startup to load the correct theme file.</summary>
    public static string GetColorsFile()
    {
        return UseDark() ? "Colors.Dark.xaml" : "Colors.Light.xaml";
    }

    private static bool UseDark()
    {
        return CurrentTheme switch
        {
            AppTheme.Light => false,
            AppTheme.Dark => true,
            _ => !IsSystemLightTheme()
        };
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

    private static void Restart()
    {
        SettingsManager.ForceSave();
        var exe = Process.GetCurrentProcess().MainModule?.FileName;
        if (exe != null)
        {
            // Release mutex before starting new process
            if (Application.Current is App app)
                app.ReleaseMutex();

            Process.Start(exe);
            Application.Current.Shutdown();
        }
    }
}
