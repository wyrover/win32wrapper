/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 11/17/2014
 * Time: 8:25 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;

namespace Win32Wrapper
{
	[StructLayout(LayoutKind.Sequential)]
	public struct WIN32_FIND_DATA
	{
		public uint dwFileAttributes;
		public FILETIME ftCreationTime;
		public FILETIME ftLastAccessTime;
		public FILETIME ftLastWriteTime;
		public uint nFileSizeHigh;
		public uint nFileSizeLow;
		public uint dwReserved0;
		public uint dwReserved1;
		public string cFileName;
		public string cAlternateFileName;
	}
}
