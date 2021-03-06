// Copyright Epic Games, Inc. All Rights Reserved.
// This file is automatically generated. Changes to this file may be overwritten.

using System;
using System.Runtime.InteropServices;

namespace Epic.OnlineServices.Sessions
{
	public class AttributeDataValue
	{
		private long m_AsInt64;
		private double m_AsDouble;
		private bool m_AsBool;
		private string m_AsUtf8;
		private AttributeType m_ValueType;

		public static implicit operator AttributeDataValue(long value)
		{
			return new AttributeDataValue() { AsInt64 = value };
		}

		public static implicit operator AttributeDataValue(double value)
		{
			return new AttributeDataValue() { AsDouble = value };
		}

		public static implicit operator AttributeDataValue(bool value)
		{
			return new AttributeDataValue() { AsBool = value };
		}

		public static implicit operator AttributeDataValue(string value)
		{
			return new AttributeDataValue() { AsUtf8 = value };
		}

		/// <summary>
		/// Stored as an 8 byte integer
		/// </summary>
		public long? AsInt64
		{
			get
			{
				var value = Helper.GetDefault<long?>();
				Helper.TryMarshalGet(m_AsInt64, out value, m_ValueType, AttributeType.Int64);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_AsInt64, value, ref m_ValueType, AttributeType.Int64, this); }
		}

		/// <summary>
		/// Stored as a double precision floating point
		/// </summary>
		public double? AsDouble
		{
			get
			{
				var value = Helper.GetDefault<double?>();
				Helper.TryMarshalGet(m_AsDouble, out value, m_ValueType, AttributeType.Double);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_AsDouble, value, ref m_ValueType, AttributeType.Double, this); }
		}

		/// <summary>
		/// Stored as a boolean
		/// </summary>
		public bool? AsBool
		{
			get
			{
				var value = Helper.GetDefault<bool?>();
				Helper.TryMarshalGet(m_AsBool, out value, m_ValueType, AttributeType.Boolean);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_AsBool, value, ref m_ValueType, AttributeType.Boolean, this); }
		}

		/// <summary>
		/// Stored as a null terminated UTF8 string
		/// </summary>
		public string AsUtf8
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_AsUtf8, out value, m_ValueType, AttributeType.String);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_AsUtf8, value, ref m_ValueType, AttributeType.String, this); }
		}

		/// <summary>
		/// Type of value stored in the union
		/// </summary>
		public AttributeType ValueType { get { return m_ValueType; } private set { m_ValueType = value; } }
	}

	[StructLayout(LayoutKind.Explicit, Pack = 8)]
	internal struct AttributeDataValueInternal : IDisposable
	{
		[FieldOffset(0)]
		private long m_AsInt64;
		[FieldOffset(0)]
		private double m_AsDouble;
		[FieldOffset(0)]
		private int m_AsBool;
		[FieldOffset(0)]
		private IntPtr m_AsUtf8;
		[FieldOffset(8)]
		private AttributeType m_ValueType;

		public long? AsInt64
		{
			get
			{
				var value = Helper.GetDefault<long?>();
				Helper.TryMarshalGet(m_AsInt64, out value, m_ValueType, AttributeType.Int64);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_AsInt64, value, ref m_ValueType, AttributeType.Int64, this); }
		}

		public double? AsDouble
		{
			get
			{
				var value = Helper.GetDefault<double?>();
				Helper.TryMarshalGet(m_AsDouble, out value, m_ValueType, AttributeType.Double);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_AsDouble, value, ref m_ValueType, AttributeType.Double, this); }
		}

		public bool? AsBool
		{
			get
			{
				var value = Helper.GetDefault<bool?>();
				Helper.TryMarshalGet(m_AsBool, out value, m_ValueType, AttributeType.Boolean);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_AsBool, value, ref m_ValueType, AttributeType.Boolean, this); }
		}

		public string AsUtf8
		{
			get
			{
				var value = Helper.GetDefault<string>();
				Helper.TryMarshalGet(m_AsUtf8, out value, m_ValueType, AttributeType.String);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_AsUtf8, value, ref m_ValueType, AttributeType.String, this); }
		}

		public AttributeType ValueType
		{
			get
			{
				var value = Helper.GetDefault<AttributeType>();
				Helper.TryMarshalGet(m_ValueType, out value);
				return value;
			}
			set { Helper.TryMarshalSet(ref m_ValueType, value); }
		}

		public void Dispose()
		{
			Helper.TryMarshalDispose(ref m_AsUtf8, m_ValueType, AttributeType.String);
		}
	}
}