/*
 * Created by SharpDevelop.
 * User: Taben Malik
 * Date: 1/23/2015
 * Time: 12:14 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;

namespace Win32Wrapper
{
	[Flags]
	enum MoveFileFlags
	{
	    MOVEFILE_REPLACE_EXISTING           = 0x00000001,
	    MOVEFILE_COPY_ALLOWED               = 0x00000002,
	    MOVEFILE_DELAY_UNTIL_REBOOT         = 0x00000004,
	    MOVEFILE_WRITE_THROUGH              = 0x00000008,
	    MOVEFILE_CREATE_HARDLINK            = 0x00000010,
	    MOVEFILE_FAIL_IF_NOT_TRACKABLE      = 0x00000020
	}
}
