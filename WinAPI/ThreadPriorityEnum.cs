/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 11/23/2014
 * Time: 9:51 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Win32Wrapper
{
	public enum ThreadPriority
	{
		THREAD_MODE_BACKGROUND_BEGIN = 0x00010000,
		THREAD_MODE_BACKGROUND_END = 0x00020000,
		THREAD_PRIORITY_ABOVE_NORMAL = 1,
		THREAD_PRIORITY_BELOW_NORMAL = -1,
		THREAD_PRIORITY_HIGHEST = 2,
		THREAD_PRIORITY_IDLE = -15,
		THREAD_PRIORITY_LOWEST = -2,
		THREAD_PRIORITY_NORMAL = 0,
		THREAD_PRIORITY_TIME_CRITICAL = 15
	}
}
