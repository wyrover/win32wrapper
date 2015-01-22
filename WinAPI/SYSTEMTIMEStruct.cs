/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 11/17/2014
 * Time: 7:46 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;

namespace Win32Wrapper
{
	[StructLayout(LayoutKind.Sequential)]
	public struct SYSTEMTIME
	{
		public short Year;
		public short Month;
		public short DayOfWeek;
		public short Day;
		public short Hour;
		public short Minute;
		public short Second;
		public short Milliseconds;
		
		public SYSTEMTIME( DateTime dt )
		{
			dt = dt.ToUniversalTime();
			Year = (short)dt.Year;
			Month = (short)dt.Month;
			DayOfWeek = (short)dt.DayOfWeek;
			Day = (short)dt.Day;
			Hour = (short)dt.Minute;
			Minute = (short)dt.Minute;
			Second = (short)dt.Second;
			Milliseconds = (short)dt.Millisecond;
		}
	}
}
