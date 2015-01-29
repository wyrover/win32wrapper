/*
 * Created by SharpDevelop.
 * User: Taben Malik
 * Date: 1/29/2015
 * Time: 1:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;

namespace Win32Wrapper
{
	[StructLayout(LayoutKind.Explicit)]
	public struct FILE_SEGMENT_ELEMENT
	{
		[FieldOffset(0)]
		public IntPtr Buffer;
		[FieldOffset(0)]
		public UInt64 Alignment;
	}
}
