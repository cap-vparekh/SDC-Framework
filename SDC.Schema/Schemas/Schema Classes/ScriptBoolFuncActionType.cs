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

[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
public partial class ScriptBoolFuncActionType : ScriptCodeBoolType
{
    
    #region Private fields
    private ExtensionBaseType[] _items;

        private ItemsChoiceType[] _itemsElementName;
    #endregion
    
    [System.Xml.Serialization.XmlElementAttribute("Actions", typeof(ActionsType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("ConditionalActions", typeof(PredActionType), Order=0)]
    [System.Xml.Serialization.XmlElementAttribute("Else", typeof(PredActionType), Order=0)]
    [System.Xml.Serialization.XmlChoiceIdentifierAttribute("ItemsElementName")]
    public virtual ExtensionBaseType[] Items 
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
    
    [System.Xml.Serialization.XmlElementAttribute("ItemsElementName", Order=1)]
    [System.Xml.Serialization.XmlIgnoreAttribute()]
    public virtual ItemsChoiceType[] ItemsElementName
    {
        get
        {
            return this._itemsElementName;
        }
        set
        {
            if ((this._itemsElementName == value))
            {
                return;
            }
            if (((this._itemsElementName == null) 
                        || (_itemsElementName.Equals(value) != true)))
            {
                this._itemsElementName = value;
                this.OnPropertyChanged("ItemsElementName", value);
            }
        }
    }
}
}
#pragma warning restore
