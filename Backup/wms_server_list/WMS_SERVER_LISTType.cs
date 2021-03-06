﻿//
// WMS_SERVER_LISTType.cs.cs
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

namespace wms_server_list
{
	public class WMS_SERVER_LISTType : Altova.Xml.Node
	{
		#region Forward constructors
		public WMS_SERVER_LISTType() : base() { SetCollectionParents(); }
		public WMS_SERVER_LISTType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public WMS_SERVER_LISTType(XmlNode node) : base(node) { SetCollectionParents(); }
		public WMS_SERVER_LISTType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "Server"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "Server", i);
				InternalAdjustPrefix(DOMNode, true);
				new WMS_server(DOMNode).AdjustPrefix();
			}
		}


		#region Server accessor methods
		public int GetServerMinCount()
		{
			return 0;
		}

		public int ServerMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetServerMaxCount()
		{
			return Int32.MaxValue;
		}

		public int ServerMaxCount
		{
			get
			{
				return Int32.MaxValue;
			}
		}

		public int GetServerCount()
		{
			return DomChildCount(NodeType.Element, "", "Server");
		}

		public int ServerCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "Server");
			}
		}

		public bool HasServer()
		{
			return HasDomChild(NodeType.Element, "", "Server");
		}

		public WMS_server GetServerAt(int index)
		{
			return new WMS_server(GetDomChildAt(NodeType.Element, "", "Server", index));
		}

		public WMS_server GetServer()
		{
			return GetServerAt(0);
		}

		public WMS_server Server
		{
			get
			{
				return GetServerAt(0);
			}
		}

		public void RemoveServerAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "Server", index);
		}

		public void RemoveServer()
		{
			while (HasServer())
				RemoveServerAt(0);
		}

		public void AddServer(WMS_server newValue)
		{
			AppendDomElement("", "Server", newValue);
		}

		public void InsertServerAt(WMS_server newValue, int index)
		{
			InsertDomElementAt("", "Server", index, newValue);
		}

		public void ReplaceServerAt(WMS_server newValue, int index)
		{
			ReplaceDomElementAt("", "Server", index, newValue);
		}
		#endregion // Server accessor methods

		#region Server collection
        public ServerCollection	MyServers = new ServerCollection( );

        public class ServerCollection: IEnumerable
        {
            WMS_SERVER_LISTType parent;
            public WMS_SERVER_LISTType Parent
			{
				set
				{
					parent = value;
				}
			}
			public ServerEnumerator GetEnumerator() 
			{
				return new ServerEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class ServerEnumerator: IEnumerator 
        {
			int nIndex;
			WMS_SERVER_LISTType parent;
			public ServerEnumerator(WMS_SERVER_LISTType par) 
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
				return(nIndex < parent.ServerCount );
			}
			public WMS_server  Current 
			{
				get 
				{
					return(parent.GetServerAt(nIndex));
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

        #endregion // Server collection

        private void SetCollectionParents()
        {
            MyServers.Parent = this; 
	}
}
}
