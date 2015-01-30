/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 1/19/2015
 * Time: 2:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace WinAPI
{
	
	public enum ProcessorFeature : uint
	{
		FloatingPointPrecisionErrata = 0,
		FloatingPointEmulated = 1,
		CompareExchangeDouble = 2,
		InstructionsMMXAvailable = 3,
		InstructionsXMMIAvailable = 6,
		Instruction3DNowAvailable = 7,
		InstructionRDTSCAvailable = 8,
		PAEEnabled = 9,
		InstructionsXMMI64Available = 10,
		NXEnabled = 12,
		InstructionsSSE3Available = 13,
		CompareExchange128 = 14,
		Compare64Exchange128 = 15,
		ChannelsEnabled = 16,
	}
}