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
/// This Rule evaluates an arbitrary set of attribute values from any item
/// and returns a Boolean summary value. In the PropertyValues condition, the contained
/// Boolean attributed values are ANDed together (by default) to return a derived
/// Boolean value. Default values are used if the attribute is not explicitly set to a
/// value. For attributes without default values, omitted (null) values are ignored and
/// are not used for null propagation.
/// </summary>
[System.Xml.Serialization.XmlIncludeAttribute(typeof(AttributeEvalActionType))]
[System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.3752.0")]
[System.SerializableAttribute()]
[System.ComponentModel.DesignerCategoryAttribute("code")]
[System.Xml.Serialization.XmlTypeAttribute(Namespace="urn:ihe:qrph:sdc:2016")]
public partial class PredEvalAttribValuesType : FuncBoolBaseType
{
    
    #region Private fields
    private bool _shouldSerializeboolOp;
    
    private bool _shouldSerializehasValue;
    
    private bool _shouldSerializeisReadOnly;
    
    private bool _shouldSerializeisRequired;
    
    private bool _shouldSerializeisEnabled;
    
    private bool _shouldSerializeisVisible;
    
    private bool _shouldSerializehasResponse;
    
    private bool _shouldSerializeisActive;
    
    private bool _shouldSerializeisSelected;
    
    private bool _shouldSerializenot;
    
    private bool _not;
    
    private PredEvalAttribValuesTypeBoolOp _boolOp;
    
    private string _itemNames;
    
    private bool _isSelected;
    
    private bool _isActive;
    
    private string _hasSelectionsGTE;
    
    private string _hasSelectionsLTE;
    
    private string _hasSelectionsExact;
    
    private bool _hasResponse;
    
    private bool _isVisible;
    
    private bool _isEnabled;
    
    private bool _isRequired;
    
    private bool _isReadOnly;
    
    private string _hasType;
    
    private string _hasStyleClass;
    
    private bool _hasValue;
    
    private string _supportDatesAndIntervals;
    
    private string _hasPattern;
    
    private string _hasValueEQ;
    
    private string _hasValueLT;
    
    private string _hasValueLTE;
    
    private string _hasValueGT;
    
    private string _hasValueGTE;
    
    private string _hasAssociatedValueEQ;
    
    private string _hasAssociatedValueLT;
    
    private string _hasAssociatedValueLTE;
    
    private string _hasAssociatedValueGT;
    
    private string _hasAssociatedValueGTE;
    #endregion
    
    /// <summary>
    /// PredEvalAttribValuesType class constructor
    /// </summary>
    public PredEvalAttribValuesType()
    {
        this._not = false;
        this._boolOp = PredEvalAttribValuesTypeBoolOp.AND;
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(false)]
    public virtual bool not
    {
        get
        {
            return this._not;
        }
        set
        {
            if ((_not.Equals(value) != true))
            {
                this._not = value;
                this.OnPropertyChanged("not", value);
            }
            _shouldSerializenot = true;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    [System.ComponentModel.DefaultValueAttribute(PredEvalAttribValuesTypeBoolOp.AND)]
    public virtual PredEvalAttribValuesTypeBoolOp boolOp
    {
        get
        {
            return this._boolOp;
        }
        set
        {
            if ((_boolOp.Equals(value) != true))
            {
                this._boolOp = value;
                this.OnPropertyChanged("boolOp", value);
            }
            _shouldSerializeboolOp = true;
        }
    }
    
    /// <summary>
    /// Required. This attribute holds the @name attributes of the
    /// item(s) (Section, Question, List Item) to interrogate. These named items
    /// will be searched for attribute values specified in this Type. If a named
    /// item does not have a particualr attribute, then the attribute condition
    /// is ignored for that named item. It does not generate an error or a null
    /// propagation response.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKENS")]
    public virtual string itemNames
    {
        get
        {
            return this._itemNames;
        }
        set
        {
            if ((this._itemNames == value))
            {
                return;
            }
            if (((this._itemNames == null) 
                        || (_itemNames.Equals(value) != true)))
            {
                this._itemNames = value;
                this.OnPropertyChanged("itemNames", value);
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual bool isSelected
    {
        get
        {
            return this._isSelected;
        }
        set
        {
            if ((_isSelected.Equals(value) != true))
            {
                this._isSelected = value;
                this.OnPropertyChanged("isSelected", value);
            }
            _shouldSerializeisSelected = true;
        }
    }
    
    /// <summary>
    /// If visible and enabled are both true, then isActive is
    /// true. Otherwise, it is false.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual bool isActive
    {
        get
        {
            return this._isActive;
        }
        set
        {
            if ((_isActive.Equals(value) != true))
            {
                this._isActive = value;
                this.OnPropertyChanged("isActive", value);
            }
            _shouldSerializeisActive = true;
        }
    }
    
    /// <summary>
    /// Applies only to Questions that have selection lists
    /// (ListItems or LookupField). Evaluates to true if the number of selected
    /// items equals or exceeds the entered value.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
    public virtual string hasSelectionsGTE
    {
        get
        {
            return this._hasSelectionsGTE;
        }
        set
        {
            if ((this._hasSelectionsGTE == value))
            {
                return;
            }
            if (((this._hasSelectionsGTE == null) 
                        || (_hasSelectionsGTE.Equals(value) != true)))
            {
                this._hasSelectionsGTE = value;
                this.OnPropertyChanged("hasSelectionsGTE", value);
            }
        }
    }
    
    /// <summary>
    /// Applies only to Questions that have selection lists
    /// (ListItems or LookupField). Evaluates to true if the number of selected
    /// items is less than or equal to the entered value.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
    public virtual string hasSelectionsLTE
    {
        get
        {
            return this._hasSelectionsLTE;
        }
        set
        {
            if ((this._hasSelectionsLTE == value))
            {
                return;
            }
            if (((this._hasSelectionsLTE == null) 
                        || (_hasSelectionsLTE.Equals(value) != true)))
            {
                this._hasSelectionsLTE = value;
                this.OnPropertyChanged("hasSelectionsLTE", value);
            }
        }
    }
    
    /// <summary>
    /// Applies only to Questions that have selection lists
    /// (ListItems or LookupField). Evaluates to true if the number of selected
    /// items equals the entered value.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="nonNegativeInteger")]
    public virtual string hasSelectionsExact
    {
        get
        {
            return this._hasSelectionsExact;
        }
        set
        {
            if ((this._hasSelectionsExact == value))
            {
                return;
            }
            if (((this._hasSelectionsExact == null) 
                        || (_hasSelectionsExact.Equals(value) != true)))
            {
                this._hasSelectionsExact = value;
                this.OnPropertyChanged("hasSelectionsExact", value);
            }
        }
    }
    
    /// <summary>
    /// Applies only to items that have Response Fields (Questions
    /// and ListItems). If the ListItem or Question has a Response Field, and
    /// that field has a value in it, this property returns true. If it does not
    /// have a value, it returns false. If no Response Field is present, it
    /// retuns null and is not used for Boolean comparisons.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual bool hasResponse
    {
        get
        {
            return this._hasResponse;
        }
        set
        {
            if ((_hasResponse.Equals(value) != true))
            {
                this._hasResponse = value;
                this.OnPropertyChanged("hasResponse", value);
            }
            _shouldSerializehasResponse = true;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual bool isVisible
    {
        get
        {
            return this._isVisible;
        }
        set
        {
            if ((_isVisible.Equals(value) != true))
            {
                this._isVisible = value;
                this.OnPropertyChanged("isVisible", value);
            }
            _shouldSerializeisVisible = true;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual bool isEnabled
    {
        get
        {
            return this._isEnabled;
        }
        set
        {
            if ((_isEnabled.Equals(value) != true))
            {
                this._isEnabled = value;
                this.OnPropertyChanged("isEnabled", value);
            }
            _shouldSerializeisEnabled = true;
        }
    }
    
    /// <summary>
    /// If the minCard value is greater than 0, then isRequired =
    /// "true" If the minCard = "0" then isRequired = "false"
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual bool isRequired
    {
        get
        {
            return this._isRequired;
        }
        set
        {
            if ((_isRequired.Equals(value) != true))
            {
                this._isRequired = value;
                this.OnPropertyChanged("isRequired", value);
            }
            _shouldSerializeisRequired = true;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual bool isReadOnly
    {
        get
        {
            return this._isReadOnly;
        }
        set
        {
            if ((_isReadOnly.Equals(value) != true))
            {
                this._isReadOnly = value;
                this.OnPropertyChanged("isReadOnly", value);
            }
            _shouldSerializeisReadOnly = true;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKENS")]
    public virtual string hasType
    {
        get
        {
            return this._hasType;
        }
        set
        {
            if ((this._hasType == value))
            {
                return;
            }
            if (((this._hasType == null) 
                        || (_hasType.Equals(value) != true)))
            {
                this._hasType = value;
                this.OnPropertyChanged("hasType", value);
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute(DataType="NMTOKENS")]
    public virtual string hasStyleClass
    {
        get
        {
            return this._hasStyleClass;
        }
        set
        {
            if ((this._hasStyleClass == value))
            {
                return;
            }
            if (((this._hasStyleClass == null) 
                        || (_hasStyleClass.Equals(value) != true)))
            {
                this._hasStyleClass = value;
                this.OnPropertyChanged("hasStyleClass", value);
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual bool hasValue
    {
        get
        {
            return this._hasValue;
        }
        set
        {
            if ((_hasValue.Equals(value) != true))
            {
                this._hasValue = value;
                this.OnPropertyChanged("hasValue", value);
            }
            _shouldSerializehasValue = true;
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute("supportDatesAndIntervals...")]
    public virtual string supportDatesAndIntervals
    {
        get
        {
            return this._supportDatesAndIntervals;
        }
        set
        {
            if ((this._supportDatesAndIntervals == value))
            {
                return;
            }
            if (((this._supportDatesAndIntervals == null) 
                        || (_supportDatesAndIntervals.Equals(value) != true)))
            {
                this._supportDatesAndIntervals = value;
                this.OnPropertyChanged("supportDatesAndIntervals", value);
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string hasPattern
    {
        get
        {
            return this._hasPattern;
        }
        set
        {
            if ((this._hasPattern == value))
            {
                return;
            }
            if (((this._hasPattern == null) 
                        || (_hasPattern.Equals(value) != true)))
            {
                this._hasPattern = value;
                this.OnPropertyChanged("hasPattern", value);
            }
        }
    }
    
    /// <summary>
    /// If the value is peceded by a colon (:) sign, then it is a
    /// reference to the @val attribute of another element. References can refer
    /// to any element with an @val attribute or @propVal on a Property. The
    /// datatype must be cast to the appropriate target
    /// datatype.
    /// </summary>
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string hasValueEQ
    {
        get
        {
            return this._hasValueEQ;
        }
        set
        {
            if ((this._hasValueEQ == value))
            {
                return;
            }
            if (((this._hasValueEQ == null) 
                        || (_hasValueEQ.Equals(value) != true)))
            {
                this._hasValueEQ = value;
                this.OnPropertyChanged("hasValueEQ", value);
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string hasValueLT
    {
        get
        {
            return this._hasValueLT;
        }
        set
        {
            if ((this._hasValueLT == value))
            {
                return;
            }
            if (((this._hasValueLT == null) 
                        || (_hasValueLT.Equals(value) != true)))
            {
                this._hasValueLT = value;
                this.OnPropertyChanged("hasValueLT", value);
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string hasValueLTE
    {
        get
        {
            return this._hasValueLTE;
        }
        set
        {
            if ((this._hasValueLTE == value))
            {
                return;
            }
            if (((this._hasValueLTE == null) 
                        || (_hasValueLTE.Equals(value) != true)))
            {
                this._hasValueLTE = value;
                this.OnPropertyChanged("hasValueLTE", value);
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string hasValueGT
    {
        get
        {
            return this._hasValueGT;
        }
        set
        {
            if ((this._hasValueGT == value))
            {
                return;
            }
            if (((this._hasValueGT == null) 
                        || (_hasValueGT.Equals(value) != true)))
            {
                this._hasValueGT = value;
                this.OnPropertyChanged("hasValueGT", value);
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string hasValueGTE
    {
        get
        {
            return this._hasValueGTE;
        }
        set
        {
            if ((this._hasValueGTE == value))
            {
                return;
            }
            if (((this._hasValueGTE == null) 
                        || (_hasValueGTE.Equals(value) != true)))
            {
                this._hasValueGTE = value;
                this.OnPropertyChanged("hasValueGTE", value);
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string hasAssociatedValueEQ
    {
        get
        {
            return this._hasAssociatedValueEQ;
        }
        set
        {
            if ((this._hasAssociatedValueEQ == value))
            {
                return;
            }
            if (((this._hasAssociatedValueEQ == null) 
                        || (_hasAssociatedValueEQ.Equals(value) != true)))
            {
                this._hasAssociatedValueEQ = value;
                this.OnPropertyChanged("hasAssociatedValueEQ", value);
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string hasAssociatedValueLT
    {
        get
        {
            return this._hasAssociatedValueLT;
        }
        set
        {
            if ((this._hasAssociatedValueLT == value))
            {
                return;
            }
            if (((this._hasAssociatedValueLT == null) 
                        || (_hasAssociatedValueLT.Equals(value) != true)))
            {
                this._hasAssociatedValueLT = value;
                this.OnPropertyChanged("hasAssociatedValueLT", value);
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string hasAssociatedValueLTE
    {
        get
        {
            return this._hasAssociatedValueLTE;
        }
        set
        {
            if ((this._hasAssociatedValueLTE == value))
            {
                return;
            }
            if (((this._hasAssociatedValueLTE == null) 
                        || (_hasAssociatedValueLTE.Equals(value) != true)))
            {
                this._hasAssociatedValueLTE = value;
                this.OnPropertyChanged("hasAssociatedValueLTE", value);
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string hasAssociatedValueGT
    {
        get
        {
            return this._hasAssociatedValueGT;
        }
        set
        {
            if ((this._hasAssociatedValueGT == value))
            {
                return;
            }
            if (((this._hasAssociatedValueGT == null) 
                        || (_hasAssociatedValueGT.Equals(value) != true)))
            {
                this._hasAssociatedValueGT = value;
                this.OnPropertyChanged("hasAssociatedValueGT", value);
            }
        }
    }
    
    [System.Xml.Serialization.XmlAttributeAttribute()]
    public virtual string hasAssociatedValueGTE
    {
        get
        {
            return this._hasAssociatedValueGTE;
        }
        set
        {
            if ((this._hasAssociatedValueGTE == value))
            {
                return;
            }
            if (((this._hasAssociatedValueGTE == null) 
                        || (_hasAssociatedValueGTE.Equals(value) != true)))
            {
                this._hasAssociatedValueGTE = value;
                this.OnPropertyChanged("hasAssociatedValueGTE", value);
            }
        }
    }
    
    /// <summary>
    /// Test whether not should be serialized
    /// </summary>
    public virtual bool ShouldSerializenot()
    {
        if (_shouldSerializenot)
        {
            return true;
        }
        return (_not != default(bool));
    }
    
    /// <summary>
    /// Test whether isSelected should be serialized
    /// </summary>
    public virtual bool ShouldSerializeisSelected()
    {
        if (_shouldSerializeisSelected)
        {
            return true;
        }
        return (_isSelected != default(bool));
    }
    
    /// <summary>
    /// Test whether isActive should be serialized
    /// </summary>
    public virtual bool ShouldSerializeisActive()
    {
        if (_shouldSerializeisActive)
        {
            return true;
        }
        return (_isActive != default(bool));
    }
    
    /// <summary>
    /// Test whether hasResponse should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasResponse()
    {
        if (_shouldSerializehasResponse)
        {
            return true;
        }
        return (_hasResponse != default(bool));
    }
    
    /// <summary>
    /// Test whether isVisible should be serialized
    /// </summary>
    public virtual bool ShouldSerializeisVisible()
    {
        if (_shouldSerializeisVisible)
        {
            return true;
        }
        return (_isVisible != default(bool));
    }
    
    /// <summary>
    /// Test whether isEnabled should be serialized
    /// </summary>
    public virtual bool ShouldSerializeisEnabled()
    {
        if (_shouldSerializeisEnabled)
        {
            return true;
        }
        return (_isEnabled != default(bool));
    }
    
    /// <summary>
    /// Test whether isRequired should be serialized
    /// </summary>
    public virtual bool ShouldSerializeisRequired()
    {
        if (_shouldSerializeisRequired)
        {
            return true;
        }
        return (_isRequired != default(bool));
    }
    
    /// <summary>
    /// Test whether isReadOnly should be serialized
    /// </summary>
    public virtual bool ShouldSerializeisReadOnly()
    {
        if (_shouldSerializeisReadOnly)
        {
            return true;
        }
        return (_isReadOnly != default(bool));
    }
    
    /// <summary>
    /// Test whether hasValue should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasValue()
    {
        if (_shouldSerializehasValue)
        {
            return true;
        }
        return (_hasValue != default(bool));
    }
    
    /// <summary>
    /// Test whether boolOp should be serialized
    /// </summary>
    public virtual bool ShouldSerializeboolOp()
    {
        if (_shouldSerializeboolOp)
        {
            return true;
        }
        return (_boolOp != default(PredEvalAttribValuesTypeBoolOp));
    }
    
    /// <summary>
    /// Test whether itemNames should be serialized
    /// </summary>
    public virtual bool ShouldSerializeitemNames()
    {
        return !string.IsNullOrEmpty(itemNames);
    }
    
    /// <summary>
    /// Test whether hasSelectionsGTE should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasSelectionsGTE()
    {
        return !string.IsNullOrEmpty(hasSelectionsGTE);
    }
    
    /// <summary>
    /// Test whether hasSelectionsLTE should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasSelectionsLTE()
    {
        return !string.IsNullOrEmpty(hasSelectionsLTE);
    }
    
    /// <summary>
    /// Test whether hasSelectionsExact should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasSelectionsExact()
    {
        return !string.IsNullOrEmpty(hasSelectionsExact);
    }
    
    /// <summary>
    /// Test whether hasType should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasType()
    {
        return !string.IsNullOrEmpty(hasType);
    }
    
    /// <summary>
    /// Test whether hasStyleClass should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasStyleClass()
    {
        return !string.IsNullOrEmpty(hasStyleClass);
    }
    
    /// <summary>
    /// Test whether supportDatesAndIntervals should be serialized
    /// </summary>
    public virtual bool ShouldSerializesupportDatesAndIntervals()
    {
        return !string.IsNullOrEmpty(supportDatesAndIntervals);
    }
    
    /// <summary>
    /// Test whether hasPattern should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasPattern()
    {
        return !string.IsNullOrEmpty(hasPattern);
    }
    
    /// <summary>
    /// Test whether hasValueEQ should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasValueEQ()
    {
        return !string.IsNullOrEmpty(hasValueEQ);
    }
    
    /// <summary>
    /// Test whether hasValueLT should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasValueLT()
    {
        return !string.IsNullOrEmpty(hasValueLT);
    }
    
    /// <summary>
    /// Test whether hasValueLTE should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasValueLTE()
    {
        return !string.IsNullOrEmpty(hasValueLTE);
    }
    
    /// <summary>
    /// Test whether hasValueGT should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasValueGT()
    {
        return !string.IsNullOrEmpty(hasValueGT);
    }
    
    /// <summary>
    /// Test whether hasValueGTE should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasValueGTE()
    {
        return !string.IsNullOrEmpty(hasValueGTE);
    }
    
    /// <summary>
    /// Test whether hasAssociatedValueEQ should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasAssociatedValueEQ()
    {
        return !string.IsNullOrEmpty(hasAssociatedValueEQ);
    }
    
    /// <summary>
    /// Test whether hasAssociatedValueLT should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasAssociatedValueLT()
    {
        return !string.IsNullOrEmpty(hasAssociatedValueLT);
    }
    
    /// <summary>
    /// Test whether hasAssociatedValueLTE should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasAssociatedValueLTE()
    {
        return !string.IsNullOrEmpty(hasAssociatedValueLTE);
    }
    
    /// <summary>
    /// Test whether hasAssociatedValueGT should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasAssociatedValueGT()
    {
        return !string.IsNullOrEmpty(hasAssociatedValueGT);
    }
    
    /// <summary>
    /// Test whether hasAssociatedValueGTE should be serialized
    /// </summary>
    public virtual bool ShouldSerializehasAssociatedValueGTE()
    {
        return !string.IsNullOrEmpty(hasAssociatedValueGTE);
    }
}
}
#pragma warning restore