// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamFriends001VTable
	{
		public IntPtr GetPersonaName0;
		public IntPtr SetPersonaName1;
		public IntPtr GetPersonaState2;
		public IntPtr SetPersonaState3;
		public IntPtr AddFriend4;
		public IntPtr RemoveFriend5;
		public IntPtr HasFriend6;
		public IntPtr GetFriendRelationship7;
		public IntPtr GetFriendPersonaState8;
		public IntPtr Deprecated_GetFriendGamePlayed9;
		public IntPtr GetFriendPersonaName10;
		public IntPtr AddFriendByName11;
		public IntPtr GetFriendCount12;
		public IntPtr GetFriendByIndex13;
		public IntPtr SendMsgToFriend14;
		public IntPtr SetFriendRegValue15;
		public IntPtr GetFriendRegValue16;
		public IntPtr GetFriendPersonaNameHistory17;
		public IntPtr GetChatMessage18;
		public IntPtr SendMsgToFriend19;
		public IntPtr GetChatIDOfChatHistoryStart20;
		public IntPtr SetChatHistoryStart21;
		public IntPtr ClearChatHistory22;
		public IntPtr InviteFriendByEmail23;
		public IntPtr GetBlockedFriendCount24;
		public IntPtr GetFriendGamePlayed25;
		public IntPtr GetFriendGamePlayed226;
		private IntPtr DTorISteamFriends00127;
	};
	
	[InteropHelp.InterfaceVersion("SteamFriends001")]
	public class ISteamFriends001 : InteropHelp.NativeWrapper<ISteamFriends001VTable>
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
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetPersonaStateE( IntPtr thisptr, EPersonaState ePersonaState );
		public void SetPersonaState( EPersonaState ePersonaState ) 
		{
			this.GetFunction<NativeSetPersonaStateE>( this.Functions.SetPersonaState3 )( this.ObjectAddress, ePersonaState ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeAddFriendC( IntPtr thisptr, UInt64 steamIDFriend );
		public bool AddFriend( CSteamID steamIDFriend ) 
		{
			return this.GetFunction<NativeAddFriendC>( this.Functions.AddFriend4 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRemoveFriendC( IntPtr thisptr, UInt64 steamIDFriend );
		public bool RemoveFriend( CSteamID steamIDFriend ) 
		{
			return this.GetFunction<NativeRemoveFriendC>( this.Functions.RemoveFriend5 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeHasFriendC( IntPtr thisptr, UInt64 steamIDFriend );
		public bool HasFriend( CSteamID steamIDFriend ) 
		{
			return this.GetFunction<NativeHasFriendC>( this.Functions.HasFriend6 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EFriendRelationship NativeGetFriendRelationshipC( IntPtr thisptr, UInt64 steamIDFriend );
		public EFriendRelationship GetFriendRelationship( CSteamID steamIDFriend ) 
		{
			return this.GetFunction<NativeGetFriendRelationshipC>( this.Functions.GetFriendRelationship7 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EPersonaState NativeGetFriendPersonaStateC( IntPtr thisptr, UInt64 steamIDFriend );
		public EPersonaState GetFriendPersonaState( CSteamID steamIDFriend ) 
		{
			return this.GetFunction<NativeGetFriendPersonaStateC>( this.Functions.GetFriendPersonaState8 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeDeprecated_GetFriendGamePlayedCIUU( IntPtr thisptr, UInt64 steamIDFriend, ref Int32 pnGameID, ref UInt32 punGameIP, ref UInt16 pusGamePort );
		public bool Deprecated_GetFriendGamePlayed( CSteamID steamIDFriend, ref Int32 pnGameID, ref UInt32 punGameIP, ref UInt16 pusGamePort ) 
		{
			return this.GetFunction<NativeDeprecated_GetFriendGamePlayedCIUU>( this.Functions.Deprecated_GetFriendGamePlayed9 )( this.ObjectAddress, steamIDFriend.ConvertToUint64(), ref pnGameID, ref punGameIP, ref pusGamePort ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetFriendPersonaNameC( IntPtr thisptr, UInt64 steamIDFriend );
		public string GetFriendPersonaName( CSteamID steamIDFriend ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetFriendPersonaNameC>( this.Functions.GetFriendPersonaName10 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeAddFriendByNameS( IntPtr thisptr, string pchEmailOrAccountName );
		public Int32 AddFriendByName( string pchEmailOrAccountName ) 
		{
			return this.GetFunction<NativeAddFriendByNameS>( this.Functions.AddFriendByName11 )( this.ObjectAddress, pchEmailOrAccountName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetFriendCount( IntPtr thisptr );
		public Int32 GetFriendCount(  ) 
		{
			return this.GetFunction<NativeGetFriendCount>( this.Functions.GetFriendCount12 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeGetFriendByIndexI( IntPtr thisptr, ref UInt64 retarg, Int32 iFriend );
		public CSteamID GetFriendByIndex( Int32 iFriend ) 
		{
			UInt64 ret = 0; this.GetFunction<NativeGetFriendByIndexI>( this.Functions.GetFriendByIndex13 )( this.ObjectAddress, ref ret, iFriend ); return new CSteamID(ret);
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSendMsgToFriendCES( IntPtr thisptr, UInt64 steamIDFriend, EChatEntryType eFriendMsgType, string pchMsgBody );
		public void SendMsgToFriend( CSteamID steamIDFriend, EChatEntryType eFriendMsgType, string pchMsgBody ) 
		{
			this.GetFunction<NativeSendMsgToFriendCES>( this.Functions.SendMsgToFriend14 )( this.ObjectAddress, steamIDFriend.ConvertToUint64(), eFriendMsgType, pchMsgBody ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetFriendRegValueCSS( IntPtr thisptr, UInt64 steamIDFriend, string pchKey, string pchValue );
		public void SetFriendRegValue( CSteamID steamIDFriend, string pchKey, string pchValue ) 
		{
			this.GetFunction<NativeSetFriendRegValueCSS>( this.Functions.SetFriendRegValue15 )( this.ObjectAddress, steamIDFriend.ConvertToUint64(), pchKey, pchValue ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetFriendRegValueCS( IntPtr thisptr, UInt64 steamIDFriend, string pchKey );
		public string GetFriendRegValue( CSteamID steamIDFriend, string pchKey ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetFriendRegValueCS>( this.Functions.GetFriendRegValue16 )( this.ObjectAddress, steamIDFriend.ConvertToUint64(), pchKey ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetFriendPersonaNameHistoryCI( IntPtr thisptr, UInt64 steamIDFriend, Int32 iPersonaName );
		public string GetFriendPersonaNameHistory( CSteamID steamIDFriend, Int32 iPersonaName ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetFriendPersonaNameHistoryCI>( this.Functions.GetFriendPersonaNameHistory17 )( this.ObjectAddress, steamIDFriend.ConvertToUint64(), iPersonaName ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetChatMessageCIBIE( IntPtr thisptr, UInt64 steamIDFriend, Int32 iChatID, Byte[] pvData, Int32 cubData, ref EChatEntryType peFriendMsgType );
		public Int32 GetChatMessage( CSteamID steamIDFriend, Int32 iChatID, Byte[] pvData, ref EChatEntryType peFriendMsgType ) 
		{
			return this.GetFunction<NativeGetChatMessageCIBIE>( this.Functions.GetChatMessage18 )( this.ObjectAddress, steamIDFriend.ConvertToUint64(), iChatID, pvData, (Int32) pvData.Length, ref peFriendMsgType ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSendMsgToFriendCEBI( IntPtr thisptr, UInt64 steamIDFriend, EChatEntryType eFriendMsgType, Byte[] pvMsgBody, Int32 cubMsgBody );
		public bool SendMsgToFriend( CSteamID steamIDFriend, EChatEntryType eFriendMsgType, Byte[] pvMsgBody ) 
		{
			return this.GetFunction<NativeSendMsgToFriendCEBI>( this.Functions.SendMsgToFriend19 )( this.ObjectAddress, steamIDFriend.ConvertToUint64(), eFriendMsgType, pvMsgBody, (Int32) pvMsgBody.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetChatIDOfChatHistoryStartC( IntPtr thisptr, UInt64 steamIDFriend );
		public Int32 GetChatIDOfChatHistoryStart( CSteamID steamIDFriend ) 
		{
			return this.GetFunction<NativeGetChatIDOfChatHistoryStartC>( this.Functions.GetChatIDOfChatHistoryStart20 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeSetChatHistoryStartCI( IntPtr thisptr, UInt64 steamIDFriend, Int32 iChatID );
		public void SetChatHistoryStart( CSteamID steamIDFriend, Int32 iChatID ) 
		{
			this.GetFunction<NativeSetChatHistoryStartCI>( this.Functions.SetChatHistoryStart21 )( this.ObjectAddress, steamIDFriend.ConvertToUint64(), iChatID ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate void NativeClearChatHistoryC( IntPtr thisptr, UInt64 steamIDFriend );
		public void ClearChatHistory( CSteamID steamIDFriend ) 
		{
			this.GetFunction<NativeClearChatHistoryC>( this.Functions.ClearChatHistory22 )( this.ObjectAddress, steamIDFriend.ConvertToUint64() ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeInviteFriendByEmailS( IntPtr thisptr, string pchEmailOrAccountName );
		public Int32 InviteFriendByEmail( string pchEmailOrAccountName ) 
		{
			return this.GetFunction<NativeInviteFriendByEmailS>( this.Functions.InviteFriendByEmail23 )( this.ObjectAddress, pchEmailOrAccountName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetBlockedFriendCount( IntPtr thisptr );
		public UInt32 GetBlockedFriendCount(  ) 
		{
			return this.GetFunction<NativeGetBlockedFriendCount>( this.Functions.GetBlockedFriendCount24 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetFriendGamePlayedCUUU( IntPtr thisptr, UInt64 steamIDFriend, ref UInt64 pulGameID, ref UInt32 punGameIP, ref UInt16 pusGamePort );
		public bool GetFriendGamePlayed( CSteamID steamIDFriend, ref UInt64 pulGameID, ref UInt32 punGameIP, ref UInt16 pusGamePort ) 
		{
			return this.GetFunction<NativeGetFriendGamePlayedCUUU>( this.Functions.GetFriendGamePlayed25 )( this.ObjectAddress, steamIDFriend.ConvertToUint64(), ref pulGameID, ref punGameIP, ref pusGamePort ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetFriendGamePlayed2CUUUU( IntPtr thisptr, UInt64 steamDIFriend, ref UInt64 pulGameID, ref UInt32 punGameIP, ref UInt16 pusGamePort, ref UInt16 pusQueryPort );
		public bool GetFriendGamePlayed2( CSteamID steamDIFriend, ref UInt64 pulGameID, ref UInt32 punGameIP, ref UInt16 pusGamePort, ref UInt16 pusQueryPort ) 
		{
			return this.GetFunction<NativeGetFriendGamePlayed2CUUUU>( this.Functions.GetFriendGamePlayed226 )( this.ObjectAddress, steamDIFriend.ConvertToUint64(), ref pulGameID, ref punGameIP, ref pusGamePort, ref pusQueryPort ); 
		}
		
	};
}
