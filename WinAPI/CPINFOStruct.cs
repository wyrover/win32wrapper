/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 11/17/2014
 * Time: 9:38 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;

namespace Win32Wrapper
{
	[StructLayout(LayoutKind.Sequential)]
	public struct CPINFO
	{
		public uint MaxCharSize;
		public byte DefaultChar;
		public byte LeadByte;
	}
}
