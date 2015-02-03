/*
 * Created by SharpDevelop.
 * User: Taben Malik
 * Date: 2/3/2015
 * Time: 1:39 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using Win32Wrapper.Kernel;
using System.Runtime.InteropServices;
using System.ComponentModel;

namespace Win32Wrapper.Kernel
{
	public class Kernel
	{
		public Kernel()
		{
		}
		
		public static ushort AddAtom(string astring)
		{
			
			ushort atom = NativeMethods.AddAtom(astring);
			int error = Marshal.GetLastWin32Error();
			
			if(error != 0)
			{
				throw new Win32Exception(error);
			}
			
			return atom;
		}
		
		public static bool AllocConsole()
		{
			bool succeed = NativeMethods.AllocConsole();
			int error = Marshal.GetLastWin32Error();
			
			if(error != 0)
			{
				throw new Win32Exception(error);
			}
			
			return succeed;
		}
	}
}
