/*
 * Created by SharpDevelop.
 * User: Taben Malik
 * Date: 1/23/2015
 * Time: 12:08 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;

namespace Win32Wrapper
{
	[StructLayout(LayoutKind.Sequential)]
	public struct MODULEENTRY32
    {
       private const int MAX_PATH = 255;
       internal uint dwSize;
       internal uint th32ModuleID;
       internal uint th32ProcessID;
       internal uint GlblcntUsage;
       internal uint ProccntUsage;
       internal IntPtr modBaseAddr;
       internal uint modBaseSize;
       internal IntPtr hModule;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH + 1)]
       internal string szModule;
        [MarshalAs(UnmanagedType.ByValTStr, SizeConst = MAX_PATH+5)]
       internal string szExePath;
    }
}
