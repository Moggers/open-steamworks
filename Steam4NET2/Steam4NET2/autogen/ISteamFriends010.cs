// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamFriends010VTable
	{
		public IntPtr GetPersonaName0;
		public IntPtr SetPersonaName1;
		public IntPtr GetPersonaState2;
		public IntPtr GetFriendCount3;
		public IntPtr GetFriendByIndex4;
		public IntPtr GetFriendRelationship5;
		public IntPtr GetFriendPersonaState6;
		public IntPtr GetFriendPersonaName7;
		public IntPtr GetFriendGamePlayed8;
		public IntPtr GetFriendPersonaNameHistory9;
		public IntPtr HasFriend10;
		public IntPtr GetClanCount11;
		public IntPtr GetClanByIndex12;
		public IntPtr GetClanName13;
		public IntPtr GetClanTag14;
		public IntPtr GetClanActivityCounts15;
		public IntPtr DownloadClanActivityCounts16;
		public IntPtr GetFriendCountFromSource17;
		public IntPtr GetFriendFromSourceByIndex18;
		public IntPtr IsUserInSource19;
		public IntPtr SetInGameVoiceSpeaking20;
		public IntPtr ActivateGameOverlay21;
		public IntPtr ActivateGameOverlayToUser22;
		public IntPtr ActivateGameOverlayToWebPage23;
		public IntPtr ActivateGameOverlayToStore24;
		public IntPtr SetPlayedWith25;
		public IntPtr ActivateGameOverlayInviteDialog26;
		public IntPtr GetSmallFriendAvatar27;
		public IntPtr GetMediumFriendAvatar28;
		public IntPtr GetLargeFriendAvatar29;
		public IntPtr RequestUserInformation30;
		public IntPtr RequestClanOfficerList31;
		public IntPtr GetClanOwner32;
		public IntPtr GetClanOfficerCount33;
		public IntPtr GetClanOfficerByIndex34;
		public IntPtr GetUserRestrictions35;
		public IntPtr SetRichPresence36;
		public IntPtr ClearRichPresence37;
		public IntPtr GetFriendRichPresence38;
		public IntPtr GetFriendRichPresenceKeyCount39;
		public IntPtr GetFriendRichPresenceKeyByIndex40;
		public IntPtr InviteUserToGame41;
		public IntPtr GetCoplayFriendCount42;
		public IntPtr GetCoplayFriend43;
		public IntPtr GetFriendCoplayTime44;
		public IntPtr GetFriendCoplayGame45;
		public IntPtr JoinClanChatRoom46;
		public IntPtr LeaveClanChatRoom47;
		public IntPtr GetClanChatMemberCount48;
		public IntPtr GetChatMemberByIndex49;
		public IntPtr SendClanChatMessage50;
		public IntPtr GetClanChatMessage51;
		public IntPtr IsClanChatAdmin52;
		public IntPtr IsClanChatWindowOpenInSteam53;
		public IntPtr OpenClanChatWindowInSteam54;
		public IntPtr CloseClanChatWindowInSteam55;
		public IntPtr SetListenForFriendsMessages56;
		public IntPtr ReplyToFriendMessage57;
		public IntPtr GetFriendMessage58;
		private IntPtr DTorISteamFriends01059;
	};
	
	[InteropHelp.InterfaceVersion("SteamFriends010")]
	public class ISteamFriends010 : InteropHelp.NativeWrapper<ISteamFriends010VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetPersonaName( IntPtr thisptr );
		public string GetPersonaName(  ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetPersonaName>( this.Functions.GetPersonaName0 )( this.ObjectAddress ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetPersonaNameS( IntPtr thisptr, string pchPersonaName );
		public void SetPersonaName( string pchPersonaName ) 
		{
			this.GetFunction<NativeSetPersonaNameS>( this.Functions.SetPersonaName1 )( this.ObjectAddress, pchPersonaName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EPersonaState NativeGetPersonaState( IntPtr thisptr );
		public EPersonaState GetPersonaState(  ) 
		{
			return this.GetFunction<NativeGetPersonaState>( this.Functions.GetPersonaState2 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFriendCountI( IntPtr thisptr, Int32 iFriendFlags );
		public Int32 GetFriendCount( Int32 iFriendFlags ) 
		{
			return this.GetFunction<NativeGetFriendCountI>( this.Functions.GetFriendCount3 )( this.ObjectAddress, iFriendFlags ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetFriendByIndexII( IntPtr thisptr, ref UInt64 retarg, Int32 iFriend, Int32 iFriendFlags );
		public CSteamID GetFriendByIndex( Int32 iFriend, Int32 iFriendFlags ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetFriendByIndexII>( this.Functions.GetFriendByIndex4 )( this.ObjectAddress, ref ret, iFriend, iFriendFlags ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EFriendRelationship NativeGetFriendRelationshipC( IntPtr thisptr, UInt64 steamIDFriend );
		public EFriendRelationship GetFriendRelationship( CSteamID steamIDFriend ) 
		{
			return this.GetFunction<NativeGetFriendRelationshipC>( this.Functions.GetFriendRelationship5 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EPersonaState NativeGetFriendPersonaStateC( IntPtr thisptr, UInt64 steamIDFriend );
		public EPersonaState GetFriendPersonaState( CSteamID steamIDFriend ) 
		{
			return this.GetFunction<NativeGetFriendPersonaStateC>( this.Functions.GetFriendPersonaState6 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetFriendPersonaNameC( IntPtr thisptr, UInt64 steamIDFriend );
		public string GetFriendPersonaName( CSteamID steamIDFriend ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetFriendPersonaNameC>( this.Functions.GetFriendPersonaName7 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ) ) ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetFriendGamePlayedCF( IntPtr thisptr, UInt64 steamIDFriend, ref FriendGameInfo_t pFriendGameInfo );
		public bool GetFriendGamePlayed( CSteamID steamIDFriend, ref FriendGameInfo_t pFriendGameInfo ) 
		{
			return this.GetFunction<NativeGetFriendGamePlayedCF>( this.Functions.GetFriendGamePlayed8 )( this.ObjectAddress, steamIDFriend.ConvertToUint64(), ref pFriendGameInfo ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetFriendPersonaNameHistoryCI( IntPtr thisptr, UInt64 steamIDFriend, Int32 iPersonaName );
		public string GetFriendPersonaNameHistory( CSteamID steamIDFriend, Int32 iPersonaName ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetFriendPersonaNameHistoryCI>( this.Functions.GetFriendPersonaNameHistory9 )( this.ObjectAddress, steamIDFriend.ConvertToUint64(), iPersonaName ) ) ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeHasFriendCI( IntPtr thisptr, UInt64 steamIDFriend, Int32 iFriendFlags );
		public bool HasFriend( CSteamID steamIDFriend, Int32 iFriendFlags ) 
		{
			return this.GetFunction<NativeHasFriendCI>( this.Functions.HasFriend10 )( this.ObjectAddress, steamIDFriend.ConvertToUint64(), iFriendFlags ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetClanCount( IntPtr thisptr );
		public Int32 GetClanCount(  ) 
		{
			return this.GetFunction<NativeGetClanCount>( this.Functions.GetClanCount11 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetClanByIndexI( IntPtr thisptr, ref UInt64 retarg, Int32 iClan );
		public CSteamID GetClanByIndex( Int32 iClan ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetClanByIndexI>( this.Functions.GetClanByIndex12 )( this.ObjectAddress, ref ret, iClan ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetClanNameC( IntPtr thisptr, UInt64 steamIDClan );
		public string GetClanName( CSteamID steamIDClan ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetClanNameC>( this.Functions.GetClanName13 )( this.ObjectAddress, steamIDClan.ConvertToUint64() ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetClanTagC( IntPtr thisptr, UInt64 steamIDClan );
		public string GetClanTag( CSteamID steamIDClan ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetClanTagC>( this.Functions.GetClanTag14 )( this.ObjectAddress, steamIDClan.ConvertToUint64() ) ) ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetClanActivityCountsCIII( IntPtr thisptr, UInt64 steamID, ref Int32 pnOnline, ref Int32 pnInGame, ref Int32 pnChatting );
		public bool GetClanActivityCounts( CSteamID steamID, ref Int32 pnOnline, ref Int32 pnInGame, ref Int32 pnChatting ) 
		{
			return this.GetFunction<NativeGetClanActivityCountsCIII>( this.Functions.GetClanActivityCounts15 )( this.ObjectAddress, steamID.ConvertToUint64(), ref pnOnline, ref pnInGame, ref pnChatting ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeDownloadClanActivityCountsCI( IntPtr thisptr, ref UInt64 groupIDs, Int32 nIds );
		public UInt64 DownloadClanActivityCounts( ref CSteamID groupIDs, Int32 nIds ) 
		{
			UInt64 s0 = 0; var result = this.GetFunction<NativeDownloadClanActivityCountsCI>( this.Functions.DownloadClanActivityCounts16 )( this.ObjectAddress, ref s0, nIds ); groupIDs = new CSteamID(s0); return result;
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFriendCountFromSourceC( IntPtr thisptr, UInt64 steamIDSource );
		public Int32 GetFriendCountFromSource( CSteamID steamIDSource ) 
		{
			return this.GetFunction<NativeGetFriendCountFromSourceC>( this.Functions.GetFriendCountFromSource17 )( this.ObjectAddress, steamIDSource.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetFriendFromSourceByIndexCI( IntPtr thisptr, ref UInt64 retarg, UInt64 steamIDSource, Int32 iFriend );
		public CSteamID GetFriendFromSourceByIndex( CSteamID steamIDSource, Int32 iFriend ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetFriendFromSourceByIndexCI>( this.Functions.GetFriendFromSourceByIndex18 )( this.ObjectAddress, ref ret, steamIDSource.ConvertToUint64(), iFriend ); return new CSteamID(ret);
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsUserInSourceCC( IntPtr thisptr, UInt64 steamIDUser, UInt64 steamIDSource );
		public bool IsUserInSource( CSteamID steamIDUser, CSteamID steamIDSource ) 
		{
			return this.GetFunction<NativeIsUserInSourceCC>( this.Functions.IsUserInSource19 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), steamIDSource.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetInGameVoiceSpeakingCB( IntPtr thisptr, UInt64 steamIDUser, [MarshalAs(UnmanagedType.I1)] bool bSpeaking );
		public void SetInGameVoiceSpeaking( CSteamID steamIDUser, bool bSpeaking ) 
		{
			this.GetFunction<NativeSetInGameVoiceSpeakingCB>( this.Functions.SetInGameVoiceSpeaking20 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), bSpeaking ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeActivateGameOverlayS( IntPtr thisptr, string pchDialog );
		public void ActivateGameOverlay( string pchDialog ) 
		{
			this.GetFunction<NativeActivateGameOverlayS>( this.Functions.ActivateGameOverlay21 )( this.ObjectAddress, pchDialog ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeActivateGameOverlayToUserSC( IntPtr thisptr, string pchDialog, UInt64 steamID );
		public void ActivateGameOverlayToUser( string pchDialog, CSteamID steamID ) 
		{
			this.GetFunction<NativeActivateGameOverlayToUserSC>( this.Functions.ActivateGameOverlayToUser22 )( this.ObjectAddress, pchDialog, steamID.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeActivateGameOverlayToWebPageS( IntPtr thisptr, string pchURL );
		public void ActivateGameOverlayToWebPage( string pchURL ) 
		{
			this.GetFunction<NativeActivateGameOverlayToWebPageS>( this.Functions.ActivateGameOverlayToWebPage23 )( this.ObjectAddress, pchURL ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeActivateGameOverlayToStoreU( IntPtr thisptr, UInt32 nAppID );
		public void ActivateGameOverlayToStore( UInt32 nAppID ) 
		{
			this.GetFunction<NativeActivateGameOverlayToStoreU>( this.Functions.ActivateGameOverlayToStore24 )( this.ObjectAddress, nAppID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetPlayedWithC( IntPtr thisptr, UInt64 steamIDUserPlayedWith );
		public void SetPlayedWith( CSteamID steamIDUserPlayedWith ) 
		{
			this.GetFunction<NativeSetPlayedWithC>( this.Functions.SetPlayedWith25 )( this.ObjectAddress, steamIDUserPlayedWith.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeActivateGameOverlayInviteDialogC( IntPtr thisptr, UInt64 steamIDLobby );
		public void ActivateGameOverlayInviteDialog( CSteamID steamIDLobby ) 
		{
			this.GetFunction<NativeActivateGameOverlayInviteDialogC>( this.Functions.ActivateGameOverlayInviteDialog26 )( this.ObjectAddress, steamIDLobby.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetSmallFriendAvatarC( IntPtr thisptr, UInt64 steamIDFriend );
		public Int32 GetSmallFriendAvatar( CSteamID steamIDFriend ) 
		{
			return this.GetFunction<NativeGetSmallFriendAvatarC>( this.Functions.GetSmallFriendAvatar27 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetMediumFriendAvatarC( IntPtr thisptr, UInt64 steamIDFriend );
		public Int32 GetMediumFriendAvatar( CSteamID steamIDFriend ) 
		{
			return this.GetFunction<NativeGetMediumFriendAvatarC>( this.Functions.GetMediumFriendAvatar28 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetLargeFriendAvatarC( IntPtr thisptr, UInt64 steamIDFriend );
		public Int32 GetLargeFriendAvatar( CSteamID steamIDFriend ) 
		{
			return this.GetFunction<NativeGetLargeFriendAvatarC>( this.Functions.GetLargeFriendAvatar29 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRequestUserInformationCB( IntPtr thisptr, UInt64 steamIDUser, [MarshalAs(UnmanagedType.I1)] bool bRequireNameOnly );
		public bool RequestUserInformation( CSteamID steamIDUser, bool bRequireNameOnly ) 
		{
			return this.GetFunction<NativeRequestUserInformationCB>( this.Functions.RequestUserInformation30 )( this.ObjectAddress, steamIDUser.ConvertToUint64(), bRequireNameOnly ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeRequestClanOfficerListC( IntPtr thisptr, UInt64 steamIDClan );
		public UInt64 RequestClanOfficerList( CSteamID steamIDClan ) 
		{
			return this.GetFunction<NativeRequestClanOfficerListC>( this.Functions.RequestClanOfficerList31 )( this.ObjectAddress, steamIDClan.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetClanOwnerC( IntPtr thisptr, ref UInt64 retarg, UInt64 steamIDClan );
		public CSteamID GetClanOwner( CSteamID steamIDClan ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetClanOwnerC>( this.Functions.GetClanOwner32 )( this.ObjectAddress, ref ret, steamIDClan.ConvertToUint64() ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetClanOfficerCountC( IntPtr thisptr, UInt64 steamIDClan );
		public Int32 GetClanOfficerCount( CSteamID steamIDClan ) 
		{
			return this.GetFunction<NativeGetClanOfficerCountC>( this.Functions.GetClanOfficerCount33 )( this.ObjectAddress, steamIDClan.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetClanOfficerByIndexCI( IntPtr thisptr, ref UInt64 retarg, UInt64 steamIDClan, Int32 iOfficer );
		public CSteamID GetClanOfficerByIndex( CSteamID steamIDClan, Int32 iOfficer ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetClanOfficerByIndexCI>( this.Functions.GetClanOfficerByIndex34 )( this.ObjectAddress, ref ret, steamIDClan.ConvertToUint64(), iOfficer ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EUserRestriction NativeGetUserRestrictions( IntPtr thisptr );
		public EUserRestriction GetUserRestrictions(  ) 
		{
			return this.GetFunction<NativeGetUserRestrictions>( this.Functions.GetUserRestrictions35 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetRichPresenceSS( IntPtr thisptr, string pchKey, string pchValue );
		public bool SetRichPresence( string pchKey, string pchValue ) 
		{
			return this.GetFunction<NativeSetRichPresenceSS>( this.Functions.SetRichPresence36 )( this.ObjectAddress, pchKey, pchValue ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeClearRichPresence( IntPtr thisptr );
		public void ClearRichPresence(  ) 
		{
			this.GetFunction<NativeClearRichPresence>( this.Functions.ClearRichPresence37 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetFriendRichPresenceCS( IntPtr thisptr, UInt64 steamIDFriend, string pchKey );
		public string GetFriendRichPresence( CSteamID steamIDFriend, string pchKey ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetFriendRichPresenceCS>( this.Functions.GetFriendRichPresence38 )( this.ObjectAddress, steamIDFriend.ConvertToUint64(), pchKey ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFriendRichPresenceKeyCountC( IntPtr thisptr, UInt64 steamIDFriend );
		public Int32 GetFriendRichPresenceKeyCount( CSteamID steamIDFriend ) 
		{
			return this.GetFunction<NativeGetFriendRichPresenceKeyCountC>( this.Functions.GetFriendRichPresenceKeyCount39 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetFriendRichPresenceKeyByIndexCI( IntPtr thisptr, UInt64 steamIDFriend, Int32 iKey );
		public string GetFriendRichPresenceKeyByIndex( CSteamID steamIDFriend, Int32 iKey ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetFriendRichPresenceKeyByIndexCI>( this.Functions.GetFriendRichPresenceKeyByIndex40 )( this.ObjectAddress, steamIDFriend.ConvertToUint64(), iKey ) ) ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeInviteUserToGameCS( IntPtr thisptr, UInt64 steamIDFriend, string pchConnectString );
		public bool InviteUserToGame( CSteamID steamIDFriend, string pchConnectString ) 
		{
			return this.GetFunction<NativeInviteUserToGameCS>( this.Functions.InviteUserToGame41 )( this.ObjectAddress, steamIDFriend.ConvertToUint64(), pchConnectString ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetCoplayFriendCount( IntPtr thisptr );
		public Int32 GetCoplayFriendCount(  ) 
		{
			return this.GetFunction<NativeGetCoplayFriendCount>( this.Functions.GetCoplayFriendCount42 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetCoplayFriendI( IntPtr thisptr, ref UInt64 retarg, Int32 iCoplayFriend );
		public CSteamID GetCoplayFriend( Int32 iCoplayFriend ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetCoplayFriendI>( this.Functions.GetCoplayFriend43 )( this.ObjectAddress, ref ret, iCoplayFriend ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFriendCoplayTimeC( IntPtr thisptr, UInt64 steamIDFriend );
		public Int32 GetFriendCoplayTime( CSteamID steamIDFriend ) 
		{
			return this.GetFunction<NativeGetFriendCoplayTimeC>( this.Functions.GetFriendCoplayTime44 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetFriendCoplayGameC( IntPtr thisptr, UInt64 steamIDFriend );
		public UInt32 GetFriendCoplayGame( CSteamID steamIDFriend ) 
		{
			return this.GetFunction<NativeGetFriendCoplayGameC>( this.Functions.GetFriendCoplayGame45 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeJoinClanChatRoomC( IntPtr thisptr, UInt64 groupID );
		public UInt64 JoinClanChatRoom( CSteamID groupID ) 
		{
			return this.GetFunction<NativeJoinClanChatRoomC>( this.Functions.JoinClanChatRoom46 )( this.ObjectAddress, groupID.ConvertToUint64() ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeLeaveClanChatRoomC( IntPtr thisptr, UInt64 groupID );
		public bool LeaveClanChatRoom( CSteamID groupID ) 
		{
			return this.GetFunction<NativeLeaveClanChatRoomC>( this.Functions.LeaveClanChatRoom47 )( this.ObjectAddress, groupID.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetClanChatMemberCountC( IntPtr thisptr, UInt64 groupID );
		public Int32 GetClanChatMemberCount( CSteamID groupID ) 
		{
			return this.GetFunction<NativeGetClanChatMemberCountC>( this.Functions.GetClanChatMemberCount48 )( this.ObjectAddress, groupID.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetChatMemberByIndexCI( IntPtr thisptr, ref UInt64 retarg, UInt64 groupID, Int32 iIndex );
		public CSteamID GetChatMemberByIndex( CSteamID groupID, Int32 iIndex ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetChatMemberByIndexCI>( this.Functions.GetChatMemberByIndex49 )( this.ObjectAddress, ref ret, groupID.ConvertToUint64(), iIndex ); return new CSteamID(ret);
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSendClanChatMessageCS( IntPtr thisptr, UInt64 groupID, string cszMessage );
		public bool SendClanChatMessage( CSteamID groupID, string cszMessage ) 
		{
			return this.GetFunction<NativeSendClanChatMessageCS>( this.Functions.SendClanChatMessage50 )( this.ObjectAddress, groupID.ConvertToUint64(), cszMessage ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetClanChatMessageCIBIEC( IntPtr thisptr, UInt64 groupID, Int32 iChatID, Byte[] pvData, Int32 cubData, ref EChatEntryType peChatEntryType, ref UInt64 pSteamIDChatter );
		public Int32 GetClanChatMessage( CSteamID groupID, Int32 iChatID, Byte[] pvData, ref EChatEntryType peChatEntryType, ref CSteamID pSteamIDChatter ) 
		{
			UInt64 s0 = 0; var result = this.GetFunction<NativeGetClanChatMessageCIBIEC>( this.Functions.GetClanChatMessage51 )( this.ObjectAddress, groupID.ConvertToUint64(), iChatID, pvData, (Int32) pvData.Length, ref peChatEntryType, ref s0 ); pSteamIDChatter = new CSteamID(s0); return result;
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsClanChatAdminCC( IntPtr thisptr, UInt64 groupID, UInt64 userID );
		public bool IsClanChatAdmin( CSteamID groupID, CSteamID userID ) 
		{
			return this.GetFunction<NativeIsClanChatAdminCC>( this.Functions.IsClanChatAdmin52 )( this.ObjectAddress, groupID.ConvertToUint64(), userID.ConvertToUint64() ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsClanChatWindowOpenInSteamC( IntPtr thisptr, UInt64 groupID );
		public bool IsClanChatWindowOpenInSteam( CSteamID groupID ) 
		{
			return this.GetFunction<NativeIsClanChatWindowOpenInSteamC>( this.Functions.IsClanChatWindowOpenInSteam53 )( this.ObjectAddress, groupID.ConvertToUint64() ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeOpenClanChatWindowInSteamC( IntPtr thisptr, UInt64 groupID );
		public bool OpenClanChatWindowInSteam( CSteamID groupID ) 
		{
			return this.GetFunction<NativeOpenClanChatWindowInSteamC>( this.Functions.OpenClanChatWindowInSteam54 )( this.ObjectAddress, groupID.ConvertToUint64() ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeCloseClanChatWindowInSteamC( IntPtr thisptr, UInt64 groupID );
		public bool CloseClanChatWindowInSteam( CSteamID groupID ) 
		{
			return this.GetFunction<NativeCloseClanChatWindowInSteamC>( this.Functions.CloseClanChatWindowInSteam55 )( this.ObjectAddress, groupID.ConvertToUint64() ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetListenForFriendsMessagesB( IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bListen );
		public bool SetListenForFriendsMessages( bool bListen ) 
		{
			return this.GetFunction<NativeSetListenForFriendsMessagesB>( this.Functions.SetListenForFriendsMessages56 )( this.ObjectAddress, bListen ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeReplyToFriendMessageCS( IntPtr thisptr, UInt64 friendID, string cszMessage );
		public bool ReplyToFriendMessage( CSteamID friendID, string cszMessage ) 
		{
			return this.GetFunction<NativeReplyToFriendMessageCS>( this.Functions.ReplyToFriendMessage57 )( this.ObjectAddress, friendID.ConvertToUint64(), cszMessage ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFriendMessageCIBIE( IntPtr thisptr, UInt64 friendID, Int32 iChatID, Byte[] pvData, Int32 cubData, ref EChatEntryType peChatEntryType );
		public Int32 GetFriendMessage( CSteamID friendID, Int32 iChatID, Byte[] pvData, ref EChatEntryType peChatEntryType ) 
		{
			return this.GetFunction<NativeGetFriendMessageCIBIE>( this.Functions.GetFriendMessage58 )( this.ObjectAddress, friendID.ConvertToUint64(), iChatID, pvData, (Int32) pvData.Length, ref peChatEntryType ); 
		}
		
	};
}
