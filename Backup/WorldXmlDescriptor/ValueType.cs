﻿//
// ValueType.cs.cs
//
// This file was generated by XMLSPY 2004 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSPY Documentation for further details.
// http://www.altova.com/xmlspy
//


using Altova.Types;

namespace WorldXmlDescriptor
{

	public class ValueType : SchemaDecimal
	{
		public ValueType() : base()
		{
		}

		public ValueType(string newValue) : base(newValue)
		{
			Validate();
		}

		public new void Validate()
		{

			if (CompareTo(GetMinInclusive()) < 0)
				throw new System.Exception("Out of range");

			if (CompareTo(GetMaxInclusive()) > 0)
				throw new System.Exception("Out of range");
		}
		public new SchemaDecimal GetMinInclusive()
		{
			return new SchemaDecimal("-90");
		}
		public new SchemaDecimal GetMaxInclusive()
		{
			return new SchemaDecimal("90");
		}
	}
}
