/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 8/18/2014
 * Time: 7:12 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;
using System.Collections.Specialized;

namespace WinAPI
{
	[StructLayout(LayoutKind.Sequential)]
	public struct DCB
	{
		public uint DCBLength;
		public uint BaudRate;
		private BitVector32 Flags;
		
		private ushort wReserved;
		public ushort XonLim;
		public ushort XoffLim;
		
		public byte ByteSize;
		public Parity Parity;
		public StopBits StopBits;
		
		public sbyte XonChar;
		public sbyte XoffChar;
		public sbyte ErrorChar;
		public sbyte EofChar;
		public sbyte EvtChar;
		private ushort wReserved1;
		
		private static readonly int fBinary;
		private static readonly int fParity;
		private static readonly int fOutxCtsFlow;
		private static readonly int fOutxDsrFlow;
		private static readonly BitVector32.Section fDtrControl;
		private static readonly int fDsrSensitivity;
		private static readonly int fTXContinueOnXoff;
		private static readonly int fOutX;
		private static readonly int fInX;
		private static readonly int fErrorChar;
		private static readonly int fNull;
		private static readonly BitVector32.Section fRtsControl;
		private static readonly int fAbortOnError;
		
		static DCB()
		{
			int previousMask;
	        fBinary = BitVector32.CreateMask();
	        fParity = BitVector32.CreateMask(fBinary);
	        fOutxCtsFlow = BitVector32.CreateMask(fParity);
	        fOutxDsrFlow = BitVector32.CreateMask(fOutxCtsFlow);
	        previousMask = BitVector32.CreateMask(fOutxDsrFlow);
	        previousMask = BitVector32.CreateMask(previousMask);
	        fDsrSensitivity = BitVector32.CreateMask(previousMask);
	        fTXContinueOnXoff = BitVector32.CreateMask(fDsrSensitivity);
	        fOutX = BitVector32.CreateMask(fTXContinueOnXoff);
	        fInX = BitVector32.CreateMask(fOutX);
	        fErrorChar = BitVector32.CreateMask(fInX);
	        fNull = BitVector32.CreateMask(fErrorChar);
	        previousMask = BitVector32.CreateMask(fNull);
	        previousMask = BitVector32.CreateMask(previousMask);
	        fAbortOnError = BitVector32.CreateMask(previousMask);
	        
	        // Create section Mask
	        BitVector32.Section previousSection;
	        previousSection = BitVector32.CreateSection(1);
	        previousSection = BitVector32.CreateSection(1, previousSection);
	        previousSection = BitVector32.CreateSection(1, previousSection);
	        previousSection = BitVector32.CreateSection(1, previousSection);
	        fDtrControl = BitVector32.CreateSection(2, previousSection);
	        previousSection = BitVector32.CreateSection(1, fDtrControl);
	        previousSection = BitVector32.CreateSection(1, previousSection);
	        previousSection = BitVector32.CreateSection(1, previousSection);
	        previousSection = BitVector32.CreateSection(1, previousSection);
	        previousSection = BitVector32.CreateSection(1, previousSection);
	        previousSection = BitVector32.CreateSection(1, previousSection);
	        fRtsControl = BitVector32.CreateSection(3, previousSection);
	        previousSection = BitVector32.CreateSection(1, fRtsControl);
			
		}
		
		public bool Binary
	    {
	        get { return Flags[fBinary]; }
	        set { Flags[fBinary] = value; }
	    }
	
	    public bool CheckParity
	    {
	        get { return Flags[fParity]; }
	        set { Flags[fParity] = value; }
	    }
	
	    public bool OutxCtsFlow
	    {
	        get { return Flags[fOutxCtsFlow]; }
	        set { Flags[fOutxCtsFlow] = value; }
	    }
	
	    public bool OutxDsrFlow
	    {
	        get { return Flags[fOutxDsrFlow]; }
	        set { Flags[fOutxDsrFlow]  = value; }
	    }
	
	    public DtrControl DtrControl
	    {
	        get { return (DtrControl)Flags[fDtrControl]; }
	        set { Flags[fDtrControl] = (int)value; }
	    }
	
	    public bool DsrSensitivity
	    {
	        get { return Flags[fDsrSensitivity]; }
	        set { Flags[fDsrSensitivity] = value; }
	    }
	
	    public bool TxContinueOnXoff
	    {
	        get { return Flags[fTXContinueOnXoff]; }
	        set { Flags[fTXContinueOnXoff] = value; }
	    }
	
	    public bool OutX
	    {
	        get { return Flags[fOutX]; }
	        set { Flags[fOutX] = value; }
	    }
	
	    public bool InX
	    {
	        get { return Flags[fInX]; }
	        set { Flags[fInX] = value; }
	    }
	
	    public bool ReplaceErrorChar
	    {
	        get { return Flags[fErrorChar]; }
	        set { Flags[fErrorChar] = value; }
	    }
	
	    public bool Null
	    {
	        get { return Flags[fNull]; }
	        set { Flags[fNull] = value; }
	    }
	
	    public RtsControl RtsControl
	    {
	        get { return (RtsControl)Flags[fRtsControl]; }
	        set { Flags[fRtsControl]  = (int)value; }
	    }
	
	    public bool AbortOnError
	    {
	        get { return Flags[fAbortOnError]; }
	        set { Flags[fAbortOnError] = value; }
	    }
	}
}
