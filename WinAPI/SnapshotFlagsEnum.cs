/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 11/13/2014
 * Time: 8:21 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace WinAPI
{
	[Flags]
	public enum SnapshotFlags : uint	
	{
		HeapList = 0x00000001,
	    Process  = 0x00000002,
	    Thread   = 0x00000004,
	    Module   = 0x00000008,
	    Module32 = 0x00000010,
	    All      = (HeapList | Process | Thread | Module),
	    Inherit  = 0x80000000,
	    NoHeaps = 0x40000000
	}
}
