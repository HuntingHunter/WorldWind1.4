﻿//
// Type_SimpleTimeSpan2.cs.cs
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
	public class Type_SimpleTimeSpan2 : Altova.Xml.Node
	{
		#region Forward constructors
		public Type_SimpleTimeSpan2() : base() { SetCollectionParents(); }
		public Type_SimpleTimeSpan2(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public Type_SimpleTimeSpan2(XmlNode node) : base(node) { SetCollectionParents(); }
		public Type_SimpleTimeSpan2(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "Days"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "Days", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "Hours"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "Hours", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "Mins"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "Mins", i);
				InternalAdjustPrefix(DOMNode, true);
			}

			for (int i = 0; i < DomChildCount(NodeType.Element, "", "Seconds"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Element, "", "Seconds", i);
				InternalAdjustPrefix(DOMNode, true);
			}
		}


		#region Days accessor methods
		public int GetDaysMinCount()
		{
			return 1;
		}

		public int DaysMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetDaysMaxCount()
		{
			return 1;
		}

		public int DaysMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetDaysCount()
		{
			return DomChildCount(NodeType.Element, "", "Days");
		}

		public int DaysCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "Days");
			}
		}

		public bool HasDays()
		{
			return HasDomChild(NodeType.Element, "", "Days");
		}

		public SchemaInt GetDaysAt(int index)
		{
			return new SchemaInt(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "Days", index)));
		}

		public XmlNode GetStartingDaysCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "Days" );
		}

		public XmlNode GetAdvancedDaysCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "Days", curNode );
		}

		public SchemaInt GetDaysValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaInt( curNode.InnerText );
		}


		public SchemaInt GetDays()
		{
			return GetDaysAt(0);
		}

		public SchemaInt Days
		{
			get
			{
				return GetDaysAt(0);
			}
		}

		public void RemoveDaysAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "Days", index);
		}

		public void RemoveDays()
		{
			while (HasDays())
				RemoveDaysAt(0);
		}

		public void AddDays(SchemaInt newValue)
		{
			AppendDomChild(NodeType.Element, "", "Days", newValue.ToString());
		}

		public void InsertDaysAt(SchemaInt newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "", "Days", index, newValue.ToString());
		}

		public void ReplaceDaysAt(SchemaInt newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "Days", index, newValue.ToString());
		}
		#endregion // Days accessor methods

		#region Days collection
        public DaysCollection	MyDayss = new DaysCollection( );

        public class DaysCollection: IEnumerable
        {
            Type_SimpleTimeSpan2 parent;
            public Type_SimpleTimeSpan2 Parent
			{
				set
				{
					parent = value;
				}
			}
			public DaysEnumerator GetEnumerator() 
			{
				return new DaysEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class DaysEnumerator: IEnumerator 
        {
			int nIndex;
			Type_SimpleTimeSpan2 parent;
			public DaysEnumerator(Type_SimpleTimeSpan2 par) 
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
				return(nIndex < parent.DaysCount );
			}
			public SchemaInt  Current 
			{
				get 
				{
					return(parent.GetDaysAt(nIndex));
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

        #endregion // Days collection

		#region Hours accessor methods
		public int GetHoursMinCount()
		{
			return 1;
		}

		public int HoursMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetHoursMaxCount()
		{
			return 1;
		}

		public int HoursMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetHoursCount()
		{
			return DomChildCount(NodeType.Element, "", "Hours");
		}

		public int HoursCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "Hours");
			}
		}

		public bool HasHours()
		{
			return HasDomChild(NodeType.Element, "", "Hours");
		}

		public SchemaLong GetHoursAt(int index)
		{
			return new SchemaLong(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "Hours", index)));
		}

		public XmlNode GetStartingHoursCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "Hours" );
		}

		public XmlNode GetAdvancedHoursCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "Hours", curNode );
		}

		public SchemaLong GetHoursValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaLong( curNode.InnerText );
		}


		public SchemaLong GetHours()
		{
			return GetHoursAt(0);
		}

		public SchemaLong Hours
		{
			get
			{
				return GetHoursAt(0);
			}
		}

		public void RemoveHoursAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "Hours", index);
		}

		public void RemoveHours()
		{
			while (HasHours())
				RemoveHoursAt(0);
		}

		public void AddHours(SchemaLong newValue)
		{
			AppendDomChild(NodeType.Element, "", "Hours", newValue.ToString());
		}

		public void InsertHoursAt(SchemaLong newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "", "Hours", index, newValue.ToString());
		}

		public void ReplaceHoursAt(SchemaLong newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "Hours", index, newValue.ToString());
		}
		#endregion // Hours accessor methods

		#region Hours collection
        public HoursCollection	MyHourss = new HoursCollection( );

        public class HoursCollection: IEnumerable
        {
            Type_SimpleTimeSpan2 parent;
            public Type_SimpleTimeSpan2 Parent
			{
				set
				{
					parent = value;
				}
			}
			public HoursEnumerator GetEnumerator() 
			{
				return new HoursEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class HoursEnumerator: IEnumerator 
        {
			int nIndex;
			Type_SimpleTimeSpan2 parent;
			public HoursEnumerator(Type_SimpleTimeSpan2 par) 
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
				return(nIndex < parent.HoursCount );
			}
			public SchemaLong  Current 
			{
				get 
				{
					return(parent.GetHoursAt(nIndex));
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

        #endregion // Hours collection

		#region Mins accessor methods
		public int GetMinsMinCount()
		{
			return 1;
		}

		public int MinsMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetMinsMaxCount()
		{
			return 1;
		}

		public int MinsMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetMinsCount()
		{
			return DomChildCount(NodeType.Element, "", "Mins");
		}

		public int MinsCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "Mins");
			}
		}

		public bool HasMins()
		{
			return HasDomChild(NodeType.Element, "", "Mins");
		}

		public SchemaInt GetMinsAt(int index)
		{
			return new SchemaInt(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "Mins", index)));
		}

		public XmlNode GetStartingMinsCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "Mins" );
		}

		public XmlNode GetAdvancedMinsCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "Mins", curNode );
		}

		public SchemaInt GetMinsValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaInt( curNode.InnerText );
		}


		public SchemaInt GetMins()
		{
			return GetMinsAt(0);
		}

		public SchemaInt Mins
		{
			get
			{
				return GetMinsAt(0);
			}
		}

		public void RemoveMinsAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "Mins", index);
		}

		public void RemoveMins()
		{
			while (HasMins())
				RemoveMinsAt(0);
		}

		public void AddMins(SchemaInt newValue)
		{
			AppendDomChild(NodeType.Element, "", "Mins", newValue.ToString());
		}

		public void InsertMinsAt(SchemaInt newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "", "Mins", index, newValue.ToString());
		}

		public void ReplaceMinsAt(SchemaInt newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "Mins", index, newValue.ToString());
		}
		#endregion // Mins accessor methods

		#region Mins collection
        public MinsCollection	MyMinss = new MinsCollection( );

        public class MinsCollection: IEnumerable
        {
            Type_SimpleTimeSpan2 parent;
            public Type_SimpleTimeSpan2 Parent
			{
				set
				{
					parent = value;
				}
			}
			public MinsEnumerator GetEnumerator() 
			{
				return new MinsEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class MinsEnumerator: IEnumerator 
        {
			int nIndex;
			Type_SimpleTimeSpan2 parent;
			public MinsEnumerator(Type_SimpleTimeSpan2 par) 
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
				return(nIndex < parent.MinsCount );
			}
			public SchemaInt  Current 
			{
				get 
				{
					return(parent.GetMinsAt(nIndex));
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

        #endregion // Mins collection

		#region Seconds accessor methods
		public int GetSecondsMinCount()
		{
			return 1;
		}

		public int SecondsMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetSecondsMaxCount()
		{
			return 1;
		}

		public int SecondsMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetSecondsCount()
		{
			return DomChildCount(NodeType.Element, "", "Seconds");
		}

		public int SecondsCount
		{
			get
			{
				return DomChildCount(NodeType.Element, "", "Seconds");
			}
		}

		public bool HasSeconds()
		{
			return HasDomChild(NodeType.Element, "", "Seconds");
		}

		public SchemaInt GetSecondsAt(int index)
		{
			return new SchemaInt(GetDomNodeValue(GetDomChildAt(NodeType.Element, "", "Seconds", index)));
		}

		public XmlNode GetStartingSecondsCursor()
		{
			return GetDomFirstChild( NodeType.Element, "", "Seconds" );
		}

		public XmlNode GetAdvancedSecondsCursor( XmlNode curNode )
		{
			return GetDomNextChild( NodeType.Element, "", "Seconds", curNode );
		}

		public SchemaInt GetSecondsValueAtCursor( XmlNode curNode )
		{
			if( curNode == null )
				  throw new Altova.Xml.XmlException("Out of range");
			else
				return new SchemaInt( curNode.InnerText );
		}


		public SchemaInt GetSeconds()
		{
			return GetSecondsAt(0);
		}

		public SchemaInt Seconds
		{
			get
			{
				return GetSecondsAt(0);
			}
		}

		public void RemoveSecondsAt(int index)
		{
			RemoveDomChildAt(NodeType.Element, "", "Seconds", index);
		}

		public void RemoveSeconds()
		{
			while (HasSeconds())
				RemoveSecondsAt(0);
		}

		public void AddSeconds(SchemaInt newValue)
		{
			AppendDomChild(NodeType.Element, "", "Seconds", newValue.ToString());
		}

		public void InsertSecondsAt(SchemaInt newValue, int index)
		{
			InsertDomChildAt(NodeType.Element, "", "Seconds", index, newValue.ToString());
		}

		public void ReplaceSecondsAt(SchemaInt newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Element, "", "Seconds", index, newValue.ToString());
		}
		#endregion // Seconds accessor methods

		#region Seconds collection
        public SecondsCollection	MySecondss = new SecondsCollection( );

        public class SecondsCollection: IEnumerable
        {
            Type_SimpleTimeSpan2 parent;
            public Type_SimpleTimeSpan2 Parent
			{
				set
				{
					parent = value;
				}
			}
			public SecondsEnumerator GetEnumerator() 
			{
				return new SecondsEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class SecondsEnumerator: IEnumerator 
        {
			int nIndex;
			Type_SimpleTimeSpan2 parent;
			public SecondsEnumerator(Type_SimpleTimeSpan2 par) 
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
				return(nIndex < parent.SecondsCount );
			}
			public SchemaInt  Current 
			{
				get 
				{
					return(parent.GetSecondsAt(nIndex));
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

        #endregion // Seconds collection

        private void SetCollectionParents()
        {
            MyDayss.Parent = this; 
            MyHourss.Parent = this; 
            MyMinss.Parent = this; 
            MySecondss.Parent = this; 
	}
}
}
