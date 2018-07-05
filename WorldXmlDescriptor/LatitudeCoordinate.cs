﻿//
// LatitudeCoordinate.cs.cs
//
// This file was generated by XMLSPY 2004 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSPY Documentation for further details.
// http://www.altova.com/xmlspy
//


using System;
using System.Collections;
using System.Xml;
using Altova.Types;

namespace WorldXmlDescriptor
{
	public class LatitudeCoordinate : Altova.Xml.Node
	{
		#region Forward constructors
		public LatitudeCoordinate() : base() { SetCollectionParents(); }
		public LatitudeCoordinate(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public LatitudeCoordinate(XmlNode node) : base(node) { SetCollectionParents(); }
		public LatitudeCoordinate(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "Value"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "Value", i);
				InternalAdjustPrefix(DOMNode, true);
			}
		}


		#region Value accessor methods
		public int GetValueMinCount()
		{
			return 1;
		}

		public int ValueMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetValueMaxCount()
		{
			return 1;
		}

		public int ValueMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetValueCount()
		{
			return DomChildCount(NodeType.Element, "", "Value");
		}

		public int ValueCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "Value");
			}
		}

		public bool HasValue()
		{
			return HasDomChild(NodeType.Element, "", "Value");
		}

		public ValueType GetValueAt(int index)
		{
			return new ValueType(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "Value", index)));
		}

		public ValueType GetValue()
		{
			return GetValueAt(0);
		}

		public ValueType Value
		{
			get
			{
				return GetValueAt(0);
			}
		}

		public void RemoveValueAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "Value", index);
		}

		public void RemoveValue()
		{
			while (HasValue())
				RemoveValueAt(0);
		}

		public void AddValue(ValueType newValue)
		{
			AppendDomChild(NodeType.Element, "", "Value", newValue.ToString());
		}

		public void InsertValueAt(ValueType newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "", "Value", index, newValue.ToString());
		}

		public void ReplaceValueAt(ValueType newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "Value", index, newValue.ToString());
		}
		#endregion // Value accessor methods

		#region Value collection
        public ValueCollection	MyValues = new ValueCollection( );

        public class ValueCollection: IEnumerable
        {
            LatitudeCoordinate parent;
            public LatitudeCoordinate Parent
			{
				set
				{
					parent = value;
				}
			}
			public ValueEnumerator GetEnumerator() 
			{
				return new ValueEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class ValueEnumerator: IEnumerator 
        {
			int nIndex;
			LatitudeCoordinate parent;
			public ValueEnumerator(LatitudeCoordinate par) 
			{
				parent = par;
				nIndex = -1;
			}
			public void Reset() 
			{
				nIndex = -1;
			}
			public bool MoveNext() 
			{
				nIndex++;
				return(nIndex < parent.ValueCount );
			}
			public ValueType  Current 
			{
				get 
				{
					return(parent.GetValueAt(nIndex));
				}
			}
			object IEnumerator.Current 
			{
				get 
				{
					return(Current);
				}
			}
    	}

        #endregion // Value collection

        private void SetCollectionParents()
        {
            MyValues.Parent = this; 
	}
}
}
