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
/// This type supports the mapping of the targeted template items to any other template items or code system.  The @type tokens include PrePop, AutoPop, SNOMED, LOINC, Keys, LocalValues, etc.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
[System.Xml.Serialization.XmlRootAttribute("Map", Namespace="urn:ihe:qrph:sdc:2016", IsNullable=false)]
public partial class MappingType : ExtensionBaseType
{
    
    #region Private fields
    private CodeSystemType _defaultCodeSystem;
    
    private List<ItemMapType> _itemMap;
    
    private string _templateID;
    
    private string _targetTemplateID;
    #endregion
    
    /// <summary>
    /// Specifies the default coding system to be implied for all MappedCode elements listed in thte ItemMap entries.  Any CodeSystem explicitly used in a MappedCode entry will override the default value.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute(Order=0)]
    public virtual CodeSystemType DefaultCodeSystem
    {
        get
        {
            return this._defaultCodeSystem;
        }
        set
        {
            if ((this._defaultCodeSystem == value))
            {
                return;
            }
            if (((this._defaultCodeSystem == null) 
                        || (_defaultCodeSystem.Equals(value) != true)))
            {
                this._defaultCodeSystem = value;
                this.OnPropertyChanged("DefaultCodeSystem", value);
            }
        }
    }
    
    /// <summary>
    /// Entries under this element map a target item in a FormDesignTemplate to a terminology code, local value, XML-based document entry, database record, RDF store triple, etc.
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("ItemMap", Order=1)]
    public virtual List<ItemMapType> ItemMap
    {
        get
        {
            return this._itemMap;
        }
        set
        {
            if ((this._itemMap == value))
            {
                return;
            }
            if (((this._itemMap == null) 
                        || (_itemMap.Equals(value) != true)))
            {
                this._itemMap = value;
                this.OnPropertyChanged("ItemMap", value);
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public virtual string templateID
    {
        get
        {
            return this._templateID;
        }
        set
        {
            if ((this._templateID == value))
            {
                return;
            }
            if (((this._templateID == null) 
                        || (_templateID.Equals(value) != true)))
            {
                this._templateID = value;
                this.OnPropertyChanged("templateID", value);
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
    public virtual string targetTemplateID
    {
        get
        {
            return this._targetTemplateID;
        }
        set
        {
            if ((this._targetTemplateID == value))
            {
                return;
            }
            if (((this._targetTemplateID == null) 
                        || (_targetTemplateID.Equals(value) != true)))
            {
                this._targetTemplateID = value;
                this.OnPropertyChanged("targetTemplateID", value);
            }
        }
    }
    
    /// <summary>
    /// Test whether ItemMap should be serialized
    /// </summary>
    public virtual bool ShouldSerializeItemMap()
    {
        return ItemMap != null && ItemMap.Count > 0;
    }
    
    /// <summary>
    /// Test whether DefaultCodeSystem should be serialized
    /// </summary>
    public virtual bool ShouldSerializeDefaultCodeSystem()
    {
        return (_defaultCodeSystem != null);
    }
    
    /// <summary>
    /// Test whether templateID should be serialized
    /// </summary>
    public virtual bool ShouldSerializetemplateID()
    {
        return !string.IsNullOrEmpty(templateID);
    }
    
    /// <summary>
    /// Test whether targetTemplateID should be serialized
    /// </summary>
    public virtual bool ShouldSerializetargetTemplateID()
    {
        return !string.IsNullOrEmpty(targetTemplateID);
    }
}
}
#pragma warning restore