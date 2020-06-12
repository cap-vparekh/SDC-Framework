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
/// ChildItems have descendants that are of type DisplayedType. They may
/// include primary items of type SectionType, QuestionType, InjectFormType,
/// DisplayedType and ButtonType, in any order. The ChildItem separates new child
/// primary items from elements and attributes that are sub-parts of the parent primary
/// item.
/// </summary>
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
public partial class ChildItemsType : ExtensionBaseType
{
    
    #region Private fields
    private List<IdentifiedExtensionType> _items;
        #endregion
    /// <summary>
    /// May hold one  or more of the following:
    /// ButtonAction (ButtonItemType),
    /// DisplayedItem (DisplayedType),
    /// InjectForm (InjectFormType),
    /// Question (QuestionItemType),
    /// Section(SectionItemType),
    /// </summary>
    [System.Xml.Serialization.XmlElementAttribute("ButtonAction", typeof(ButtonItemType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("DisplayedItem", typeof(DisplayedType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("InjectForm", typeof(InjectFormType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("Question", typeof(QuestionItemType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("Section", typeof(SectionItemType), Order=0)]
    public virtual List<IdentifiedExtensionType> Items
    {
        get
        {
            return this._items;
        }
        set
        {
            if ((this._items == value))
            {
                return;
            }
            if (((this._items == null) 
                        || (_items.Equals(value) != true)))
            {
                this._items = value;
                this.OnPropertyChanged("Items", value);
            }
        }
    }
    
    /// <summary>
    /// Test whether Items should be serialized
    /// </summary>
    public virtual bool ShouldSerializeItems()
    {
        return Items != null && Items.Count > 0;
    }
}
}
#pragma warning restore