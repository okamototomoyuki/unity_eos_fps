// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Auth
{
	/// <summary>
	/// Input parameters for the <see cref="AuthInterface.CopyUserAuthToken" /> Function.
	/// </summary>
	public class CopyUserAuthTokenOptions
	{
		/// <summary>
		/// Version of the API to use
		/// </summary>
		public int ApiVersion { get { return 1; } }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct CopyUserAuthTokenOptionsInternal : IDisposable
	{
		private int m_ApiVersion;

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

		public void Dispose()
		{
		}
	}
}