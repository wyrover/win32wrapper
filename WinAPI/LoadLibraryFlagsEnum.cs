/*
 * Created by SharpDevelop.
 * User: Taben Malik
 * Date: 1/22/2015
 * Time: 2:57 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

namespace Win32Wrapper
{
	[System.Flags]
	enum LoadLibraryFlags : uint
	{     
	     DONT_RESOLVE_DLL_REFERENCES = 0x00000001,
	     LOAD_IGNORE_CODE_AUTHZ_LEVEL = 0x00000010,
	     LOAD_LIBRARY_AS_DATAFILE = 0x00000002,
	     LOAD_LIBRARY_AS_DATAFILE_EXCLUSIVE = 0x00000040,
	     LOAD_LIBRARY_AS_IMAGE_RESOURCE = 0x00000020,
	     LOAD_WITH_ALTERED_SEARCH_PATH = 0x00000008
	}
}