using System;
using System.Windows;
using System.Threading;
using System.Windows.Controls;
using ExplorerTabUtility.UI.Views;
using ExplorerTabUtility.Helpers;
using ExplorerTabUtility.Managers;

namespace ExplorerTabUtility;

// ReSharper disable once RedundantExtendsListEntry
public partial class App : Application
{
    private Mutex? _mutex;

    protected override void OnStartup(StartupEventArgs e)
    {
        _mutex = new Mutex(true, Constants.MutexId, out var createdNew);

        if (createdNew)
        {
            base.OnStartup(e);
            SetupTooltipBehavior();

            // Initialize language from settings
            var lang = Managers.SettingsManager.Language;
            if (!string.IsNullOrEmpty(lang))
                LocalizationService.Instance.SetLanguage(lang);

            // Register for XAML bindings
            Application.Current.Resources["Loc"] = LocalizationService.Instance;

            ThemeManager.Initialize();
            Application.Current.Resources.MergedDictionaries.Add(
                new System.Windows.ResourceDictionary { Source = new Uri($"pack://application:,,,/ExplorerTabUtility;component/UI/Themes/{ThemeManager.GetColorsFile()}") });
            _ = new MainWindow();
            return;
        }

        CustomMessageBox.Show("""
                              Another instance is already running.
                              Check in System Tray Icons.
                              """, Constants.AppName, icon: MessageBoxImage.Information);
        Shutdown();
    }

    protected override void OnExit(ExitEventArgs e)
    {
        _mutex?.Dispose();
        base.OnExit(e);
    }

    private static void SetupTooltipBehavior()
    {
        ToolTipService.ShowDurationProperty.OverrideMetadata(typeof(FrameworkElement), new FrameworkPropertyMetadata(3500));
        ToolTipService.InitialShowDelayProperty.OverrideMetadata(typeof(FrameworkElement), new FrameworkPropertyMetadata(1700));
        ToolTipService.BetweenShowDelayProperty.OverrideMetadata(typeof(FrameworkElement), new FrameworkPropertyMetadata(150));
        ToolTipService.ShowsToolTipOnKeyboardFocusProperty.OverrideMetadata(typeof(FrameworkElement), new FrameworkPropertyMetadata(false));
    }
}