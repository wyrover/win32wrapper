/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 8/24/2014
 * Time: 5:57 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Win32Wrapper
{
	[Flags]
	public enum CopyFileFlags : uint
	{
		COPY_FILE_FAIL_IF_EXISTS = 1,
		COPY_FILE_RESTARTABLE = 2,
		COPY_FILE_OPEN_SOURCE_FOR_WRITE = 4,
		COPY_FILE_ALLOW_DECRYPTED_DESTINATION = 8,
		COPY_FILE_COPY_SYMLINK = 2048
	}
}
