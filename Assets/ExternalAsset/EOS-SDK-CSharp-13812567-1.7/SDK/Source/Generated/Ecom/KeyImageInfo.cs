// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Ecom
{
	/// <summary>
	/// Contains information about a key image used by the catalog. Instances of this structure are
	/// created by <see cref="EcomInterface.CopyItemImageInfoByIndex" />. They must be passed to <see cref="EcomInterface.Release" />.
	/// A Key Image is defined within Dev Portal and is associated with a Catalog Item. A Key Image is
	/// intended to be used to provide imagery for an in-game store.
	/// <seealso cref="EcomInterface.CopyItemImageInfoByIndex" />
	/// <seealso cref="EcomInterface.Release" />
	/// </summary>
	public class KeyImageInfo
	{
		/// <summary>
		/// Version of the API
		/// </summary>
		public int ApiVersion { get { return 1; } }

		/// <summary>
		/// Describes the usage of the image (ex: home_thumbnail)
		/// </summary>
		public string Type { get; set; }

		/// <summary>
		/// The URL of the image
		/// </summary>
		public string Url { get; set; }

		/// <summary>
		/// The expected width in pixels of the image
		/// </summary>
		public uint Width { get; set; }

		/// <summary>
		/// The expected height in pixels of the image
		/// </summary>
		public uint Height { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct KeyImageInfoInternal : IDisposable
	{
		private int m_ApiVersion;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_Type;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_Url;
		private uint m_Width;
		private uint m_Height;

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

		public string Type
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_Type, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_Type, value); }
		}

		public string Url
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_Url, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_Url, value); }
		}

		public uint Width
		{
			get
			{
				var value = Helper.GetDefault<uint>();
				Helper.TryMarshalGet(m_Width, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_Width, value); }
		}

		public uint Height
		{
			get
			{
				var value = Helper.GetDefault<uint>();
				Helper.TryMarshalGet(m_Height, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_Height, value); }
		}

		public void Dispose()
		{
		}
	}
}