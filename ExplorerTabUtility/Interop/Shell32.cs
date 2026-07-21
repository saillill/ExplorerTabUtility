using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Reflection;
using System.Runtime.InteropServices;

namespace Shell32
{
	[ComImport]
	[CompilerGenerated]
	[InterfaceType(ComInterfaceType.InterfaceIsIDispatch)]
	[Guid("62112AA2-EBE4-11CF-A5FB-0020AFE7292D")]
	
	public interface DShellFolderViewEvents
	{
	}
	[ComImport]
	[CompilerGenerated]
	[ComEventInterface(typeof(DShellFolderViewEvents), typeof(DShellFolderViewEvents))]
	[Guid("62112AA2-EBE4-11CF-A5FB-0020AFE7292D")]
	public interface DShellFolderViewEvents_Event
	{
	}
	[ComImport]
	[CompilerGenerated]
	[Guid("BBCBDE60-C3FF-11CE-8350-444553540000")]
	[DefaultMember("Title")]
	
	public interface Folder
	{
		[DispId(0)]
		string Title
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		void _VtblGap1_4();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610743813)]
		[return: MarshalAs(UnmanagedType.Interface)]
		FolderItem ParseName([In][MarshalAs(UnmanagedType.BStr)] string bName);
	}
	[ComImport]
	[CompilerGenerated]
	[Guid("F0D2D8EF-3890-11D2-BF8B-00C04FB93661")]
	[DefaultMember("Title")]
	
	public interface Folder2 : Folder
	{
		[DispId(0)]
		new string Title
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}

		void _VtblGap1_9();

		[DispId(1610809344)]
		FolderItem Self
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[DispId(1610809344)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}
	}
	[ComImport]
	[CompilerGenerated]
	[Guid("FAC32C80-CBE4-11CE-8350-444553540000")]
	[DefaultMember("Name")]
	
	public interface FolderItem
	{
		void _VtblGap1_2();

		[DispId(0)]
		string Name
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[DispId(0)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[DispId(0)]
			[param: In]
			[param: MarshalAs(UnmanagedType.BStr)]
			set;
		}

		[DispId(1610743812)]
		string Path
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[DispId(1610743812)]
			[return: MarshalAs(UnmanagedType.BStr)]
			get;
		}
	}
	[ComImport]
	[CompilerGenerated]
	[Guid("744129E0-CBE5-11CE-8350-444553540000")]
	
	public interface FolderItems : IEnumerable
	{
		[DispId(1610743808)]
		int Count
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[DispId(1610743808)]
			get;
		}

		void _VtblGap1_2();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610743811)]
		[return: MarshalAs(UnmanagedType.Interface)]
		FolderItem Item([Optional][In][MarshalAs(UnmanagedType.Struct)] object index);
	}
	[ComImport]
	[CompilerGenerated]
	[Guid("D8F015C0-C278-11CE-A49E-444553540000")]
	
	public interface IShellDispatch
	{
	}
	[ComImport]
	[CompilerGenerated]
	[Guid("A4C6892C-3BA9-11D2-9DEA-00C04FB16162")]
	
	public interface IShellDispatch2 : IShellDispatch
	{
	}
	[ComImport]
	[CompilerGenerated]
	[Guid("177160CA-BB5A-411C-841D-BD38FACDEAA0")]
	
	public interface IShellDispatch3 : IShellDispatch2
	{
	}
	[ComImport]
	[CompilerGenerated]
	[Guid("EFD84B2D-4BCF-4298-BE25-EB542A59FBDA")]
	
	public interface IShellDispatch4 : IShellDispatch3
	{
	}
	[ComImport]
	[CompilerGenerated]
	[Guid("866738B9-6CF2-4DE8-8767-F794EBE74F4E")]
	
	public interface IShellDispatch5 : IShellDispatch4
	{
	}
	[ComImport]
	[CompilerGenerated]
	[Guid("286E6F1B-7113-4355-9562-96B7E9D64C54")]
	
	public interface IShellDispatch6 : IShellDispatch5
	{
		void _VtblGap1_2();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610743810)]
		[return: MarshalAs(UnmanagedType.Interface)]
		Folder NameSpace([In][MarshalAs(UnmanagedType.Struct)] object vDir);

		void _VtblGap2_21();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610809345)]
		void ShellExecute([In][MarshalAs(UnmanagedType.BStr)] string File, [Optional][In][MarshalAs(UnmanagedType.Struct)] object vArgs, [Optional][In][MarshalAs(UnmanagedType.Struct)] object vDir, [Optional][In][MarshalAs(UnmanagedType.Struct)] object vOperation, [Optional][In][MarshalAs(UnmanagedType.Struct)] object vShow);
	}
	[ComImport]
	[CompilerGenerated]
	[Guid("E7A1AF80-4D96-11CF-960C-0080C7F4EE85")]
	
	public interface IShellFolderViewDual
	{
	}
	[ComImport]
	[CompilerGenerated]
	[Guid("31C147B6-0ADE-4A3C-B514-DDF932EF6D17")]
	
	public interface IShellFolderViewDual2 : IShellFolderViewDual
	{
	}
	[ComImport]
	[CompilerGenerated]
	[Guid("29EC8E6C-46D3-411F-BAAA-611A6C9CAC66")]
	
	public interface IShellFolderViewDual3 : IShellFolderViewDual2
	{
		void _VtblGap1_2();

		[DispId(1610743810)]
		Folder Folder
		{
			[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
			[DispId(1610743810)]
			[return: MarshalAs(UnmanagedType.Interface)]
			get;
		}

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610743811)]
		[return: MarshalAs(UnmanagedType.Interface)]
		FolderItems SelectedItems();

		void _VtblGap2_1();

		[MethodImpl(MethodImplOptions.InternalCall, MethodCodeType = MethodCodeType.Runtime)]
		[DispId(1610743813)]
		void SelectItem([In][MarshalAs(UnmanagedType.Struct)] ref object pvfi, [In] int dwFlags);
	}
	[ComImport]
	[CompilerGenerated]
	[Guid("286E6F1B-7113-4355-9562-96B7E9D64C54")]
	[CoClass(typeof(ShellClass))]
	
	public interface Shell : IShellDispatch6
	{
	}
	[ComImport]
	[CompilerGenerated]
	[Guid("29EC8E6C-46D3-411F-BAAA-611A6C9CAC66")]
	[CoClass(typeof(ShellFolderViewClass))]
	
	public interface ShellFolderView : IShellFolderViewDual3, DShellFolderViewEvents_Event
	{
	}
	[ComImport]
	[CompilerGenerated]
	[Guid("13709620-C279-11CE-A49E-444553540000")]
	[ClassInterface(ClassInterfaceType.None)]
	public class ShellClass
	{
	}

	[ComImport]
	[CompilerGenerated]
	[Guid("62112AA1-EBE4-11CF-A5FB-0020AFE7292D")]
	[ClassInterface(ClassInterfaceType.None)]
	public class ShellFolderViewClass
	{
	}

}
