/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 8/24/2014
 * Time: 5:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;

namespace Win32Wrapper
{
	[StructLayout(LayoutKind.Sequential)]
	public struct FILETIME
	{
		public uint DateTimeLow;
		public uint DateTimeHigh;
	}
}
