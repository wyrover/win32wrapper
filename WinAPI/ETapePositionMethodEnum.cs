/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 1/29/2015
 * Time: 9:28 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Win32Wrapper
{
	[Flags]
    public enum ETapePositionMethod : uint
    {
        TAPE_ABSOLUTE_BLOCK=1, // Moves the tape to the device-specific block address specified by the dwOffsetLow and dwOffsetHigh parameters. The dwPartition parameter is ignored.
        TAPE_LOGICAL_BLOCK=2, //  Moves the tape to the block address specified by dwOffsetLow and dwOffsetHigh in the partition specified by dwPartition.
        TAPE_REWIND=0, // Moves the tape to the beginning of the current partition. The dwPartition, dwOffsetLow, and dwOffsetHigh parameters are ignored.
        TAPE_SPACE_END_OF_DATA=4, // Moves the tape to the end of the data on the partition specified by dwPartition.
        TAPE_SPACE_FILEMARKS=6, // Moves the tape forward (or backward) the number of filemarks specified by dwOffsetLow and dwOffsetHigh in the current partition. The dwPartition parameter is ignored.
        TAPE_SPACE_RELATIVE_BLOCKS=5, // Moves the tape forward (or backward) the number of blocks specified by dwOffsetLow and dwOffsetHigh in the current partition. The dwPartition parameter is ignored.
        TAPE_SPACE_SEQUENTIAL_FMKS=7, // Moves the tape forward (or backward) to the first occurrence of n filemarks in the current partition, where n is the number specified by dwOffsetLow and dwOffsetHigh. The dwPartition parameter is ignored.
        TAPE_SPACE_SEQUENTIAL_SMKS=9, // Moves the tape forward (or backward) to the first occurrence of n setmarks in the current partition, where n is the number specified by dwOffsetLow and dwOffsetHigh. The dwPartition parameter is ignored.
        TAPE_SPACE_SETMARKS=8 // Moves the tape forward (or backward) the number of setmarks specified by dwOffsetLow and dwOffsetHigh in the current partition. The dwPartition parameter is ignored.
     }
}
