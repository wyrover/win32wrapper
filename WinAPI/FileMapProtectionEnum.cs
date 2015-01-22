/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 8/25/2014
 * Time: 7:34 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Win32Wrapper
{
	[Flags]
	public enum FileMapProtection : uint
	{
		PageReadonly = 0x02,
		PageReadWrite = 0x04,
		PageWriteCopy = 0x08,
		PageExecuteRead = 0x20,
		PageExecuteReadWrite = 0x40,
		SectionCommit = 0x8000000,
		SectionImage = 0x1000000,
		SectionNoCache = 0x10000000,
		SectionReserve = 0x4000000
	}
}
