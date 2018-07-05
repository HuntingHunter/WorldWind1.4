﻿//
// BoundingBoxType.cs.cs
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
	public class BoundingBoxType : Altova.Xml.Node
	{
		#region Forward constructors
		public BoundingBoxType() : base() { SetCollectionParents(); }
		public BoundingBoxType(XmlDocument doc) : base(doc) { SetCollectionParents(); }
		public BoundingBoxType(XmlNode node) : base(node) { SetCollectionParents(); }
		public BoundingBoxType(Altova.Xml.Node node) : base(node) { SetCollectionParents(); }
		#endregion // Forward constructors

		public override void AdjustPrefix()
		{

			for (int i = 0; i < DomChildCount(NodeType.Attribute, "", "CRS"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Attribute, "", "CRS", i);
				InternalAdjustPrefix(DOMNode, false);
			}

			for (int i = 0; i < DomChildCount(NodeType.Attribute, "", "minx"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Attribute, "", "minx", i);
				InternalAdjustPrefix(DOMNode, false);
			}

			for (int i = 0; i < DomChildCount(NodeType.Attribute, "", "miny"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Attribute, "", "miny", i);
				InternalAdjustPrefix(DOMNode, false);
			}

			for (int i = 0; i < DomChildCount(NodeType.Attribute, "", "maxx"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Attribute, "", "maxx", i);
				InternalAdjustPrefix(DOMNode, false);
			}

			for (int i = 0; i < DomChildCount(NodeType.Attribute, "", "maxy"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Attribute, "", "maxy", i);
				InternalAdjustPrefix(DOMNode, false);
			}

			for (int i = 0; i < DomChildCount(NodeType.Attribute, "", "resx"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Attribute, "", "resx", i);
				InternalAdjustPrefix(DOMNode, false);
			}

			for (int i = 0; i < DomChildCount(NodeType.Attribute, "", "resy"); i++)
			{
				XmlNode DOMNode = GetDomChildAt(NodeType.Attribute, "", "resy", i);
				InternalAdjustPrefix(DOMNode, false);
			}
		}


		#region CRS accessor methods
		public int GetCRSMinCount()
		{
			return 1;
		}

		public int CRSMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetCRSMaxCount()
		{
			return 1;
		}

		public int CRSMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetCRSCount()
		{
			return DomChildCount(NodeType.Attribute, "", "CRS");
		}

		public int CRSCount
		{
			get
			{
				return DomChildCount(NodeType.Attribute, "", "CRS");
			}
		}

		public bool HasCRS()
		{
			return HasDomChild(NodeType.Attribute, "", "CRS");
		}

		public SchemaString GetCRSAt(int index)
		{
			return new SchemaString(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "CRS", index)));
		}

		public SchemaString GetCRS()
		{
			return GetCRSAt(0);
		}

		public SchemaString CRS
		{
			get
			{
				return GetCRSAt(0);
			}
		}

		public void RemoveCRSAt(int index)
		{
			RemoveDomChildAt(NodeType.Attribute, "", "CRS", index);
		}

		public void RemoveCRS()
		{
			while (HasCRS())
				RemoveCRSAt(0);
		}

		public void AddCRS(SchemaString newValue)
		{
			AppendDomChild(NodeType.Attribute, "", "CRS", newValue.ToString());
		}

		public void InsertCRSAt(SchemaString newValue, int index)
		{
			InsertDomChildAt(NodeType.Attribute, "", "CRS", index, newValue.ToString());
		}

		public void ReplaceCRSAt(SchemaString newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Attribute, "", "CRS", index, newValue.ToString());
		}
		#endregion // CRS accessor methods

		#region CRS collection
        public CRSCollection	MyCRSs = new CRSCollection( );

        public class CRSCollection: IEnumerable
        {
            BoundingBoxType parent;
            public BoundingBoxType Parent
			{
				set
				{
					parent = value;
				}
			}
			public CRSEnumerator GetEnumerator() 
			{
				return new CRSEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class CRSEnumerator: IEnumerator 
        {
			int nIndex;
			BoundingBoxType parent;
			public CRSEnumerator(BoundingBoxType par) 
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
				return(nIndex < parent.CRSCount );
			}
			public SchemaString  Current 
			{
				get 
				{
					return(parent.GetCRSAt(nIndex));
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

        #endregion // CRS collection

		#region minx accessor methods
		public int GetminxMinCount()
		{
			return 1;
		}

		public int minxMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetminxMaxCount()
		{
			return 1;
		}

		public int minxMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetminxCount()
		{
			return DomChildCount(NodeType.Attribute, "", "minx");
		}

		public int minxCount
		{
			get
			{
				return DomChildCount(NodeType.Attribute, "", "minx");
			}
		}

		public bool Hasminx()
		{
			return HasDomChild(NodeType.Attribute, "", "minx");
		}

		public SchemaDecimal GetminxAt(int index)
		{
			return new SchemaDecimal(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "minx", index)));
		}

		public SchemaDecimal Getminx()
		{
			return GetminxAt(0);
		}

		public SchemaDecimal minx
		{
			get
			{
				return GetminxAt(0);
			}
		}

		public void RemoveminxAt(int index)
		{
			RemoveDomChildAt(NodeType.Attribute, "", "minx", index);
		}

		public void Removeminx()
		{
			while (Hasminx())
				RemoveminxAt(0);
		}

		public void Addminx(SchemaDecimal newValue)
		{
			AppendDomChild(NodeType.Attribute, "", "minx", newValue.ToString());
		}

		public void InsertminxAt(SchemaDecimal newValue, int index)
		{
			InsertDomChildAt(NodeType.Attribute, "", "minx", index, newValue.ToString());
		}

		public void ReplaceminxAt(SchemaDecimal newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Attribute, "", "minx", index, newValue.ToString());
		}
		#endregion // minx accessor methods

		#region minx collection
        public minxCollection	Myminxs = new minxCollection( );

        public class minxCollection: IEnumerable
        {
            BoundingBoxType parent;
            public BoundingBoxType Parent
			{
				set
				{
					parent = value;
				}
			}
			public minxEnumerator GetEnumerator() 
			{
				return new minxEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class minxEnumerator: IEnumerator 
        {
			int nIndex;
			BoundingBoxType parent;
			public minxEnumerator(BoundingBoxType par) 
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
				return(nIndex < parent.minxCount );
			}
			public SchemaDecimal  Current 
			{
				get 
				{
					return(parent.GetminxAt(nIndex));
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

        #endregion // minx collection

		#region miny accessor methods
		public int GetminyMinCount()
		{
			return 1;
		}

		public int minyMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetminyMaxCount()
		{
			return 1;
		}

		public int minyMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetminyCount()
		{
			return DomChildCount(NodeType.Attribute, "", "miny");
		}

		public int minyCount
		{
			get
			{
				return DomChildCount(NodeType.Attribute, "", "miny");
			}
		}

		public bool Hasminy()
		{
			return HasDomChild(NodeType.Attribute, "", "miny");
		}

		public SchemaDecimal GetminyAt(int index)
		{
			return new SchemaDecimal(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "miny", index)));
		}

		public SchemaDecimal Getminy()
		{
			return GetminyAt(0);
		}

		public SchemaDecimal miny
		{
			get
			{
				return GetminyAt(0);
			}
		}

		public void RemoveminyAt(int index)
		{
			RemoveDomChildAt(NodeType.Attribute, "", "miny", index);
		}

		public void Removeminy()
		{
			while (Hasminy())
				RemoveminyAt(0);
		}

		public void Addminy(SchemaDecimal newValue)
		{
			AppendDomChild(NodeType.Attribute, "", "miny", newValue.ToString());
		}

		public void InsertminyAt(SchemaDecimal newValue, int index)
		{
			InsertDomChildAt(NodeType.Attribute, "", "miny", index, newValue.ToString());
		}

		public void ReplaceminyAt(SchemaDecimal newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Attribute, "", "miny", index, newValue.ToString());
		}
		#endregion // miny accessor methods

		#region miny collection
        public minyCollection	Myminys = new minyCollection( );

        public class minyCollection: IEnumerable
        {
            BoundingBoxType parent;
            public BoundingBoxType Parent
			{
				set
				{
					parent = value;
				}
			}
			public minyEnumerator GetEnumerator() 
			{
				return new minyEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class minyEnumerator: IEnumerator 
        {
			int nIndex;
			BoundingBoxType parent;
			public minyEnumerator(BoundingBoxType par) 
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
				return(nIndex < parent.minyCount );
			}
			public SchemaDecimal  Current 
			{
				get 
				{
					return(parent.GetminyAt(nIndex));
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

        #endregion // miny collection

		#region maxx accessor methods
		public int GetmaxxMinCount()
		{
			return 1;
		}

		public int maxxMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetmaxxMaxCount()
		{
			return 1;
		}

		public int maxxMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetmaxxCount()
		{
			return DomChildCount(NodeType.Attribute, "", "maxx");
		}

		public int maxxCount
		{
			get
			{
				return DomChildCount(NodeType.Attribute, "", "maxx");
			}
		}

		public bool Hasmaxx()
		{
			return HasDomChild(NodeType.Attribute, "", "maxx");
		}

		public SchemaDecimal GetmaxxAt(int index)
		{
			return new SchemaDecimal(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "maxx", index)));
		}

		public SchemaDecimal Getmaxx()
		{
			return GetmaxxAt(0);
		}

		public SchemaDecimal maxx
		{
			get
			{
				return GetmaxxAt(0);
			}
		}

		public void RemovemaxxAt(int index)
		{
			RemoveDomChildAt(NodeType.Attribute, "", "maxx", index);
		}

		public void Removemaxx()
		{
			while (Hasmaxx())
				RemovemaxxAt(0);
		}

		public void Addmaxx(SchemaDecimal newValue)
		{
			AppendDomChild(NodeType.Attribute, "", "maxx", newValue.ToString());
		}

		public void InsertmaxxAt(SchemaDecimal newValue, int index)
		{
			InsertDomChildAt(NodeType.Attribute, "", "maxx", index, newValue.ToString());
		}

		public void ReplacemaxxAt(SchemaDecimal newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Attribute, "", "maxx", index, newValue.ToString());
		}
		#endregion // maxx accessor methods

		#region maxx collection
        public maxxCollection	Mymaxxs = new maxxCollection( );

        public class maxxCollection: IEnumerable
        {
            BoundingBoxType parent;
            public BoundingBoxType Parent
			{
				set
				{
					parent = value;
				}
			}
			public maxxEnumerator GetEnumerator() 
			{
				return new maxxEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class maxxEnumerator: IEnumerator 
        {
			int nIndex;
			BoundingBoxType parent;
			public maxxEnumerator(BoundingBoxType par) 
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
				return(nIndex < parent.maxxCount );
			}
			public SchemaDecimal  Current 
			{
				get 
				{
					return(parent.GetmaxxAt(nIndex));
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

        #endregion // maxx collection

		#region maxy accessor methods
		public int GetmaxyMinCount()
		{
			return 1;
		}

		public int maxyMinCount
		{
			get
			{
				return 1;
			}
		}

		public int GetmaxyMaxCount()
		{
			return 1;
		}

		public int maxyMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetmaxyCount()
		{
			return DomChildCount(NodeType.Attribute, "", "maxy");
		}

		public int maxyCount
		{
			get
			{
				return DomChildCount(NodeType.Attribute, "", "maxy");
			}
		}

		public bool Hasmaxy()
		{
			return HasDomChild(NodeType.Attribute, "", "maxy");
		}

		public SchemaDecimal GetmaxyAt(int index)
		{
			return new SchemaDecimal(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "maxy", index)));
		}

		public SchemaDecimal Getmaxy()
		{
			return GetmaxyAt(0);
		}

		public SchemaDecimal maxy
		{
			get
			{
				return GetmaxyAt(0);
			}
		}

		public void RemovemaxyAt(int index)
		{
			RemoveDomChildAt(NodeType.Attribute, "", "maxy", index);
		}

		public void Removemaxy()
		{
			while (Hasmaxy())
				RemovemaxyAt(0);
		}

		public void Addmaxy(SchemaDecimal newValue)
		{
			AppendDomChild(NodeType.Attribute, "", "maxy", newValue.ToString());
		}

		public void InsertmaxyAt(SchemaDecimal newValue, int index)
		{
			InsertDomChildAt(NodeType.Attribute, "", "maxy", index, newValue.ToString());
		}

		public void ReplacemaxyAt(SchemaDecimal newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Attribute, "", "maxy", index, newValue.ToString());
		}
		#endregion // maxy accessor methods

		#region maxy collection
        public maxyCollection	Mymaxys = new maxyCollection( );

        public class maxyCollection: IEnumerable
        {
            BoundingBoxType parent;
            public BoundingBoxType Parent
			{
				set
				{
					parent = value;
				}
			}
			public maxyEnumerator GetEnumerator() 
			{
				return new maxyEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class maxyEnumerator: IEnumerator 
        {
			int nIndex;
			BoundingBoxType parent;
			public maxyEnumerator(BoundingBoxType par) 
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
				return(nIndex < parent.maxyCount );
			}
			public SchemaDecimal  Current 
			{
				get 
				{
					return(parent.GetmaxyAt(nIndex));
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

        #endregion // maxy collection

		#region resx accessor methods
		public int GetresxMinCount()
		{
			return 0;
		}

		public int resxMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetresxMaxCount()
		{
			return 1;
		}

		public int resxMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetresxCount()
		{
			return DomChildCount(NodeType.Attribute, "", "resx");
		}

		public int resxCount
		{
			get
			{
				return DomChildCount(NodeType.Attribute, "", "resx");
			}
		}

		public bool Hasresx()
		{
			return HasDomChild(NodeType.Attribute, "", "resx");
		}

		public SchemaDecimal GetresxAt(int index)
		{
			return new SchemaDecimal(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "resx", index)));
		}

		public SchemaDecimal Getresx()
		{
			return GetresxAt(0);
		}

		public SchemaDecimal resx
		{
			get
			{
				return GetresxAt(0);
			}
		}

		public void RemoveresxAt(int index)
		{
			RemoveDomChildAt(NodeType.Attribute, "", "resx", index);
		}

		public void Removeresx()
		{
			while (Hasresx())
				RemoveresxAt(0);
		}

		public void Addresx(SchemaDecimal newValue)
		{
			AppendDomChild(NodeType.Attribute, "", "resx", newValue.ToString());
		}

		public void InsertresxAt(SchemaDecimal newValue, int index)
		{
			InsertDomChildAt(NodeType.Attribute, "", "resx", index, newValue.ToString());
		}

		public void ReplaceresxAt(SchemaDecimal newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Attribute, "", "resx", index, newValue.ToString());
		}
		#endregion // resx accessor methods

		#region resx collection
        public resxCollection	Myresxs = new resxCollection( );

        public class resxCollection: IEnumerable
        {
            BoundingBoxType parent;
            public BoundingBoxType Parent
			{
				set
				{
					parent = value;
				}
			}
			public resxEnumerator GetEnumerator() 
			{
				return new resxEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class resxEnumerator: IEnumerator 
        {
			int nIndex;
			BoundingBoxType parent;
			public resxEnumerator(BoundingBoxType par) 
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
				return(nIndex < parent.resxCount );
			}
			public SchemaDecimal  Current 
			{
				get 
				{
					return(parent.GetresxAt(nIndex));
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

        #endregion // resx collection

		#region resy accessor methods
		public int GetresyMinCount()
		{
			return 0;
		}

		public int resyMinCount
		{
			get
			{
				return 0;
			}
		}

		public int GetresyMaxCount()
		{
			return 1;
		}

		public int resyMaxCount
		{
			get
			{
				return 1;
			}
		}

		public int GetresyCount()
		{
			return DomChildCount(NodeType.Attribute, "", "resy");
		}

		public int resyCount
		{
			get
			{
				return DomChildCount(NodeType.Attribute, "", "resy");
			}
		}

		public bool Hasresy()
		{
			return HasDomChild(NodeType.Attribute, "", "resy");
		}

		public SchemaDecimal GetresyAt(int index)
		{
			return new SchemaDecimal(GetDomNodeValue(GetDomChildAt(NodeType.Attribute, "", "resy", index)));
		}

		public SchemaDecimal Getresy()
		{
			return GetresyAt(0);
		}

		public SchemaDecimal resy
		{
			get
			{
				return GetresyAt(0);
			}
		}

		public void RemoveresyAt(int index)
		{
			RemoveDomChildAt(NodeType.Attribute, "", "resy", index);
		}

		public void Removeresy()
		{
			while (Hasresy())
				RemoveresyAt(0);
		}

		public void Addresy(SchemaDecimal newValue)
		{
			AppendDomChild(NodeType.Attribute, "", "resy", newValue.ToString());
		}

		public void InsertresyAt(SchemaDecimal newValue, int index)
		{
			InsertDomChildAt(NodeType.Attribute, "", "resy", index, newValue.ToString());
		}

		public void ReplaceresyAt(SchemaDecimal newValue, int index)
		{
			ReplaceDomChildAt(NodeType.Attribute, "", "resy", index, newValue.ToString());
		}
		#endregion // resy accessor methods

		#region resy collection
        public resyCollection	Myresys = new resyCollection( );

        public class resyCollection: IEnumerable
        {
            BoundingBoxType parent;
            public BoundingBoxType Parent
			{
				set
				{
					parent = value;
				}
			}
			public resyEnumerator GetEnumerator() 
			{
				return new resyEnumerator(parent);
			}
		
			IEnumerator IEnumerable.GetEnumerator() 
			{
				return GetEnumerator();
			}
        }

        public class resyEnumerator: IEnumerator 
        {
			int nIndex;
			BoundingBoxType parent;
			public resyEnumerator(BoundingBoxType par) 
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
				return(nIndex < parent.resyCount );
			}
			public SchemaDecimal  Current 
			{
				get 
				{
					return(parent.GetresyAt(nIndex));
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

        #endregion // resy collection

        private void SetCollectionParents()
        {
            MyCRSs.Parent = this; 
            Myminxs.Parent = this; 
            Myminys.Parent = this; 
            Mymaxxs.Parent = this; 
            Mymaxys.Parent = this; 
            Myresxs.Parent = this; 
            Myresys.Parent = this; 
	}
}
}
