// ------------------------------------------------------------------------------
//  <auto-generated>
//    Generated by Xsd2Code++. Version 5.1.87.0. www.xsd2code.com
//  </auto-generated>
// ------------------------------------------------------------------------------
#pragma warning disable
namespace SDC.Schema
{
using System;
using System.Diagnostics;
using System.Xml.Serialization;
using System.Collections;
using System.Xml.Schema;
using System.ComponentModel;
using System.Xml;
using System.IO;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;

[System.Xml.Serialization.XmlIncludeAttribute(typeof(TargetItemIDType))]
[System.Xml.Serialization.XmlIncludeAttribute(typeof(anyURI_DEtype))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
public partial class anyURI_Stype : BaseType
{
    
    #region Private fields
    private string _mediaType;
    
    private string _val;
    #endregion
    
    /// <summary>
    /// TBD: Must be a valid Media (MIME) type
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string mediaType
    {
        get
        {
            return this._mediaType;
        }
        set
        {
            if ((this._mediaType == value))
            {
                return;
            }
            if (((this._mediaType == null) 
                        || (_mediaType.Equals(value) != true)))
            {
                this._mediaType = value;
                this.OnPropertyChanged("mediaType", value);
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public virtual string val
    {
        get
        {
            return this._val;
        }
        set
        {
            if ((this._val == value))
            {
                return;
            }
            if (((this._val == null) 
                        || (_val.Equals(value) != true)))
            {
                this._val = value;
                this.OnPropertyChanged("val", value);
            }
        }
    }
    
    /// <summary>
    /// Test whether mediaType should be serialized
    /// </summary>
    public virtual bool ShouldSerializemediaType()
    {
        return !string.IsNullOrEmpty(mediaType);
    }
    
    /// <summary>
    /// Test whether val should be serialized
    /// </summary>
    public virtual bool ShouldSerializeval()
    {
        return !string.IsNullOrEmpty(val);
    }
}
}
#pragma warning restore