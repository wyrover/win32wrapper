/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 8/24/2014
 * Time: 5:54 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace WinAPI
{
	public enum CopyProgressResult : uint
	{
		PROGRESS_CONTINUE = 0,
		PROGRESS_CANCEL = 1,
		PROGRESS_STOP = 2,
		PROGRESS_QUIET = 3
	}
}
