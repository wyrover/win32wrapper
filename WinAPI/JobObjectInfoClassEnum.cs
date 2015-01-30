/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 1/29/2015
 * Time: 8:58 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Win32Wrapper
{
	public enum JOBOBJECTINFOCLASS
	{
		AssociateCompletionPortInformation = 7,
		BasicLimitInformation = 2,
		BasicUIRestrictions = 4,
		EndOfJobTimeInformation = 6,
		ExtendedLimitInformation = 9,
		SecurityLimitInformation = 5,
		GroupInformation = 11
	}
}
