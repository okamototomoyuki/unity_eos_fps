// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.PlayerDataStorage
{
	/// <summary>
	/// Data containing information about a query file list request
	/// </summary>
	public class QueryFileListCallbackInfo
	{
		/// <summary>
		/// Result code for the operation. <see cref="Result.Success" /> is returned for a successful request, other codes indicate an error
		/// </summary>
		public Result ResultCode { get; set; }

		/// <summary>
		/// Client-specified data passed into the file query request
		/// </summary>
		public object ClientData { get; set; }

		/// <summary>
		/// The Account ID of the local user who initiated this request
		/// </summary>
		public ProductUserId LocalUserId { get; set; }

		/// <summary>
		/// A count of files that were found, if successful
		/// </summary>
		public uint FileCount { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct QueryFileListCallbackInfoInternal : ICallbackInfo
	{
		private Result m_ResultCode;
		private IntPtr m_ClientData;
		private IntPtr m_LocalUserId;
		private uint m_FileCount;

		public Result ResultCode
		{
			get
			{
				var value = Helper.GetDefault<Result>();
				Helper.TryMarshalGet(m_ResultCode, out value);
				return value;
			}
		}

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

		public ProductUserId LocalUserId
		{
			get
			{
				var value = Helper.GetDefault<ProductUserId>();
				Helper.TryMarshalGet(m_LocalUserId, out value);
				return value;
			}
		}

		public uint FileCount
		{
			get
			{
				var value = Helper.GetDefault<uint>();
				Helper.TryMarshalGet(m_FileCount, out value);
				return value;
			}
		}
	}
}