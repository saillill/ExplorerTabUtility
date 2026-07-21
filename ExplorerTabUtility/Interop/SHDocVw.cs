using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Runtime.InteropServices;

namespace SHDocVw
{
	[ComImport]
	[CompilerGenerated]
	[Guid("FE4106E0-399A-11D0-A48C-00A0C90A8F39")]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
	
	public interface DShellWindowsEvents
	{
		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(200)]
		void WindowRegistered([In] int lCookie);
	}
	[ComImport]
	[CompilerGenerated]
	[ComEventInterface(typeof(DShellWindowsEvents), typeof(DShellWindowsEvents))]
	[Guid("FE4106E0-399A-11D0-A48C-00A0C90A8F39")]
	public interface DShellWindowsEvents_Event
	{
		event DShellWindowsEvents_WindowRegisteredEventHandler WindowRegistered;
	}
	[CompilerGenerated]
	
	public delegate void DShellWindowsEvents_WindowRegisteredEventHandler([In] int lCookie);
	[ComImport]
	[CompilerGenerated]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
	[Guid("34A715A0-6587-11D0-924A-0020AFC7AC4D")]
	
	public interface DWebBrowserEvents2
	{
		void _VtblGap1_9();

		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(252)]
		void NavigateComplete2([In][MarshalAs(UnmanagedType.IDispatch)] object pDisp, [In][MarshalAs(UnmanagedType.Struct)] ref object URL);

		void _VtblGap2_1();

		[MethodImpl(MethodImplOptions.PreserveSig | MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(253)]
		void OnQuit();
	}
	[ComImport]
	[CompilerGenerated]
	[ComEventInterface(typeof(DWebBrowserEvents2), typeof(DWebBrowserEvents2))]
	[Guid("34A715A0-6587-11D0-924A-0020AFC7AC4D")]
	public interface DWebBrowserEvents2_Event
	{
		void _VtblGap1_18();

		event DWebBrowserEvents2_NavigateComplete2EventHandler NavigateComplete2;

		void _VtblGap2_2();

		event DWebBrowserEvents2_OnQuitEventHandler OnQuit;
	}
	[CompilerGenerated]
	
	public delegate void DWebBrowserEvents2_NavigateComplete2EventHandler([In][MarshalAs(UnmanagedType.IDispatch)] object pDisp, [In][MarshalAs(UnmanagedType.Struct)] ref object URL);
	[CompilerGenerated]
	
	public delegate void DWebBrowserEvents2_OnQuitEventHandler();
	[ComImport]
	[CompilerGenerated]
	[DefaultMember("Item")]
	[Guid("85CB6900-4D95-11CF-960C-0080C7F4EE85")]
	
	public interface IShellWindows : IEnumerable
	{
		[DispId(1610743808)]
		int Count
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[DispId(1610743808)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(0)]
		[return: MarshalAs(UnmanagedType.IDispatch)]
		object Item([Optional][In][MarshalAs(UnmanagedType.Struct)] object index);
	}
	[ComImport]
	[CompilerGenerated]
	[Guid("EAB22AC1-30C1-11CF-A7EB-0000C05BAE0B")]
	
	public interface IWebBrowser
	{
	}
	[ComImport]
	[CompilerGenerated]
	[Guid("D30C1661-CDAF-11D0-8A3E-00C04FC9E26E")]
	[DefaultMember("Name")]
	
	public interface IWebBrowser2 : IWebBrowserApp
	{
		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(100)]
		void GoBack();

		void _VtblGap1_1();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(101)]
		void GoForward();

		void _VtblGap1_8();

		[DispId(203)]
		object Document
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[DispId(203)]
			[return: MarshalAs(UnmanagedType.IDispatch)]
			get;
		}

		void _VtblGap2_10();

		[DispId(210)]
		string LocationName
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[DispId(210)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(211)]
		string LocationURL
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[DispId(211)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		void _VtblGap3_1();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(300)]
		void Quit();

		void _VtblGap4_3();

		[DispId(0)]
		new string Name
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		[DispId(-515)]
		long HWND
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[DispId(-515)]
			get;
		}

		void _VtblGap5_14();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(500)]
		void Navigate2([In][MarshalAs(UnmanagedType.Struct)] ref object URL, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Flags, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object TargetFrameName, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object PostData, [Optional][In][MarshalAs(UnmanagedType.Struct)] ref object Headers);
	}
	[ComImport]
	[CompilerGenerated]
	[Guid("0002DF05-0000-0000-C000-000000000046")]
	[DefaultMember("Name")]
	
	public interface IWebBrowserApp : IWebBrowser
	{
[DispId(0)]
		string Name
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}
	}
	[ComImport]
	[CompilerGenerated]
	[Guid("D30C1661-CDAF-11D0-8A3E-00C04FC9E26E")]
	[CoClass(typeof(InternetExplorerClass))]
	
	public interface InternetExplorer : IWebBrowser2, DWebBrowserEvents2_Event
	{
	}
	[ComImport]
	[CompilerGenerated]
	[CoClass(typeof(ShellWindowsClass))]
	[Guid("85CB6900-4D95-11CF-960C-0080C7F4EE85")]
	
	public interface ShellWindows : IShellWindows, DShellWindowsEvents_Event
	{
	}
	[ComImport]
	[CompilerGenerated]
	[Guid("9BA05972-F6A8-11CF-A442-00A0C90A8F39")]
	[ClassInterface(ClassInterfaceType.None)]
	public class ShellWindowsClass
	{
	}

	[ComImport]
	[CompilerGenerated]
	[Guid("0002DF01-0000-0000-C000-000000000046")]
	[ClassInterface(ClassInterfaceType.None)]
	public class InternetExplorerClass
	{
	}

}
