/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 11/20/2014
 * Time: 10:21 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;

namespace Win32Wrapper
{
	[StructLayout(LayoutKind.Sequential)]
	public struct BY_HANDLE_FILE_INFORMATION
	{
		public uint FileAttributes;
		public FILETIME CreationTime;
		public FILETIME LastAccessTime;
		public FILETIME LastWriteTime;
		public uint VolumeSerialNumber;
		public uint FileSizeHigh;
		public uint FileSizeLow;
		public uint NumberOfLinks;
		public uint FileIndexHigh;
		public uint FileIndexLow;
	}
}
