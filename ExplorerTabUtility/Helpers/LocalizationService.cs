using System;
using System.ComponentModel;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace ExplorerTabUtility.Helpers;

public class LocalizationService : INotifyPropertyChanged
{
    private static LocalizationService? _instance;
    public static LocalizationService Instance => _instance ??= new LocalizationService();

    private readonly ResourceManager _resourceManager;

    private LocalizationService()
    {
        _resourceManager = new ResourceManager("ExplorerTabUtility.Properties.Resources", typeof(LocalizationService).Assembly);
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    public static event Action? LanguageChanged;

    public string this[string key]
    {
        get
        {
            try { return _resourceManager.GetString(key, CultureInfo.CurrentUICulture) ?? key; }
            catch { return key; }
        }
    }

    public static string Get(string key) => Instance[key];

    public string Language
    {
        get => CultureInfo.CurrentUICulture.Name.StartsWith("zh") ? "zh-CN" : "en";
        set
        {
            var culture = value == "zh-CN" ? new CultureInfo("zh-CN") : new CultureInfo("en");
            CultureInfo.CurrentUICulture = culture;
            CultureInfo.CurrentCulture = culture;
            OnPropertyChanged("Item[]");
            OnPropertyChanged("");
            LanguageChanged?.Invoke();
        }
    }

    public void SetLanguage(string lang) => Language = lang;

    protected void OnPropertyChanged([CallerMemberName] string? name = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    }
}
