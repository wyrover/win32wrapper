/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 11/21/2014
 * Time: 4:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;

namespace Win32Wrapper
{
	[StructLayout(LayoutKind.Sequential)]
	public struct SYSTEM_INFO
	{
		public ushort processorArchitecture;
		ushort reserved;
		public uint pageSize;
		public IntPtr minimumApplicationAddress;
		public IntPtr maximumApplicationAddress;
		public IntPtr activeProcessorMask;
		public uint numberOfProcessors;
		public uint processorType;
		public uint allocationGranularity;
		public ushort processorLevel;
		public ushort processorRevision;
	}
}
