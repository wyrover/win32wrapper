/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 11/19/2014
 * Time: 10:05 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;

namespace WinAPI
{
	[StructLayout(LayoutKind.Sequential)]
	public struct CURRENCYFMT
	{
		public UInt32 uiNumDigits;
		public UInt32 uiLeadingZero;
		public UInt32 uiGrouping;
		public string lpDecimalSep;
		public string lpThousandSep;
		public UInt32 uiNegativeOrder;
		public UInt32 uiPositiveOrder;
		public string lpCurrencySymbol;
	}
}
