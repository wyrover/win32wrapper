/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 1/29/2015
 * Time: 8:55 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Win32Wrapper
{
	[Flags]
	enum HANDLE_FLAGS: uint
	{
		None = 0,
		INHERIT = 1,
		PROTECT_FROM_CLOSE = 2
	}
}
