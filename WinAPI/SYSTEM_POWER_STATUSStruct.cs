/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 11/23/2014
 * Time: 9:29 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;

namespace WinAPI
{
	[StructLayout(LayoutKind.Sequential)]
	public struct SYSTEM_POWER_STATUS
	{
		public byte ACLineStatus;
		public byte BatteryFlag;
		public byte BatteryLifePercent;
		public byte Reserved1;
		public int BatteryLifeTime;
		public int BatteryFullLifeTime;
	}
}
