// This file is automatically generated.
using System;
using System.Text;
using System.Runtime.InteropServices;

namespace Steam4NET
{

	[StructLayout(LayoutKind.Sequential,Pack=4)]
	public class ISteamBilling002VTable
	{
		public IntPtr InitCreditCardPurchase0;
		public IntPtr InitPayPalPurchase1;
		public IntPtr GetActivationCodeInfo2;
		public IntPtr PurchaseWithActivationCode3;
		public IntPtr GetFinalPrice4;
		public IntPtr CancelPurchase5;
		public IntPtr CompletePurchase6;
		public IntPtr UpdateCardInfo7;
		public IntPtr DeleteCard8;
		public IntPtr GetCardList9;
		public IntPtr Obsolete_GetLicenses10;
		public IntPtr CancelLicense11;
		public IntPtr GetPurchaseReceipts12;
		public IntPtr SetBillingAddress13;
		public IntPtr GetBillingAddress14;
		public IntPtr SetShippingAddress15;
		public IntPtr GetShippingAddress16;
		public IntPtr SetCardInfo17;
		public IntPtr GetCardInfo18;
		public IntPtr GetLicensePackageID19;
		public IntPtr GetLicenseTimeCreated20;
		public IntPtr GetLicenseTimeNextProcess21;
		public IntPtr GetLicenseMinuteLimit22;
		public IntPtr GetLicenseMinutesUsed23;
		public IntPtr GetLicensePaymentMethod24;
		public IntPtr GetLicenseFlags25;
		public IntPtr GetLicensePurchaseCountryCode26;
		public IntPtr GetReceiptPackageID27;
		public IntPtr GetReceiptStatus28;
		public IntPtr GetReceiptResultDetail29;
		public IntPtr GetReceiptTransTime30;
		public IntPtr GetReceiptTransID31;
		public IntPtr GetReceiptPaymentMethod32;
		public IntPtr GetReceiptBaseCost33;
		public IntPtr GetReceiptTotalDiscount34;
		public IntPtr GetReceiptTax35;
		public IntPtr GetReceiptShipping36;
		public IntPtr GetReceiptCountryCode37;
		public IntPtr GetNumLicenses38;
		public IntPtr GetNumReceipts39;
		public IntPtr PurchaseWithMachineID40;
		public IntPtr InitClickAndBuyPurchase41;
		public IntPtr GetPreviousClickAndBuyAccount42;
		private IntPtr DTorISteamBilling00243;
	};
	
