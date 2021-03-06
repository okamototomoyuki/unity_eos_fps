// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="SessionModification.SetMaxPlayers" /> Function.
	/// </summary>
	public class SessionModificationSetMaxPlayersOptions
	{
		/// <summary>
		/// Version of the API
		/// </summary>
		public int ApiVersion { get { return 1; } }

		/// <summary>
		/// Max number of players to allow in the session
		/// </summary>
		public uint MaxPlayers { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct SessionModificationSetMaxPlayersOptionsInternal : IDisposable
	{
		private int m_ApiVersion;
		private uint m_MaxPlayers;

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

		public uint MaxPlayers
		{
			get
			{
				var value = Helper.GetDefault<uint>();
				Helper.TryMarshalGet(m_MaxPlayers, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_MaxPlayers, value); }
		}

		public void Dispose()
		{
		}
	}
}