// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices
{
	public sealed class ByteArray : Handle
	{
		public ByteArray() : base(IntPtr.Zero)
		{
		}

		public ByteArray(IntPtr innerHandle) : base(innerHandle)
		{
		}

		/// <summary>
		/// Encode a byte array into hex encoded string
		/// </summary>
		/// <returns>
		/// An <see cref="Result" /> that indicates whether the byte array was converted and copied into the OutBuffer.
		/// <see cref="Result.Success" /> if the encoding was successful and passed out in OutBuffer
		/// <see cref="Result.InvalidParameters" /> if you pass a null pointer on invalid length for any of the parameters
		/// <see cref="Result.LimitExceeded" /> - The OutBuffer is not large enough to receive the encoding. InOutBufferLength contains the required minimum length to perform the operation successfully.
		/// </returns>
		public static Result ToString(byte byteArray, uint length, System.Text.StringBuilder outBuffer, ref uint inOutBufferLength)
		{
			var funcResult = EOS_ByteArray_ToString(ref byteArray, length, outBuffer, ref inOutBufferLength);
			var funcResultReturn = Helper.GetDefault<Result>();
			Helper.TryMarshalGet(funcResult, out funcResultReturn);
			return funcResultReturn;
		}

		[DllImport(Config.BinaryName)]
		private static extern Result EOS_ByteArray_ToString(ref byte byteArray, uint length, System.Text.StringBuilder outBuffer, ref uint inOutBufferLength);
	}
}