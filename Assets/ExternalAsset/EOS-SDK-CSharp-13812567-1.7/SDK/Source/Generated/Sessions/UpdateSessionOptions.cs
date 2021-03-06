// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Sessions
{
	public class UpdateSessionOptions
	{
		/// <summary>
		/// Version of the API
		/// </summary>
		public int ApiVersion { get { return 1; } }

		/// <summary>
		/// Builder handle
		/// </summary>
		public SessionModification SessionModificationHandle { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct UpdateSessionOptionsInternal : IDisposable
	{
		private int m_ApiVersion;
		private IntPtr m_SessionModificationHandle;

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

		public SessionModification SessionModificationHandle
		{
			get
			{
				var value = Helper.GetDefault<SessionModification>();
				Helper.TryMarshalGet(m_SessionModificationHandle, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_SessionModificationHandle, value); }
		}

		public void Dispose()
		{
		}
	}
}