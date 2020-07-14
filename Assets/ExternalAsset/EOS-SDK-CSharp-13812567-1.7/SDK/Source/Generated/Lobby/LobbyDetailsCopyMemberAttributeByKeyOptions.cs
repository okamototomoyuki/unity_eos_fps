// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Input parameters for the <see cref="LobbyDetails.CopyMemberAttributeByKey" /> Function.
	/// </summary>
	public class LobbyDetailsCopyMemberAttributeByKeyOptions
	{
		/// <summary>
		/// Version of the API
		/// </summary>
		public int ApiVersion { get { return 1; } }

		/// <summary>
		/// Lobby member of interest
		/// </summary>
		public ProductUserId TargetUserId { get; set; }

		/// <summary>
		/// Name of the attribute
		/// </summary>
		public string AttrKey { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct LobbyDetailsCopyMemberAttributeByKeyOptionsInternal : IDisposable
	{
		private int m_ApiVersion;
		private IntPtr m_TargetUserId;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_AttrKey;

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

		public ProductUserId TargetUserId
		{
			get
			{
				var value = Helper.GetDefault<ProductUserId>();
				Helper.TryMarshalGet(m_TargetUserId, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_TargetUserId, value); }
		}

		public string AttrKey
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_AttrKey, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_AttrKey, value); }
		}

		public void Dispose()
		{
		}
	}
}