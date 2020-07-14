// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Achievements
{
	/// <summary>
	/// Input parameters for the <see cref="AchievementsInterface.CopyAchievementDefinitionV2ByAchievementId" /> Function.
	/// </summary>
	public class CopyAchievementDefinitionV2ByAchievementIdOptions
	{
		/// <summary>
		/// API Version of the <see cref="CopyAchievementDefinitionV2ByAchievementIdOptions" /> function
		/// </summary>
		public int ApiVersion { get { return 2; } }

		/// <summary>
		/// Achievement ID to look for when copying definition from the cache
		/// </summary>
		public string AchievementId { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct CopyAchievementDefinitionV2ByAchievementIdOptionsInternal : IDisposable
	{
		private int m_ApiVersion;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_AchievementId;

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

		public string AchievementId
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_AchievementId, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_AchievementId, value); }
		}

		public void Dispose()
		{
		}
	}
}