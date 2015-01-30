/*
 * Created by SharpDevelop.
 * User: Taben Malik
 * Date: 1/30/2015
 * Time: 10:27 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;

namespace Win32Wrapper
{
	[StructLayout(LayoutKind.Sequential)]
	public struct THREADENTRY32
	{
		internal UInt32 dwSize;
		internal UInt32 cntUsage;
		internal UInt32 th32ThreadID;
		internal UInt32 th32OwnerProcessID;
		internal UInt32 tpBasePri;
		internal UInt32 tpDeltaPri;
		internal UInt32 dwFlags;
	}
}
