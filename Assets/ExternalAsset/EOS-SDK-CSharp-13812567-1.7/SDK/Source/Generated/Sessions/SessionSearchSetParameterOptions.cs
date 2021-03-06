// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Sessions
{
	/// <summary>
	/// Input parameters for the <see cref="SessionSearch.SetParameter" /> Function.
	/// 
	/// A search key may be set more than once to make multiple comparisons
	/// The two comparisons are AND'd together
	/// (ie, Key GREATER_THAN 5, Key NOT_EQUALS 10)
	/// </summary>
	public class SessionSearchSetParameterOptions
	{
		/// <summary>
		/// Version of the API
		/// </summary>
		public int ApiVersion { get { return 1; } }

		/// <summary>
		/// Search parameter describing a key and a value to compare
		/// </summary>
		public AttributeData Parameter { get; set; }

		/// <summary>
		/// The type of comparison to make against the search parameter
		/// </summary>
		public ComparisonOp ComparisonOp { get; set; }
	}

	[StructLayout(LayoutKind.Sequential, Pack = 8)]
	internal struct SessionSearchSetParameterOptionsInternal : IDisposable
	{
		private int m_ApiVersion;
		private IntPtr m_Parameter;
		private ComparisonOp m_ComparisonOp;

		public int ApiVersion
		{
			get
			{
				var value = Helper.GetDefault<int>();
				Helper.TryMarshalGet(m_ApiVersion, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_ApiVersion, value); }
		}

		public AttributeDataInternal? Parameter
		{
			get
			{
				var value = Helper.GetDefault<AttributeDataInternal?>();
				Helper.TryMarshalGet(m_Parameter, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_Parameter, value); }
		}

		public ComparisonOp ComparisonOp
		{
			get
			{
				var value = Helper.GetDefault<ComparisonOp>();
				Helper.TryMarshalGet(m_ComparisonOp, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_ComparisonOp, value); }
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_Parameter);
		}
	}
}