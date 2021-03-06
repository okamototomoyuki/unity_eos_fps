// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.PlayerDataStorage
{
	/// <summary>
	/// Callback for when <see cref="PlayerDataStorageInterface.WriteFile" /> completes
	/// </summary>
	public delegate void OnWriteFileCompleteCallback(WriteFileCallbackInfo data);

	internal delegate void OnWriteFileCompleteCallbackInternal(IntPtr messagePtr);
}