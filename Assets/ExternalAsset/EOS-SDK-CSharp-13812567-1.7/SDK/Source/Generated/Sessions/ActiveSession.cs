// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Sessions
{
	public sealed class ActiveSession : Handle
	{
		public ActiveSession() : base(IntPtr.Zero)
		{
		}

		public ActiveSession(IntPtr innerHandle) : base(innerHandle)
		{
		}

		/// <summary>
		/// <see cref="CopyInfo" /> is used to immediately retrieve a copy of active session information
		/// If the call returns an <see cref="Result.Success" /> result, the out parameter, OutActiveSessionInfo, must be passed to <see cref="Release" /> to release the memory associated with it.
		/// <seealso cref="ActiveSessionInfo" />
		/// <seealso cref="ActiveSessionCopyInfoOptions" />
		/// <seealso cref="Release" />
		/// </summary>
		/// <param name="options">Structure containing the input parameters</param>
		/// <param name="outActiveSessionInfo">Out parameter used to receive the <see cref="ActiveSessionInfo" /> structure.</param>
		/// <returns>
		/// <see cref="Result.Success" /> if the information is available and passed out in OutActiveSessionInfo
		/// <see cref="Result.InvalidParameters" /> if you pass a null pointer for the out parameter
		/// <see cref="Result.IncompatibleVersion" /> if the API version passed in is incorrect
		/// </returns>
		public Result CopyInfo(ActiveSessionCopyInfoOptions options, out ActiveSessionInfo outActiveSessionInfo)
		{
			var optionsInternal = Helper.CopyProperties<ActiveSessionCopyInfoOptionsInternal>(options);

			outActiveSessionInfo = Helper.GetDefault<ActiveSessionInfo>();

			var outActiveSessionInfoAddress = IntPtr.Zero;

			var funcResult = EOS_ActiveSession_CopyInfo(InnerHandle, ref optionsInternal, ref outActiveSessionInfoAddress);
			Helper.TryMarshalDispose(ref optionsInternal);

			if (Helper.TryMarshalGet<ActiveSessionInfoInternal, ActiveSessionInfo>(outActiveSessionInfoAddress, out outActiveSessionInfo))
			{
				EOS_ActiveSession_Info_Release(outActiveSessionInfoAddress);
			}

			var funcResultReturn = Helper.GetDefault<Result>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Get the number of registered players associated with this active session
		/// </summary>
		/// <param name="options">the Options associated with retrieving the registered player count</param>
		/// <returns>
		/// number of registered players in the active session or 0 if there is an error
		/// </returns>
		public uint GetRegisteredPlayerCount(ActiveSessionGetRegisteredPlayerCountOptions options)
		{
			var optionsInternal = Helper.CopyProperties<ActiveSessionGetRegisteredPlayerCountOptionsInternal>(options);

			var funcResult = EOS_ActiveSession_GetRegisteredPlayerCount(InnerHandle, ref optionsInternal);
			Helper.TryMarshalDispose(ref optionsInternal);

			var funcResultReturn = Helper.GetDefault<uint>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// <see cref="GetRegisteredPlayerByIndex" /> is used to immediately retrieve individual players registered with the active session.
		/// <seealso cref="GetRegisteredPlayerCount" />
		/// <seealso cref="ActiveSessionGetRegisteredPlayerByIndexOptions" />
		/// </summary>
		/// <param name="options">Structure containing the input parameters</param>
		/// <returns>
		/// the product user id for the registered player at a given index or null if that index is invalid
		/// </returns>
		public ProductUserId GetRegisteredPlayerByIndex(ActiveSessionGetRegisteredPlayerByIndexOptions options)
		{
			var optionsInternal = Helper.CopyProperties<ActiveSessionGetRegisteredPlayerByIndexOptionsInternal>(options);

			var funcResult = EOS_ActiveSession_GetRegisteredPlayerByIndex(InnerHandle, ref optionsInternal);
			Helper.TryMarshalDispose(ref optionsInternal);

			var funcResultReturn = Helper.GetDefault<ProductUserId>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Release the memory associated with an active session.
		/// This must be called on data retrieved from <see cref="SessionsInterface.CopyActiveSessionHandle" />
		/// <seealso cref="SessionsInterface.CopyActiveSessionHandle" />
		/// </summary>
		/// <param name="activeSessionHandle">- The active session handle to release</param>
		public void Release()
		{
			EOS_ActiveSession_Release(InnerHandle);
		}

		[DllImport(Config.BinaryName)]
		private static extern void EOS_ActiveSession_Info_Release(IntPtr activeSessionInfo);

		[DllImport(Config.BinaryName)]
		private static extern void EOS_ActiveSession_Release(IntPtr activeSessionHandle);

		[DllImport(Config.BinaryName)]
		private static extern IntPtr EOS_ActiveSession_GetRegisteredPlayerByIndex(IntPtr handle, ref ActiveSessionGetRegisteredPlayerByIndexOptionsInternal options);

		[DllImport(Config.BinaryName)]
		private static extern uint EOS_ActiveSession_GetRegisteredPlayerCount(IntPtr handle, ref ActiveSessionGetRegisteredPlayerCountOptionsInternal options);

		[DllImport(Config.BinaryName)]
		private static extern Result EOS_ActiveSession_CopyInfo(IntPtr handle, ref ActiveSessionCopyInfoOptionsInternal options, ref IntPtr outActiveSessionInfo);
	}
}