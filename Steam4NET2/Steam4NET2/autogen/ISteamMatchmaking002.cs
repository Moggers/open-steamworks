// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamMatchmaking002VTable
	{
		public IntPtr GetFavoriteGameCount0;
		public IntPtr GetFavoriteGame1;
		public IntPtr AddFavoriteGame2;
		public IntPtr RemoveFavoriteGame3;
		public IntPtr RequestLobbyList4;
		public IntPtr GetLobbyByIndex5;
		public IntPtr CreateLobby6;
		public IntPtr JoinLobby7;
		public IntPtr LeaveLobby8;
		public IntPtr InviteUserToLobby9;
		public IntPtr GetNumLobbyMembers10;
		public IntPtr GetLobbyMemberByIndex11;
		public IntPtr GetLobbyData12;
		public IntPtr SetLobbyData13;
		public IntPtr GetLobbyMemberData14;
		public IntPtr SetLobbyMemberData15;
		public IntPtr SendLobbyChatMsg16;
		public IntPtr GetLobbyChatEntry17;
		public IntPtr RequestLobbyData18;
		public IntPtr SetLobbyGameServer19;
		private IntPtr DTorISteamMatchmaking00220;
	};
	
	[InteropHelp.InterfaceVersion("SteamMatchMaking002")]
	public class ISteamMatchmaking002 : InteropHelp.NativeWrapper<ISteamMatchmaking002VTable>
	{
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFavoriteGameCount( IntPtr thisptr );
		public Int32 GetFavoriteGameCount(  ) 
		{
			return this.GetFunction<NativeGetFavoriteGameCount>( this.Functions.GetFavoriteGameCount0 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetFavoriteGameIUUUUUU( IntPtr thisptr, Int32 iGame, ref UInt32 pnAppID, ref UInt32 pnIP, ref UInt16 pnConnPort, ref UInt16 pnQueryPort, ref UInt32 punFlags, ref UInt32 pRTime32LastPlayedOnServer );
		public bool GetFavoriteGame( Int32 iGame, ref UInt32 pnAppID, ref UInt32 pnIP, ref UInt16 pnConnPort, ref UInt16 pnQueryPort, ref UInt32 punFlags, ref UInt32 pRTime32LastPlayedOnServer ) 
		{
			return this.GetFunction<NativeGetFavoriteGameIUUUUUU>( this.Functions.GetFavoriteGame1 )( this.ObjectAddress, iGame, ref pnAppID, ref pnIP, ref pnConnPort, ref pnQueryPort, ref punFlags, ref pRTime32LastPlayedOnServer ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeAddFavoriteGameUUUUUU( IntPtr thisptr, UInt32 nAppID, UInt32 nIP, UInt16 nConnPort, UInt16 nQueryPort, UInt32 unFlags, UInt32 rTime32LastPlayedOnServer );
		public Int32 AddFavoriteGame( UInt32 nAppID, UInt32 nIP, UInt16 nConnPort, UInt16 nQueryPort, UInt32 unFlags, UInt32 rTime32LastPlayedOnServer ) 
		{
			return this.GetFunction<NativeAddFavoriteGameUUUUUU>( this.Functions.AddFavoriteGame2 )( this.ObjectAddress, nAppID, nIP, nConnPort, nQueryPort, unFlags, rTime32LastPlayedOnServer ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRemoveFavoriteGameUUUUU( IntPtr thisptr, UInt32 nAppID, UInt32 nIP, UInt16 nConnPort, UInt16 nQueryPort, UInt32 unFlags );
		public bool RemoveFavoriteGame( UInt32 nAppID, UInt32 nIP, UInt16 nConnPort, UInt16 nQueryPort, UInt32 unFlags ) 
		{
			return this.GetFunction<NativeRemoveFavoriteGameUUUUU>( this.Functions.RemoveFavoriteGame3 )( this.ObjectAddress, nAppID, nIP, nConnPort, nQueryPort, unFlags ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeRequestLobbyList( IntPtr thisptr );
		public void RequestLobbyList(  ) 
		{
			this.GetFunction<NativeRequestLobbyList>( this.Functions.RequestLobbyList4 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetLobbyByIndexI( IntPtr thisptr, ref UInt64 retarg, Int32 iLobby );
		public CSteamID GetLobbyByIndex( Int32 iLobby ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetLobbyByIndexI>( this.Functions.GetLobbyByIndex5 )( this.ObjectAddress, ref ret, iLobby ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeCreateLobbyB( IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bPrivate );
		public void CreateLobby( bool bPrivate ) 
		{
			this.GetFunction<NativeCreateLobbyB>( this.Functions.CreateLobby6 )( this.ObjectAddress, bPrivate ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeJoinLobbyC( IntPtr thisptr, UInt64 steamIDLobby );
		public void JoinLobby( CSteamID steamIDLobby ) 
		{
			this.GetFunction<NativeJoinLobbyC>( this.Functions.JoinLobby7 )( this.ObjectAddress, steamIDLobby.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeLeaveLobbyC( IntPtr thisptr, UInt64 steamIDLobby );
		public void LeaveLobby( CSteamID steamIDLobby ) 
		{
			this.GetFunction<NativeLeaveLobbyC>( this.Functions.LeaveLobby8 )( this.ObjectAddress, steamIDLobby.ConvertToUint64() ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeInviteUserToLobbyCC( IntPtr thisptr, UInt64 steamIDLobby, UInt64 steamIDInvitee );
		public bool InviteUserToLobby( CSteamID steamIDLobby, CSteamID steamIDInvitee ) 
		{
			return this.GetFunction<NativeInviteUserToLobbyCC>( this.Functions.InviteUserToLobby9 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), steamIDInvitee.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetNumLobbyMembersC( IntPtr thisptr, UInt64 steamIDLobby );
		public Int32 GetNumLobbyMembers( CSteamID steamIDLobby ) 
		{
			return this.GetFunction<NativeGetNumLobbyMembersC>( this.Functions.GetNumLobbyMembers10 )( this.ObjectAddress, steamIDLobby.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetLobbyMemberByIndexCI( IntPtr thisptr, ref UInt64 retarg, UInt64 steamIDLobby, Int32 iMember );
		public CSteamID GetLobbyMemberByIndex( CSteamID steamIDLobby, Int32 iMember ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetLobbyMemberByIndexCI>( this.Functions.GetLobbyMemberByIndex11 )( this.ObjectAddress, ref ret, steamIDLobby.ConvertToUint64(), iMember ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetLobbyDataCS( IntPtr thisptr, UInt64 SteamIDLobby, string pchKey );
		public string GetLobbyData( CSteamID SteamIDLobby, string pchKey ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetLobbyDataCS>( this.Functions.GetLobbyData12 )( this.ObjectAddress, SteamIDLobby.ConvertToUint64(), pchKey ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetLobbyDataCSS( IntPtr thisptr, UInt64 steamIDLobby, string pchKey, string pchValue );
		public void SetLobbyData( CSteamID steamIDLobby, string pchKey, string pchValue ) 
		{
			this.GetFunction<NativeSetLobbyDataCSS>( this.Functions.SetLobbyData13 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), pchKey, pchValue ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetLobbyMemberDataCCS( IntPtr thisptr, UInt64 steamIDLobby, UInt64 steamIDUser, string pchKey );
		public string GetLobbyMemberData( CSteamID steamIDLobby, CSteamID steamIDUser, string pchKey ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetLobbyMemberDataCCS>( this.Functions.GetLobbyMemberData14 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), steamIDUser.ConvertToUint64(), pchKey ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetLobbyMemberDataCSS( IntPtr thisptr, UInt64 steamIDLobby, string pchKey, string pchValue );
		public void SetLobbyMemberData( CSteamID steamIDLobby, string pchKey, string pchValue ) 
		{
			this.GetFunction<NativeSetLobbyMemberDataCSS>( this.Functions.SetLobbyMemberData15 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), pchKey, pchValue ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSendLobbyChatMsgCBI( IntPtr thisptr, UInt64 steamIDLobby, Byte[] pvMsgBody, Int32 cubMsgBody );
		public bool SendLobbyChatMsg( CSteamID steamIDLobby, Byte[] pvMsgBody ) 
		{
			return this.GetFunction<NativeSendLobbyChatMsgCBI>( this.Functions.SendLobbyChatMsg16 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), pvMsgBody, (Int32) pvMsgBody.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetLobbyChatEntryCICBIE( IntPtr thisptr, UInt64 steamIDLobby, Int32 iChatID, ref UInt64 pSteamIDUser, Byte[] pvData, Int32 cubData, ref EChatEntryType peChatEntryType );
		public Int32 GetLobbyChatEntry( CSteamID steamIDLobby, Int32 iChatID, ref CSteamID pSteamIDUser, Byte[] pvData, ref EChatEntryType peChatEntryType ) 
		{
			UInt64 s0 = 0; var result = this.GetFunction<NativeGetLobbyChatEntryCICBIE>( this.Functions.GetLobbyChatEntry17 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), iChatID, ref s0, pvData, (Int32) pvData.Length, ref peChatEntryType ); pSteamIDUser = new CSteamID(s0); return result;
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRequestLobbyDataC( IntPtr thisptr, UInt64 steamIDLobby );
		public bool RequestLobbyData( CSteamID steamIDLobby ) 
		{
			return this.GetFunction<NativeRequestLobbyDataC>( this.Functions.RequestLobbyData18 )( this.ObjectAddress, steamIDLobby.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetLobbyGameServerCUUC( IntPtr thisptr, UInt64 steamIDLobby, UInt32 unGameServerIP, UInt16 unGameServerPort, UInt64 steamIDGameServer );
		public void SetLobbyGameServer( CSteamID steamIDLobby, UInt32 unGameServerIP, UInt16 unGameServerPort, CSteamID steamIDGameServer ) 
		{
			this.GetFunction<NativeSetLobbyGameServerCUUC>( this.Functions.SetLobbyGameServer19 )( this.ObjectAddress, steamIDLobby.ConvertToUint64(), unGameServerIP, unGameServerPort, steamIDGameServer.ConvertToUint64() ); 
		}
		
	};
}
