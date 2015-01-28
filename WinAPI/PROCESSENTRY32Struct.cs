/*
 * Created by SharpDevelop.
 * User: Taben Malik
 * Date: 1/27/2015
 * Time: 2:20 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;

namespace Win32Wrapper
{
	[StructLayout(LayoutKind.Sequential)]
	public struct PROCESSENTRY32
	{
		public uint dwSize; 
		public uint cntUsage; 
		public uint th32ProcessID; 
		public IntPtr th32DefaultHeapID; 
		public uint th32ModuleID; 
		public uint cntThreads; 
		public uint th32ParentProcessID; 
		public int pcPriClassBase; 
		public uint dwFlags; 
		[MarshalAs(UnmanagedType.ByValTStr, SizeConst=260)] public string szExeFile; 
    }
}
