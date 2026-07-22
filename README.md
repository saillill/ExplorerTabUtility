# Explorer Tab Utility — 文件夹标签合并工具

> [!TIP]
> 强制 Windows 11 的新文件资源管理器窗口以标签页方式打开，让工作区更整洁有序！

<div align="center">
  <img src="https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/ExplorerTabUtilityLogo.gif" alt="Explorer Tab Utility Logo">
  
  [![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg)](https://opensource.org/licenses/MIT)
  [![Windows 11](https://img.shields.io/badge/Windows%2011-22H2+-blue.svg)](https://www.microsoft.com/windows/windows-11)
  [![.NET](https://img.shields.io/badge/.NET-9.0-purple.svg)](https://dotnet.microsoft.com/download)
  [![.NET Framework](https://img.shields.io/badge/.NET%20Framework-4.8.1-purple.svg)](https://dotnet.microsoft.com/download/dotnet-framework)
</div>

> [!IMPORTANT]
> 本应用需要 Windows 11（22H2 Build 22621 或更高版本），且支持文件资源管理器标签页功能。

## 🤔 为什么需要这个工具？

<div align="center">
  <img src="https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/TheWhy.png" alt="Why use Explorer Tab Utility">
</div>

告别桌面上杂乱无章的多个资源管理器窗口！Explorer Tab Utility 自动将新窗口转换为标签页，提供更整洁有序的文件管理体验。

## ✨ 功能特性

<details>
<summary>🔄 自动窗口转标签页</summary>

- 将新资源管理器窗口无缝转换为标签页
- 如果路径已打开，自动定位到现有标签页
- 支持通过快捷键切换虚拟桌面
- 支持附加/分离标签页
- 优雅处理"在文件夹中显示"的文件选择
- 支持同时打开多个标签页

**效果演示：**
![Window to tab conversion](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/WindowToTab.gif)
</details>

<details>
<summary>🖨️ 复制当前标签页</summary>

- 快速复制当前标签页/窗口
- 可选择复制为标签页或新窗口
- 保留当前位置和选中项

**效果演示：**
![Duplicate current tab](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/DuplicateTab.gif)
</details>

<details>
<summary>♻️ 重新打开已关闭标签页</summary>

- 重新打开之前关闭的标签页/窗口
- 可选择以标签页或新窗口方式打开
- 恢复精确位置和选中项
- 关闭历史在应用重启后保留

**效果演示：**
![Reopen closed tabs](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/ReopenClosedTab.gif)
</details>

<details>
<summary>🔄 恢复之前的窗口</summary>

- 资源管理器崩溃或系统重启后自动恢复之前的窗口
- 可通过设置配置
- 首次启动时弹出确认对话框

![Restore Previous Windows](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/RestorePrevious.png)
</details>

<details>
<summary>📋 分离与贴靠窗口</summary>

- 将当前标签页分离到新窗口
- 将窗口贴靠到屏幕边缘（右/左/上/下）
- 一个快捷键可串联多个操作
- 配置示例（CTRL + Q）：分离当前标签 → 原窗口贴靠左侧 → 新窗口贴靠右侧
- 可根据系统性能自定义延迟

**效果演示：**
![Detach & Snap](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/DetachSnap.gif)
</details>

<details>
<summary>⬅️ 前进后退导航</summary>

- 通过键盘快捷键或鼠标点击文件夹空白区域进行后退/前进/向上导航
- 非常适合在目录之间快速导航

**效果演示：**
![Navigate back/up](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/NavigateBack.gif)
</details>

<details>
<summary>📁 自定义路径导航</summary>

- 为常用位置分配快捷键
- 支持多种格式：标准路径、环境变量、CLSID 路径、文件、网址
- 使用 CLSID 即时访问系统文件夹

**效果演示：**
![Custom location](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/CustomLocation.gif)
</details>

<details>
<summary>🔍 标签页搜索/切换器</summary>

- 快速查找和切换已打开的标签页
- 输入文件夹名或路径进行搜索
- 上下箭头键导航，回车选择
- 特殊修饰键：SHIFT 在新窗口打开、CTRL 复制标签页、一键清除关闭历史

![Tab Search](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/TabSearch.gif)
</details>

<details>
<summary>🪟 Ctrl+Shift 强制新窗口</summary>

- 打开位置时按住 Ctrl+Shift 强制在新窗口中打开
- 临时忽略窗口拦截和标签复用设置
</details>

<details>
<summary>⚡ 性能与可靠性</summary>

- 轻量级，资源占用低
- 快速响应的标签页创建
- 基于 COM 的稳定实现
- 可靠的窗口状态管理
</details>

## 📝 更新日志 (v2.5.1)

> **基于 [w4po/ExplorerTabUtility v2.5.0](https://github.com/w4po/ExplorerTabUtility) 的复刻版本**

### 🆕 新增功能
- 🌙 **深色/浅色主题**：支持深色、浅色、跟随系统三种主题模式，实时切换无需重启
- 🌐 **中英双语界面**：完整的中英文切换支持，自动检测系统语言
- 🇨🇳 **全面中文化**：菜单、设置、提示等全部界面元素中文化
- 🔤 **微软雅黑字体**：优化中文显示效果

### 🔧 改进优化
- 💾 **防抖保存 + 原子写入**：设置文件保存更可靠，自动备份防损坏
- 🛠️ **COM 互操作重构**：改用手动 COM 类型定义，替代 COMReference，更可控
- 📝 **改进的翻译**：快捷键操作（HotKeyAction）和作用域（HotkeyScope）的中文描述
- 🧹 **代码清理**：移除重复 using 指令，清理冗余代码
- 🔕 **移除自动更新**：简化应用架构

### 🐛 Bug 修复
- 🚀 **修复启动崩溃**：`Style.BasedOn` 上非法使用 `DynamicResource` 导致 XamlParseException
- 💥 **修复点击偏好设置闪退**：`Binding.Converter` 上非法使用 `DynamicResource` 导致 NullReferenceException
- 📦 **资源嵌入修复**：正确配置 .resx 资源文件的 SDK 自动嵌入

### ⚠️ 与原项目的差异
- 仅支持 .NET 9.0（不再支持 .NET Framework 4.8.1）
- COM 互操作采用手动定义（不使用 MSBuild COMReference）
- 移除了自动更新功能

---

## 🚀 快速开始

1. 从 [Releases](https://github.com/saillill/ExplorerTabUtility/releases) 页面下载最新版本
2. 运行应用程序
3. 在系统托盘中找到图标，开始使用！

    ![Menu](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/Menu.png)

> [!NOTE]
> 应用程序默认最小化到系统托盘运行。双击或右键单击托盘图标进行配置。

## ⚙️ 配置说明

<details>
<summary>🔧 通用设置</summary>

- **窗口拦截**：启用/禁用自动窗口转标签页
- **标签复用**：切换到现有标签页而非打开重复标签
- **键盘快捷键**：启用/禁用键盘快捷方式
- **鼠标快捷键**：启用/禁用鼠标导航功能
- **开机自启**：配置随 Windows 自动启动
- **设置持久化**：设置保存在 `%APPDATA%\ExplorerTabUtility\settings.json`
</details>

<details>
<summary>⚙️ 偏好设置</summary>

- **自动更新**：启动时检查更新
- **我有主题问题**：使用替代窗口隐藏方法保留自定义主题
- **保存关闭历史**：保留关闭窗口记录以便重新打开
- **恢复之前的窗口**：重启后恢复之前打开的窗口
- **隐藏托盘图标**：需先配置"切换可见性"快捷键

![Preferences](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/Preferences.png)
</details>

<details>
<summary>⌨️ 快捷键配置</summary>

### 配置选项
- 新建、导入、导出、启用/禁用配置方案

### 配置设置
1. **基本配置**
   - 快捷键：支持修饰键组合
   - 作用域：全局 / 仅在资源管理器中
   - 操作类型：打开、复制、重新打开、标签搜索、后退、前进、向上、设置目标窗口、切换窗口拦截、切换标签复用、切换可见性、分离标签页、贴靠窗口
   - 路径字段：支持多种格式，留空则打开新标签页

2. **高级设置**
   - 执行延迟、按键传递、删除配置

![Form](https://cdn.jsdelivr.net/gh/w4po/ExplorerTabUtility@master/Assets/Form.png)
</details>

## 🔧 技术细节

<details>
<summary>实现概述</summary>

### 核心组件

#### COM 集成
- 通过原生 COM 接口直接交互 Windows Shell（Shell32、SHDocVw）
- 高效的 PIDL 文件系统操作
- 线程安全的 COM 对象生命周期管理

#### 窗口管理
- 并发集合实现线程安全窗口跟踪
- 智能窗口转标签页转换逻辑
- 支持 CLSID 特殊文件夹导航

#### 进程与事件系统
- 资源管理器崩溃自动恢复
- 事件驱动架构
- 非阻塞 COM 操作，SemaphoreSlim 同步

#### 性能优化
- 窗口句柄缓存、路径比较优化、标签状态跟踪
- 正确释放 COM 对象、最小化窗口重建

#### 现代化 UI
- WPF + XAML，Windows 11 设计风格
- 自定义主题、系统托盘、标签搜索弹窗

### 关键技术
- .NET 9 / .NET Framework 4.8.1
- Windows COM API（Shell32、SHDocVw）
- 原生 P/Invoke、STA 调度器、WPF
</details>

## 🗑️ 卸载

- **安装程序安装**：设置 > 应用 > 已安装的应用 > 卸载
- **winget 安装**：`winget uninstall w4po.ExplorerTabUtility`
- **便携版**：直接删除文件夹即可

## 杀毒软件误报说明

> [!WARNING]
> 可能被杀毒软件误报。原因：COM 交互 + 底层键盘鼠标钩子。
> 本工具完全开源，可查看源代码自行编译验证。

### 添加到 Windows Defender 排除项
1. Windows 安全中心 → 病毒和威胁防护 → 管理设置
2. 排除项 → 添加排除项 → 文件夹 → 浏览到应用目录

## 💝 支持项目

如果觉得有用，欢迎支持开发：

<p align="center">
  <a href="https://github.com/sponsors/w4po"><img src="https://img.shields.io/badge/sponsor-30363D?style=for-the-badge&logo=GitHub-Sponsors&logoColor=white" alt="GitHub Sponsors"/></a>
  <a href="https://www.patreon.com/w4po"><img src="https://img.shields.io/badge/Patreon-F96854?style=for-the-badge&logo=patreon&logoColor=white" alt="Patreon"/></a>
  <a href="https://www.buymeacoffee.com/w4po"><img src="https://img.shields.io/badge/Buy_Me_A_Coffee-FFDD00?style=for-the-badge&logo=buy-me-a-coffee&logoColor=black" alt="Buy Me A Coffee"/></a>
  <a href="https://paypal.me/w4po77"><img src="https://img.shields.io/badge/PayPal-00457C?style=for-the-badge&logo=paypal&logoColor=white" alt="PayPal"/></a>
</p>

## 致谢

本项目使用了以下优秀开源包：
- **[H.Hooks](https://github.com/HavenDV/H.Hooks)** - 高效键盘钩子
- **[Hardcodet.NotifyIcon.Wpf](https://github.com/hardcodet/wpf-notifyicon)** - WPF 系统托盘图标

## 许可协议

MIT License - 详见 [LICENSE](LICENSE) 文件。
