// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Lobby
{
	/// <summary>
	/// Output parameters for the <see cref="LobbyInterface.SendInvite" /> function.
	/// </summary>
	public class SendInviteCallbackInfo
	{
		/// <summary>
		/// Result code for the operation. <see cref="Result.Success" /> is returned for a successful operation, otherwise one of the error codes is returned. See <see cref="Common" />
		/// </summary>
		public Result ResultCode { get; set; }

		/// <summary>
		/// Context that was passed into <see cref="LobbyInterface.SendInvite" />
		/// </summary>
		public object ClientData { get; set; }

		/// <summary>
		/// The id of the lobby affected
		/// </summary>
		public string LobbyId { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct SendInviteCallbackInfoInternal : ICallbackInfo
	{
		private Result m_ResultCode;
		private IntPtr m_ClientData;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_LobbyId;

		public Result ResultCode
		{
			get
			{
				var value = Helper.GetDefault<Result>();
				Helper.TryMarshalGet(m_ResultCode, out value);
				return value;
			}
		}

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
	}
}