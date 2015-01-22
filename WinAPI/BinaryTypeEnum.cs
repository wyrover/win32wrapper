/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 11/17/2014
 * Time: 9:24 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Win32Wrapper
{
	public enum BinaryType : uint
	{
		SCS_32BIT_BINARY = 0,
		SCS_64BIT_BINARY = 6,
		SCS_DOS_BINARY = 1,
		SCS_OS216_BINARY = 5,
		SCS_PIF_BINARY = 3,
		SCS_POSIX_BINARY = 4,
		SCS_WOW_BINARY = 2
	}
}
