// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.UI
{
	/// <summary>
	/// Input parameters for the <see cref="UIInterface.AcknowledgeEventId" />.
	/// </summary>
	public class AcknowledgeEventIdOptions
	{
		/// <summary>
		/// API version of <see cref="UIInterface.AcknowledgeEventId" />.
		/// </summary>
		public int ApiVersion { get { return 1; } }

		/// <summary>
		/// The ID being acknowledged.
		/// </summary>
		public ulong UiEventId { get; set; }

		/// <summary>
		/// The result to use for the acknowledgment.
		/// When acknowledging <see cref="Presence.JoinGameAcceptedCallbackInfo" /> this should be the
		/// result code from the JoinSession call.
		/// </summary>
		public Result Result { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct AcknowledgeEventIdOptionsInternal : IDisposable
	{
		private int m_ApiVersion;
		private ulong m_UiEventId;
		private Result m_Result;

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

		public ulong UiEventId
		{
			get
			{
				var value = Helper.GetDefault<ulong>();
				Helper.TryMarshalGet(m_UiEventId, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_UiEventId, value); }
		}

		public Result Result
		{
			get
			{
				var value = Helper.GetDefault<Result>();
				Helper.TryMarshalGet(m_Result, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_Result, value); }
		}

		public void Dispose()
		{
		}
	}
}