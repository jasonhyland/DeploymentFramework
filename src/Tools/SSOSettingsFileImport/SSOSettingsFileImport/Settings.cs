// Copyright 2004, Microsoft Corporation
// Sample Code - Use restricted to terms of use defined in the accompanying license agreement (EULA.doc)

//--------------------------------------------------------------
// Autogenerated by XSDObjectGen version 1.3.6.0
// Schema file: Settings.xsd
// Creation Date: 12/3/2004 10:54:38 AM
//--------------------------------------------------------------

using System;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;

namespace SSOSettingsFileManager
{

	public struct Declarations
	{
		public const string SchemaVersion = "";
	}


	[Serializable]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	public class propertyCollection : ArrayList
	{
		public property Add(property obj)
		{
			base.Add(obj);
			return obj;
		}

		public property Add()
		{
			return Add(new property());
		}

		public void Insert(int index, property obj)
		{
			base.Insert(index, obj);
		}

		public void Remove(property obj)
		{
			base.Remove(obj);
		}

		new public property this[int index]
		{
			get { return (property) base[index]; }
			set { base[index] = value; }
		}
	}



	[XmlRoot(ElementName="property",IsNullable=false),Serializable]
	public class property
	{

		[XmlAttribute(AttributeName="name",Form=XmlSchemaForm.Unqualified,DataType="string")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string __name;
		
		[XmlIgnore]
		public string name
		{ 
			get { return __name; }
			set { __name = value; }
		}

		[XmlText(DataType="string")]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public string __Value;
		
		[XmlIgnore]
		public string Value
		{ 
			get { return __Value; }
			set { __Value = value; }
		}

		public property()
		{
		}
	}


	[XmlRoot(ElementName="settings",IsNullable=false),Serializable]
	public class settings
	{
		[System.Runtime.InteropServices.DispIdAttribute(-4)]
		public IEnumerator GetEnumerator() 
		{
			return propertyCollection.GetEnumerator();
		}

		public property Add(property obj)
		{
			return propertyCollection.Add(obj);
		}

		[XmlIgnore]
		public property this[int index]
		{
			get { return (property) propertyCollection[index]; }
		}

		[XmlIgnore]
        public int Count 
		{
            get { return propertyCollection.Count; }
        }

        public void Clear()
		{
            propertyCollection.Clear();
        }

		public property Remove(int index) 
		{ 
            property obj = propertyCollection[index];
            propertyCollection.Remove(obj);
			return obj;
        }

        public void Remove(object obj)
		{
            propertyCollection.Remove(obj);
        }

		[XmlElement(Type=typeof(property),ElementName="property",IsNullable=false,Form=XmlSchemaForm.Qualified)]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		public propertyCollection __propertyCollection;
		
		[XmlIgnore]
		public propertyCollection propertyCollection
		{
			get
			{
				if (__propertyCollection == null) __propertyCollection = new propertyCollection();
				return __propertyCollection;
			}
			set {__propertyCollection = value;}
		}

		public settings()
		{
		}
	}
}