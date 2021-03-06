// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="SessionsInterface.RejectInvite" /> Function.
	/// </summary>
	public class RejectInviteOptions
	{
		/// <summary>
		/// Version of the API
		/// </summary>
		public int ApiVersion { get { return 1; } }

		/// <summary>
		/// The local user rejecting the invite
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// The invite id to reject
		/// </summary>
		public string InviteId { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct RejectInviteOptionsInternal : IDisposable
	{
		private int m_ApiVersion;
		private IntPtr m_LocalUserId;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_InviteId;

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

		public ProductUserId LocalUserId
		{
			get
			{
				var value = Helper.GetDefault<ProductUserId>();
				Helper.TryMarshalGet(m_LocalUserId, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_LocalUserId, value); }
		}

		public string InviteId
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_InviteId, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_InviteId, value); }
		}

		public void Dispose()
		{
		}
	}
}