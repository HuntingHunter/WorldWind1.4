﻿//
// NameType2.cs.cs
//
// This file was generated by XMLSpy 2005 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSpy Documentation for further details.
// http://www.altova.com/xmlspy
//


using Altova.Types;

namespace LayerSet
{

	public class NameType2 : SchemaString
	{

		public NameType2() : base()
		{
		}

		public NameType2(string newValue) : base(newValue)
		{
			Validate();
		}

		public NameType2(SchemaString newValue) : base(newValue)
		{
			Validate();
		}

		public void Validate()
		{
			if (Value.Length < GetMinLength())
				throw new System.Exception("Too short");
		}
		public int GetMinLength()
		{
			return 1;
		}
	}
}
