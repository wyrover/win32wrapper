/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 1/19/2015
 * Time: 3:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Runtime.InteropServices;

namespace WinAPI
{
	[StructLayout(LayoutKind.Sequential)]
	struct CRITICAL_SECTION
	{
		long LockCount;
		long RecursionCount;
	}
}