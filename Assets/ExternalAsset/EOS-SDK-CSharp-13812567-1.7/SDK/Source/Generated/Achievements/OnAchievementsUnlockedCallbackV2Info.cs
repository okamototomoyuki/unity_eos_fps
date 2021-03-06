// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Achievements
{
	/// <summary>
	/// Output parameters for the <see cref="OnAchievementsUnlockedCallbackV2" /> Function.
	/// </summary>
	public class OnAchievementsUnlockedCallbackV2Info
	{
		/// <summary>
		/// Context that was passed into <see cref="AchievementsInterface.AddNotifyAchievementsUnlocked" />
		/// </summary>
		public object ClientData { get; set; }

		/// <summary>
		/// Account ID for user that received the unlocked achievements notification
		/// </summary>
		public ProductUserId UserId { get; set; }

		/// <summary>
		/// Achievement ID for the achievement that was unlocked. Can be passed to <see cref="AchievementsInterface.CopyPlayerAchievementByAchievementId" /> to get full information for the achievement.
		/// </summary>
		public string AchievementId { get; set; }

		/// <summary>
		/// POSIX timestamp when the achievement was unlocked
		/// </summary>
		public DateTimeOffset? UnlockTime { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct OnAchievementsUnlockedCallbackV2InfoInternal : ICallbackInfo
	{
		private IntPtr m_ClientData;
		private IntPtr m_UserId;
		[MarshalAs(UnmanagedType.LPStr)]
		private string m_AchievementId;
		private long m_UnlockTime;

		public object ClientData
		{
			get
			{
				var value = Helper.GetDefault<object>();
				Helper.TryMarshalGet(m_ClientData, out value);
				return value;
			}
		}

		public IntPtr ClientDataAddress { get { return m_ClientData; } }

		public ProductUserId UserId
		{
			get
			{
				var value = Helper.GetDefault<ProductUserId>();
				Helper.TryMarshalGet(m_UserId, out value);
				return value;
			}
		}

		public string AchievementId
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_AchievementId, out value);
				return value;
			}
		}

		public DateTimeOffset? UnlockTime
		{
			get
			{
				var value = Helper.GetDefault<DateTimeOffset?>();
				Helper.TryMarshalGet(m_UnlockTime, out value);
				return value;
			}
		}
	}
}