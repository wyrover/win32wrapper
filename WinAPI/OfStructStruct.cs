/*
 * Created by SharpDevelop.
 * User: Taben Malik
 * Date: 1/23/2015
 * Time: 12:21 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;

namespace Win32Wrapper
{
	[StructLayout(LayoutKind.Sequential)]
	public struct OFSTRUCT
	{
	  public byte cBytes;
	  public byte fFixedDisc;
	  public UInt16 nErrCode;
	  public UInt16 Reserved1;
	  public UInt16 Reserved2;
	  [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 128)] 
	  public string szPathName;
	}
}
