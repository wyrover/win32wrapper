/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 11/20/2014
 * Time: 12:49 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Win32Wrapper
{
	public enum DriveType : uint
	{
		Unknown = 0,
		Error = 1,
		Removable = 2,
		Fixed = 3,
		Remote = 4,
		CDROM = 5,
		RAMDisk = 6
	}
}
