// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Presence
{
	/// <summary>
	/// Data for the <see cref="PresenceModificationSetRawRichTextOptions" /> function.
	/// </summary>
	public class PresenceModificationSetRawRichTextOptions
	{
		/// <summary>
		/// API Version of the <see cref="PresenceModificationSetRawRichTextOptions" /> function
		/// </summary>
		public int ApiVersion { get { return 1; } }

		/// <summary>
		/// The status of the user
		/// </summary>
		public string RichText { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct PresenceModificationSetRawRichTextOptionsInternal : IDisposable
	{
		private int m_ApiVersion;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_RichText;

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

		public string RichText
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_RichText, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_RichText, value); }
		}

		public void Dispose()
		{
		}
	}
}