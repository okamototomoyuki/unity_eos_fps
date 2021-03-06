// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Achievements
{
	/// <summary>
	/// Contains information about a collection of stat info data.
	/// <seealso cref="PlayerAchievement" />
	/// </summary>
	public class PlayerStatInfo
	{
		/// <summary>
		/// API Version for the <see cref="PlayerStatInfo" /> struct
		/// </summary>
		public int ApiVersion { get { return 1; } }

		/// <summary>
		/// The name of the stat.
		/// </summary>
		public string Name { get; set; }

		/// <summary>
		/// The current value of the stat.
		/// </summary>
		public int CurrentValue { get; set; }

		/// <summary>
		/// The threshold value of the stat.
		/// </summary>
		public int ThresholdValue { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct PlayerStatInfoInternal : IDisposable
	{
		private int m_ApiVersion;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_Name;
		private int m_CurrentValue;
		private int m_ThresholdValue;

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

		public string Name
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_Name, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_Name, value); }
		}

		public int CurrentValue
		{
			get
			{
				var value = Helper.GetDefault<int>();
				Helper.TryMarshalGet(m_CurrentValue, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_CurrentValue, value); }
		}

		public int ThresholdValue
		{
			get
			{
				var value = Helper.GetDefault<int>();
				Helper.TryMarshalGet(m_ThresholdValue, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_ThresholdValue, value); }
		}

		public void Dispose()
		{
		}
	}
}