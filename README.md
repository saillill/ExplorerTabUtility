# Explorer Tab Utility — 文件夹标签合并工具

> 强制 Windows 11 的新文件资源管理器窗口以标签页方式打开，告别杂乱窗口！
> Force new File Explorer windows to open as tabs — keep your workspace clean and organized!

<p align="center">
  <a href="#chinese">📖 中文</a> &nbsp;|&nbsp;
  <a href="#english">📖 English</a>
</p>

<div align="center">
  <img src="https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/ExplorerTabUtilityLogo.gif" alt="Explorer Tab Utility Logo" width="200">
  
  [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
  [![Windows 11](https://img.shields.io/badge/Windows%2011-22H2+-blue.svg)](https://www.microsoft.com/windows/windows-11)
  [![.NET](https://img.shields.io/badge/.NET-9.0-purple.svg)](https://dotnet.microsoft.com/download)
  [![Release](https://img.shields.io/github/v/release/saillill/ExplorerTabUtility)](https://github.com/saillill/ExplorerTabUtility/releases)
</div>

---

<h2 id="chinese">📖 中文介绍</h2>

### 这是什么？

这是一个 **Explorer Tab Utility** 的中文增强版，基于 [w4po 原版](https://github.com/w4po/ExplorerTabUtility) 深度改进而来。

原版是个非常棒的工具，但它有两个小遗憾：**没有中文界面**，**只有深色主题**。于是就有了这个版本。

### 🆚 和原版相比，多了什么？

| | 原版 w4po | 这个版本 |
|------|:--:|:--:|
| 🌐 中文界面 | ❌ 纯英文 | ✅ 完整中文 |
| 🌓 深色/浅色主题 | ❌ 仅深色 | ✅ 深色/浅色/跟随系统 |
| 💬 界面语言切换 | ❌ | ✅ 中英一键切换 |
| 🔤 中文字体优化 | ❌ | ✅ 微软雅黑 |
| 💾 设置保存 | 普通保存 | ✅ 防抖保存 + 自动备份 |
| 📝 中文翻译 | ❌ | ✅ 菜单/快捷键/提示全部汉化 |

### 📥 快速开始

1. 从 [Releases](https://github.com/saillill/ExplorerTabUtility/releases) 下载 `ExplorerTabUtility_v2.5.1_Setup.exe` 安装包
2. 运行安装程序，根据提示选择语言（中文/英文）
3. 安装完成后应用会自动启动到系统托盘，右键图标开始使用

> 需要 **Windows 11 22H2+**，支持资源管理器标签页功能。

---

<h2 id="english">📖 English</h2>

### What is this?

This is an enhanced Chinese version of **Explorer Tab Utility**, built on the excellent [original by w4po](https://github.com/w4po/ExplorerTabUtility).

The original tool is fantastic, but it had two small limitations: no Chinese UI and only a dark theme. This version fills those gaps.

### What's different from the original?

- 🌐 **Full Chinese localization** — every menu, setting, and tooltip translated
- 🌓 **Light/Dark/System theme** — switch between themes without restarting
- 💬 **Language switching** — toggle between Chinese and English anytime
- 🔤 **Better CJK font rendering** — Microsoft YaHei for Chinese text
- 💾 **Safer settings save** — debounced atomic writes with automatic backup

### Quick Start

1. Download `ExplorerTabUtility_v2.5.1_Setup.exe` from [Releases](https://github.com/saillill/ExplorerTabUtility/releases)
2. Run the installer and follow the prompts
3. The app starts in your system tray — right-click the icon to begin

> Requires **Windows 11 22H2+** with native Explorer tab support.

---

## ✨ 功能特性 / Features

<details>
<summary>🔄 自动窗口转标签页 / Auto Window-to-Tab</summary>

- 将新资源管理器窗口无缝转换为标签页
- 如果路径已打开，自动定位到现有标签页
- 支持通过快捷键切换虚拟桌面
- 支持附加/分离标签页
- 优雅处理"在文件夹中显示"的文件选择

![Window to tab conversion](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/WindowToTab.gif)
</details>

<details>
<summary>🖨️ 复制当前标签页 / Duplicate Tab</summary>

- 快速复制当前标签页/窗口
- 可选择复制为标签页或新窗口
- 保留当前位置和选中项

![Duplicate current tab](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/DuplicateTab.gif)
</details>

<details>
<summary>♻️ 重新打开已关闭标签页 / Reopen Closed Tabs</summary>

- 重新打开之前关闭的标签页/窗口
- 可选择以标签页或新窗口方式打开
- 恢复精确位置和选中项
- 关闭历史在应用重启后保留

![Reopen closed tabs](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/ReopenClosedTab.gif)
</details>

<details>
<summary>🔄 恢复之前的窗口 / Restore Previous Windows</summary>

- 资源管理器崩溃或系统重启后自动恢复之前的窗口
- 可通过设置配置
- 首次启动时弹出确认对话框

![Restore Previous Windows](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/RestorePrevious.png)
</details>

<details>
<summary>📋 分离与贴靠窗口 / Detach & Snap</summary>

- 将当前标签页分离到新窗口
- 将窗口贴靠到屏幕边缘（右/左/上/下）
- 一个快捷键可串联多个操作

![Detach & Snap](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/DetachSnap.gif)
</details>

<details>
<summary>⬅️ 前进后退导航 / Navigate Back/Forward</summary>

- 通过键盘快捷键或鼠标点击文件夹空白区域进行后退/前进/向上导航

![Navigate back/up](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/NavigateBack.gif)
</details>

<details>
<summary>📁 自定义路径导航 / Custom Path Shortcuts</summary>

- 为常用位置分配快捷键
- 支持多种格式：标准路径、环境变量、CLSID 路径、文件、网址

![Custom location](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/CustomLocation.gif)
</details>

<details>
<summary>🔍 标签页搜索/切换器 / Tab Search</summary>

- 快速查找和切换已打开的标签页
- 输入文件夹名或路径进行搜索
- 特殊修饰键：SHIFT 新窗口打开、CTRL 复制标签页

![Tab Search](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/TabSearch.gif)
</details>

---

## 📝 更新日志 / Changelog

### v2.5.1 — 中文化主题版

**对比原版 w4po/ExplorerTabUtility v2.5.0：**

#### 🆕 新增
- 🌙 **主题切换**：支持深色、浅色、跟随系统三种模式，实时切换无需重启
- 🌐 **双语界面**：完整的中英文界面，自动检测系统语言，也可手动切换
- 🇨🇳 **全面汉化**：菜单、按钮、提示、快捷键配置全部中文化
- 🔤 **微软雅黑字体**：优化中文文本显示效果

#### 🔧 改进
- 💾 **更可靠的设置保存**：防抖保存机制 + 原子写入，避免突然断电导致配置文件损坏，损坏时自动从备份恢复
- 🛠️ **COM 互操作优化**：改用更可控的手动 COM 类型定义
- 📝 **快捷键中文提示**：键盘和鼠标快捷键的操作说明全部翻译为中文

#### ⚠️ 与原版的差异
- 仅支持 **.NET 9.0**（不再支持 .NET Framework 4.8.1，.NET 9 性能更好且微软已停止 .NET Framework 主要开发）
- 移除了自动更新功能（简化架构，通过 GitHub Releases 手动更新）

---

## ⚙️ 系统托盘菜单

![Menu](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/Menu.png)

> 双击托盘图标打开设置窗口。所有设置保存在 `%APPDATA%\ExplorerTabUtility\settings.json`

## ⚙️ 偏好设置 / Preferences

![Preferences](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/Preferences.png)

- **主题**：深色 / 浅色 / 跟随系统
- **语言**：中文 / English
- **我有主题问题**：使用替代窗口隐藏方法保留自定义主题
- **保存关闭历史**：保留关闭窗口记录以便重新打开
- **恢复之前的窗口**：重启后恢复之前打开的窗口
- **隐藏托盘图标**：需先配置"切换可见性"快捷键

## ⌨️ 快捷键配置 / Hotkey Configuration

![Form](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/Form.png)

- 新建、导入、导出配置方案
- 支持修饰键组合、全局或仅资源管理器、多种操作类型
- 路径字段支持环境变量、CLSID、网址、文件路径

---

## 杀毒软件说明 / Antivirus Notice

> 本工具使用底层键盘鼠标钩子和 COM 交互，可能被杀毒软件误报。代码完全开源，可自行编译验证。如果遇到误报，将应用目录添加到 Windows Defender 排除项即可。

## 💝 支持 / Support

如果这个工具对你有帮助，欢迎支持原版作者 w4po：

<p align="center">
  <a href="https://github.com/sponsors/w4po"><img src="https://img.shields.io/badge/sponsor-30363D?style=for-the-badge&logo=GitHub-Sponsors&logoColor=white" alt="GitHub Sponsors"/></a>
  <a href="https://www.patreon.com/w4po"><img src="https://img.shields.io/badge/Patreon-F96854?style=for-the-badge&logo=patreon&logoColor=white" alt="Patreon"/></a>
  <a href="https://www.buymeacoffee.com/w4po"><img src="https://img.shields.io/badge/Buy_Me_A_Coffee-FFDD00?style=for-the-badge&logo=buy-me-a-coffee&logoColor=black" alt="Buy Me A Coffee"/></a>
  <a href="https://paypal.me/w4po77"><img src="https://img.shields.io/badge/PayPal-00457C?style=for-the-badge&logo=paypal&logoColor=white" alt="PayPal"/></a>
</p>

## 致谢 / Credits

- 原版项目：[w4po/ExplorerTabUtility](https://github.com/w4po/ExplorerTabUtility) — 感谢 w4po 的出色工作
- **[H.Hooks](https://github.com/HavenDV/H.Hooks)** — 高效键盘钩子
- **[Hardcodet.NotifyIcon.Wpf](https://github.com/hardcodet/wpf-notifyicon)** — WPF 系统托盘图标

## 许可协议 / License

MIT License — 详见 [LICENSE](LICENSE) 文件。
