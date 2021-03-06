// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Connect
{
	/// <summary>
	/// List of the supported identity providers to authenticate a user.
	/// 
	/// The type of authentication token is specific to each provider.
	/// Tokens in string format should be passed as-is to the function,
	/// and tokens retrieved as raw byte arrays should be converted to string using
	/// the <see cref="ByteArray.ToString" /> API before passing them to the Connect Interface API.
	/// <seealso cref="ConnectInterface.Login" />
	/// <seealso cref="Credentials" />
	/// </summary>
	public enum ExternalCredentialType
	{
		/// <summary>
		/// Epic Games User Token
		/// 
		/// Acquired using <see cref="Auth.AuthInterface.CopyUserAuthToken" /> that returns <see cref="Auth.Token" />::AccessToken
		/// </summary>
		Epic = 0,
		/// <summary>
		/// Steam Encrypted App Ticket
		/// 
		/// Generated using the ISteamUser::RequestEncryptedAppTicket API of Steamworks SDK.
		/// As the ticket generation parameters, use pDataToInclude(NULL) and cbDataToInclude(0).
		/// 
		/// Use the <see cref="ByteArray.ToString" /> API to pass the retrieved ticket buffer as a hex-encoded string for the <see cref="ConnectInterface.Login" /> API.
		/// </summary>
		SteamAppTicket = 1,
		/// <summary>
		/// Playstation ID Token
		/// 
		/// Retrieved from the Playstation SDK. Please see first-party documentation for additional information.
		/// </summary>
		PsnIdToken = 2,
		/// <summary>
		/// Xbox Live User's XSTS Token
		/// 
		/// Retrieved from the Xbox One XDK. Please see first-party documentation for additional information.
		/// </summary>
		XblXstsToken = 3,
		/// <summary>
		/// Discord Access Token
		/// </summary>
		DiscordAccessToken = 4,
		/// <summary>
		/// GOG Galaxy Encrypted Session Ticket
		/// </summary>
		GogSessionTicket = 5,
		/// <summary>
		/// Nintendo Account ID Token
		/// 
		/// This token identifies the user's Nintendo account and is acquired using web flow authentication.
		/// On Nintendo Switch, the first time login requires the user to authenticate using their Nintendo account,
		/// after which the login is automatic and uses the primary authentication method with NSA ID Token.
		/// </summary>
		NintendoIdToken = 6,
		/// <summary>
		/// Nintendo Service Account ID Token
		/// 
		/// This is the device specific authentication token that is first used on login and will be linked with a Nintendo user account.
		/// </summary>
		NintendoNsaIdToken = 7,
		/// <summary>
		/// Uplay Access Token
		/// </summary>
		UplayAccessToken = 8,
		/// <summary>
		/// OpenID Provider Access Token
		/// </summary>
		OpenidAccessToken = 9,
		/// <summary>
		/// Device ID access token that identifies the current locally logged in user profile on the local device.
		/// The local user profile here refers to the operating system user login, for example the user's Windows Account
		/// or on a mobile device the default active user profile.
		/// 
		/// This credential type is used to automatically login the local user using the EOS Connect Device ID feature.
		/// 
		/// The intended use of the Device ID feature is to allow automatically logging in the user on a mobile device
		/// and to allow playing the game without requiring the user to necessarily login using a real user account at all.
		/// This makes a seamless first-time experience possible and allows linking the local device with a real external
		/// user account at a later time, sharing the same <see cref="ProductUserId" /> that is being used with the Device ID feature.
		/// <seealso cref="ConnectInterface.CreateDeviceId" />
		/// </summary>
		DeviceidAccessToken = 10,
		/// <summary>
		/// Apple Identity Token
		/// </summary>
		AppleIdToken = 11
	}
}