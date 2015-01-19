/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 8/26/2014
 * Time: 1:02 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;

namespace WinAPI
{
	[StructLayout(LayoutKind.Sequential)]
	internal struct PROCESS_INFORMATION 
	{
	   public IntPtr hProcess;
	   public IntPtr hThread;
	   public int dwProcessId;
	   public int dwThreadId;
	}
}
