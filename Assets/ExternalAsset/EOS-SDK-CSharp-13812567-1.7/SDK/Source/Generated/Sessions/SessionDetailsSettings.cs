// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Common settings associated with a single session
	/// </summary>
	public class SessionDetailsSettings
	{
		/// <summary>
		/// Version of the API
		/// </summary>
		public int ApiVersion { get { return 2; } }

		/// <summary>
		/// The main indexed parameter for this session, can be any string (ie "Region:GameMode")
		/// </summary>
		public string BucketId { get; set; }

		/// <summary>
		/// Number of total players allowed in the session
		/// </summary>
		public uint NumPublicConnections { get; set; }

		/// <summary>
		/// Are players allowed to join the session while it is in the "in progress" state
		/// </summary>
		public bool AllowJoinInProgress { get; set; }

		/// <summary>
		/// Permission level describing allowed access to the session when joining or searching for the session
		/// </summary>
		public OnlineSessionPermissionLevel PermissionLevel { get; set; }

		/// <summary>
		/// Are players allowed to send invites for the session
		/// </summary>
		public bool InvitesAllowed { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct SessionDetailsSettingsInternal : IDisposable
	{
		private int m_ApiVersion;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_BucketId;
		private uint m_NumPublicConnections;
		private int m_AllowJoinInProgress;
		private OnlineSessionPermissionLevel m_PermissionLevel;
		private int m_InvitesAllowed;

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

		public string BucketId
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_BucketId, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_BucketId, value); }
		}

		public uint NumPublicConnections
		{
			get
			{
				var value = Helper.GetDefault<uint>();
				Helper.TryMarshalGet(m_NumPublicConnections, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_NumPublicConnections, value); }
		}

		public bool AllowJoinInProgress
		{
			get
			{
				var value = Helper.GetDefault<bool>();
				Helper.TryMarshalGet(m_AllowJoinInProgress, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_AllowJoinInProgress, value); }
		}

		public OnlineSessionPermissionLevel PermissionLevel
		{
			get
			{
				var value = Helper.GetDefault<OnlineSessionPermissionLevel>();
				Helper.TryMarshalGet(m_PermissionLevel, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_PermissionLevel, value); }
		}

		public bool InvitesAllowed
		{
			get
			{
				var value = Helper.GetDefault<bool>();
				Helper.TryMarshalGet(m_InvitesAllowed, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_InvitesAllowed, value); }
		}

		public void Dispose()
		{
		}
	}
}