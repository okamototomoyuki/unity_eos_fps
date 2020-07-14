// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Auth
{
	/// <summary>
	/// Function prototype definition for callbacks passed to <see cref="AuthInterface.Login" />
	/// </summary>
	/// <param name="data">A <see cref="LoginCallbackInfo" /> containing the output information and result</param>
	public delegate void OnLoginCallback(LoginCallbackInfo data);

	internal delegate void OnLoginCallbackInternal(IntPtr messagePtr);
}