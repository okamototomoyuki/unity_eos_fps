// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Metrics
{
	public sealed class MetricsInterface : Handle
	{
		public MetricsInterface() : base(IntPtr.Zero)
		{
		}

		public MetricsInterface(IntPtr innerHandle) : base(innerHandle)
		{
		}

		/// <summary>
		/// Logs the start of a new game session for a local player.
		/// 
		/// The game client should call this function whenever it joins into a new multiplayer, peer-to-peer or single player game session.
		/// Each call to BeginPlayerSession must be matched with a corresponding call to EndPlayerSession.
		/// </summary>
		/// <param name="options">Structure containing the local player's game account and the game session information.</param>
		/// <returns>
		/// Returns <see cref="Result.Success" /> on success, or an error code if the input parameters are invalid or an active session for the player already exists.
		/// </returns>
		public Result BeginPlayerSession(BeginPlayerSessionOptions options)
		{
			var optionsInternal = Helper.CopyProperties<BeginPlayerSessionOptionsInternal>(options);

			var funcResult = EOS_Metrics_BeginPlayerSession(InnerHandle, ref optionsInternal);
			Helper.TryMarshalDispose(ref optionsInternal);

			var funcResultReturn = Helper.GetDefault<Result>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Logs the end of a game session for a local player.
		/// 
		/// Call once when the game client leaves the active game session.
		/// Each call to BeginPlayerSession must be matched with a corresponding call to EndPlayerSession.
		/// </summary>
		/// <param name="options">Structure containing the account id of the player whose session to end.</param>
		/// <returns>
		/// Returns <see cref="Result.Success" /> on success, or an error code if the input parameters are invalid or there was no active session for the player.
		/// </returns>
		public Result EndPlayerSession(EndPlayerSessionOptions options)
		{
			var optionsInternal = Helper.CopyProperties<EndPlayerSessionOptionsInternal>(options);

			var funcResult = EOS_Metrics_EndPlayerSession(InnerHandle, ref optionsInternal);
			Helper.TryMarshalDispose(ref optionsInternal);

			var funcResultReturn = Helper.GetDefault<Result>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		[DllImport(Config.BinaryName)]
		private static extern Result EOS_Metrics_EndPlayerSession(IntPtr handle, ref EndPlayerSessionOptionsInternal options);

		[DllImport(Config.BinaryName)]
		private static extern Result EOS_Metrics_BeginPlayerSession(IntPtr handle, ref BeginPlayerSessionOptionsInternal options);
	}
}