/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 11/24/2014
 * Time: 4:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;

namespace WinAPI
{
	[StructLayout(LayoutKind.Sequential)]
	public struct OSVERSIONINFO
	{
		public uint dwOSVersionInfoSize;
		public uint dwMajorVersion;
		public uint dwMinorVersion;
		public uint dwBuildNumber;
		public uint dwPlatformId;
		public string szCSDVersion;
		public Int16 wServicePackMajor;
		public Int16 wServicePackMinor;
		public Int16 wSuiteMask;
		public Byte wProductType;
		public Byte wReserved;
	}
}
