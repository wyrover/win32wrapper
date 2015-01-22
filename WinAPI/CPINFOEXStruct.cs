/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 11/19/2014
 * Time: 8:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;

namespace Win32Wrapper
{
	[StructLayout(LayoutKind.Sequential)]
	public struct CPINFOEX
	{
		public int MaxCharSize;
		public byte[] DefaultChar;
		public byte[] LeadBytes;
		public int CodePage;
		public string CodePageName;
	}
}
