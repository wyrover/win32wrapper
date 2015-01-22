/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 8/18/2014
 * Time: 8:22 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Win32Wrapper
{
	public struct COMMTIMEOUTS
	{
		public UInt32 ReadIntervalTimeout;
		public UInt32 ReadTotalTimeoutMultiplier;
		public UInt32 ReadTotalTimeoutConstant;
		public UInt32 WriteTotalTimeoutMultiplier;
		public UInt32 WriteTotalTimeoutConstant;
	}
}
