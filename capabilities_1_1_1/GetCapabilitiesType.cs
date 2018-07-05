﻿//
// GetCapabilitiesType.cs.cs
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

namespace capabilities_1_1_1
{
	public class GetCapabilitiesType : Altova.Xml.Node
	{
		#region Forward constructors
		public GetCapabilitiesType() : base() { SetCollectionParents(); }
		public GetCapabilitiesType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public GetCapabilitiesType(XmlNode node) : base(node) { SetCollectionParents(); }
		public GetCapabilitiesType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "Format"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "Format", i);
				InternalAdjustPrefix(DOMNode, false);
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "DCPType"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "DCPType", i);
				InternalAdjustPrefix(DOMNode, false);
				new DCPTypeType(DOMNode).AdjustPrefix();
			}
		}


		#region Format accessor methods
		public int GetFormatMinCount()
		{
			return 1;
		}

		public int FormatMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetFormatMaxCount()
		{
			return Int32.MaxValue;
		}

		public int FormatMaxCount
		{
			get
			{
				return Int32.MaxValue;
			}
		}

		public int GetFormatCount()
		{
			return DomChildCount(NodeType.Element, "", "Format");
		}

		public int FormatCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "Format");
			}
		}

		public bool HasFormat()
		{
			return HasDomChild(NodeType.Element, "", "Format");
		}

		public SchemaString GetFormatAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "Format", index)));
		}

		public SchemaString GetFormat()
		{
			return GetFormatAt(0);
		}

		public SchemaString Format
		{
			get
			{
				return GetFormatAt(0);
			}
		}

		public void RemoveFormatAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "Format", index);
		}

		public void RemoveFormat()
		{
			while (HasFormat())
				RemoveFormatAt(0);
		}

		public void AddFormat(SchemaString newValue)
		{
			AppendDomChild(NodeType.Element, "", "Format", newValue.ToString());
		}

		public void InsertFormatAt(SchemaString newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "", "Format", index, newValue.ToString());
		}

		public void ReplaceFormatAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "Format", index, newValue.ToString());
		}
		#endregion // Format accessor methods

		#region Format collection
        public FormatCollection	MyFormats = new FormatCollection( );

        public class FormatCollection: IEnumerable
        {
            GetCapabilitiesType parent;
            public GetCapabilitiesType Parent
			{
				set
				{
					parent = value;
				}
			}
			public FormatEnumerator GetEnumerator() 
			{
				return new FormatEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class FormatEnumerator: IEnumerator 
        {
			int nIndex;
			GetCapabilitiesType parent;
			public FormatEnumerator(GetCapabilitiesType par) 
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
				return(nIndex < parent.FormatCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetFormatAt(nIndex));
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

        #endregion // Format collection

		#region DCPType accessor methods
		public int GetDCPTypeMinCount()
		{
			return 1;
		}

		public int DCPTypeMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetDCPTypeMaxCount()
		{
			return Int32.MaxValue;
		}

		public int DCPTypeMaxCount
		{
			get
			{
				return Int32.MaxValue;
			}
		}

		public int GetDCPTypeCount()
		{
			return DomChildCount(NodeType.Element, "", "DCPType");
		}

		public int DCPTypeCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "DCPType");
			}
		}

		public bool HasDCPType()
		{
			return HasDomChild(NodeType.Element, "", "DCPType");
		}

		public DCPTypeType GetDCPTypeAt(int index)
		{
			return new DCPTypeType(GetDomChildAt(NodeType.Element, "", "DCPType", index));
		}

		public DCPTypeType GetDCPType()
		{
			return GetDCPTypeAt(0);
		}

		public DCPTypeType DCPType
		{
			get
			{
				return GetDCPTypeAt(0);
			}
		}

		public void RemoveDCPTypeAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "DCPType", index);
		}

		public void RemoveDCPType()
		{
			while (HasDCPType())
				RemoveDCPTypeAt(0);
		}

		public void AddDCPType(DCPTypeType newValue)
		{
			AppendDomElement("", "DCPType", newValue);
		}

		public void InsertDCPTypeAt(DCPTypeType newValue, int index)
		{
			InsertDomElementAt("", "DCPType", index, newValue);
		}

		public void ReplaceDCPTypeAt(DCPTypeType newValue, int index)
		{
			ReplaceDomElementAt("", "DCPType", index, newValue);
		}
		#endregion // DCPType accessor methods

		#region DCPType collection
        public DCPTypeCollection	MyDCPTypes = new DCPTypeCollection( );

        public class DCPTypeCollection: IEnumerable
        {
            GetCapabilitiesType parent;
            public GetCapabilitiesType Parent
			{
				set
				{
					parent = value;
				}
			}
			public DCPTypeEnumerator GetEnumerator() 
			{
				return new DCPTypeEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class DCPTypeEnumerator: IEnumerator 
        {
			int nIndex;
			GetCapabilitiesType parent;
			public DCPTypeEnumerator(GetCapabilitiesType par) 
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
				return(nIndex < parent.DCPTypeCount );
			}
			public DCPTypeType  Current 
			{
				get 
				{
					return(parent.GetDCPTypeAt(nIndex));
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

        #endregion // DCPType collection

        private void SetCollectionParents()
        {
            MyFormats.Parent = this; 
            MyDCPTypes.Parent = this; 
	}
}
}
