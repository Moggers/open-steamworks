// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamRemoteStorage007VTable
	{
		public IntPtr FileWrite0;
		public IntPtr FileRead1;
		public IntPtr FileForget2;
		public IntPtr FileDelete3;
		public IntPtr FileShare4;
		public IntPtr SetSyncPlatforms5;
		public IntPtr FileExists6;
		public IntPtr FilePersisted7;
		public IntPtr GetFileSize8;
		public IntPtr GetFileTimestamp9;
		public IntPtr GetSyncPlatforms10;
		public IntPtr GetFileCount11;
		public IntPtr GetFileNameAndSize12;
		public IntPtr GetQuota13;
		public IntPtr IsCloudEnabledForAccount14;
		public IntPtr IsCloudEnabledForApp15;
		public IntPtr SetCloudEnabledForApp16;
		public IntPtr UGCDownload17;
		public IntPtr GetUGCDownloadProgress18;
		public IntPtr GetUGCDetails19;
		public IntPtr UGCRead20;
		public IntPtr GetCachedUGCCount21;
		public IntPtr GetCachedUGCHandle22;
		public IntPtr PublishWorkshopFile23;
		public IntPtr CreatePublishedFileUpdateRequest24;
		public IntPtr UpdatePublishedFileFile25;
		public IntPtr UpdatePublishedFilePreviewFile26;
		public IntPtr UpdatePublishedFileTitle27;
		public IntPtr UpdatePublishedFileDescription28;
		public IntPtr UpdatePublishedFileVisibility29;
		public IntPtr UpdatePublishedFileTags30;
		public IntPtr CommitPublishedFileUpdate31;
		public IntPtr GetPublishedFileDetails32;
		public IntPtr DeletePublishedFile33;
		public IntPtr EnumerateUserPublishedFiles34;
		public IntPtr SubscribePublishedFile35;
		public IntPtr EnumerateUserSubscribedFiles36;
		public IntPtr UnsubscribePublishedFile37;
		public IntPtr UpdatePublishedFileSetChangeDescription38;
		public IntPtr GetPublishedItemVoteDetails39;
		public IntPtr UpdateUserPublishedItemVote40;
		public IntPtr GetUserPublishedItemVoteDetails41;
		public IntPtr EnumerateUserSharedWorkshopFiles42;
		public IntPtr PublishVideo43;
		public IntPtr SetUserPublishedFileAction44;
		public IntPtr EnumeratePublishedFilesByUserAction45;
		public IntPtr EnumeratePublishedWorkshopFiles46;
		private IntPtr DTorISteamRemoteStorage00747;
	};
	
	[InteropHelp.InterfaceVersion("STEAMREMOTESTORAGE_INTERFACE_VERSION007")]
	public class ISteamRemoteStorage007 : InteropHelp.NativeWrapper<ISteamRemoteStorage007VTable>
	{
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFileWriteSBI( IntPtr thisptr, string pchFile, Byte[] pvData, Int32 cubData );
		public bool FileWrite( string pchFile, Byte[] pvData ) 
		{
			return this.GetFunction<NativeFileWriteSBI>( this.Functions.FileWrite0 )( this.ObjectAddress, pchFile, pvData, (Int32) pvData.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeFileReadSBI( IntPtr thisptr, string pchFile, Byte[] pvData, Int32 cubDataToRead );
		public Int32 FileRead( string pchFile, Byte[] pvData ) 
		{
			return this.GetFunction<NativeFileReadSBI>( this.Functions.FileRead1 )( this.ObjectAddress, pchFile, pvData, (Int32) pvData.Length ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFileForgetS( IntPtr thisptr, string pchFile );
		public bool FileForget( string pchFile ) 
		{
			return this.GetFunction<NativeFileForgetS>( this.Functions.FileForget2 )( this.ObjectAddress, pchFile ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFileDeleteS( IntPtr thisptr, string pchFile );
		public bool FileDelete( string pchFile ) 
		{
			return this.GetFunction<NativeFileDeleteS>( this.Functions.FileDelete3 )( this.ObjectAddress, pchFile ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeFileShareS( IntPtr thisptr, string pchFile );
		public UInt64 FileShare( string pchFile ) 
		{
			return this.GetFunction<NativeFileShareS>( this.Functions.FileShare4 )( this.ObjectAddress, pchFile ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetSyncPlatformsSE( IntPtr thisptr, string pchFile, ERemoteStoragePlatform eRemoteStoragePlatform );
		public bool SetSyncPlatforms( string pchFile, ERemoteStoragePlatform eRemoteStoragePlatform ) 
		{
			return this.GetFunction<NativeSetSyncPlatformsSE>( this.Functions.SetSyncPlatforms5 )( this.ObjectAddress, pchFile, eRemoteStoragePlatform ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFileExistsS( IntPtr thisptr, string pchFile );
		public bool FileExists( string pchFile ) 
		{
			return this.GetFunction<NativeFileExistsS>( this.Functions.FileExists6 )( this.ObjectAddress, pchFile ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFilePersistedS( IntPtr thisptr, string pchFile );
		public bool FilePersisted( string pchFile ) 
		{
			return this.GetFunction<NativeFilePersistedS>( this.Functions.FilePersisted7 )( this.ObjectAddress, pchFile ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFileSizeS( IntPtr thisptr, string pchFile );
		public Int32 GetFileSize( string pchFile ) 
		{
			return this.GetFunction<NativeGetFileSizeS>( this.Functions.GetFileSize8 )( this.ObjectAddress, pchFile ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int64 NativeGetFileTimestampS( IntPtr thisptr, string pchFile );
		public Int64 GetFileTimestamp( string pchFile ) 
		{
			return this.GetFunction<NativeGetFileTimestampS>( this.Functions.GetFileTimestamp9 )( this.ObjectAddress, pchFile ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate ERemoteStoragePlatform NativeGetSyncPlatformsS( IntPtr thisptr, string pchFile );
		public ERemoteStoragePlatform GetSyncPlatforms( string pchFile ) 
		{
			return this.GetFunction<NativeGetSyncPlatformsS>( this.Functions.GetSyncPlatforms10 )( this.ObjectAddress, pchFile ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFileCount( IntPtr thisptr );
		public Int32 GetFileCount(  ) 
		{
			return this.GetFunction<NativeGetFileCount>( this.Functions.GetFileCount11 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetFileNameAndSizeII( IntPtr thisptr, Int32 iFile, ref Int32 pnFileSizeInBytes );
		public string GetFileNameAndSize( Int32 iFile, ref Int32 pnFileSizeInBytes ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetFileNameAndSizeII>( this.Functions.GetFileNameAndSize12 )( this.ObjectAddress, iFile, ref pnFileSizeInBytes ) ) ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetQuotaII( IntPtr thisptr, ref Int32 pnTotalBytes, ref Int32 puAvailableBytes );
		public bool GetQuota( ref Int32 pnTotalBytes, ref Int32 puAvailableBytes ) 
		{
			return this.GetFunction<NativeGetQuotaII>( this.Functions.GetQuota13 )( this.ObjectAddress, ref pnTotalBytes, ref puAvailableBytes ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsCloudEnabledForAccount( IntPtr thisptr );
		public bool IsCloudEnabledForAccount(  ) 
		{
			return this.GetFunction<NativeIsCloudEnabledForAccount>( this.Functions.IsCloudEnabledForAccount14 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsCloudEnabledForApp( IntPtr thisptr );
		public bool IsCloudEnabledForApp(  ) 
		{
			return this.GetFunction<NativeIsCloudEnabledForApp>( this.Functions.IsCloudEnabledForApp15 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetCloudEnabledForAppB( IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bEnabled );
		public void SetCloudEnabledForApp( bool bEnabled ) 
		{
			this.GetFunction<NativeSetCloudEnabledForAppB>( this.Functions.SetCloudEnabledForApp16 )( this.ObjectAddress, bEnabled ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeUGCDownloadU( IntPtr thisptr, UInt64 hContent );
		public UInt64 UGCDownload( UInt64 hContent ) 
		{
			return this.GetFunction<NativeUGCDownloadU>( this.Functions.UGCDownload17 )( this.ObjectAddress, hContent ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUGCDownloadProgressUUU( IntPtr thisptr, UInt64 hContent, ref UInt32 puDownloadedBytes, ref UInt32 puTotalBytes );
		public bool GetUGCDownloadProgress( UInt64 hContent, ref UInt32 puDownloadedBytes, ref UInt32 puTotalBytes ) 
		{
			return this.GetFunction<NativeGetUGCDownloadProgressUUU>( this.Functions.GetUGCDownloadProgress18 )( this.ObjectAddress, hContent, ref puDownloadedBytes, ref puTotalBytes ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetUGCDetailsUUSIC( IntPtr thisptr, UInt64 hContent, ref UInt32 pnAppID, StringBuilder ppchName, ref Int32 pnFileSizeInBytes, ref UInt64 pSteamIDOwner );
		public bool GetUGCDetails( UInt64 hContent, ref UInt32 pnAppID, StringBuilder ppchName, ref Int32 pnFileSizeInBytes, ref CSteamID pSteamIDOwner ) 
		{
			UInt64 s0 = 0; var result = this.GetFunction<NativeGetUGCDetailsUUSIC>( this.Functions.GetUGCDetails19 )( this.ObjectAddress, hContent, ref pnAppID, ppchName, ref pnFileSizeInBytes, ref s0 ); pSteamIDOwner = new CSteamID(s0); return result;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeUGCReadUBI( IntPtr thisptr, UInt64 hContent, Byte[] pvData, Int32 cubDataToRead );
		public Int32 UGCRead( UInt64 hContent, Byte[] pvData ) 
		{
			return this.GetFunction<NativeUGCReadUBI>( this.Functions.UGCRead20 )( this.ObjectAddress, hContent, pvData, (Int32) pvData.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetCachedUGCCount( IntPtr thisptr );
		public Int32 GetCachedUGCCount(  ) 
		{
			return this.GetFunction<NativeGetCachedUGCCount>( this.Functions.GetCachedUGCCount21 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetCachedUGCHandleI( IntPtr thisptr, Int32 iCachedContent );
		public UInt64 GetCachedUGCHandle( Int32 iCachedContent ) 
		{
			return this.GetFunction<NativeGetCachedUGCHandleI>( this.Functions.GetCachedUGCHandle22 )( this.ObjectAddress, iCachedContent ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativePublishWorkshopFileSSUSSESE( IntPtr thisptr, string pchFile, string pchPreviewFile, UInt32 nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, ref SteamParamStringArray_t pTags, EWorkshopFileType eWorkshopFileType );
		public UInt64 PublishWorkshopFile( string pchFile, string pchPreviewFile, UInt32 nConsumerAppId, string pchTitle, string pchDescription, ERemoteStoragePublishedFileVisibility eVisibility, ref SteamParamStringArray_t pTags, EWorkshopFileType eWorkshopFileType ) 
		{
			return this.GetFunction<NativePublishWorkshopFileSSUSSESE>( this.Functions.PublishWorkshopFile23 )( this.ObjectAddress, pchFile, pchPreviewFile, nConsumerAppId, pchTitle, pchDescription, eVisibility, ref pTags, eWorkshopFileType ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeCreatePublishedFileUpdateRequestU( IntPtr thisptr, UInt64 unPublishedFileId );
		public UInt64 CreatePublishedFileUpdateRequest( UInt64 unPublishedFileId ) 
		{
			return this.GetFunction<NativeCreatePublishedFileUpdateRequestU>( this.Functions.CreatePublishedFileUpdateRequest24 )( this.ObjectAddress, unPublishedFileId ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdatePublishedFileFileUS( IntPtr thisptr, UInt64 hUpdateRequest, string pchFile );
		public bool UpdatePublishedFileFile( UInt64 hUpdateRequest, string pchFile ) 
		{
			return this.GetFunction<NativeUpdatePublishedFileFileUS>( this.Functions.UpdatePublishedFileFile25 )( this.ObjectAddress, hUpdateRequest, pchFile ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdatePublishedFilePreviewFileUS( IntPtr thisptr, UInt64 hUpdateRequest, string pchPreviewFile );
		public bool UpdatePublishedFilePreviewFile( UInt64 hUpdateRequest, string pchPreviewFile ) 
		{
			return this.GetFunction<NativeUpdatePublishedFilePreviewFileUS>( this.Functions.UpdatePublishedFilePreviewFile26 )( this.ObjectAddress, hUpdateRequest, pchPreviewFile ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdatePublishedFileTitleUS( IntPtr thisptr, UInt64 hUpdateRequest, string pchTitle );
		public bool UpdatePublishedFileTitle( UInt64 hUpdateRequest, string pchTitle ) 
		{
			return this.GetFunction<NativeUpdatePublishedFileTitleUS>( this.Functions.UpdatePublishedFileTitle27 )( this.ObjectAddress, hUpdateRequest, pchTitle ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdatePublishedFileDescriptionUS( IntPtr thisptr, UInt64 hUpdateRequest, string pchDescription );
		public bool UpdatePublishedFileDescription( UInt64 hUpdateRequest, string pchDescription ) 
		{
			return this.GetFunction<NativeUpdatePublishedFileDescriptionUS>( this.Functions.UpdatePublishedFileDescription28 )( this.ObjectAddress, hUpdateRequest, pchDescription ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdatePublishedFileVisibilityUE( IntPtr thisptr, UInt64 hUpdateRequest, ERemoteStoragePublishedFileVisibility eVisibility );
		public bool UpdatePublishedFileVisibility( UInt64 hUpdateRequest, ERemoteStoragePublishedFileVisibility eVisibility ) 
		{
			return this.GetFunction<NativeUpdatePublishedFileVisibilityUE>( this.Functions.UpdatePublishedFileVisibility29 )( this.ObjectAddress, hUpdateRequest, eVisibility ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdatePublishedFileTagsUS( IntPtr thisptr, UInt64 hUpdateRequest, ref SteamParamStringArray_t pTags );
		public bool UpdatePublishedFileTags( UInt64 hUpdateRequest, ref SteamParamStringArray_t pTags ) 
		{
			return this.GetFunction<NativeUpdatePublishedFileTagsUS>( this.Functions.UpdatePublishedFileTags30 )( this.ObjectAddress, hUpdateRequest, ref pTags ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeCommitPublishedFileUpdateU( IntPtr thisptr, UInt64 hUpdateRequest );
		public UInt64 CommitPublishedFileUpdate( UInt64 hUpdateRequest ) 
		{
			return this.GetFunction<NativeCommitPublishedFileUpdateU>( this.Functions.CommitPublishedFileUpdate31 )( this.ObjectAddress, hUpdateRequest ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetPublishedFileDetailsU( IntPtr thisptr, UInt64 unPublishedFileId );
		public UInt64 GetPublishedFileDetails( UInt64 unPublishedFileId ) 
		{
			return this.GetFunction<NativeGetPublishedFileDetailsU>( this.Functions.GetPublishedFileDetails32 )( this.ObjectAddress, unPublishedFileId ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeDeletePublishedFileU( IntPtr thisptr, UInt64 unPublishedFileId );
		public UInt64 DeletePublishedFile( UInt64 unPublishedFileId ) 
		{
			return this.GetFunction<NativeDeletePublishedFileU>( this.Functions.DeletePublishedFile33 )( this.ObjectAddress, unPublishedFileId ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeEnumerateUserPublishedFilesU( IntPtr thisptr, UInt32 uStartIndex );
		public UInt64 EnumerateUserPublishedFiles( UInt32 uStartIndex ) 
		{
			return this.GetFunction<NativeEnumerateUserPublishedFilesU>( this.Functions.EnumerateUserPublishedFiles34 )( this.ObjectAddress, uStartIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeSubscribePublishedFileU( IntPtr thisptr, UInt64 unPublishedFileId );
		public UInt64 SubscribePublishedFile( UInt64 unPublishedFileId ) 
		{
			return this.GetFunction<NativeSubscribePublishedFileU>( this.Functions.SubscribePublishedFile35 )( this.ObjectAddress, unPublishedFileId ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeEnumerateUserSubscribedFilesU( IntPtr thisptr, UInt32 uStartIndex );
		public UInt64 EnumerateUserSubscribedFiles( UInt32 uStartIndex ) 
		{
			return this.GetFunction<NativeEnumerateUserSubscribedFilesU>( this.Functions.EnumerateUserSubscribedFiles36 )( this.ObjectAddress, uStartIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeUnsubscribePublishedFileU( IntPtr thisptr, UInt64 unPublishedFileId );
		public UInt64 UnsubscribePublishedFile( UInt64 unPublishedFileId ) 
		{
			return this.GetFunction<NativeUnsubscribePublishedFileU>( this.Functions.UnsubscribePublishedFile37 )( this.ObjectAddress, unPublishedFileId ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdatePublishedFileSetChangeDescriptionUS( IntPtr thisptr, UInt64 hUpdateRequest, string cszDescription );
		public bool UpdatePublishedFileSetChangeDescription( UInt64 hUpdateRequest, string cszDescription ) 
		{
			return this.GetFunction<NativeUpdatePublishedFileSetChangeDescriptionUS>( this.Functions.UpdatePublishedFileSetChangeDescription38 )( this.ObjectAddress, hUpdateRequest, cszDescription ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetPublishedItemVoteDetailsU( IntPtr thisptr, UInt64 unPublishedFileId );
		public UInt64 GetPublishedItemVoteDetails( UInt64 unPublishedFileId ) 
		{
			return this.GetFunction<NativeGetPublishedItemVoteDetailsU>( this.Functions.GetPublishedItemVoteDetails39 )( this.ObjectAddress, unPublishedFileId ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeUpdateUserPublishedItemVoteUB( IntPtr thisptr, UInt64 unPublishedFileId, [MarshalAs(UnmanagedType.I1)] bool bVoteUp );
		public UInt64 UpdateUserPublishedItemVote( UInt64 unPublishedFileId, bool bVoteUp ) 
		{
			return this.GetFunction<NativeUpdateUserPublishedItemVoteUB>( this.Functions.UpdateUserPublishedItemVote40 )( this.ObjectAddress, unPublishedFileId, bVoteUp ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetUserPublishedItemVoteDetailsU( IntPtr thisptr, UInt64 unPublishedFileId );
		public UInt64 GetUserPublishedItemVoteDetails( UInt64 unPublishedFileId ) 
		{
			return this.GetFunction<NativeGetUserPublishedItemVoteDetailsU>( this.Functions.GetUserPublishedItemVoteDetails41 )( this.ObjectAddress, unPublishedFileId ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeEnumerateUserSharedWorkshopFilesUCUSS( IntPtr thisptr, UInt32 nAppId, UInt64 creatorSteamID, UInt32 uStartIndex, ref SteamParamStringArray_t pRequiredTags, ref SteamParamStringArray_t pExcludedTags );
		public UInt64 EnumerateUserSharedWorkshopFiles( UInt32 nAppId, CSteamID creatorSteamID, UInt32 uStartIndex, ref SteamParamStringArray_t pRequiredTags, ref SteamParamStringArray_t pExcludedTags ) 
		{
			return this.GetFunction<NativeEnumerateUserSharedWorkshopFilesUCUSS>( this.Functions.EnumerateUserSharedWorkshopFiles42 )( this.ObjectAddress, nAppId, creatorSteamID.ConvertToUint64(), uStartIndex, ref pRequiredTags, ref pExcludedTags ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativePublishVideoESSSUSSES( IntPtr thisptr, EWorkshopVideoProvider eVideoProvider, string cszVideoAccountName, string cszVideoIdentifier, string cszFileName, UInt32 nConsumerAppId, string cszTitle, string cszDescription, ERemoteStoragePublishedFileVisibility eVisibility, ref SteamParamStringArray_t pTags );
		public UInt64 PublishVideo( EWorkshopVideoProvider eVideoProvider, string cszVideoAccountName, string cszVideoIdentifier, string cszFileName, UInt32 nConsumerAppId, string cszTitle, string cszDescription, ERemoteStoragePublishedFileVisibility eVisibility, ref SteamParamStringArray_t pTags ) 
		{
			return this.GetFunction<NativePublishVideoESSSUSSES>( this.Functions.PublishVideo43 )( this.ObjectAddress, eVideoProvider, cszVideoAccountName, cszVideoIdentifier, cszFileName, nConsumerAppId, cszTitle, cszDescription, eVisibility, ref pTags ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeSetUserPublishedFileActionUE( IntPtr thisptr, UInt64 unPublishedFileId, EWorkshopFileAction eAction );
		public UInt64 SetUserPublishedFileAction( UInt64 unPublishedFileId, EWorkshopFileAction eAction ) 
		{
			return this.GetFunction<NativeSetUserPublishedFileActionUE>( this.Functions.SetUserPublishedFileAction44 )( this.ObjectAddress, unPublishedFileId, eAction ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeEnumeratePublishedFilesByUserActionEU( IntPtr thisptr, EWorkshopFileAction eAction, UInt32 uStartIndex );
		public UInt64 EnumeratePublishedFilesByUserAction( EWorkshopFileAction eAction, UInt32 uStartIndex ) 
		{
			return this.GetFunction<NativeEnumeratePublishedFilesByUserActionEU>( this.Functions.EnumeratePublishedFilesByUserAction45 )( this.ObjectAddress, eAction, uStartIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeEnumeratePublishedWorkshopFilesEUUUSS( IntPtr thisptr, EWorkshopEnumerationType eType, UInt32 uStartIndex, UInt32 cDays, UInt32 cCount, ref SteamParamStringArray_t pTags, ref SteamParamStringArray_t pUserTags );
		public UInt64 EnumeratePublishedWorkshopFiles( EWorkshopEnumerationType eType, UInt32 uStartIndex, UInt32 cDays, UInt32 cCount, ref SteamParamStringArray_t pTags, ref SteamParamStringArray_t pUserTags ) 
		{
			return this.GetFunction<NativeEnumeratePublishedWorkshopFilesEUUUSS>( this.Functions.EnumeratePublishedWorkshopFiles46 )( this.ObjectAddress, eType, uStartIndex, cDays, cCount, ref pTags, ref pUserTags ); 
		}
		
	};
}
