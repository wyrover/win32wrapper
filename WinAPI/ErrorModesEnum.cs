/*
 * Created by SharpDevelop.
 * User: Taben Malik
 * Date: 1/29/2015
 * Time: 2:52 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Win32Wrapper
{
	[Flags]
    public enum ErrorModes : uint 
    {
        SYSTEM_DEFAULT         = 0x0,
        SEM_FAILCRITICALERRORS     = 0x0001,
        SEM_NOALIGNMENTFAULTEXCEPT = 0x0004,
        SEM_NOGPFAULTERRORBOX      = 0x0002,
        SEM_NOOPENFILEERRORBOX     = 0x8000
    }
}
