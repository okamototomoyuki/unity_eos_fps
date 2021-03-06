// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Presence
{
	/// <summary>
	/// Callback for information related to <see cref="PresenceInterface.SetPresence" /> finishing.
	/// </summary>
	public delegate void SetPresenceCompleteCallback(SetPresenceCallbackInfo data);

	internal delegate void SetPresenceCompleteCallbackInternal(IntPtr messagePtr);
}