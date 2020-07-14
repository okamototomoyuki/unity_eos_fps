// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Ecom
{
	/// <summary>
	/// Input parameters for the <see cref="EcomInterface.GetOfferItemCount" /> Function.
	/// </summary>
	public class GetOfferItemCountOptions
	{
		/// <summary>
		/// Version of the API
		/// </summary>
		public int ApiVersion { get { return 1; } }

		/// <summary>
		/// Local user whose items is being accessed
		/// </summary>
		public EpicAccountId LocalUserId { get; set; }

		/// <summary>
		/// The ID of the offer to get the items for.
		/// </summary>
		public string OfferId { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct GetOfferItemCountOptionsInternal : IDisposable
	{
		private int m_ApiVersion;
		private IntPtr m_LocalUserId;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_OfferId;

		public int ApiVersion
		{
			get
			{
				var value = Helper.GetDefault<int>();
				Helper.TryMarshalGet(m_ApiVersion, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_ApiVersion, value); }
		}

		public EpicAccountId LocalUserId
		{
			get
			{
				var value = Helper.GetDefault<EpicAccountId>();
				Helper.TryMarshalGet(m_LocalUserId, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_LocalUserId, value); }
		}

		public string OfferId
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_OfferId, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_OfferId, value); }
		}

		public void Dispose()
		{
		}
	}
}