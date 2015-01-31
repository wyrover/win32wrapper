/*
 * Created by SharpDevelop.
 * User: Number One
 * Date: 8/17/2014
 * Time: 8:42 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Runtime.InteropServices;
using System.Text;

using Win32Wrapper;

namespace Win32Wrapper.Kernel
{
	internal class NativeMethods
	{
		private NativeMethods()
		{
			
		}
		
		[DllImport("kernel32",CharSet = CharSet.Auto, SetLastError = true)]
		public static extern ushort AddAtom( string lpstring );
		
		[DllImport("kernel32",CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool AllocConsole();
		
		[DllImport("kernel32",CharSet = CharSet.Auto, ExactSpelling = true, SetLastError = true)]
		public static extern bool AreFileApisANSI();
		
		[DllImport("kernel32",CharSet = CharSet.Auto, SetLastError = true)]
		[return:MarshalAs(UnmanagedType.Bool)]
		public static extern bool AssignProcessToJobObject( IntPtr hJob, IntPtr hProcess);
		
		[DllImport("kernel32",CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool BackupRead( IntPtr hFile, IntPtr lpBuffer, uint nNumberOfBytesToRead, out uint lpNumberOfBytesRead, bool bAbort, bool bProcessSecurity, ref IntPtr lpContext);
		
		[DllImport("kernel32",CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool BackupSeek( IntPtr hFile, uint dwLowBytesToSeek, uint dwHighBytesToSeek, out uint lpdwLowBytesSeeked, out uint lpdwHightBytesSeeked, ref IntPtr lpContext);
		
		[DllImport("kernel32",CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool BackuWrite( IntPtr hFile, IntPtr lpBuffer, uint nNumberOfBytesToWrite, out uint lpNumberOfBytesWritten, bool bAbort, bool bProcessSecurity, ref IntPtr lpContext);
		
		[DllImport("kernel32",CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool Beep( uint dwFreq, uint dwDuration );
		
		[DllImport("kernel32",CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr BeginUpdateResource( string pFileName, [MarshalAs(UnmanagedType.Bool)] bool bDeleteExistingResources );
		
		[DllImport("kernel32",CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool BuildCommDCB( string lpDef, [In] ref DCB lpDCB );
		
		[DllImport("kernel32",CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool BuildCommDCBAndTimeouts(string lpDef, [Out, In] ref DCB lpDCB, [Out, In] ref COMMTIMEOUTS lpCommTimeouts);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool CallNamedPipe(string lpNamedPipeName, byte[] lpInBuffer, uint nInBufferSize, [Out, In] byte [] lpOutBuffer, uint nOutBufferSize, out uint lpBytesRead, uint nTimeOut);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool CancelWaitableTimer(IntPtr hTimer);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool CloseHandle(IntPtr hObject);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool CommConfigDialog( string lpszName, IntPtr hwnd, ref COMMCONFIG lpcc);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int CompareFileTime( [In] ref Win32Wrapper.FILETIME lpFileTime1, [In] ref Win32Wrapper.FILETIME lpFileTime2);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int CompareString( uint Locale, uint dwCmpFlags, string lpString1, int cchCount1, string lpString2, int cchCount2);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool ConnectNamedPipe(IntPtr hNamedPipe, [In] ref System.Threading.NativeOverlapped lpOverlapped);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool ContinueDebugEvent( uint dwProcessID, uint dwThreadId, uint dwContinueStatus);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint ConvertDefaultLocale( uint Locale );
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr ConvertThreadToFiber(IntPtr lpParameter);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool CopyFile( string lpExistingFileName, string lpNewFileName, bool bFailIfExists);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool CopyFileEx( string lpExistingFileName, string lpNewFileName, CopyProgressRoutine lpProgressRoutine, IntPtr lpData, ref Int32 pbCancel, CopyFileFlags dwCopyFlags);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr CreateConsoleScreenBuffer( UInt32 dwDesiredAccess, UInt32 dwShareMode, IntPtr SecurityAttributes, UInt32 flags, UInt32 screenBufferData);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool CreateDirectory( string lpPathName, IntPtr lpSecuityAttributes);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool CreateDirectory( string lpTemplateDirectory, string lpNewDirectory, IntPtr lpSecurityAttributes);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr CreateEvent( IntPtr lpEventAttributes, bool bManualReset, bool bInitialState, string lpName);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr CreateFiber( uint dwStackSize, System.Delegate lpStartAdress, IntPtr lpParameter);
		
		//Needs work
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern IntPtr CreateFile( [MarshalAs(UnmanagedType.LPTStr)] string filename, [MarshalAs(UnmanagedType.U4)] FileAcess access, [MarshalAs(UnmanagedType.U4)] FileShare share, IntPtr SecurityAttributes, [MarshalAs(UnmanagedType.U4)] FileMode creationDisposition, [MarshalAs(UnmanagedType.U4)] FileAttributes flagsAndAttributes, IntPtr templateFile);
	
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr CreateFileMapping( IntPtr hFile, IntPtr lpFileMappingAttributes, FileMapProtection flProtect, uint dwMaximumSizeHigh, uint dwMaximumSizeLow, string lpName);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool CreateHardLink(string lpFileName, string lpExistingFileName, IntPtr lpSecurityAttributes);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr CreateIoCompletionPort(IntPtr FileHandle, IntPtr ExistingCompletionPort, UIntPtr CompletionKey, uint NumberOfConcurrentThreads);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr CreateJobObject([In] ref SECURITY_ATTRIBUTES lpJobAttributes, string lpName);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr CreateMailslot(string lpName, uint nMaxMessageSize, uint lReadTimeout, IntPtr lpSecurityAttributes);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr CreateMutex(IntPtr lpMutexAttributes, bool bInitialOwner, string lpName);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr CreateNamedPipe(string lpName, uint dwOpenMode, uint dwPipeMode, uint nMaxInstances, uint nOutBufferSize, uint nInBufferSize, uint nDefaultTimeOut, SECURITY_ATTRIBUTES lpSecurityAttributes);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool CreatePipe(out IntPtr hReadPipe, out IntPtr hWritePipe, ref SECURITY_ATTRIBUTES lpPipeAttributes, uint nSize);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool CreateProcess(string lpApplicationName, string lpCommandLine, ref SECURITY_ATTRIBUTES lpProcessAttributes, ref SECURITY_ATTRIBUTES lpThreadAttributes, bool bInheritHandles, uint dwCreationFlags, IntPtr lpEnvironment, string lpCurrentDirectory, [In] ref STARTUPINFO lpStartupInfo, out PROCESS_INFORMATION lpProcessInformation);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern IntPtr CreateRemoteThread(IntPtr hProcess, IntPtr lpThreadAttributes, uint dwStackSize, ThreadStartDelegate lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, IntPtr lpThreadId);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr CreateSemaphore(ref SECURITY_ATTRIBUTES securityAttributes, int initialCount, int maximumCount, string name);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint CreateTapePartition(IntPtr hDevice, uint dwPartitionMethod, uint dwCount, uint dwSize);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr CreateThread( [In] ref SECURITY_ATTRIBUTES lpThreadAttributse, uint dwStackSize, System.Threading.ThreadStart lpStartAddress, IntPtr lpParameter, uint dwCreationFlags, out uint lpThreadId);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr CreateToolhelp32Snapshot( SnapshotFlags dwFlags, uint th32ProcessID);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr CreateWaitableTimer( SECURITY_ATTRIBUTES lpTimerAttributes, bool bManualReset, string lpTimerName);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool DebugActiveProcess(uint dwProcessId);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern void DebugBreak();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool DefineDosDevice(uint dwFlags, string lpDeviceName, string lpTargetPath);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern ushort DeleteAtom(ushort nAtom);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DeleteFile( string lpFileName);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool DeviceIoControl( IntPtr hDevice, uint dwIoControlCode, IntPtr lpInBuffer, uint nInBufferSize, IntPtr lpOutBuffer, uint nOutBufferSize, out uint lpBytesReturned, IntPtr lpOverlapped);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool DisableThreadLibraryCalls([In] IntPtr hModule);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool DisconnectNampedPipe(IntPtr hNamedPipe);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool DosDateTimeToFileTime(ushort wFatDate, ushort wFatTime, out FILETIME lpFileTime);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		public static extern bool DuplicateHandle(IntPtr hSourceProcessHandle, IntPtr hSourceHandle, IntPtr hTargetProcessHandle, out IntPtr lpTargetHandle, uint dwDesiredAccess, bool bInheritHandle, uint dwOptions);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool EndUpdateResource(IntPtr hUpdate, bool fDiscard);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern void EnterCriticalSection(ref CRITICAL_SECTION lpCriticalSection);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool EnumCalendarInfo(CALINFO_ENUMPROC pCalInfoEnumProc, uint Locale, uint Calendar, uint CalType);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool EnumCalendarInfoEx(CALINFO_ENUMPROC pCalInfoEnumProcEx, uint Locale, uint Calendar, uint CalType);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool EnumDateFormats(DATEFMT_ENUMPROC lpDateFmtEnumProc, uint Locale, uint dwFlags);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool EnumDateFormatsEx(DATEFMT_ENUMPROC lpDateFmtEnumProcEx, uint Locale, uint dwFlags);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool EnumResourceLanguages(IntPtr hModule, string lpszType, string lpName, ENUMRESLANGPROC lpEnumFunc, IntPtr lParam);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool EnumResourceNames(IntPtr hModule, string lpszType, ENUMRESNAMEPROC lpEnumFunc, IntPtr lParam);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool EnumResourceTypes(IntPtr hModule, ENUMRESTYPEPROC lpEnumFunc, IntPtr lParam);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool EnumSystemCodePages(CODEPAGE_ENUMPROC lpCodePageEnumProc, uint dwFlags);
		
//		[DllImport("kernel32.dll", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool EnumSystemLocales( LOCALE_ENUMPROC lpLocaleEnumProc, uint dwFlags);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool EnumTimeFormats(TIMEFMT_ENUMPROC lpTimeFmtEnumProc, uint Locale, uint dwFlags);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint EraseTape(IntPtr hDevice, uint dwEraseType, bool bImmediate);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool EscapeCommFunction(IntPtr hFile, uint dwFunc);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern void ExitProcess(uint uExitCode);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern void ExitThread(uint dwExitCode);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int ExpandEnvironmentStrings(string lpSrc, string lpDst, long nSize);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern void FatalAppExit(uint uAction, string lpMessageText);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern void FatalExit(int ExitCode);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool FileTimeToDosDateTime([In] ref FILETIME lpFileTime, out ushort lpFatDate, out ushort lpFatTime);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool FileTimeToLocalFileTime([In] ref FILETIME lpFileTime, out FILETIME lpLocalFileTime);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool FileTimeToSystemTime([In] ref FILETIME lpFileTime, out SYSTEMTIME lpSystemTime);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool FillConsoleOutAttributes(IntPtr hConsoleOutput, ushort wAttribute, uint nLength, COORD dwWriteCoord, out uint lpNumberOfAttrsWritten);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern ushort FindAtom(string lpString);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool FindClose(IntPtr hFindFile);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool FindCloseChangeNotification(IntPtr hChangeHandle);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr FindFirstChangeNotifications(string lpPathName, bool bWatchSubtree, uint dwNotifyFilter);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr FindFirstFile(string lpFileName, out WIN32_FIND_DATA lpFindFileData);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr FindFirstFileEx(string lpFileName, FINDEX_INFO_LEVELS fInfoLevelId, out WIN32_FIND_DATA lpFindFileData, FINDEX_SEARCH_OPS fSearchOp, IntPtr lpSearchFilter, int dwAdditionalFlags);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool FindNextChangeNotification(IntPtr hChangeHandle);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool FindNextFile(IntPtr hFindFile, out WIN32_FIND_DATA lpFindFileData);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr FindResource(IntPtr hModule, string lpName, string lpType);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr FindResourceEx(IntPtr hModule, IntPtr lpType, IntPtr lpName, ushort wLanguage);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool FlushConsoleInputBuffer(IntPtr hConsoleInput);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool FlushFileBuffers(IntPtr hFile);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool FlushInstructionCache(IntPtr hProcess, IntPtr lpBaseAddress, UIntPtr dwSize);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool FlushViewOfFile(IntPtr lpBaseAddress, uint dwNumberOfBytesToFlush);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool FoldString(uint dwMapFlags, string lpSrcStr, int cchSrc, out string lpDestStr, int cchDest);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint FormatMessage(uint dwFlags, IntPtr lpSource, uint dwMessageId, uint dwLanguageId, [Out] string lpBuffer, uint nSize, IntPtr Arguments);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool FreeConsole();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool FreeEnvironmentStrings(string lpszEnvironmentBlock);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool FreeLibrary(IntPtr hModule);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern void FreeLibraryAndExitThread(IntPtr hModule, uint dwExitCode);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GenerateConsoleCtrlEvent(uint dwCtrlEvent, uint dwProcessGroupId);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetACP();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetAtomName(ushort nAtom, [Out] string lpBuffer, int nSize);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetBinaryType(string lpApplicationName, out BinaryType lpBinaryType);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetCPInfoEx(uint CodePage, int dwFlags, out CPINFOEX lpCPInfo);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetCommConfig(IntPtr hCommDev, ref COMMCONFIG lpCC, ref uint lpdwSize);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetCommMask(IntPtr hFile, out uint lpEvtMask);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool GetCommModemStatus(SafeFileHandle hFile, out uint lpModemStat);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetCommProperties(IntPtr hFile, ref COMMPROP lpCommProp);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetCommState(IntPtr hFile, ref DCB lpDCB);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetCommTimeouts(IntPtr hFile, ref COMMTIMEOUTS lpCommTimeouts);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr GetCommandLine();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetCompressedFileSize(string lpFileName, out uint lpFileSizeHigh);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetComputerName(string lpBuffer, ref uint nSize);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetConsoleCP();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetConsoleCursorInfo( IntPtr hConsoleOutput, out CONSOLE_CURSOR_INFO lpConsoleCursorInfo);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetConsoleMode(IntPtr hConsoleHandle, out uint lpMode);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetConsoleOutCP();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetConsoleScreenBufferInfo(IntPtr hConsoleOutput, out CONSOLE_SCREEN_BUFFER_INFO lpConsoleScreenBufferInfo);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int GetConsoleTitle(string lpConsoleTitle, int nSize);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr GetConsoleWindow();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int GetCurrencyFormat(uint Locale, uint dwFlags, string lpValue, CURRENCYFMT lpFormat, IntPtr lpCurrencyStr, int cchCurrency);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetCurrentDirectory(uint nBufferLength, [Out] string lpBuffer);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr GetCurrentProcess();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetCurrentProcessId();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr GetCurrentThread();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetCurrentThreadId();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int GetDateFormat(uint Locale, uint dwFlags, ref SYSTEMTIME lpDate, string lpFormat, string lpDateStr, int cchDate);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetDefaultCommConfig(string lpszName, [In, Out] ref COMMCONFIG lpCC, ref uint lpdwSize);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetDevicePowerState(IntPtr hDevice);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetDiskFreeSpace(string lpRootPathName, out uint lpSectorsPerCluster, out uint lpBytesPerSector, out uint lpNumberOfFreeClusters, out uint lpTotalNumberOfClusters);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetDiskFreeSpaceEx(string lpDirectoryName, out ulong lpFreeBytesAvailable, out ulong lpTotalNumberOfBytes, out ulong lpTotalNumberOfFreeBytes);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern DriveType GetDriveType(string lpRootPathName);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr GetEnvironmentStrings();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetEnvironmentVariable(string lpName, [Out] string lpBuffer, ulong nSize);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetExitCodeProcess(IntPtr hProcess, out uint lpExitCode);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetExitCodeThread(IntPtr hThread, out uint lpExitCode);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetFileAttributes(string lpFileName);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetFileAttributesEx(string lpFileName, GET_FILEEX_INFO_LEVELS fInfoLevelId, IntPtr lpFileInformation);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetFileInformationByHandle(IntPtr hFile, out BY_HANDLE_FILE_INFORMATION lpFileInformation);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetFileSize(IntPtr hFile, IntPtr lpFileSizeHigh);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetFileTime(IntPtr hFile, IntPtr lpCreationTime, IntPtr lpLastAccessTime, IntPtr lpLastWriteTime);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern FileType GetFileType(IntPtr hFile);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetFullPathName(string lpFileName, uint nBufferLength, [Out] string lpBuffer, [Out] string lpFilePart);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetHandleInformation(IntPtr hObject, out uint lpdwFlags);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern COORD GetLargestConsoleWindowSize(IntPtr hConsoleOutput);
		
		//NEVER USE
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern uint GetLastError();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern void GetLocalTime(out SYSTEMTIME lpSystemTime);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int GetLocaleInfo(uint Locale, uint LCType, [Out] string lpLCData, int cchData);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetLogicalDriveStrings(uint bufferLength, [Out] char[] buffer);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetLogicalDrives();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int GetLongPathName(string lpszShortPath, string lpszLongPath, int cchBuffer);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetMailslotInfo(IntPtr hMailslot, IntPtr lpMaxMessageSize, IntPtr lpNextSize, IntPtr lpMessageCount, IntPtr lpReadTimeout);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetModuleFileName(IntPtr hModule, [Out] string lpFileName, int nSize);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr GetModuleHandle(string lpModuleName);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetNamedPipeHandleState(IntPtr hNamedPipe, IntPtr lpState, IntPtr lpCurInstances, IntPtr lpMaxCollectionCount, IntPtr lpCollectDataTimeout, [Out] string lpUserName, uint nMaxUserNameSize);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetNamedPipeInfo(IntPtr hNamedPipe, IntPtr lpFlags, IntPtr lpOutBufferSize, IntPtr lpInBufferSize, IntPtr lpMaxInstances);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int GetNumberFormat(uint Locale, uint dwFlags, string lpValue, IntPtr lpFormat, [Out] string lpNumberStr, int cchNumber);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetNumberOfConsoleInputEvents(IntPtr hConsoleInput, out uint lpcNumberOfEvents);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetNumberOfConsoleMouseButtons(ref uint lpNumberOfMouseButtons);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetOEMCP();
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool GetOverlappedResult(IntPtr hFile, [In] ref OVERLAPPED lpOverlapped, out uint lpNumberOfBytesTransferred, bool bWait);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetPriorityClass(IntPtr hProcess);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetPrivateProfileInt(string lpAppName, string lpKeyName, int nDefault, string lpFileName);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetPrivateProfileSection(string lpAppName, IntPtr lpReturnedString, uint nSize, string lpFileName);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetPrivateProfileSectionNames(IntPtr lpszReturnBuffer, uint nSize, string lpFileName);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, string lpReturnedString, uint nSize, string lpFileName);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetPrivateProfileStruct(string lpszSection, string lpszKey, IntPtr lpStruct, uint uSizeStruct, string szFile);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr GetProcAddress(IntPtr hModule, string procName);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetProcessAffinityMask(IntPtr hProcess, out UIntPtr lpProcessAffinityMask, out UIntPtr lpSystemAffinityMask);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr GetProcessHeap();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern UInt32 GetProcessHeaps(UInt32 NumberOfHeaps, IntPtr[] ProcessHeaps);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetProcessPriorityBoost(IntPtr hProcess, out bool pDisablePriorityBoost);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetProcessShutdownParameters(out uint lpdwLevel, out uint lpdwFlags);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetProcessTimes(IntPtr hProcess, out FILETIME lpCreationTime, out FILETIME lpExitTime, out FILETIME lpKernelTime, out FILETIME lpUserTime);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetProcessVersion(uint ProcessId);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetProcessWorkingSetSize(IntPtr hProcess, out UIntPtr lpMinimumWorkingSetSize, out UIntPtr lpMaximumWorkingSetSize);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetProfileInt(string lpAppName, string lpKeyName, int nDefault);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetProfileSection(string lpAppName, IntPtr lpReturnedString, uint nSize);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetProfileString(string lpAppName, string lpKeyName, string lpDefault, [Out] string lpReturnedString, uint nSize);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool GetQueuedCompletionStatus(IntPtr CompletionPort, out uint lpNumberOfBytes, out UIntPtr lpCompletionKey, out OVERLAPPED lpOverlapped, uint dwMilliseconds);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetShortPathName(string lpszLongPath, string lpszShortPath, uint cchBuffer);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern void GetStartupInfo(out STARTUPINFO lpStartupInfo);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr GetStdHandle(int nStdHandle);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetStringType(uint Locale, uint dwInfoType, string lpSrcStr, int cchSrc, [Out] ushort[] lpCharType);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetSystemDefaultLCID();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern ushort GetSystemDefaultLangID();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetSystemDirectory([Out] string lpBuffer, uint uSize);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern void GetSystemInfo( ref SYSTEM_INFO lpSystemInfo);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetSystemPowerStatus(out SYSTEM_POWER_STATUS lpSystemPowerStatus);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern void GetSystemTime(out SYSTEMTIME lpSystemTime);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetSystemTimeAdjustment(out uint lpTimeAdjustment, out uint lpTimeIncrement, out bool lpTimeAdjustmentDisabled);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern void GetSystemTimeAsFileTime(out FILETIME lpSystemTimeAsFileTime);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetTapeParameters(IntPtr hDevice, uint dwOperation, out uint lpdwSize, IntPtr lpTapeInformation);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetTapePosition(IntPtr hDevice, uint dwPositionType, out uint lpdwPartition, out uint lpdwOffsetLow, out uint lpdwOffsetHigh);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetTapeStatus(IntPtr hDevice);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetTempFileName(string lpPathName, string lpPrefixString, uint uUnique, [Out] string lpTempFileName);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetTempPath(uint nBufferLength, [Out] string lpBuffer);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool GetThreadContext(IntPtr hThread, ref CONTEXT lpContext);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetThreadLocale();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern ThreadPriority GetThreadPriority(IntPtr hThread);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetThreadPriorityBoost(IntPtr hThread, out bool spDisablePriorityBoost);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool GetThreadSelectorEntry(IntPtr hThread, uint dwSelector, out LDT_ENTRY lpSelectorEntry);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetThreadTimes(IntPtr hThread, out long lpCreationTime, out long lpExitTime, out long lpKernelTime, out long lpUserTime);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetTickCount();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int GetTimeFormat(uint Locale, uint dwFlags, ref SYSTEMTIME lpTime, string lpFormat, string lpTimeStr, int cchTime);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetTimeZoneInformation(out TIME_ZONE_INFORMATION lpTimeZoneInformation);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetUserDefaultLCID();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern ushort GetUserDefaultLangID();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetVersion();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GetVersionEx(ref OSVERSIONINFO lpVersionInfo);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool GetVolumeInformation(string RootPathName, string VolumeNameBuffer, int VolumeNameSize, out uint VolumeSerialNumber, out uint MaximumComponentLength, out FileSystemFeature FileSystemFlags, string FileSystemNameBuffer, int nFileSystemNameSize);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GetWindowsDirectory(string lpBuffer, uint uSize);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern ushort GlobalAddAtom(string lpString);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr GlobalAlloc(uint uFlags, UIntPtr dwBytes);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern ushort GlobalDeleteAtom(ushort nAtom);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern ushort GlobalFindAtom(string lpString);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GlobalFlags(IntPtr hMem);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr GlobalFree(IntPtr hMem);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint GlobalGetAtomName(ushort nAtom, string lpBuffer, int nSize);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr GlobalHandle(IntPtr pMem);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr GlobablLock(IntPtr hMem);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool GlobalMemoryStatus(ref MEMORYSTATUS lpBuffer);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GlobalMemoryStatusEx( [In,Out] MEMORYSTATUSEX lpBuffer);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr GlobalReAlloc(IntPtr hMem, UIntPtr dwBytes, uint uFlags);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern UIntPtr GlobalSize(IntPtr hMem);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool GlobalUnlock(IntPtr hMem);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool Heap32First(ref HEAPENTRY32 lphe, uint th32ProcessID, UIntPtr th32HeapID);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool Heap32ListFirst(IntPtr hSnapshot, ref HEAPLIST32 lphl);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool Heap32ListNext(IntPtr hSnapshot, ref HEAPLIST32 lphl);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool Heap32Next(out HEAPENTRY32 lphe);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr HeapAlloc(IntPtr hHeap, uint dwFlags, UIntPtr dwBytes);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint HeapCompact(IntPtr hHeap, uint dwFlags);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr HeapCreate(uint flOptions, UIntPtr dwInitialSize, UIntPtr dwMaximumSize);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool HeapDestroy(IntPtr hHeap);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool HeapFree(IntPtr hHeap, uint dwFlags, IntPtr lpMem);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool HeapLock(IntPtr hHeap);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr HeapReAlloc(IntPtr hHeap, uint dwFlags, IntPtr lpMem, UIntPtr dwBytes);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint HeapSize(IntPtr hHeap, uint dwFlags, IntPtr lpMem);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool HeapUnlock(IntPtr hHeap);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool HeapValidate(IntPtr hHeap, uint dwFlags, IntPtr lpMem);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool HeapWalk(IntPtr hHeap, ref PROCESS_HEAP_ENTRY lpEntry);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool InitAtomTable(uint nSize);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern void InitializeCriticalSection(out CRITICAL_SECTION lpCriticalSection);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool InitializeCriticalSectionAndSpinCount(ref CRITICAL_SECTION lpCriticalSection, uint dwSpinCount);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int InterlockedCompareExchange(ref int Destination, int Exchange, int Comperand);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int InterlockedDecrement(ref int lpAddend);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int InterlockedExchange(ref int Target, int Value);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int InterlockedExchangeAdd(ref int Addend, int Value);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int InterlockedIncrement(ref int lpAddend);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool IsBadCodePtr(IntPtr lpfn);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool IsBadReadPtr(IntPtr lp, uint ucb);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool IsBadStringPtr(string lpsz, uint ucchMax);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool IsBadWritePtr(IntPtr lp, uint ucb);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool IsDBCSLeadByte(byte TestChar);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool IsDBCDLeadByteEx(uint CodePage, byte TestChar);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool IsDebuggerPresent();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool IsProcessorFeaturePresent(ProcessorFeature processorFeature);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool IsValidCodePage(uint CodePage);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool IsValidLocale( uint Locale, uint dwFlags);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int LCMapString(uint Locale, uint dwMapFlags, string lpSrcStr, int cchSrc, [Out] StringBuilder lpDestStr, int cchDest);
		
		//Need to create Critical_section structure. hard to find
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern void LeaveCriticalSection(ref CRITICAL_SECTION lpCriticalSection);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr LoadLibrary(string lpFileName);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr LoadLibraryEx(string lpFileName, IntPtr hReservedNull, LoadLibraryFlags dwFlags);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint LoadModule(string lpModuleName, IntPtr lpParameterBlock);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr LoadResource(IntPtr hModule, IntPtr hResInfo);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr LocalAlloc(uint uFlags, UIntPtr uBytes);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool LocalFileTimeToFileTime([In] ref FILETIME lpLocalFileTime, out FILETIME lpFileTime);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint LocalFlags(IntPtr hMem);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr LocalFree(IntPtr hMem);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr LocalHandle(IntPtr pMem);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr LocalLock(IntPtr hMem);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr LocalReAlloc(IntPtr hMem, UIntPtr uBytes, uint uFlags);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint LocalSize(IntPtr hMem);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool LocalUnlock(IntPtr hMem);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool LockFile(IntPtr hFile, uint dwFileOffsetLow, uint dwFileOffsetHigh, uint nNumberOfBytesToLockLow, uint nNumberOfBytesToLockHigh);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool LockFileEx(IntPtr hFile, uint dwFlags, uint dwReserved, uint nNumberOfBytesToLockLow, uint nNumberOfBytesToLockHigh, [In] ref System.Threading.NativeOverlapped lpOverlapped);
	
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr LockResource(IntPtr hResData);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr lstrcat(StringBuilder lpString1, string lpString2);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int lstrcmp(string lpString1, string lpString2);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int lstrcmpi(string lpString1, string lpString2);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr lstrcpy([Out] StringBuilder lpString1, string lpString2);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr lstrcpyn([Out] StringBuilder lpString1, string lpString2, int iMaxLength);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int lstrlen(string lpString);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr MapViewOfFile(IntPtr hFileMappingObject, FileMapAccess dwDesiredAccess,UInt32 dwFileOffsetHigh, UInt32 dwFileOffsetLow, UIntPtr dwNumberOfBytesToMap);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr MapViewOfFileEx(IntPtr hFileMappingObject, FileMapAccess dwDesiredAccess, uint dwFileOffsetHigh, uint dwFileOffsetLow, UIntPtr dwNumberOfBytesToMap, IntPtr lpBaseAddress);
	
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool Module32First(IntPtr hSnapshot, ref MODULEENTRY32 lpme);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool Module32Next(IntPtr hSnapshot, ref MODULEENTRY32 lpme);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool MoveFile(string lpExistingFileName, string lpNewFileName);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool MoveFileEx(string lpExistingFileName, string lpNewFileName, MoveFileFlags dwFlags);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool MoveFileWithProgress(string lpExistingFileName, string lpNewFileName, CopyProgressRoutine lpProgressRoutine, IntPtr lpData, MoveFileFlags dwFlags);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int MulDiv(int nNumber, int nNumerator, int nDenominator);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int MultiByteToWideChar(uint CodePage, uint dwFlags, string lpMultiByteStr, int cbMultiByte, [Out, MarshalAs(UnmanagedType.LPWStr)] StringBuilder lpWideCharStr, int cchWideChar);
	
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr OpenEvent(uint dwDesiredAccess, bool bInheritHandle, string lpName);
		
		//Missing struct or enum
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern int OpenFile([System.Runtime.InteropServices.MarshalAs(System.Runtime.InteropServices.UnmanagedType.LPStr)]string lpFileName, out OFSTRUCT lpReOpenBuff, OpenFileStyle uStyle);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr OpenFileMapping(uint dwDesiredAccess, bool bInheritHandle, string lpName);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr OpenJobObject(uint dwDesiredAccess, bool bInheritHandle, string lpName);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr OpenMutex(uint dwDesiredAccess, bool bInheritHandle, string lpName);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern IntPtr OpenProcess(ProcessAccessFlags processAccess, bool bInheritHandle, int processId);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr OpenSemaphore(uint dwDesiredAccess, bool bInheritHandle, string lpName);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr OpenWaitableTimer(uint dwDesiredAccess, bool bInheritHandle, string lpTimerName);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern void OutputDebugString(string lpOutputString);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool PeekConsoleInput(IntPtr hConsoleInput, [MarshalAs(UnmanagedType.LPArray), Out] INPUT_RECORD[] lpBuffer, DWORD nLength, out DWORD lpNumberOfEventsRead);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool PostQueuedCompletionStatus(IntPtr CompletionPort, uint dwNumberOfBytesTransferred, UIntPtr dwCompletionKey, [In] ref System.Threading.NativeOverlapped lpOverlapped);
	
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint PrepareTape(IntPtr hDevice, uint dwOperation, bool bImmediate);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool Process32First(IntPtr hSnapshot, ref PROCESSENTRY32 lppe);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool Process32Next(IntPtr hSnapshot, ref PROCESSENTRY32 lppe);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool PulseEvent(IntPtr hEvent);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool PurgeComm(IntPtr hFile, uint dwFlags);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint QueryDosDevice(string lpDeviceName, IntPtr lpTargetPath, uint ucchMax);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool QueryInformationJobObject(IntPtr hJob, JOBOBJECTINFOCLASS JobObjectInformationClass, IntPtr lpJobObjectInfo, uint cbJobObjectInfoLength, IntPtr lpReturnLength);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool QueryPerformanceCounter(out long lpPerformanceCount);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool QueryPerformanceFrequency(out long frequency);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern uint QueueUserAPC(ApcDelegate pfnAPC, IntPtr hThread, UIntPtr dwData);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern void RaiseException(uint dwExceptionCode, uint dwExceptionFlags, uint nNumberOfArguments, IntPtr lpArguments);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool ReadConsole(IntPtr hConsoleInput, [Out] StringBuilder lpBuffer, uint nNumberOfCharsToRead, out uint lpNumberOfCharsRead, IntPtr lpReserved);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool ReadConsoleInput(IntPtr hConsoleInput, [Out] INPUT_RECORD [] lpBuffer, uint nLength, out uint lpNumberOfEventsRead);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool ReadConsoleOutput
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool ReadConsoleOutputAttribute(IntPtr hConsoleOutput, [Out] ushort [] lpAttribute, uint nLength, COORD dwReadCoord, out uint lpNumberOfAttrsRead);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool ReadConsoleOutputCharacter(IntPtr hConsoleOutput, StringBuilder lpCharacter, uint nLength, COORD dwReadCoord, out uint lpNumberOfCharsRead);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool ReadFile(IntPtr hFile, [Out] byte[] lpBuffer, uint nNumberOfBytesToRead, out uint lpNumberOfBytesRead, IntPtr lpOverlapped);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool ReadFileEx(IntPtr hFile, [Out] byte [] lpBuffer, uint nNumberOfBytesToRead, [In] ref System.Threading.NativeOverlapped lpOverlapped, ReadFileCompletionDelegate lpCompletionRoutine);
	
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool ReadFileScatter(IntPtr hFile, FILE_SEGMENT_ELEMENT[] aSegementArray, uint nNumberOfBytesToRead, IntPtr lpReserved, [In] ref System.Threading.NativeOverlapped lpOverlapped);
	
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool ReadProcessMemory(IntPtr hProcess, IntPtr lpBaseAddress, [Out] byte[] lpBuffer, int dwSize, out IntPtr lpNumberOfBytesRead);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool ReleaseMutex(IntPtr hMutex);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool ReleaseSemaphore(IntPtr hSemaphore, int lReleaseCount, IntPtr lpPreviousCount);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool RemoveDirectory(string lpPathName);
		
		//can't find latency time struct
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool RequestWakeupLatency(LATENCY_TIME latency);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool ResetEvent(IntPtr hEvent);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint ResumeThread(IntPtr hThread);
		
		//no char info struct
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool ScrollConsoleScreenBuffer(IntPtr hConsoleOutput, [In] ref SMALL_RECT lpScrollRectangle, IntPtr lpClipRectangle, COORD dwDestinationOrigin, [In] ref CHAR_INFO lpFill);
	
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint SearchPath (string lpPath, string lpFileName, string lpExtension, int nBufferLength, [MarshalAs ( UnmanagedType.LPTStr )] StringBuilder lpBuffer, out IntPtr lpFilePart );
	
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetCommConfig(IntPtr hCommDev, [In] ref COMMCONFIG lpCC, uint dwSize);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetCommMask(IntPtr hFile, uint dwEvtMask);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetCommState(IntPtr hFile, [In] ref DCB lpDCB);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetCommTimeouts(IntPtr hFile, [In] ref COMMTIMEOUTS lpCommTimeouts);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetComputerName(string lpComputerName);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetConsoleActiveScreenBuffer(IntPtr hConsoleOutput);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetConsoleCP(uint wCodePageID);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetConsoleCtrlHandler(ConsoleCtrlDelegate HandlerRoutine, bool Add);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetConsoleCursorInfo(IntPtr hConsoleOutput, [In] ref CONSOLE_CURSOR_INFO lpConsoleCursorInfo);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetConsoleCursorPosition(IntPtr hConsoleOutput, COORD dwCursorPosition);
		
		//can't find consoleModes struct
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool SetConsoleMode(IntPtr hConsoleHandle, uint dwMode);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetConsoleOutputCP(uint wCodePageID);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetConsoleScreenBufferSize(IntPtr hConsoleOutput, COORD dwSize);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetConsoleTextAttribute(IntPtr hConsoleOutput, ushort wAttributes);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetConsoleTitle(string lpConsoleTitle);

		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetConsoleWindowInfo(IntPtr hConsoleOutput, bool bAbsolute, [In] ref SMALL_RECT lpConsoleWindow);
		
		//no critical section struct
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern uint SetCriticalSectionSpinCount(ref CRITICAL_SECTION lpCriticalSection, uint dwSpinCount);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetCurrentDirectory(string lpPathName);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetDefaultCommConfig(string lpszName, [In] ref COMMCONFIG lpCC, uint dwSize);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetEnvironmentVariable(string lpName, string lpValue);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern ErrorModes SetErrorMode(ErrorModes uMode);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetEvent(IntPtr hEvent);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern void SetFileApisToANSI();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern void SetFileApisToOEM();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetFileAttributes(string lpFileName, uint dwFileAttributes);
		
		//was originally unsafe
		//no safefilehandle struct
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern uint SetFilePointer([In] SafeFileHandle hFile, [In] int lDistanceToMove, [Out] int* lpDistanceToMoveHigh, [In] EMoveMethod dwMoveMethod);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetFileTime(IntPtr hFile, ref long lpCreationTime, ref long lpLastAccessTime, ref long lpLastWriteTime);
		
		//set handlecount doesn't exist on pinvoke.net
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern 
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetHandleInformation(IntPtr hObject, HANDLE_FLAGS dwMask, HANDLE_FLAGS dwFlags);
		
		//there are some extra structures that seem to relate to this
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetInformationJobObject(IntPtr hJob, JOBOBJECTINFOCLASS JobObjectInfoClass, IntPtr lpJobObjectInfo, uint cbJobObjectInfoLength);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern void SetLastError(uint dwErrCode);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetLocalTime([In] ref SYSTEMTIME lpLocalTime);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetLocaleInfo(uint Locale, uint LCType, string lpLCData);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetMailslotInfo(IntPtr hMailslot, uint lReadTimeout);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetNamedPipeHandleState(IntPtr hNamedPipe, IntPtr lpMode, IntPtr lpMaxCollectionCount, IntPtr lpCollectDataTimeout);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetPriorityClass(IntPtr handle, PriorityClass priorityClass);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetProcessAffinityMask(IntPtr hProcess, UIntPtr dwProcessAffinityMask);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetProcessPriorityBoost(IntPtr hProcess, bool DisablePriorityBoost);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetProcessShutdownParameters(uint dwLevel, uint dwFlags);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetProcessWorkingSetSize(IntPtr hProcess, UIntPtr dwMinimumWorkingSetSize, UIntPtr dwMaximumWorkingSetSize);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetStdHandle(int nStdHandle, IntPtr hHandle);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetSystemPowerState(bool fSuspend, bool fForce);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetSystemTime(ref SYSTEMTIME time);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetSystemTimeAdjustment(uint dwTimeAdjustment, bool bTimeAdjustmentDisabled);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint SetTapeParameters(IntPtr hDevice, uint dwOperation, IntPtr lpTapeInformation);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint SetTapePosition(IntPtr hDevice, ETapePositionMethod dwPositionMethod, uint dwPartition, uint dwOffsetLow, uint dwOffsetHigh, bool bImmediate);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern UIntPtr SetThreadAffinityMask(IntPtr hThread, UIntPtr dwThreadAffinityMask);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool SetThreadContext(IntPtr hThread, [In] ref CONTEXT lpContext);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern EXECUTION_STATE SetThreadExecutionState(EXECUTION_STATE esFlags);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint SetThreadIdealProcessor(IntPtr hThread, uint dwIdealProcessor);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetThreadLocale(uint Locale);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetThreadPriority(IntPtr hThread, ThreadPriority nPriority);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetThreadPriorityBoost(IntPtr hThread, bool DisablePriorityBoost);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetTimeZoneInformation([In] ref TIME_ZONE_INFORMATION lpTimeZoneInformation);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern FilterDelegate SetUnhandledExceptionFilter(FilterDelegate lpTopLevelExceptionFilter);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetVolumeLabel(string lpRootPathName, string lpVolumeName);
		
		//I mean really what the fuck is a delegate?
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool SetWaitableTimer(IntPtr hTimer, [In] ref long pDueTime, int lPeriod, TimerCompleteDelegate pfnCompletionRoutine, IntPtr lpArgToCompletionRoutine, bool fResume);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SetupComm(IntPtr hFile, uint dwInQueue, uint dwOutQueue);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint SignalObjectAndWait(IntPtr hObjectToSignal, IntPtr hObjectToWaitOn, uint dwMilliseconds, bool bAlertable);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint SizeofResource(IntPtr hModule, IntPtr hResInfo);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern void Sleep(uint dwMilliseconds);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint SleepEx(uint dwMilliseconds, bool bAlertable);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int SuspendThread(IntPtr hThread);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern void SwitchToFiber(IntPtr lpFiber);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SwitchToThread();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SystemTimeToFileTime([In] IntPtr lpSystemTime, IntPtr lpFileTime);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool SystemTimeToTzSpecificLocalTime(IntPtr lpTimeZoneInformation, [In] ref SYSTEMTIME lpUniversalTime, out SYSTEMTIME lpLocalTime);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool TerminateJobObject(IntPtr hJob, uint uExitCode);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool TerminateProcess(IntPtr hProcess, uint uExitCode);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool TerminateThread(IntPtr hThread, uint dwExitCode);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool Thread32First(IntPtr hSnapshot, ref THREADENTRY32 lpte);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool Thread32Next(IntPtr hSnapshot, out THREADENTRY32 lpte);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint TlsAlloc();
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool TlsFree(uint dwTlsIndex);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr TlsGetValue(uint dwTlsIndex);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool TlsSetValue(uint dwTlsIndex, IntPtr lpTlsValue);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool Toolhelp32ReadProcessMemory(uint th32ProcessID, IntPtr lpBaseAddress, [Out] byte [] lpBuffer, UIntPtr cbRead, IntPtr lpNumberOfBytesRead);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool TransactNamedPipe(IntPtr hNamedPipe, byte [] lpInBuffer, uint nInBufferSize, [Out] byte [] lpOutBuffer, uint nOutBufferSize, IntPtr lpBytesRead, IntPtr lpOverlapped);
	
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool TransmitCommChar(IntPtr hFile, char cChar);
		
		//still don't have the critical section struct
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool TryEnterCriticalSection(ref CRITICAL_SECTION lpCriticalSection);
		
		//need exception pointers
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern int UnhandledExceptionFilter([In] ref EXCEPTION_POINTERS ExceptionInfo);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool UnlockFile(IntPtr hFile, uint dwFileOffsetLow, uint dwFileOffsetHigh, uint nNumberOfBytesToUnlockLow, uint nNumberOfBytesToUnlockHigh);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool UnlockFileEx(IntPtr hFile, uint dwReserved, uint nNumberOfBytesToUnlockLow, uint nNumberOfBytesToUnlockHigh, [In] ref System.Threading.NativeOverlapped lpOverlapped);
	
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool UnmapViewOfFile(IntPtr lpBaseAddress);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool UpdateResource(IntPtr hUpdate, string lpType, string lpName, ushort wLanguage, IntPtr lpData, uint cbData);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint VerLanguageName(uint wLang, [Out] StringBuilder szLang, uint wSize);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern UIntPtr VirtualAlloc(UIntPtr lpAddress, UIntPtr dwSize, AllocationType flAllocationType, MemoryProtection flProtect);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern IntPtr VirtualAllocEx(IntPtr hProcess, IntPtr lpAddress, uint dwSize, AllocationType flAllocationType, MemoryProtection flProtect);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool VirtualFree(UIntPtr lpAddress, UIntPtr dwSize, uint dwFreeType);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool VirtualFreeEx(IntPtr hProcess, IntPtr lpAddress, int dwSize, FreeType dwFreeType);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool VirtualLock(IntPtr lpAddress, UIntPtr dwSize);
		
		//File Protection enum associated with this
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool VirtualProtect(IntPtr lpAddress, uint dwSize, uint flNewProtect, out uint lpflOldProtect);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool VirtualProtectEx(IntPtr hProcess, IntPtr lpAddress, UIntPtr dwSize, uint flNewProtect, out uint lpflOldProtect);
		
		//there were some other structs
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int VirtualQuery(ref UIntPtr lpAddress, ref MEMORY_BASIC_INFORMATION lpBuffer, int dwLength);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int VirtualQueryEx(IntPtr hProcess, IntPtr lpAddress, out MEMORY_BASIC_INFORMATION lpBuffer, uint dwLength);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool VirtualUnlock(IntPtr lpAddress, UIntPtr dwSize);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool WaitCommEvent(IntPtr hFile, out uint lpEvtMask, IntPtr lpOverlapped);
		
//		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
//		public static extern bool WaitForDebugEvent( [In] ref DEBUG_EVENT lpDebugEvent, uint dwMilliseconds );
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint WaitForMultipleObjects(uint nCount, IntPtr [] lpHandles, bool bWaitAll, uint dwMilliseconds);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint WaitForMultipleObjectsEx(uint nCount, IntPtr [] lpHandles, bool bWaitAll, uint dwMilliseconds, bool bAlertable);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern UInt32 WaitForSingleObject(IntPtr hHandle, UInt32 dwMilliseconds);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint WaitForSingleObjectEx(IntPtr hHandle, uint dwMilliseconds, bool bAlertable);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern bool WaitNamedPipe(string lpNamedPipeName, uint nTimeOut);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern int WideCharToMultiByte(uint CodePage, uint dwFlags, [MarshalAs(UnmanagedType.LPWStr)] string lpWideCharStr, int cchWideChar, [MarshalAs(UnmanagedType.LPArray)] Byte[] lpMultiByteStr, int cbMultiByte, IntPtr lpDefaultChar, out bool lpUsedDefaultChar);
		
		[DllImport("kernel32", CharSet = CharSet.Auto, SetLastError = true)]
		public static extern uint WinExec(string lpCmdLine, uint uCmdShow);
	
	}
} 
