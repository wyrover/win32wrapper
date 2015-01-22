/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 11/19/2014
 * Time: 9:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;

namespace Win32Wrapper
{
	[StructLayout(LayoutKind.Sequential)]
	public struct CONSOLE_CURSOR_INFO
	{
		uint Size;
		bool Visible;
	}
}
