// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Stats
{
	/// <summary>
	/// Input parameters for the <see cref="StatsInterface.CopyStatByIndex" /> Function.
	/// </summary>
	public class CopyStatByIndexOptions
	{
		/// <summary>
		/// API Version of the <see cref="CopyStatByIndexOptions" /> function
		/// </summary>
		public int ApiVersion { get { return 1; } }

		/// <summary>
		/// The Account ID for the user who is copying the stat.
		/// </summary>
		public ProductUserId UserId { get; set; }

		/// <summary>
		/// Index of the stat to retrieve from the cache
		/// </summary>
		public uint StatIndex { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct CopyStatByIndexOptionsInternal : IDisposable
	{
		private int m_ApiVersion;
		private IntPtr m_UserId;
		private uint m_StatIndex;

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

		public ProductUserId UserId
		{
			get
			{
				var value = Helper.GetDefault<ProductUserId>();
				Helper.TryMarshalGet(m_UserId, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_UserId, value); }
		}

		public uint StatIndex
		{
			get
			{
				var value = Helper.GetDefault<uint>();
				Helper.TryMarshalGet(m_StatIndex, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_StatIndex, value); }
		}

		public void Dispose()
		{
		}
	}
}