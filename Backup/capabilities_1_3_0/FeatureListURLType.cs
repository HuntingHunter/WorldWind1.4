﻿//
// FeatureListURLType.cs.cs
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

namespace capabilities_1_3_0.wms
{
	public class FeatureListURLType : Altova.Xml.Node
	{
		#region Forward constructors
		public FeatureListURLType() : base() { SetCollectionParents(); }
		public FeatureListURLType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public FeatureListURLType(XmlNode node) : base(node) { SetCollectionParents(); }
		public FeatureListURLType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "Format"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "Format", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "OnlineResource"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "OnlineResource", i);
				InternalAdjustPrefix(DOMNode, true);
				new OnlineResourceType(DOMNode).AdjustPrefix();
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
			return 1;
		}

		public int FormatMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetFormatCount()
		{
			return DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "Format");
		}

		public int FormatCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "Format");
			}
		}

		public bool HasFormat()
		{
			return HasDomChild(NodeType.Element, "http://www.opengis.net/wms", "Format");
		}

		public SchemaString GetFormatAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "Format", index)));
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
			RemoveDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "Format", index);
		}

		public void RemoveFormat()
		{
			while (HasFormat())
				RemoveFormatAt(0);
		}

		public void AddFormat(SchemaString newValue)
		{
			AppendDomChild(NodeType.Element, "http://www.opengis.net/wms", "Format", newValue.ToString());
		}

		public void InsertFormatAt(SchemaString newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "Format", index, newValue.ToString());
		}

		public void ReplaceFormatAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "Format", index, newValue.ToString());
		}
		#endregion // Format accessor methods

		#region Format collection
        public FormatCollection	MyFormats = new FormatCollection( );

        public class FormatCollection: IEnumerable
        {
            FeatureListURLType parent;
            public FeatureListURLType Parent
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
			FeatureListURLType parent;
			public FormatEnumerator(FeatureListURLType par) 
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

		#region OnlineResource accessor methods
		public int GetOnlineResourceMinCount()
		{
			return 1;
		}

		public int OnlineResourceMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetOnlineResourceMaxCount()
		{
			return 1;
		}

		public int OnlineResourceMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetOnlineResourceCount()
		{
			return DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "OnlineResource");
		}

		public int OnlineResourceCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "http://www.opengis.net/wms", "OnlineResource");
			}
		}

		public bool HasOnlineResource()
		{
			return HasDomChild(NodeType.Element, "http://www.opengis.net/wms", "OnlineResource");
		}

		public OnlineResourceType GetOnlineResourceAt(int index)
		{
			return new OnlineResourceType(GetDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "OnlineResource", index));
		}

		public OnlineResourceType GetOnlineResource()
		{
			return GetOnlineResourceAt(0);
		}

		public OnlineResourceType OnlineResource
		{
			get
			{
				return GetOnlineResourceAt(0);
			}
		}

		public void RemoveOnlineResourceAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "http://www.opengis.net/wms", "OnlineResource", index);
		}

		public void RemoveOnlineResource()
		{
			while (HasOnlineResource())
				RemoveOnlineResourceAt(0);
		}

		public void AddOnlineResource(OnlineResourceType newValue)
		{
			AppendDomElement("http://www.opengis.net/wms", "OnlineResource", newValue);
		}

		public void InsertOnlineResourceAt(OnlineResourceType newValue, int index)
		{
			InsertDomElementAt("http://www.opengis.net/wms", "OnlineResource", index, newValue);
		}

		public void ReplaceOnlineResourceAt(OnlineResourceType newValue, int index)
		{
			ReplaceDomElementAt("http://www.opengis.net/wms", "OnlineResource", index, newValue);
		}
		#endregion // OnlineResource accessor methods

		#region OnlineResource collection
        public OnlineResourceCollection	MyOnlineResources = new OnlineResourceCollection( );

        public class OnlineResourceCollection: IEnumerable
        {
            FeatureListURLType parent;
            public FeatureListURLType Parent
			{
				set
				{
					parent = value;
				}
			}
			public OnlineResourceEnumerator GetEnumerator() 
			{
				return new OnlineResourceEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class OnlineResourceEnumerator: IEnumerator 
        {
			int nIndex;
			FeatureListURLType parent;
			public OnlineResourceEnumerator(FeatureListURLType par) 
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
				return(nIndex < parent.OnlineResourceCount );
			}
			public OnlineResourceType  Current 
			{
				get 
				{
					return(parent.GetOnlineResourceAt(nIndex));
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

        #endregion // OnlineResource collection

        private void SetCollectionParents()
        {
            MyFormats.Parent = this; 
            MyOnlineResources.Parent = this; 
	}
}
}
