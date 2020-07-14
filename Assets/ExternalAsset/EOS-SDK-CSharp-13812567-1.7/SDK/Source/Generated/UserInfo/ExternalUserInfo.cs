// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.UserInfo
{
	/// <summary>
	/// Contains information about a single external user info.
	/// </summary>
	public class ExternalUserInfo
	{
		/// <summary>
		/// Version of the API.
		/// </summary>
		public int ApiVersion { get { return 1; } }

		/// <summary>
		/// The type of the external account
		/// </summary>
		public ExternalAccountType AccountType { get; set; }

		/// <summary>
		/// The id of the external account. Can be null
		/// </summary>
		public string AccountId { get; set; }

		/// <summary>
		/// The display name of the external account. Can be null
		/// </summary>
		public string DisplayName { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct ExternalUserInfoInternal : IDisposable
	{
		private int m_ApiVersion;
		private ExternalAccountType m_AccountType;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_AccountId;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_DisplayName;

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

		public ExternalAccountType AccountType
		{
			get
			{
				var value = Helper.GetDefault<ExternalAccountType>();
				Helper.TryMarshalGet(m_AccountType, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_AccountType, value); }
		}

		public string AccountId
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_AccountId, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_AccountId, value); }
		}

		public string DisplayName
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_DisplayName, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_DisplayName, value); }
		}

		public void Dispose()
		{
		}
	}
}