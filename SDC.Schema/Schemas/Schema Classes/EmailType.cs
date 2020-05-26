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

/// <summary>
/// A structure for recording email addresses.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
public partial class EmailType : ExtensionBaseType
{
    
    #region Private fields
    private EmailAddressType _emailAddress;
    
    private string_Stype _emailClass;
    
    private string_Stype _usage;
    #endregion
    
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public virtual EmailAddressType EmailAddress
    {
        get
        {
            return this._emailAddress;
        }
        set
        {
            if ((this._emailAddress == value))
            {
                return;
            }
            if (((this._emailAddress == null) 
                        || (_emailAddress.Equals(value) != true)))
            {
                this._emailAddress = value;
                this.OnPropertyChanged("EmailAddress", value);
            }
        }
    }
    
    /// <summary>
    /// Type of email, e.g., home, office, etc
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=1)]
    public virtual string_Stype EmailClass
    {
        get
        {
            return this._emailClass;
        }
        set
        {
            if ((this._emailClass == value))
            {
                return;
            }
            if (((this._emailClass == null) 
                        || (_emailClass.Equals(value) != true)))
            {
                this._emailClass = value;
                this.OnPropertyChanged("EmailClass", value);
            }
        }
    }
    
    /// <summary>
    /// When this email should be used
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=2)]
    public virtual string_Stype Usage
    {
        get
        {
            return this._usage;
        }
        set
        {
            if ((this._usage == value))
            {
                return;
            }
            if (((this._usage == null) 
                        || (_usage.Equals(value) != true)))
            {
                this._usage = value;
                this.OnPropertyChanged("Usage", value);
            }
        }
    }
    
    /// <summary>
    /// Test whether EmailAddress should be serialized
    /// </summary>
    public virtual bool ShouldSerializeEmailAddress()
    {
        return (_emailAddress != null);
    }
    
    /// <summary>
    /// Test whether EmailClass should be serialized
    /// </summary>
    public virtual bool ShouldSerializeEmailClass()
    {
        return (_emailClass != null);
    }
    
    /// <summary>
    /// Test whether Usage should be serialized
    /// </summary>
    public virtual bool ShouldSerializeUsage()
    {
        return (_usage != null);
    }
}
}
#pragma warning restore