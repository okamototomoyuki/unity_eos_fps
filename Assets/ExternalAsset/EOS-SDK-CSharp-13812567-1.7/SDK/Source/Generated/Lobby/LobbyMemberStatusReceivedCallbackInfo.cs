// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Output parameters for the <see cref="LobbyInterface.AddNotifyLobbyMemberStatusReceived" /> function.
	/// </summary>
	public class LobbyMemberStatusReceivedCallbackInfo
	{
		/// <summary>
		/// Context that was passed into <see cref="LobbyInterface.AddNotifyLobbyMemberStatusReceived" />
		/// </summary>
		public object ClientData { get; set; }

		/// <summary>
		/// The id of the lobby affected
		/// </summary>
		public string LobbyId { get; set; }

		/// <summary>
		/// Target user that was affected
		/// </summary>
		public ProductUserId TargetUserId { get; set; }

		/// <summary>
		/// Latest status of the user
		/// </summary>
		public LobbyMemberStatus CurrentStatus { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct LobbyMemberStatusReceivedCallbackInfoInternal : ICallbackInfo
	{
		private IntPtr m_ClientData;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_LobbyId;
		private IntPtr m_TargetUserId;
		private LobbyMemberStatus m_CurrentStatus;

		public object ClientData
		{
			get
			{
				var value = Helper.GetDefault<object>();
				Helper.TryMarshalGet(m_ClientData, out value);
				return value;
			}
		}

		public IntPtr ClientDataAddress { get { return m_ClientData; } }

		public string LobbyId
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_LobbyId, out value);
				return value;
			}
		}

		public ProductUserId TargetUserId
		{
			get
			{
				var value = Helper.GetDefault<ProductUserId>();
				Helper.TryMarshalGet(m_TargetUserId, out value);
				return value;
			}
		}

		public LobbyMemberStatus CurrentStatus
		{
			get
			{
				var value = Helper.GetDefault<LobbyMemberStatus>();
				Helper.TryMarshalGet(m_CurrentStatus, out value);
				return value;
			}
		}
	}
}