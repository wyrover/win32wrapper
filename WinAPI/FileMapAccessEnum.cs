/*
 * Created by SharpDevelop.
 * User: Taben Malik
 * Date: 1/23/2015
 * Time: 12:04 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Win32Wrapper
{
	[Flags]
	public enum FileMapAccess : uint
	{
	    FileMapCopy = 0x0001,
	    FileMapWrite = 0x0002,
	    FileMapRead = 0x0004,
	    FileMapAllAccess = 0x001f,
	    FileMapExecute = 0x0020,
	}
}
