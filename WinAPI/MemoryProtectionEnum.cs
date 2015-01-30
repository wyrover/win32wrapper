/*
 * Created by SharpDevelop.
 * User: Taben Malik
 * Date: 1/30/2015
 * Time: 10:42 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Win32Wrapper
{
	[Flags()]
	public enum MemoryProtection:uint
	{
		EXECUTE=0x10,
		EXECUTE_READ=0x20,
		EXECUTE_READWRITE=0x40,
		EXECUTE_WRITECOPY=0x80,
		NOACCESS=0x01,
		READONLY=0x02,
		READWRITE=0x04,
		WRITECOPY=0x08,
		GUARD_Modifierflag=0x100,
		NOCACHE_Modifierflag = 0x200,
		WRITECOMBINE_Modifierflag = 0x400
	}
}
