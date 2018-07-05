﻿//
// Document.cs
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
using System.Xml;
using Altova;

namespace Altova.Xml
{
	public class XmlException : AltovaException 
	{
		public XmlException(string text) :
			base( text )
		{
		}

		public XmlException(Exception other) 
			: base( other )
		{
		}
	}

	public abstract class Document
	{
		protected static XmlDocument			tmpDocument		= null;
		protected static XmlDocumentFragment	tmpFragment		= null;

		protected static XmlDocument GetTemporaryDocument()
		{
			if (tmpDocument == null)
				tmpDocument = new XmlDocument();
			return tmpDocument;
		}

		public static XmlNode CreateTemporaryDomNode()
		{
			string tmpName = "tmp";
			if (tmpFragment == null)
			{
				tmpFragment = GetTemporaryDocument().CreateDocumentFragment();
				tmpDocument.AppendChild(tmpFragment);
			}

			XmlNode node = GetTemporaryDocument().CreateElement(tmpName);
			tmpFragment.AppendChild(node);
			return node;
		}

		protected System.Text.Encoding encoding = System.Text.Encoding.UTF8;
		protected string rootElementName	= null;
		protected string namespaceURI		= null;
		protected string schemaLocation		= null;

		public Document()
		{
		}

		public System.Text.Encoding Encoding
		{
			set
			{
				encoding = value;
			}
		}

		public void SetEncoding(string encoding)
		{
			encoding = encoding.ToUpper();
			if (encoding == "UTF-8")
				this.encoding = System.Text.Encoding.UTF8;
			else if (encoding == "UTF-16")
				this.encoding = System.Text.Encoding.Unicode;
			else if (encoding == "UTF-7")
				this.encoding = System.Text.Encoding.UTF7;
			else if (encoding == "US-ASCII")
				this.encoding = System.Text.Encoding.ASCII;
			else
			{
				try
				{
					this.encoding = System.Text.Encoding.GetEncoding( encoding );
				}
				catch( NotSupportedException )
				{
					throw new XmlException("Unknown encoding");
				}
			}
		}

		public void SetRootElementName(string namespaceURI, string rootElementName)
		{
			this.namespaceURI = namespaceURI;
			this.rootElementName = rootElementName;
		}

		public void SetSchemaLocation(string schemaLocation)
		{
			this.schemaLocation = schemaLocation;
		}

		public XmlNode Load(XmlReader reader)
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(reader);
			return doc.DocumentElement;
		}

		public XmlNode Load(string filename)
		{
			XmlDocument doc = new XmlDocument();
			doc.Load(filename);
			return doc.DocumentElement;
		}

		public XmlNode LoadFromString(string xml)
		{
			XmlDocument doc = new XmlDocument();
			doc.LoadXml(xml);
			return doc.DocumentElement;
		}

		public void Save(string filename, Node node)
		{
			XmlTextWriter writer = new XmlTextWriter(filename, encoding);
			Save(writer, node);
			writer.Close();
		}

		public void Save(XmlWriter writer, Node node)
		{
			FinalizeRootElement(node);
			Node.InternalAdjustPrefix(node.domNode, true);
			node.AdjustPrefix();
			node.domNode.OwnerDocument.Save( writer );
		}

		public string SaveToString(Node node)
		{
			FinalizeRootElement(node);
			Node.InternalAdjustPrefix(node.domNode, true);
			node.AdjustPrefix();
			return node.domNode.OwnerDocument.InnerXml;
		}

		abstract protected void DeclareNamespaces(Node node);

		protected void DeclareNamespace(Node node, string prefix, string URI)
		{
			node.DeclareNamespace(prefix, URI);
		}

		protected void FinalizeRootElement(Node node)
		{
			if (node.domNode.ParentNode.NodeType != XmlNodeType.DocumentFragment)
				return;

			if (rootElementName == null || rootElementName == "")
				throw new Exception("Call SetRootElementName first");

			node.MakeRoot(namespaceURI, rootElementName, schemaLocation);
			DeclareNamespaces(node);
		}
	}
}
