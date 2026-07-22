using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ExplorerTabUtility.Helpers;

public class LocalizationService : INotifyPropertyChanged
{
    private static LocalizationService? _instance;
    public static LocalizationService Instance => _instance ??= new LocalizationService();

    private string _lang = "zh-CN";
    private static readonly Dictionary<string, Dictionary<string, string>> Strings = new()
    {
        ["en"] = new()
        {
            ["AppTitle"] = "Explorer Tab Utility",
            ["AppTitleWithDesc"] = "Explorer Tab Utility - Folder Tab Manager",
            ["AppDescription"] = "Enhance Windows File Explorer experience",
            ["MenuShortcuts"] = "\U0001F5F2  Shortcuts",
            ["MenuPreferences"] = "⚙  Preferences",
            ["MenuAbout"] = "ℹ  About",
            ["TabShortcuts"] = "Shortcuts",
            ["TabPreferences"] = "Preferences",
            ["TabAbout"] = "About",
            ["BtnNewProfile"] = "NEW",
            ["BtnImport"] = "IMPORT",
            ["BtnExport"] = "EXPORT",
            ["BtnSave"] = "SAVE",
            ["AutoSave"] = "Auto save on exit",
            ["AutoSaveTooltip"] = "Automatically save profiles when closing the window",
            ["GroupAppSettings"] = "Application Settings",
            ["Theme"] = "Theme",
            ["ThemeFollowSystem"] = "Follow System",
            ["ThemeDark"] = "Dark",
            ["ThemeLight"] = "Light",
            ["ThemeCompatibilityMode"] = "Theme Compatibility Mode",
            ["ThemeCompatibilityTooltip"] = "Use alternative window hiding method that preserves your custom theme.",
            ["SaveClosedHistory"] = "Save closed history",
            ["SaveClosedHistoryTooltip"] = "Save closed windows history so you can reopen them later",
            ["RestorePreviousWindows"] = "Restore previous windows",
            ["RestorePreviousWindowsTooltip"] = "Restore previously opened windows after restart or crash",
            ["HideTrayIcon"] = "Hide tray icon",
            ["HideTrayIconTooltip"] = "Hide the system tray icon",
            ["Language"] = "Language",
            ["StatusWindowHook"] = "Window Hook",
            ["StatusReuseTabs"] = "Reuse Tabs",
            ["StatusKeyboardHook"] = "Keyboard Hook",
            ["StatusMouseHook"] = "Mouse Hook",
            ["MenuOpen"] = "Open menu",
            ["ScopeTooltip"] = "Scope: Global or only when File Explorer is focused",
            ["ActionTooltip"] = "Action to perform when the hotkeys are pressed",
            ["ProfileEnabledTooltip"] = "Enable or disable this profile",
            ["ProfileNameTooltip"] = "Name of the profile",
            ["HotKeysTooltip"] = "Keyboard or mouse keys to listen for. Click to record.",
            ["ExpanderTooltip"] = "Show more options",
            ["DeleteProfileTooltip"] = "Delete this profile",
            ["PathTooltip"] = "Path to open (folder, file, website, CLSID)",
            ["DelayTooltip"] = "Delay in milliseconds before performing the action",
            ["HandledTooltip"] = "Prevent further processing of the hotkeys",
            ["TabTooltip"] = "Open as tab instead of a new window",
            ["Delay"] = "Delay",
            ["Handled"] = "Handled",
            ["Tab"] = "Tab",
            ["SupportProject"] = "Support the Project",
            ["SupportDescription"] = "If you find this utility helpful, consider supporting its development:",
            ["Developer"] = "Developer",
            ["CurrentSupporters"] = "Current Supporters",
            ["SupportersThanks"] = "Thank you to all the amazing people who support this project!",
            ["BeFirst"] = "Be the first to support this project!",
            ["SupportHelps"] = "Your support helps keep this project alive",
            ["StarOnGitHub"] = "Star on GitHub",
            ["KeyboardShortcut"] = "Keyboard Shortcut",
            ["MouseShortcut"] = "Mouse Shortcut",
            ["WindowIntercept"] = "Window Intercept",
            ["TabReuse"] = "Tab Reuse",
            ["AddToStartup"] = "Add to startup",
            ["Settings"] = "Settings",
            ["Exit"] = "Exit",
            ["ScopeGlobal"] = "Global",
            ["ScopeFileExplorer"] = "File Explorer only",
            ["HideWindowAlert1"] = "You can show the app again by pressing {0}",
            ["HideWindowAlert2"] = "Cannot hide tray icon without a toggle visibility hotkey.",
            ["LanguageEn"] = "English",
            ["LanguageZh"] = "中文",
            ["Action_Open"] = "Open",
            ["Action_Duplicate"] = "Duplicate",
            ["Action_ReopenClosed"] = "Reopen Closed",
            ["Action_TabSearch"] = "Tab Search",
            ["Action_NavigateBack"] = "Navigate Back",
            ["Action_NavigateUp"] = "Navigate Up",
            ["Action_NavigateForward"] = "Navigate Forward",
            ["Action_SetTargetWindow"] = "Set Target Window",
            ["Action_ToggleWinHook"] = "Toggle Window Hook",
            ["Action_ToggleReuseTabs"] = "Toggle Tab Reuse",
            ["Action_ToggleVisibility"] = "Show/Hide",
            ["Action_DetachTab"] = "Detach Tab",
            ["Action_SnapRight"] = "Snap Right",
            ["Action_SnapLeft"] = "Snap Left",
            ["Action_SnapUp"] = "Snap Up",
            ["Action_SnapDown"] = "Snap Down",
        },
        ["zh-CN"] = new()
        {
            ["AppTitle"] = "Explorer Tab Utility",
            ["AppTitleWithDesc"] = "Explorer Tab Utility - 文件夹标签合并工具",
            ["AppDescription"] = "增强 Windows 文件资源管理器体验",
            ["MenuShortcuts"] = "⌨  快捷键",
            ["MenuPreferences"] = "⚙  偏好设置",
            ["MenuAbout"] = "ℹ  关于",
            ["TabShortcuts"] = "快捷键",
            ["TabPreferences"] = "偏好设置",
            ["TabAbout"] = "关于",
            ["BtnNewProfile"] = "新建",
            ["BtnImport"] = "导入",
            ["BtnExport"] = "导出",
            ["BtnSave"] = "保存",
            ["AutoSave"] = "退出时保存",
            ["AutoSaveTooltip"] = "关闭窗口时自动保存快捷键配置方案",
            ["GroupAppSettings"] = "应用设置",
            ["Theme"] = "主题",
            ["ThemeFollowSystem"] = "跟随系统",
            ["ThemeDark"] = "深色",
            ["ThemeLight"] = "浅色",
            ["ThemeCompatibilityMode"] = "主题兼容模式",
            ["ThemeCompatibilityTooltip"] = "使用替代的窗口隐藏方式以保留自定义主题外观。如果您使用了第三方文件资源管理器主题美化工具，请启用此选项",
            ["SaveClosedHistory"] = "保存关闭历史",
            ["SaveClosedHistoryTooltip"] = "保存已关闭窗口的历史记录，以便稍后重新打开",
            ["RestorePreviousWindows"] = "恢复之前的窗口",
            ["RestorePreviousWindowsTooltip"] = "重启或崩溃后自动恢复之前打开的窗口",
            ["HideTrayIcon"] = "隐藏托盘图标",
            ["HideTrayIconTooltip"] = "隐藏系统托盘图标",
            ["Language"] = "语言",
            ["StatusWindowHook"] = "窗口拦截",
            ["StatusReuseTabs"] = "标签复用",
            ["StatusKeyboardHook"] = "键盘快捷键",
            ["StatusMouseHook"] = "鼠标快捷键",
            ["MenuOpen"] = "打开菜单",
            ["ScopeTooltip"] = "快捷键作用域：全局（任意位置）或仅限资源管理器窗口时生效",
            ["ActionTooltip"] = "快捷键触发时执行的操作",
            ["ProfileEnabledTooltip"] = "启用或禁用此配置方案",
            ["ProfileNameTooltip"] = "配置方案名称",
            ["HotKeysTooltip"] = "要监听的键盘或鼠标按键。点击此处录制新的按键组合",
            ["ExpanderTooltip"] = "显示更多选项",
            ["DeleteProfileTooltip"] = "删除此配置方案",
            ["PathTooltip"] = "按下快捷键时要打开的路径（文件夹、文件、网站、CLSID）",
            ["DelayTooltip"] = "执行操作前的延迟时间（毫秒）",
            ["HandledTooltip"] = "阻止其他应用继续处理此快捷键",
            ["TabTooltip"] = "以标签页方式打开，而非新窗口",
            ["Delay"] = "延迟",
            ["Handled"] = "拦截",
            ["Tab"] = "标签页",
            ["SupportProject"] = "支持本项目",
            ["SupportDescription"] = "如果您觉得这个工具好用，可以通过以下方式支持开发：",
            ["Developer"] = "开发者",
            ["CurrentSupporters"] = "当前支持者",
            ["SupportersThanks"] = "感谢所有支持本项目的朋友们！",
            ["BeFirst"] = "成为第一个支持本项目的人！",
            ["SupportHelps"] = "您的支持让这个项目得以持续",
            ["StarOnGitHub"] = "在 GitHub 上标星",
            ["KeyboardShortcut"] = "键盘快捷键",
            ["MouseShortcut"] = "鼠标快捷键",
            ["WindowIntercept"] = "窗口拦截",
            ["TabReuse"] = "标签复用",
            ["AddToStartup"] = "开机自启",
            ["Settings"] = "设置",
            ["Exit"] = "退出",
            ["ScopeGlobal"] = "全局",
            ["ScopeFileExplorer"] = "仅资源管理器",
            ["HideWindowAlert1"] = "你可以通过按下 {0} 重新显示应用",
            ["HideWindowAlert2"] = "未配置显示/隐藏快捷键，无法隐藏托盘图标",
            ["LanguageEn"] = "English",
            ["LanguageZh"] = "中文",
            ["Action_Open"] = "打开",
            ["Action_Duplicate"] = "复制标签页",
            ["Action_ReopenClosed"] = "重新打开已关闭",
            ["Action_TabSearch"] = "标签搜索",
            ["Action_NavigateBack"] = "后退",
            ["Action_NavigateUp"] = "向上",
            ["Action_NavigateForward"] = "前进",
            ["Action_SetTargetWindow"] = "设置目标窗口",
            ["Action_ToggleWinHook"] = "切换窗口拦截",
            ["Action_ToggleReuseTabs"] = "切换标签复用",
            ["Action_ToggleVisibility"] = "显示/隐藏",
            ["Action_DetachTab"] = "分离标签页",
            ["Action_SnapRight"] = "贴靠至右侧",
            ["Action_SnapLeft"] = "贴靠至左侧",
            ["Action_SnapUp"] = "贴靠至顶部",
            ["Action_SnapDown"] = "贴靠至底部",
        }
    };

    private LocalizationService() { }

    public event PropertyChangedEventHandler? PropertyChanged;
    public static event Action? LanguageChanged;

    public string this[string key]
    {
        get
        {
            if (Strings.TryGetValue(_lang, out var dict) && dict.TryGetValue(key, out var val))
                return val;
            // Fallback to English
            if (_lang != "en" && Strings.TryGetValue("en", out var enDict) && enDict.TryGetValue(key, out var enVal))
                return enVal;
            return key;
        }
    }

    public static string Get(string key) => Instance[key];

    public string Language
    {
        get => _lang;
        set
        {
            if (_lang == value) return;
            _lang = value;
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