	[InteropHelp.InterfaceVersion("SteamBilling002")]
	public class ISteamBilling002 : InteropHelp.NativeWrapper<ISteamBilling002VTable>
	{
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeInitCreditCardPurchaseUUB( IntPtr thisptr, UInt32 nPackageID, UInt32 nCardIndex, [MarshalAs(UnmanagedType.I1)] bool bStoreCardInfo );
		public bool InitCreditCardPurchase( UInt32 nPackageID, UInt32 nCardIndex, bool bStoreCardInfo ) 
		{
			return this.GetFunction<NativeInitCreditCardPurchaseUUB>( this.Functions.InitCreditCardPurchase0 )( this.ObjectAddress, nPackageID, nCardIndex, bStoreCardInfo ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeInitPayPalPurchaseU( IntPtr thisptr, UInt32 nPackageID );
		public bool InitPayPalPurchase( UInt32 nPackageID ) 
		{
			return this.GetFunction<NativeInitPayPalPurchaseU>( this.Functions.InitPayPalPurchase1 )( this.ObjectAddress, nPackageID ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetActivationCodeInfoS( IntPtr thisptr, string pchActivationCode );
		public bool GetActivationCodeInfo( string pchActivationCode ) 
		{
			return this.GetFunction<NativeGetActivationCodeInfoS>( this.Functions.GetActivationCodeInfo2 )( this.ObjectAddress, pchActivationCode ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativePurchaseWithActivationCodeS( IntPtr thisptr, string pchActivationCode );
		public bool PurchaseWithActivationCode( string pchActivationCode ) 
		{
			return this.GetFunction<NativePurchaseWithActivationCodeS>( this.Functions.PurchaseWithActivationCode3 )( this.ObjectAddress, pchActivationCode ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetFinalPrice( IntPtr thisptr );
		public bool GetFinalPrice(  ) 
		{
			return this.GetFunction<NativeGetFinalPrice>( this.Functions.GetFinalPrice4 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeCancelPurchase( IntPtr thisptr );
		public bool CancelPurchase(  ) 
		{
			return this.GetFunction<NativeCancelPurchase>( this.Functions.CancelPurchase5 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeCompletePurchase( IntPtr thisptr );
		public bool CompletePurchase(  ) 
		{
			return this.GetFunction<NativeCompletePurchase>( this.Functions.CompletePurchase6 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeUpdateCardInfoU( IntPtr thisptr, UInt32 nCardIndex );
		public bool UpdateCardInfo( UInt32 nCardIndex ) 
		{
			return this.GetFunction<NativeUpdateCardInfoU>( this.Functions.UpdateCardInfo7 )( this.ObjectAddress, nCardIndex ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeDeleteCardU( IntPtr thisptr, UInt32 arg0 );
		public bool DeleteCard( UInt32 arg0 ) 
		{
			return this.GetFunction<NativeDeleteCardU>( this.Functions.DeleteCard8 )( this.ObjectAddress, arg0 ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetCardList( IntPtr thisptr );
		public bool GetCardList(  ) 
		{
			return this.GetFunction<NativeGetCardList>( this.Functions.GetCardList9 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeObsolete_GetLicenses( IntPtr thisptr );
		public bool Obsolete_GetLicenses(  ) 
		{
			return this.GetFunction<NativeObsolete_GetLicenses>( this.Functions.Obsolete_GetLicenses10 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeCancelLicenseUI( IntPtr thisptr, UInt32 nPackageID, Int32 nCancelReason );
		public bool CancelLicense( UInt32 nPackageID, Int32 nCancelReason ) 
		{
			return this.GetFunction<NativeCancelLicenseUI>( this.Functions.CancelLicense11 )( this.ObjectAddress, nPackageID, nCancelReason ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetPurchaseReceiptsB( IntPtr thisptr, [MarshalAs(UnmanagedType.I1)] bool bUnacknowledgedOnly );
		public bool GetPurchaseReceipts( bool bUnacknowledgedOnly ) 
		{
			return this.GetFunction<NativeGetPurchaseReceiptsB>( this.Functions.GetPurchaseReceipts12 )( this.ObjectAddress, bUnacknowledgedOnly ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetBillingAddressUSSSSSSSSS( IntPtr thisptr, UInt32 nCardIndex, string pchFirstName, string pchLastName, string pchAddress1, string pchAddress2, string pchCity, string pchPostcode, string pchState, string pchCountry, string pchPhone );
		public bool SetBillingAddress( UInt32 nCardIndex, string pchFirstName, string pchLastName, string pchAddress1, string pchAddress2, string pchCity, string pchPostcode, string pchState, string pchCountry, string pchPhone ) 
		{
			return this.GetFunction<NativeSetBillingAddressUSSSSSSSSS>( this.Functions.SetBillingAddress13 )( this.ObjectAddress, nCardIndex, pchFirstName, pchLastName, pchAddress1, pchAddress2, pchCity, pchPostcode, pchState, pchCountry, pchPhone ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetBillingAddressUSSSSSSSSS( IntPtr thisptr, UInt32 nCardIndex, StringBuilder pchFirstName, StringBuilder pchLastName, StringBuilder pchAddress1, StringBuilder pchAddress2, StringBuilder pchCity, StringBuilder pchPostcode, StringBuilder pchState, StringBuilder pchCountry, StringBuilder pchPhone );
		public bool GetBillingAddress( UInt32 nCardIndex, StringBuilder pchFirstName, StringBuilder pchLastName, StringBuilder pchAddress1, StringBuilder pchAddress2, StringBuilder pchCity, StringBuilder pchPostcode, StringBuilder pchState, StringBuilder pchCountry, StringBuilder pchPhone ) 
		{
			return this.GetFunction<NativeGetBillingAddressUSSSSSSSSS>( this.Functions.GetBillingAddress14 )( this.ObjectAddress, nCardIndex, pchFirstName, pchLastName, pchAddress1, pchAddress2, pchCity, pchPostcode, pchState, pchCountry, pchPhone ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetShippingAddressSSSSSSSSS( IntPtr thisptr, string pchFirstName, string pchLastName, string pchAddress1, string pchAddress2, string pchCity, string pchPostcode, string pchState, string pchCountry, string pchPhone );
		public bool SetShippingAddress( string pchFirstName, string pchLastName, string pchAddress1, string pchAddress2, string pchCity, string pchPostcode, string pchState, string pchCountry, string pchPhone ) 
		{
			return this.GetFunction<NativeSetShippingAddressSSSSSSSSS>( this.Functions.SetShippingAddress15 )( this.ObjectAddress, pchFirstName, pchLastName, pchAddress1, pchAddress2, pchCity, pchPostcode, pchState, pchCountry, pchPhone ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetShippingAddressSSSSSSSSS( IntPtr thisptr, StringBuilder pchFirstName, StringBuilder pchLastName, StringBuilder pchAddress1, StringBuilder pchAddress2, StringBuilder pchCity, StringBuilder pchPostcode, StringBuilder pchState, StringBuilder pchCountry, StringBuilder pchPhone );
		public bool GetShippingAddress( StringBuilder pchFirstName, StringBuilder pchLastName, StringBuilder pchAddress1, StringBuilder pchAddress2, StringBuilder pchCity, StringBuilder pchPostcode, StringBuilder pchState, StringBuilder pchCountry, StringBuilder pchPhone ) 
		{
			return this.GetFunction<NativeGetShippingAddressSSSSSSSSS>( this.Functions.GetShippingAddress16 )( this.ObjectAddress, pchFirstName, pchLastName, pchAddress1, pchAddress2, pchCity, pchPostcode, pchState, pchCountry, pchPhone ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeSetCardInfoUESSSSSS( IntPtr thisptr, UInt32 nCardIndex, ECreditCardType eCreditCardType, string pchCardNumber, string pchCardHolderFirstName, string pchCardHolderLastName, string pchCardExpYear, string pchCardExpMonth, string pchCardCVV2 );
		public bool SetCardInfo( UInt32 nCardIndex, ECreditCardType eCreditCardType, string pchCardNumber, string pchCardHolderFirstName, string pchCardHolderLastName, string pchCardExpYear, string pchCardExpMonth, string pchCardCVV2 ) 
		{
			return this.GetFunction<NativeSetCardInfoUESSSSSS>( this.Functions.SetCardInfo17 )( this.ObjectAddress, nCardIndex, eCreditCardType, pchCardNumber, pchCardHolderFirstName, pchCardHolderLastName, pchCardExpYear, pchCardExpMonth, pchCardCVV2 ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetCardInfoUESSSSSS( IntPtr thisptr, UInt32 nCardIndex, ref ECreditCardType eCreditCardType, StringBuilder pchCardNumber, StringBuilder pchCardHolderFirstName, StringBuilder pchCardHolderLastName, StringBuilder pchCardExpYear, StringBuilder pchCardExpMonth, StringBuilder pchCardCVV2 );
		public bool GetCardInfo( UInt32 nCardIndex, ref ECreditCardType eCreditCardType, StringBuilder pchCardNumber, StringBuilder pchCardHolderFirstName, StringBuilder pchCardHolderLastName, StringBuilder pchCardExpYear, StringBuilder pchCardExpMonth, StringBuilder pchCardCVV2 ) 
		{
			return this.GetFunction<NativeGetCardInfoUESSSSSS>( this.Functions.GetCardInfo18 )( this.ObjectAddress, nCardIndex, ref eCreditCardType, pchCardNumber, pchCardHolderFirstName, pchCardHolderLastName, pchCardExpYear, pchCardExpMonth, pchCardCVV2 ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetLicensePackageIDU( IntPtr thisptr, UInt32 nLicenseIndex );
		public UInt32 GetLicensePackageID( UInt32 nLicenseIndex ) 
		{
			return this.GetFunction<NativeGetLicensePackageIDU>( this.Functions.GetLicensePackageID19 )( this.ObjectAddress, nLicenseIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetLicenseTimeCreatedU( IntPtr thisptr, UInt32 nLicenseIndex );
		public UInt32 GetLicenseTimeCreated( UInt32 nLicenseIndex ) 
		{
			return this.GetFunction<NativeGetLicenseTimeCreatedU>( this.Functions.GetLicenseTimeCreated20 )( this.ObjectAddress, nLicenseIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetLicenseTimeNextProcessU( IntPtr thisptr, UInt32 nLicenseIndex );
		public UInt32 GetLicenseTimeNextProcess( UInt32 nLicenseIndex ) 
		{
			return this.GetFunction<NativeGetLicenseTimeNextProcessU>( this.Functions.GetLicenseTimeNextProcess21 )( this.ObjectAddress, nLicenseIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetLicenseMinuteLimitU( IntPtr thisptr, UInt32 nLicenseIndex );
		public Int32 GetLicenseMinuteLimit( UInt32 nLicenseIndex ) 
		{
			return this.GetFunction<NativeGetLicenseMinuteLimitU>( this.Functions.GetLicenseMinuteLimit22 )( this.ObjectAddress, nLicenseIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate Int32 NativeGetLicenseMinutesUsedU( IntPtr thisptr, UInt32 nLicenseIndex );
		public Int32 GetLicenseMinutesUsed( UInt32 nLicenseIndex ) 
		{
			return this.GetFunction<NativeGetLicenseMinutesUsedU>( this.Functions.GetLicenseMinutesUsed23 )( this.ObjectAddress, nLicenseIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EPaymentMethod NativeGetLicensePaymentMethodU( IntPtr thisptr, UInt32 nLicenseIndex );
		public EPaymentMethod GetLicensePaymentMethod( UInt32 nLicenseIndex ) 
		{
			return this.GetFunction<NativeGetLicensePaymentMethodU>( this.Functions.GetLicensePaymentMethod24 )( this.ObjectAddress, nLicenseIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate ELicenseFlags NativeGetLicenseFlagsU( IntPtr thisptr, UInt32 nLicenseIndex );
		public ELicenseFlags GetLicenseFlags( UInt32 nLicenseIndex ) 
		{
			return this.GetFunction<NativeGetLicenseFlagsU>( this.Functions.GetLicenseFlags25 )( this.ObjectAddress, nLicenseIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetLicensePurchaseCountryCodeU( IntPtr thisptr, UInt32 nLicenseIndex );
		public string GetLicensePurchaseCountryCode( UInt32 nLicenseIndex ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetLicensePurchaseCountryCodeU>( this.Functions.GetLicensePurchaseCountryCode26 )( this.ObjectAddress, nLicenseIndex ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetReceiptPackageIDU( IntPtr thisptr, UInt32 nReceiptIndex );
		public UInt32 GetReceiptPackageID( UInt32 nReceiptIndex ) 
		{
			return this.GetFunction<NativeGetReceiptPackageIDU>( this.Functions.GetReceiptPackageID27 )( this.ObjectAddress, nReceiptIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EPurchaseStatus NativeGetReceiptStatusU( IntPtr thisptr, UInt32 nReceiptIndex );
		public EPurchaseStatus GetReceiptStatus( UInt32 nReceiptIndex ) 
		{
			return this.GetFunction<NativeGetReceiptStatusU>( this.Functions.GetReceiptStatus28 )( this.ObjectAddress, nReceiptIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EPurchaseResultDetail NativeGetReceiptResultDetailU( IntPtr thisptr, UInt32 nReceiptIndex );
		public EPurchaseResultDetail GetReceiptResultDetail( UInt32 nReceiptIndex ) 
		{
			return this.GetFunction<NativeGetReceiptResultDetailU>( this.Functions.GetReceiptResultDetail29 )( this.ObjectAddress, nReceiptIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetReceiptTransTimeU( IntPtr thisptr, UInt32 nReceiptIndex );
		public UInt32 GetReceiptTransTime( UInt32 nReceiptIndex ) 
		{
			return this.GetFunction<NativeGetReceiptTransTimeU>( this.Functions.GetReceiptTransTime30 )( this.ObjectAddress, nReceiptIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt64 NativeGetReceiptTransIDU( IntPtr thisptr, UInt32 nReceiptIndex );
		public UInt64 GetReceiptTransID( UInt32 nReceiptIndex ) 
		{
			return this.GetFunction<NativeGetReceiptTransIDU>( this.Functions.GetReceiptTransID31 )( this.ObjectAddress, nReceiptIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate EPaymentMethod NativeGetReceiptPaymentMethodU( IntPtr thisptr, UInt32 nReceiptIndex );
		public EPaymentMethod GetReceiptPaymentMethod( UInt32 nReceiptIndex ) 
		{
			return this.GetFunction<NativeGetReceiptPaymentMethodU>( this.Functions.GetReceiptPaymentMethod32 )( this.ObjectAddress, nReceiptIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetReceiptBaseCostU( IntPtr thisptr, UInt32 nReceiptIndex );
		public UInt32 GetReceiptBaseCost( UInt32 nReceiptIndex ) 
		{
			return this.GetFunction<NativeGetReceiptBaseCostU>( this.Functions.GetReceiptBaseCost33 )( this.ObjectAddress, nReceiptIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetReceiptTotalDiscountU( IntPtr thisptr, UInt32 nReceiptIndex );
		public UInt32 GetReceiptTotalDiscount( UInt32 nReceiptIndex ) 
		{
			return this.GetFunction<NativeGetReceiptTotalDiscountU>( this.Functions.GetReceiptTotalDiscount34 )( this.ObjectAddress, nReceiptIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetReceiptTaxU( IntPtr thisptr, UInt32 nReceiptIndex );
		public UInt32 GetReceiptTax( UInt32 nReceiptIndex ) 
		{
			return this.GetFunction<NativeGetReceiptTaxU>( this.Functions.GetReceiptTax35 )( this.ObjectAddress, nReceiptIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetReceiptShippingU( IntPtr thisptr, UInt32 nReceiptIndex );
		public UInt32 GetReceiptShipping( UInt32 nReceiptIndex ) 
		{
			return this.GetFunction<NativeGetReceiptShippingU>( this.Functions.GetReceiptShipping36 )( this.ObjectAddress, nReceiptIndex ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate IntPtr NativeGetReceiptCountryCodeU( IntPtr thisptr, UInt32 nReceiptIndex );
		public string GetReceiptCountryCode( UInt32 nReceiptIndex ) 
		{
			return InteropHelp.DecodeANSIReturn( Marshal.PtrToStringAnsi( this.GetFunction<NativeGetReceiptCountryCodeU>( this.Functions.GetReceiptCountryCode37 )( this.ObjectAddress, nReceiptIndex ) ) ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetNumLicenses( IntPtr thisptr );
		public UInt32 GetNumLicenses(  ) 
		{
			return this.GetFunction<NativeGetNumLicenses>( this.Functions.GetNumLicenses38 )( this.ObjectAddress ); 
		}
		
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate UInt32 NativeGetNumReceipts( IntPtr thisptr );
		public UInt32 GetNumReceipts(  ) 
		{
			return this.GetFunction<NativeGetNumReceipts>( this.Functions.GetNumReceipts39 )( this.ObjectAddress ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativePurchaseWithMachineIDUS( IntPtr thisptr, UInt32 nPackageID, string pchCustomData );
		public bool PurchaseWithMachineID( UInt32 nPackageID, string pchCustomData ) 
		{
			return this.GetFunction<NativePurchaseWithMachineIDUS>( this.Functions.PurchaseWithMachineID40 )( this.ObjectAddress, nPackageID, pchCustomData ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeInitClickAndBuyPurchaseUISS( IntPtr thisptr, UInt32 nPackageID, Int64 nAccountNum, string pchState, string pchCountryCode );
		public bool InitClickAndBuyPurchase( UInt32 nPackageID, Int64 nAccountNum, string pchState, string pchCountryCode ) 
		{
			return this.GetFunction<NativeInitClickAndBuyPurchaseUISS>( this.Functions.InitClickAndBuyPurchase41 )( this.ObjectAddress, nPackageID, nAccountNum, pchState, pchCountryCode ); 
		}
		
		[return: MarshalAs(UnmanagedType.I1)]
		[UnmanagedFunctionPointer(CallingConvention.ThisCall)] private delegate bool NativeGetPreviousClickAndBuyAccountISS( IntPtr thisptr, ref Int64 pnAccountNum, StringBuilder pchState, StringBuilder pchCountryCode );
		public bool GetPreviousClickAndBuyAccount( ref Int64 pnAccountNum, StringBuilder pchState, StringBuilder pchCountryCode ) 
		{
			return this.GetFunction<NativeGetPreviousClickAndBuyAccountISS>( this.Functions.GetPreviousClickAndBuyAccount42 )( this.ObjectAddress, ref pnAccountNum, pchState, pchCountryCode ); 
		}
		
	};
}
