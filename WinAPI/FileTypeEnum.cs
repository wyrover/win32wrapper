/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 11/21/2014
 * Time: 12:41 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace WinAPI
{
	public enum FileType : uint
	{
		FileTypeChar = 0x0002,
		FileTypeDisk = 0x0001,
		FileTypePipe = 0x0003,
		FileTypeRemote = 0x8000,
		FiletypeUnkown = 0x0000
	}
}
