/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 11/23/2014
 * Time: 10:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;

namespace Win32Wrapper
{
	[StructLayout(LayoutKind.Sequential)]
	public struct TIME_ZONE_INFORMATION
	{
		public int bias;
		public string StandardName;
		public SYSTEMTIME standardDate;
		public int StandardBias;
		public string daylightName;
		public SYSTEMTIME daylightDate;
		public int daylightBias;
	}
}
