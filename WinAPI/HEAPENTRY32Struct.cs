/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 11/24/2014
 * Time: 5:27 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;

namespace WinAPI
{
	[StructLayout(LayoutKind.Sequential)]
	public struct HEAPENTRY32
	{
		public uint dwSize;
		public IntPtr hHandle;
		public uint dwAddress;
		public uint dwBlockSize;
		public uint dwFlags;
		public uint dwLockCount;
		public uint dwResvd;
		public uint th32ProcessID;
		public uint th32HeapID;
	}
}
