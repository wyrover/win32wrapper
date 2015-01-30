/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 1/29/2015
 * Time: 9:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Win32Wrapper
{
	public enum PriorityClass : uint
	{
		ABOVE_NORMAL_PRIORITY_CLASS = 0x8000,
		BELOW_NORMAL_PRIORITY_CLASS = 0x4000,
		HIGH_PRIORITY_CLASS = 0x80,
		IDLE_PRIORITY_CLASS = 0x40,
		NORMAL_PRIORITY_CLASS = 0x20,
		PROCESS_MODE_BACKGROUND_BEGIN = 0x100000,// 'Windows Vista/2008 and higher
		PROCESS_MODE_BACKGROUND_END = 0x200000,//   'Windows Vista/2008 and higher
		REALTIME_PRIORITY_CLASS = 0x100
	}
}
