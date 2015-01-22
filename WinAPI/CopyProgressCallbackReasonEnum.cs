/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 8/24/2014
 * Time: 5:56 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Win32Wrapper
{
	public enum CopyProgressCallbackReason : uint
	{
		CALLBACK_CHUNK_FINISHED = 0,
		CALLBACK_STREAM_SWITCH = 1
	}
}
