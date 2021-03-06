﻿//
// Type_LatLonBoundingBox.cs.cs
//
// This file was generated by XMLSpy 2005 Enterprise Edition.
//
// YOU SHOULD NOT MODIFY THIS FILE, BECAUSE IT WILL BE
// OVERWRITTEN WHEN YOU RE-RUN CODE GENERATION.
//
// Refer to the XMLSpy Documentation for further details.
// http://www.altova.com/xmlspy
//


using System;
using System.Collections;
using System.Xml;
using Altova.Types;

namespace LayerSet
{
	public class Type_LatLonBoundingBox : Altova.Xml.Node
	{
		#region Forward constructors
		public Type_LatLonBoundingBox() : base() { SetCollectionParents(); }
		public Type_LatLonBoundingBox(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public Type_LatLonBoundingBox(XmlNode node) : base(node) { SetCollectionParents(); }
		public Type_LatLonBoundingBox(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "North"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "North", i);
				InternalAdjustPrefix(DOMNode, true);
				new Type_LatitudeCoordinate2(DOMNode).AdjustPrefix();
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "South"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "South", i);
				InternalAdjustPrefix(DOMNode, true);
				new Type_LatitudeCoordinate2(DOMNode).AdjustPrefix();
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "West"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "West", i);
				InternalAdjustPrefix(DOMNode, true);
				new Type_LongitudeCoordinate2(DOMNode).AdjustPrefix();
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "East"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "East", i);
				InternalAdjustPrefix(DOMNode, true);
				new Type_LongitudeCoordinate2(DOMNode).AdjustPrefix();
			}
		}


		#region North accessor methods
		public int GetNorthMinCount()
		{
			return 1;
		}

		public int NorthMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetNorthMaxCount()
		{
			return 1;
		}

		public int NorthMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetNorthCount()
		{
			return DomChildCount(NodeType.Element, "", "North");
		}

		public int NorthCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "North");
			}
		}

		public bool HasNorth()
		{
			return HasDomChild(NodeType.Element, "", "North");
		}

		public Type_LatitudeCoordinate2 GetNorthAt(int index)
		{
			return new Type_LatitudeCoordinate2(GetDomChildAt(NodeType.Element, "", "North", index));
		}

		public XmlNode GetStartingNorthCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "North" );
		}

		public XmlNode GetAdvancedNorthCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "North", curNode );
		}

		public Type_LatitudeCoordinate2 GetNorthValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new Type_LatitudeCoordinate2( curNode );
		}


		public Type_LatitudeCoordinate2 GetNorth()
		{
			return GetNorthAt(0);
		}

		public Type_LatitudeCoordinate2 North
		{
			get
			{
				return GetNorthAt(0);
			}
		}

		public void RemoveNorthAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "North", index);
		}

		public void RemoveNorth()
		{
			while (HasNorth())
				RemoveNorthAt(0);
		}

		public void AddNorth(Type_LatitudeCoordinate2 newValue)
		{
			AppendDomElement("", "North", newValue);
		}

		public void InsertNorthAt(Type_LatitudeCoordinate2 newValue, int index)
		{
			InsertDomElementAt("", "North", index, newValue);
		}

		public void ReplaceNorthAt(Type_LatitudeCoordinate2 newValue, int index)
		{
			ReplaceDomElementAt("", "North", index, newValue);
		}
		#endregion // North accessor methods

		#region North collection
        public NorthCollection	MyNorths = new NorthCollection( );

        public class NorthCollection: IEnumerable
        {
            Type_LatLonBoundingBox parent;
            public Type_LatLonBoundingBox Parent
			{
				set
				{
					parent = value;
				}
			}
			public NorthEnumerator GetEnumerator() 
			{
				return new NorthEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class NorthEnumerator: IEnumerator 
        {
			int nIndex;
			Type_LatLonBoundingBox parent;
			public NorthEnumerator(Type_LatLonBoundingBox par) 
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
				return(nIndex < parent.NorthCount );
			}
			public Type_LatitudeCoordinate2  Current 
			{
				get 
				{
					return(parent.GetNorthAt(nIndex));
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

        #endregion // North collection

		#region South accessor methods
		public int GetSouthMinCount()
		{
			return 1;
		}

		public int SouthMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetSouthMaxCount()
		{
			return 1;
		}

		public int SouthMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetSouthCount()
		{
			return DomChildCount(NodeType.Element, "", "South");
		}

		public int SouthCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "South");
			}
		}

		public bool HasSouth()
		{
			return HasDomChild(NodeType.Element, "", "South");
		}

		public Type_LatitudeCoordinate2 GetSouthAt(int index)
		{
			return new Type_LatitudeCoordinate2(GetDomChildAt(NodeType.Element, "", "South", index));
		}

		public XmlNode GetStartingSouthCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "South" );
		}

		public XmlNode GetAdvancedSouthCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "South", curNode );
		}

		public Type_LatitudeCoordinate2 GetSouthValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new Type_LatitudeCoordinate2( curNode );
		}


		public Type_LatitudeCoordinate2 GetSouth()
		{
			return GetSouthAt(0);
		}

		public Type_LatitudeCoordinate2 South
		{
			get
			{
				return GetSouthAt(0);
			}
		}

		public void RemoveSouthAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "South", index);
		}

		public void RemoveSouth()
		{
			while (HasSouth())
				RemoveSouthAt(0);
		}

		public void AddSouth(Type_LatitudeCoordinate2 newValue)
		{
			AppendDomElement("", "South", newValue);
		}

		public void InsertSouthAt(Type_LatitudeCoordinate2 newValue, int index)
		{
			InsertDomElementAt("", "South", index, newValue);
		}

		public void ReplaceSouthAt(Type_LatitudeCoordinate2 newValue, int index)
		{
			ReplaceDomElementAt("", "South", index, newValue);
		}
		#endregion // South accessor methods

		#region South collection
        public SouthCollection	MySouths = new SouthCollection( );

        public class SouthCollection: IEnumerable
        {
            Type_LatLonBoundingBox parent;
            public Type_LatLonBoundingBox Parent
			{
				set
				{
					parent = value;
				}
			}
			public SouthEnumerator GetEnumerator() 
			{
				return new SouthEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class SouthEnumerator: IEnumerator 
        {
			int nIndex;
			Type_LatLonBoundingBox parent;
			public SouthEnumerator(Type_LatLonBoundingBox par) 
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
				return(nIndex < parent.SouthCount );
			}
			public Type_LatitudeCoordinate2  Current 
			{
				get 
				{
					return(parent.GetSouthAt(nIndex));
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

        #endregion // South collection

		#region West accessor methods
		public int GetWestMinCount()
		{
			return 1;
		}

		public int WestMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetWestMaxCount()
		{
			return 1;
		}

		public int WestMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetWestCount()
		{
			return DomChildCount(NodeType.Element, "", "West");
		}

		public int WestCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "West");
			}
		}

		public bool HasWest()
		{
			return HasDomChild(NodeType.Element, "", "West");
		}

		public Type_LongitudeCoordinate2 GetWestAt(int index)
		{
			return new Type_LongitudeCoordinate2(GetDomChildAt(NodeType.Element, "", "West", index));
		}

		public XmlNode GetStartingWestCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "West" );
		}

		public XmlNode GetAdvancedWestCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "West", curNode );
		}

		public Type_LongitudeCoordinate2 GetWestValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new Type_LongitudeCoordinate2( curNode );
		}


		public Type_LongitudeCoordinate2 GetWest()
		{
			return GetWestAt(0);
		}

		public Type_LongitudeCoordinate2 West
		{
			get
			{
				return GetWestAt(0);
			}
		}

		public void RemoveWestAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "West", index);
		}

		public void RemoveWest()
		{
			while (HasWest())
				RemoveWestAt(0);
		}

		public void AddWest(Type_LongitudeCoordinate2 newValue)
		{
			AppendDomElement("", "West", newValue);
		}

		public void InsertWestAt(Type_LongitudeCoordinate2 newValue, int index)
		{
			InsertDomElementAt("", "West", index, newValue);
		}

		public void ReplaceWestAt(Type_LongitudeCoordinate2 newValue, int index)
		{
			ReplaceDomElementAt("", "West", index, newValue);
		}
		#endregion // West accessor methods

		#region West collection
        public WestCollection	MyWests = new WestCollection( );

        public class WestCollection: IEnumerable
        {
            Type_LatLonBoundingBox parent;
            public Type_LatLonBoundingBox Parent
			{
				set
				{
					parent = value;
				}
			}
			public WestEnumerator GetEnumerator() 
			{
				return new WestEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class WestEnumerator: IEnumerator 
        {
			int nIndex;
			Type_LatLonBoundingBox parent;
			public WestEnumerator(Type_LatLonBoundingBox par) 
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
				return(nIndex < parent.WestCount );
			}
			public Type_LongitudeCoordinate2  Current 
			{
				get 
				{
					return(parent.GetWestAt(nIndex));
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

        #endregion // West collection

		#region East accessor methods
		public int GetEastMinCount()
		{
			return 1;
		}

		public int EastMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetEastMaxCount()
		{
			return 1;
		}

		public int EastMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetEastCount()
		{
			return DomChildCount(NodeType.Element, "", "East");
		}

		public int EastCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "East");
			}
		}

		public bool HasEast()
		{
			return HasDomChild(NodeType.Element, "", "East");
		}

		public Type_LongitudeCoordinate2 GetEastAt(int index)
		{
			return new Type_LongitudeCoordinate2(GetDomChildAt(NodeType.Element, "", "East", index));
		}

		public XmlNode GetStartingEastCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "East" );
		}

		public XmlNode GetAdvancedEastCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "East", curNode );
		}

		public Type_LongitudeCoordinate2 GetEastValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new Type_LongitudeCoordinate2( curNode );
		}


		public Type_LongitudeCoordinate2 GetEast()
		{
			return GetEastAt(0);
		}

		public Type_LongitudeCoordinate2 East
		{
			get
			{
				return GetEastAt(0);
			}
		}

		public void RemoveEastAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "East", index);
		}

		public void RemoveEast()
		{
			while (HasEast())
				RemoveEastAt(0);
		}

		public void AddEast(Type_LongitudeCoordinate2 newValue)
		{
			AppendDomElement("", "East", newValue);
		}

		public void InsertEastAt(Type_LongitudeCoordinate2 newValue, int index)
		{
			InsertDomElementAt("", "East", index, newValue);
		}

		public void ReplaceEastAt(Type_LongitudeCoordinate2 newValue, int index)
		{
			ReplaceDomElementAt("", "East", index, newValue);
		}
		#endregion // East accessor methods

		#region East collection
        public EastCollection	MyEasts = new EastCollection( );

        public class EastCollection: IEnumerable
        {
            Type_LatLonBoundingBox parent;
            public Type_LatLonBoundingBox Parent
			{
				set
				{
					parent = value;
				}
			}
			public EastEnumerator GetEnumerator() 
			{
				return new EastEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class EastEnumerator: IEnumerator 
        {
			int nIndex;
			Type_LatLonBoundingBox parent;
			public EastEnumerator(Type_LatLonBoundingBox par) 
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
				return(nIndex < parent.EastCount );
			}
			public Type_LongitudeCoordinate2  Current 
			{
				get 
				{
					return(parent.GetEastAt(nIndex));
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

        #endregion // East collection

        private void SetCollectionParents()
        {
            MyNorths.Parent = this; 
            MySouths.Parent = this; 
            MyWests.Parent = this; 
            MyEasts.Parent = this; 
	}
}
}
