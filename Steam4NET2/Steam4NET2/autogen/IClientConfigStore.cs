// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class IClientConfigStoreVTable
	{
		public IntPtr IsSet0;
		public IntPtr GetBool1;
		public IntPtr GetInt2;
		public IntPtr GetUint643;
		public IntPtr GetFloat4;
		public IntPtr GetString5;
		public IntPtr GetBinary6;
		public IntPtr GetBinary7;
		public IntPtr GetBinaryWatermarked8;
		public IntPtr SetBool9;
		public IntPtr SetInt10;
		public IntPtr SetUint6411;
		public IntPtr SetFloat12;
		public IntPtr SetString13;
		public IntPtr SetBinary14;
		public IntPtr SetBinaryWatermarked15;
		public IntPtr RemoveKey16;
		public IntPtr GetKeySerialized17;
		public IntPtr FlushToDisk18;
		private IntPtr DTorIClientConfigStore19;
	};
	
	[InteropHelp.InterfaceVersion("CLIENTCONFIGSTORE_INTERFACE_VERSION001")]
	public class IClientConfigStore : InteropHelp.NativeWrapper<IClientConfigStoreVTable>
	{
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeIsSetES( IntPtr thisptr, EConfigStore eConfigStore, string pszKeyNameIn );
		public bool IsSet( EConfigStore eConfigStore, string pszKeyNameIn ) 
		{
			return this.GetFunction<NativeIsSetES>( this.Functions.IsSet0 )( this.ObjectAddress, eConfigStore, pszKeyNameIn ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetBoolESB( IntPtr thisptr, EConfigStore eConfigStore, string pszKeyNameIn, [MarshalAs(UnmanagedType.I1)] bool defaultValue );
		public bool GetBool( EConfigStore eConfigStore, string pszKeyNameIn, bool defaultValue ) 
		{
			return this.GetFunction<NativeGetBoolESB>( this.Functions.GetBool1 )( this.ObjectAddress, eConfigStore, pszKeyNameIn, defaultValue ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetIntESI( IntPtr thisptr, EConfigStore eConfigStore, string pszKeyName, Int32 defaultValue );
		public Int32 GetInt( EConfigStore eConfigStore, string pszKeyName, Int32 defaultValue ) 
		{
			return this.GetFunction<NativeGetIntESI>( this.Functions.GetInt2 )( this.ObjectAddress, eConfigStore, pszKeyName, defaultValue ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetUint64ESU( IntPtr thisptr, EConfigStore eConfigStore, string pszKeyName, UInt64 defaultValue );
		public UInt64 GetUint64( EConfigStore eConfigStore, string pszKeyName, UInt64 defaultValue ) 
		{
			return this.GetFunction<NativeGetUint64ESU>( this.Functions.GetUint643 )( this.ObjectAddress, eConfigStore, pszKeyName, defaultValue ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate float NativeGetFloatESF( IntPtr thisptr, EConfigStore eConfigStore, string pszKeyName, float defaultValue );
		public float GetFloat( EConfigStore eConfigStore, string pszKeyName, float defaultValue ) 
		{
			return this.GetFunction<NativeGetFloatESF>( this.Functions.GetFloat4 )( this.ObjectAddress, eConfigStore, pszKeyName, defaultValue ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetStringESS( IntPtr thisptr, EConfigStore eConfigStore, string pszKeyName, string defaultValue );
		public string GetString( EConfigStore eConfigStore, string pszKeyName, string defaultValue ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetStringESS>( this.Functions.GetString5 )( this.ObjectAddress, eConfigStore, pszKeyName, defaultValue ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetBinaryESBU( IntPtr thisptr, EConfigStore eConfigStore, string pszKeyName, Byte[] pubBuf, UInt32 cubBuf );
		public UInt32 GetBinary( EConfigStore eConfigStore, string pszKeyName, Byte[] pubBuf ) 
		{
			return this.GetFunction<NativeGetBinaryESBU>( this.Functions.GetBinary6 )( this.ObjectAddress, eConfigStore, pszKeyName, pubBuf, (UInt32) pubBuf.Length ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetBinaryESC( IntPtr thisptr, EConfigStore eConfigStore, string pszKeyName, ref CUtlBuffer pUtlBuf );
		public UInt32 GetBinary( EConfigStore eConfigStore, string pszKeyName, ref CUtlBuffer pUtlBuf ) 
		{
			return this.GetFunction<NativeGetBinaryESC>( this.Functions.GetBinary7 )( this.ObjectAddress, eConfigStore, pszKeyName, ref pUtlBuf ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetBinaryWatermarkedESBU( IntPtr thisptr, EConfigStore eConfigStore, string pszKeyName, Byte[] pubBuf, UInt32 cubBuf );
		public UInt32 GetBinaryWatermarked( EConfigStore eConfigStore, string pszKeyName, Byte[] pubBuf ) 
		{
			return this.GetFunction<NativeGetBinaryWatermarkedESBU>( this.Functions.GetBinaryWatermarked8 )( this.ObjectAddress, eConfigStore, pszKeyName, pubBuf, (UInt32) pubBuf.Length ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetBoolESB( IntPtr thisptr, EConfigStore eConfigStore, string pszKeyNameIn, [MarshalAs(UnmanagedType.I1)] bool value );
		public bool SetBool( EConfigStore eConfigStore, string pszKeyNameIn, bool value ) 
		{
			return this.GetFunction<NativeSetBoolESB>( this.Functions.SetBool9 )( this.ObjectAddress, eConfigStore, pszKeyNameIn, value ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetIntESI( IntPtr thisptr, EConfigStore eConfigStore, string pszKeyNameIn, Int32 nValue );
		public bool SetInt( EConfigStore eConfigStore, string pszKeyNameIn, Int32 nValue ) 
		{
			return this.GetFunction<NativeSetIntESI>( this.Functions.SetInt10 )( this.ObjectAddress, eConfigStore, pszKeyNameIn, nValue ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetUint64ESU( IntPtr thisptr, EConfigStore eConfigStore, string pszKeyNameIn, UInt64 unValue );
		public bool SetUint64( EConfigStore eConfigStore, string pszKeyNameIn, UInt64 unValue ) 
		{
			return this.GetFunction<NativeSetUint64ESU>( this.Functions.SetUint6411 )( this.ObjectAddress, eConfigStore, pszKeyNameIn, unValue ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetFloatESF( IntPtr thisptr, EConfigStore eConfigStore, string pszKeyNameIn, float flValue );
		public bool SetFloat( EConfigStore eConfigStore, string pszKeyNameIn, float flValue ) 
		{
			return this.GetFunction<NativeSetFloatESF>( this.Functions.SetFloat12 )( this.ObjectAddress, eConfigStore, pszKeyNameIn, flValue ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetStringESS( IntPtr thisptr, EConfigStore eConfigStore, string pszKeyNameIn, string pszValue );
		public bool SetString( EConfigStore eConfigStore, string pszKeyNameIn, string pszValue ) 
		{
			return this.GetFunction<NativeSetStringESS>( this.Functions.SetString13 )( this.ObjectAddress, eConfigStore, pszKeyNameIn, pszValue ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetBinaryESBU( IntPtr thisptr, EConfigStore eConfigStore, string pszKeyName, Byte[] pubData, UInt32 cubData );
		public bool SetBinary( EConfigStore eConfigStore, string pszKeyName, Byte[] pubData ) 
		{
			return this.GetFunction<NativeSetBinaryESBU>( this.Functions.SetBinary14 )( this.ObjectAddress, eConfigStore, pszKeyName, pubData, (UInt32) pubData.Length ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetBinaryWatermarkedESBU( IntPtr thisptr, EConfigStore eConfigStore, string pszKeyName, Byte[] pubData, UInt32 cubData );
		public bool SetBinaryWatermarked( EConfigStore eConfigStore, string pszKeyName, Byte[] pubData ) 
		{
			return this.GetFunction<NativeSetBinaryWatermarkedESBU>( this.Functions.SetBinaryWatermarked15 )( this.ObjectAddress, eConfigStore, pszKeyName, pubData, (UInt32) pubData.Length ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeRemoveKeyES( IntPtr thisptr, EConfigStore eConfigStore, string pszKeyName );
		public bool RemoveKey( EConfigStore eConfigStore, string pszKeyName ) 
		{
			return this.GetFunction<NativeRemoveKeyES>( this.Functions.RemoveKey16 )( this.ObjectAddress, eConfigStore, pszKeyName ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetKeySerializedESBI( IntPtr thisptr, EConfigStore eConfigStore, string pszKeyNameIn, Byte[] pchBuffer, Int32 cbBufferMax );
		public Int32 GetKeySerialized( EConfigStore eConfigStore, string pszKeyNameIn, Byte[] pchBuffer ) 
		{
			return this.GetFunction<NativeGetKeySerializedESBI>( this.Functions.GetKeySerialized17 )( this.ObjectAddress, eConfigStore, pszKeyNameIn, pchBuffer, (Int32) pchBuffer.Length ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeFlushToDiskB( IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bIsShuttingDown );
		public bool FlushToDisk( bool bIsShuttingDown ) 
		{
			return this.GetFunction<NativeFlushToDiskB>( this.Functions.FlushToDisk18 )( this.ObjectAddress, bIsShuttingDown ); 
		}
		
	};
}
