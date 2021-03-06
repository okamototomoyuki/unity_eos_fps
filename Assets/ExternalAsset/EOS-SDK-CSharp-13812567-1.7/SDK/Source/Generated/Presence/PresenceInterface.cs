// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Presence
{
	public sealed class PresenceInterface : Handle
	{
		public PresenceInterface() : base(IntPtr.Zero)
		{
		}

		public PresenceInterface(IntPtr innerHandle) : base(innerHandle)
		{
		}

		/// <summary>
		/// The maximum allowed length a user's rich text string may be. This value is subject to change and data structures should be designed to allow for greater numbers
		/// than this.
		/// </summary>
		public const int RichTextMaxValueLength = 255;

		/// <summary>
		/// The maximum allowed length a data's value may be. This value is subject to change and data structures should be designed to allow for greater numbers than this.
		/// </summary>
		public const int DataMaxValueLength = 255;

		/// <summary>
		/// The maximum allowed length a data's key may be. This value is subject to change and data structures should be designed to allow for greater numbers than this.
		/// </summary>
		public const int DataMaxKeyLength = 64;

		/// <summary>
		/// The maximum of allowed individual pieces of data a user may have. This value is subject to change and data structures should be designed to allow for greater
		/// numbers than this.
		/// </summary>
		public const int DataMaxKeys = 32;

		public const int PresencemodificationJoininfoMaxLength = DataMaxValueLength;

		/// <summary>
		/// Query a user's presence. This must complete successfully before CopyPresence will have valid results. If HasPresence returns true for a remote
		/// user, this does not need to be called.
		/// </summary>
		/// <param name="options">Object containing properties related to who is querying presence and for what user</param>
		/// <param name="clientData">Optional pointer to help track this request, that is returned in the completion callback</param>
		/// <param name="completionDelegate">Pointer to a function that handles receiving the completion information</param>
		public void QueryPresence(QueryPresenceOptions options, object clientData, OnQueryPresenceCompleteCallback completionDelegate)
		{
			var optionsInternal = Helper.CopyProperties<QueryPresenceOptionsInternal>(options);

			var completionDelegateInternal = new OnQueryPresenceCompleteCallbackInternal(OnQueryPresenceComplete);
			var clientDataAddress = IntPtr.Zero;
			Helper.AddCallback(ref clientDataAddress, clientData, completionDelegate, completionDelegateInternal);

			EOS_Presence_QueryPresence(InnerHandle, ref optionsInternal, clientDataAddress, completionDelegateInternal);
			Helper.TryMarshalDispose(ref optionsInternal);
		}

		/// <summary>
		/// Check if we already have presence for a user
		/// </summary>
		/// <param name="options">Object containing properties related to who is requesting presence and for what user</param>
		/// <returns>
		/// 1 if we have presence for the requested user, or 0 if the request was invalid or we do not have cached data
		/// </returns>
		public bool HasPresence(HasPresenceOptions options)
		{
			var optionsInternal = Helper.CopyProperties<HasPresenceOptionsInternal>(options);

			var funcResult = EOS_Presence_HasPresence(InnerHandle, ref optionsInternal);
			Helper.TryMarshalDispose(ref optionsInternal);

			var funcResultReturn = Helper.GetDefault<bool>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Get a user's cached presence object. If successful, this data must be released by calling <see cref="Release" />
		/// <seealso cref="Release" />
		/// </summary>
		/// <param name="options">Object containing properties related to who is requesting presence and for what user</param>
		/// <param name="outPresence">A pointer to a pointer of Presence Info. If the returned result is success, this will be set to data that must be later released, otherwise this will be set to NULL</param>
		/// <returns>
		/// Success if we have cached data, or an error result if the request was invalid or we do not have cached data.
		/// </returns>
		public Result CopyPresence(CopyPresenceOptions options, out Info outPresence)
		{
			var optionsInternal = Helper.CopyProperties<CopyPresenceOptionsInternal>(options);

			outPresence = Helper.GetDefault<Info>();

			var outPresenceAddress = IntPtr.Zero;

			var funcResult = EOS_Presence_CopyPresence(InnerHandle, ref optionsInternal, ref outPresenceAddress);
			Helper.TryMarshalDispose(ref optionsInternal);

			if (Helper.TryMarshalGet<InfoInternal, Info>(outPresenceAddress, out outPresence))
			{
				EOS_Presence_Info_Release(outPresenceAddress);
			}

			var funcResultReturn = Helper.GetDefault<Result>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Creates a presence modification handle. This handle can used to add multiple changes to your presence that can be applied with <see cref="SetPresence" />.
		/// The resulting handle must be released by calling <see cref="PresenceModification.Release" /> once it has been passed to <see cref="SetPresence" />.
		/// <seealso cref="PresenceModification.Release" />
		/// <seealso cref="SetPresence" />
		/// <seealso cref="PresenceModification.SetStatus" />
		/// <seealso cref="PresenceModification.SetRawRichText" />
		/// <seealso cref="PresenceModification.SetData" />
		/// <seealso cref="PresenceModification.DeleteData" />
		/// </summary>
		/// <param name="options">Object containing properties related to the user modifying their presence</param>
		/// <param name="outPresenceModificationHandle">Pointer to a Presence Modification Handle to be set if successful</param>
		/// <returns>
		/// Success if we successfully created the Presence Modification Handle pointed at in OutPresenceModificationHandle, or an error result if the input data was invalid
		/// </returns>
		public Result CreatePresenceModification(CreatePresenceModificationOptions options, out PresenceModification outPresenceModificationHandle)
		{
			var optionsInternal = Helper.CopyProperties<CreatePresenceModificationOptionsInternal>(options);

			outPresenceModificationHandle = Helper.GetDefault<PresenceModification>();

			var outPresenceModificationHandleAddress = IntPtr.Zero;

			var funcResult = EOS_Presence_CreatePresenceModification(InnerHandle, ref optionsInternal, ref outPresenceModificationHandleAddress);
			Helper.TryMarshalDispose(ref optionsInternal);

			Helper.TryMarshalGet(outPresenceModificationHandleAddress, out outPresenceModificationHandle);
			var funcResultReturn = Helper.GetDefault<Result>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Sets your new presence with the data applied to a PresenceModificationHandle. The PresenceModificationHandle can be released safely after calling this function.
		/// <seealso cref="CreatePresenceModification" />
		/// <seealso cref="PresenceModification.Release" />
		/// </summary>
		/// <param name="options">Object containing a PresenceModificationHandle and associated user data</param>
		/// <param name="clientData">Optional pointer to help track this request, that is returned in the completion callback</param>
		/// <param name="completionDelegate">Pointer to a function that handles receiving the completion information</param>
		public void SetPresence(SetPresenceOptions options, object clientData, SetPresenceCompleteCallback completionDelegate)
		{
			var optionsInternal = Helper.CopyProperties<SetPresenceOptionsInternal>(options);

			var completionDelegateInternal = new SetPresenceCompleteCallbackInternal(SetPresenceComplete);
			var clientDataAddress = IntPtr.Zero;
			Helper.AddCallback(ref clientDataAddress, clientData, completionDelegate, completionDelegateInternal);

			EOS_Presence_SetPresence(InnerHandle, ref optionsInternal, clientDataAddress, completionDelegateInternal);
			Helper.TryMarshalDispose(ref optionsInternal);
		}

		/// <summary>
		/// Register to receive notifications when presence changes. If the returned NotificationId is valid, you must call RemoveNotifyOnPresenceChanged when you no longer wish to
		/// have your NotificationHandler called
		/// <seealso cref="Common.InvalidNotificationid" />
		/// <seealso cref="RemoveNotifyOnPresenceChanged" />
		/// </summary>
		/// <param name="clientData">Data the is returned to when NotificationHandler is invoked</param>
		/// <param name="notificationHandler">The callback to be fired when a presence change occurs</param>
		/// <returns>
		/// Notification ID representing the registered callback if successful, an invalid NotificationId if not
		/// </returns>
		public ulong AddNotifyOnPresenceChanged(AddNotifyOnPresenceChangedOptions options, object clientData, OnPresenceChangedCallback notificationHandler)
		{
			var optionsInternal = Helper.CopyProperties<AddNotifyOnPresenceChangedOptionsInternal>(options);

			var notificationHandlerInternal = new OnPresenceChangedCallbackInternal(OnPresenceChanged);
			var clientDataAddress = IntPtr.Zero;
			Helper.AddCallback(ref clientDataAddress, clientData, notificationHandler, notificationHandlerInternal);

			var funcResult = EOS_Presence_AddNotifyOnPresenceChanged(InnerHandle, ref optionsInternal, clientDataAddress, notificationHandlerInternal);
			Helper.TryMarshalDispose(ref optionsInternal);

			Helper.TryAssignNotificationIdToCallback(clientDataAddress, funcResult);

			var funcResultReturn = Helper.GetDefault<ulong>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Unregister a previously bound notification handler from receiving presence update notifications
		/// </summary>
		/// <param name="notificationId">The Notification ID representing the registered callback</param>
		public void RemoveNotifyOnPresenceChanged(ulong notificationId)
		{
			Helper.TryRemoveCallbackByNotificationId(notificationId);
			EOS_Presence_RemoveNotifyOnPresenceChanged(InnerHandle, notificationId);
		}

		/// <summary>
		/// Register to receive notifications when a user accepts a join game option via the social overlay.
		/// @note must call RemoveNotifyJoinGameAccepted to remove the notification
		/// </summary>
		/// <param name="options">Structure containing information about the request.</param>
		/// <param name="clientData">Arbitrary data that is passed back to you in the CompletionDelegate.</param>
		/// <param name="notification">A callback that is fired when a a notification is received.</param>
		/// <returns>
		/// handle representing the registered callback
		/// </returns>
		public ulong AddNotifyJoinGameAccepted(AddNotifyJoinGameAcceptedOptions options, object clientData, OnJoinGameAcceptedCallback notificationFn)
		{
			var optionsInternal = Helper.CopyProperties<AddNotifyJoinGameAcceptedOptionsInternal>(options);

			var notificationFnInternal = new OnJoinGameAcceptedCallbackInternal(OnJoinGameAccepted);
			var clientDataAddress = IntPtr.Zero;
			Helper.AddCallback(ref clientDataAddress, clientData, notificationFn, notificationFnInternal);

			var funcResult = EOS_Presence_AddNotifyJoinGameAccepted(InnerHandle, ref optionsInternal, clientDataAddress, notificationFnInternal);
			Helper.TryMarshalDispose(ref optionsInternal);

			Helper.TryAssignNotificationIdToCallback(clientDataAddress, funcResult);

			var funcResultReturn = Helper.GetDefault<ulong>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		/// <summary>
		/// Unregister from receiving notifications when a user accepts a join game option via the social overlay.
		/// </summary>
		/// <param name="inId">Handle representing the registered callback</param>
		public void RemoveNotifyJoinGameAccepted(ulong inId)
		{
			Helper.TryRemoveCallbackByNotificationId(inId);
			EOS_Presence_RemoveNotifyJoinGameAccepted(InnerHandle, inId);
		}

		/// <summary>
		/// Gets a join info custom game-data string for a specific user. This is a helper function for reading the presence data related to how a user can be joined.
		/// Its meaning is entirely application dependent.
		/// 
		/// This value will be valid only after a QueryPresence call has successfully completed.
		/// <seealso cref="PresencemodificationJoininfoMaxLength" />
		/// </summary>
		/// <param name="options">Object containing an associated user</param>
		/// <param name="outBuffer">The buffer into which the character data should be written. The buffer must be long enough to hold a string of <see cref="PresencemodificationJoininfoMaxLength" />.</param>
		/// <param name="inOutBufferLength">
		/// Used as an input to define the OutBuffer length.
		/// The input buffer should include enough space to be null-terminated.
		/// When the function returns, this parameter will be filled with the length of the string copied into OutBuffer.
		/// </param>
		/// <returns>
		/// An <see cref="Result" /> that indicates whether the location string was copied into the OutBuffer.
		/// <see cref="Result.Success" /> if the information is available and passed out in OutBuffer
		/// <see cref="Result.InvalidParameters" /> if you pass a null pointer for the out parameter
		/// <see cref="Result.NotFound" /> if there is user or the location string was not found.
		/// <see cref="Result.LimitExceeded" /> - The OutBuffer is not large enough to receive the location string. InOutBufferLength contains the required minimum length to perform the operation successfully.
		/// </returns>
		public Result GetJoinInfo(GetJoinInfoOptions options, System.Text.StringBuilder outBuffer, ref int inOutBufferLength)
		{
			var optionsInternal = Helper.CopyProperties<GetJoinInfoOptionsInternal>(options);

			var funcResult = EOS_Presence_GetJoinInfo(InnerHandle, ref optionsInternal, outBuffer, ref inOutBufferLength);
			Helper.TryMarshalDispose(ref optionsInternal);

			var funcResultReturn = Helper.GetDefault<Result>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		[MonoPInvokeCallback]
		internal static void OnJoinGameAccepted(IntPtr address)
		{
			OnJoinGameAcceptedCallback callback = null;
			JoinGameAcceptedCallbackInfo callbackInfo = null;
			if (Helper.TryGetAndRemoveCallback<OnJoinGameAcceptedCallback, JoinGameAcceptedCallbackInfoInternal, JoinGameAcceptedCallbackInfo>(address, out callback, out callbackInfo))
			{
				callback(callbackInfo);
			}
		}

		[MonoPInvokeCallback]
		internal static void OnPresenceChanged(IntPtr address)
		{
			OnPresenceChangedCallback callback = null;
			PresenceChangedCallbackInfo callbackInfo = null;
			if (Helper.TryGetAndRemoveCallback<OnPresenceChangedCallback, PresenceChangedCallbackInfoInternal, PresenceChangedCallbackInfo>(address, out callback, out callbackInfo))
			{
				callback(callbackInfo);
			}
		}

		[MonoPInvokeCallback]
		internal static void SetPresenceComplete(IntPtr address)
		{
			SetPresenceCompleteCallback callback = null;
			SetPresenceCallbackInfo callbackInfo = null;
			if (Helper.TryGetAndRemoveCallback<SetPresenceCompleteCallback, SetPresenceCallbackInfoInternal, SetPresenceCallbackInfo>(address, out callback, out callbackInfo))
			{
				callback(callbackInfo);
			}
		}

		[MonoPInvokeCallback]
		internal static void OnQueryPresenceComplete(IntPtr address)
		{
			OnQueryPresenceCompleteCallback callback = null;
			QueryPresenceCallbackInfo callbackInfo = null;
			if (Helper.TryGetAndRemoveCallback<OnQueryPresenceCompleteCallback, QueryPresenceCallbackInfoInternal, QueryPresenceCallbackInfo>(address, out callback, out callbackInfo))
			{
				callback(callbackInfo);
			}
		}

		[DllImport(Config.BinaryName)]
		private static extern void EOS_Presence_Info_Release(IntPtr presenceInfo);

		[DllImport(Config.BinaryName)]
		private static extern Result EOS_Presence_GetJoinInfo(IntPtr handle, ref GetJoinInfoOptionsInternal options, System.Text.StringBuilder outBuffer, ref int inOutBufferLength);

		[DllImport(Config.BinaryName)]
		private static extern void EOS_Presence_RemoveNotifyJoinGameAccepted(IntPtr handle, ulong inId);

		[DllImport(Config.BinaryName)]
		private static extern ulong EOS_Presence_AddNotifyJoinGameAccepted(IntPtr handle, ref AddNotifyJoinGameAcceptedOptionsInternal options, IntPtr clientData, OnJoinGameAcceptedCallbackInternal notificationFn);

		[DllImport(Config.BinaryName)]
		private static extern void EOS_Presence_RemoveNotifyOnPresenceChanged(IntPtr handle, ulong notificationId);

		[DllImport(Config.BinaryName)]
		private static extern ulong EOS_Presence_AddNotifyOnPresenceChanged(IntPtr handle, ref AddNotifyOnPresenceChangedOptionsInternal options, IntPtr clientData, OnPresenceChangedCallbackInternal notificationHandler);

		[DllImport(Config.BinaryName)]
		private static extern void EOS_Presence_SetPresence(IntPtr handle, ref SetPresenceOptionsInternal options, IntPtr clientData, SetPresenceCompleteCallbackInternal completionDelegate);

		[DllImport(Config.BinaryName)]
		private static extern Result EOS_Presence_CreatePresenceModification(IntPtr handle, ref CreatePresenceModificationOptionsInternal options, ref IntPtr outPresenceModificationHandle);

		[DllImport(Config.BinaryName)]
		private static extern Result EOS_Presence_CopyPresence(IntPtr handle, ref CopyPresenceOptionsInternal options, ref IntPtr outPresence);

		[DllImport(Config.BinaryName)]
		private static extern int EOS_Presence_HasPresence(IntPtr handle, ref HasPresenceOptionsInternal options);

		[DllImport(Config.BinaryName)]
		private static extern void EOS_Presence_QueryPresence(IntPtr handle, ref QueryPresenceOptionsInternal options, IntPtr clientData, OnQueryPresenceCompleteCallbackInternal completionDelegate);
	}
}