// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.P2P
{
	/// <summary>
	/// Structure containing information about new relay configurations.
	/// </summary>
	public class SetRelayControlOptions
	{
		/// <summary>
		/// API Version of the <see cref="SetRelayControlOptions" /> structure
		/// </summary>
		public int ApiVersion { get { return 1; } }

		/// <summary>
		/// The requested level of relay servers for P2P connections. This setting is only applied to new P2P connections, or when existing P2P connections
		/// reconnect during a temporary connectivity outage. Peers with an incompatible setting to the local setting will not be able to connnect.
		/// </summary>
		public RelayControl RelayControl { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct SetRelayControlOptionsInternal : IDisposable
	{
		private int m_ApiVersion;
		private RelayControl m_RelayControl;

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

		public RelayControl RelayControl
		{
			get
			{
				var value = Helper.GetDefault<RelayControl>();
				Helper.TryMarshalGet(m_RelayControl, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_RelayControl, value); }
		}

		public void Dispose()
		{
		}
	}
}