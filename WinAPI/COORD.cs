/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 11/17/2014
 * Time: 8:03 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;

namespace WinAPI
{
	[StructLayout(LayoutKind.Sequential)]
	public struct COORD
	{
		public short X;
		public short Y;
		
		public COORD(short x, short y)
		{
			this.X = x;
			this.Y = y;
		}
	}
}
