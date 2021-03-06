// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Ecom
{
	public sealed class Transaction : Handle
	{
		public Transaction() : base(IntPtr.Zero)
		{
		}

		public Transaction(IntPtr innerHandle) : base(innerHandle)
		{
		}

		/// <summary>
		/// The Ecom Transaction Interface exposes getters for accessing information about a completed transaction.
		/// All Ecom Transaction Interface calls take a handle of type <see cref="Transaction" /> as the first parameter.
		/// A <see cref="Transaction" /> handle is originally returned as part of the <see cref="CheckoutCallbackInfo" /> struct.
		/// A <see cref="Transaction" /> handle can also be retrieved from a <see cref="EcomInterface" /> handle using <see cref="EcomInterface.CopyTransactionByIndex" />.
		/// It is expected that after a transaction that <see cref="Release" /> is called.
		/// When <see cref="Platform.PlatformInterface.Release" /> is called any remaining transactions will also be released.
		/// <seealso cref="CheckoutCallbackInfo" />
		/// <seealso cref="EcomInterface.GetTransactionCount" />
		/// <seealso cref="EcomInterface.CopyTransactionByIndex" />
		/// </summary>
		public Result GetTransactionId(System.Text.StringBuilder outBuffer, ref int inOutBufferLength)
		{
			var funcResult = EOS_Ecom_Transaction_GetTransactionId(InnerHandle, outBuffer, ref inOutBufferLength);
			var funcResultReturn = Helper.GetDefault<Result>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Fetch the number of entitlements that are part of this transaction.
		/// <seealso cref="CopyEntitlementByIndex" />
		/// <seealso cref="Achievements" />
		/// </summary>
		/// <param name="options">structure containing the account id being accessed</param>
		/// <returns>
		/// the number of entitlements found.
		/// </returns>
		public uint GetEntitlementsCount(TransactionGetEntitlementsCountOptions options)
		{
			var optionsInternal = Helper.CopyProperties<TransactionGetEntitlementsCountOptionsInternal>(options);

			var funcResult = EOS_Ecom_Transaction_GetEntitlementsCount(InnerHandle, ref optionsInternal);
			Helper.TryMarshalDispose(ref optionsInternal);

			var funcResultReturn = Helper.GetDefault<uint>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Fetches an entitlement from a given index.
		/// <seealso cref="EcomInterface.Release" />
		/// <seealso cref="Achievements" />
		/// </summary>
		/// <param name="options">structure containing the index being accessed</param>
		/// <param name="outEntitlement">the entitlement for the given index, if it exists and is valid, use <see cref="EcomInterface.Release" /> when finished</param>
		/// <returns>
		/// <see cref="Result.Success" /> if the information is available and passed out in OutEntitlement
		/// <see cref="Result.EcomEntitlementStale" /> if the entitlement information is stale and passed out in OutEntitlement
		/// <see cref="Result.InvalidParameters" /> if you pass a null pointer for the out parameter
		/// <see cref="Result.NotFound" /> if the entitlement is not found
		/// </returns>
		public Result CopyEntitlementByIndex(TransactionCopyEntitlementByIndexOptions options, out Entitlement outEntitlement)
		{
			var optionsInternal = Helper.CopyProperties<TransactionCopyEntitlementByIndexOptionsInternal>(options);

			outEntitlement = Helper.GetDefault<Entitlement>();

			var outEntitlementAddress = IntPtr.Zero;

			var funcResult = EOS_Ecom_Transaction_CopyEntitlementByIndex(InnerHandle, ref optionsInternal, ref outEntitlementAddress);
			Helper.TryMarshalDispose(ref optionsInternal);

			if (Helper.TryMarshalGet<EntitlementInternal, Entitlement>(outEntitlementAddress, out outEntitlement))
			{
				EOS_Ecom_Entitlement_Release(outEntitlementAddress);
			}

			var funcResultReturn = Helper.GetDefault<Result>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Release the memory associated with an <see cref="Transaction" />. Is is expected to be called after
		/// being received from a <see cref="CheckoutCallbackInfo" />.
		/// <seealso cref="CheckoutCallbackInfo" />
		/// <seealso cref="EcomInterface.GetTransactionCount" />
		/// <seealso cref="EcomInterface.CopyTransactionByIndex" />
		/// </summary>
		/// <param name="transaction">A handle to a transaction.</param>
		public void Release()
		{
			EOS_Ecom_Transaction_Release(InnerHandle);
		}

		[DllImport(Config.BinaryName)]
		private static extern void EOS_Ecom_Entitlement_Release(IntPtr entitlement);

		[DllImport(Config.BinaryName)]
		private static extern void EOS_Ecom_Transaction_Release(IntPtr transaction);

		[DllImport(Config.BinaryName)]
		private static extern Result EOS_Ecom_Transaction_CopyEntitlementByIndex(IntPtr handle, ref TransactionCopyEntitlementByIndexOptionsInternal options, ref IntPtr outEntitlement);

		[DllImport(Config.BinaryName)]
		private static extern uint EOS_Ecom_Transaction_GetEntitlementsCount(IntPtr handle, ref TransactionGetEntitlementsCountOptionsInternal options);

		[DllImport(Config.BinaryName)]
		private static extern Result EOS_Ecom_Transaction_GetTransactionId(IntPtr handle, System.Text.StringBuilder outBuffer, ref int inOutBufferLength);
	}
}