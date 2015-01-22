/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 8/24/2014
 * Time: 5:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;

namespace Win32Wrapper
{
	[StructLayout( LayoutKind.Sequential )]
	public struct COMMCONFIG
	{
	   public UInt32 dwSize;
	   public UInt16 wVersion;
	   public UInt16 wReserved;
	   public DCB dcb;
	   public UInt32 dwProviderSubType;
	   public UInt32 dwProviderOffsert;
	   public UInt32 dwProviderSize;
	   public Byte wcProviderDate;
	}
}
