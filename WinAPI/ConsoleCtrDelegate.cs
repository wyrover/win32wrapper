/*
 * Created by SharpDevelop.
 * User: Taben Malik
 * Date: 1/29/2015
 * Time: 2:26 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Win32Wrapper
{
	delegate Boolean ConsoleCtrlDelegate(CtrlTypes CtrlType);

	// Enumerated type for the control messages sent to the handler routine
	enum CtrlTypes : uint
	{
	    CTRL_C_EVENT = 0,
	    CTRL_BREAK_EVENT,
	    CTRL_CLOSE_EVENT,   
	    CTRL_LOGOFF_EVENT = 5,
	    CTRL_SHUTDOWN_EVENT
	}
}
