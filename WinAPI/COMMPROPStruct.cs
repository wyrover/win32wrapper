/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 11/19/2014
 * Time: 8:33 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;

namespace WinAPI
{
	[StructLayout(LayoutKind.Sequential)]
	struct COMMPROP
	{
		short wPacketLength;
		short wPacketVersion;
		int dwServiceMask;
		int dwReserved1;
		int dwMaxTxQueue;
		int dwMaxRxQueue;
		int dwMaxBaud;
		int dwProvSubType;
		int dwProvCapabilities;
		int dwSettableParams;
		int dwSettableBaud;
		short wSettableData;
		short wSettableStopParity;
		int dwCurrentTxQueue;
		int dwCurrentRxQueue;
		int dwProvSpec1;
		int dwProvSpec2;
		string wcProvChar;
	}
}
