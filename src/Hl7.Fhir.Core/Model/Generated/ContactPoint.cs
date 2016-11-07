﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;
using System.ComponentModel;

/*
  Copyright (c) 2011+, HL7, Inc.
  All rights reserved.
  
  Redistribution and use in source and binary forms, with or without modification, 
  are permitted provided that the following conditions are met:
  
   * Redistributions of source code must retain the above copyright notice, this 
     list of conditions and the following disclaimer.
   * Redistributions in binary form must reproduce the above copyright notice, 
     this list of conditions and the following disclaimer in the documentation 
     and/or other materials provided with the distribution.
   * Neither the name of HL7 nor the names of its contributors may be used to 
     endorse or promote products derived from this software without specific 
     prior written permission.
  
  THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND 
  ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED 
  WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE DISCLAIMED. 
  IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR ANY DIRECT, 
  INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES (INCLUDING, BUT 
  NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; LOSS OF USE, DATA, OR 
  PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND ON ANY THEORY OF LIABILITY, 
  WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT (INCLUDING NEGLIGENCE OR OTHERWISE) 
  ARISING IN ANY WAY OUT OF THE USE OF THIS SOFTWARE, EVEN IF ADVISED OF THE 
  POSSIBILITY OF SUCH DAMAGE.
  

*/

//
// Generated for FHIR v1.7.0
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// Details of a Technology mediated contact point (phone, fax, email, etc.)
    /// </summary>
    [FhirType("ContactPoint")]
    [DataContract]
    public partial class ContactPoint : Hl7.Fhir.Model.Element, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override string TypeName { get { return "ContactPoint"; } }
        
        /// <summary>
        /// Telecommunications form for contact point
        /// (url: http://hl7.org/fhir/ValueSet/contact-point-system)
        /// </summary>
        [FhirEnumeration("ContactPointSystem")]
        public enum ContactPointSystem
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contact-point-system)
            /// </summary>
            [EnumLiteral("phone"), Description("Phone")]
            Phone,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contact-point-system)
            /// </summary>
            [EnumLiteral("fax"), Description("Fax")]
            Fax,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contact-point-system)
            /// </summary>
            [EnumLiteral("email"), Description("Email")]
            Email,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contact-point-system)
            /// </summary>
            [EnumLiteral("pager"), Description("Pager")]
            Pager,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contact-point-system)
            /// </summary>
            [EnumLiteral("other"), Description("URL")]
            Other,
        }

        /// <summary>
        /// Use of contact point
        /// (url: http://hl7.org/fhir/ValueSet/contact-point-use)
        /// </summary>
        [FhirEnumeration("ContactPointUse")]
        public enum ContactPointUse
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contact-point-use)
            /// </summary>
            [EnumLiteral("home"), Description("Home")]
            Home,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contact-point-use)
            /// </summary>
            [EnumLiteral("work"), Description("Work")]
            Work,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contact-point-use)
            /// </summary>
            [EnumLiteral("temp"), Description("Temp")]
            Temp,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contact-point-use)
            /// </summary>
            [EnumLiteral("old"), Description("Old")]
            Old,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/contact-point-use)
            /// </summary>
            [EnumLiteral("mobile"), Description("Mobile")]
            Mobile,
        }

        /// <summary>
        /// phone | fax | email | pager | other
        /// </summary>
        [FhirElement("system", InSummary=true, Order=30)]
        [DataMember]
        public Code<Hl7.Fhir.Model.ContactPoint.ContactPointSystem> SystemElement
        {
            get { return _SystemElement; }
            set { _SystemElement = value; OnPropertyChanged("SystemElement"); }
        }
        
        private Code<Hl7.Fhir.Model.ContactPoint.ContactPointSystem> _SystemElement;
        
        /// <summary>
        /// phone | fax | email | pager | other
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.ContactPoint.ContactPointSystem? System
        {
            get { return SystemElement != null ? SystemElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  SystemElement = null; 
                else
                  SystemElement = new Code<Hl7.Fhir.Model.ContactPoint.ContactPointSystem>(value);
                OnPropertyChanged("System");
            }
        }
        
        /// <summary>
        /// The actual contact point details
        /// </summary>
        [FhirElement("value", InSummary=true, Order=40)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString ValueElement
        {
            get { return _ValueElement; }
            set { _ValueElement = value; OnPropertyChanged("ValueElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _ValueElement;
        
        /// <summary>
        /// The actual contact point details
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Value
        {
            get { return ValueElement != null ? ValueElement.Value : null; }
            set
            {
                if (value == null)
                  ValueElement = null; 
                else
                  ValueElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Value");
            }
        }
        
        /// <summary>
        /// home | work | temp | old | mobile - purpose of this contact point
        /// </summary>
        [FhirElement("use", InSummary=true, Order=50)]
        [DataMember]
        public Code<Hl7.Fhir.Model.ContactPoint.ContactPointUse> UseElement
        {
            get { return _UseElement; }
            set { _UseElement = value; OnPropertyChanged("UseElement"); }
        }
        
        private Code<Hl7.Fhir.Model.ContactPoint.ContactPointUse> _UseElement;
        
        /// <summary>
        /// home | work | temp | old | mobile - purpose of this contact point
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.ContactPoint.ContactPointUse? Use
        {
            get { return UseElement != null ? UseElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  UseElement = null; 
                else
                  UseElement = new Code<Hl7.Fhir.Model.ContactPoint.ContactPointUse>(value);
                OnPropertyChanged("Use");
            }
        }
        
        /// <summary>
        /// Specify preferred order of use (1 = highest)
        /// </summary>
        [FhirElement("rank", InSummary=true, Order=60)]
        [DataMember]
        public Hl7.Fhir.Model.PositiveInt RankElement
        {
            get { return _RankElement; }
            set { _RankElement = value; OnPropertyChanged("RankElement"); }
        }
        
        private Hl7.Fhir.Model.PositiveInt _RankElement;
        
        /// <summary>
        /// Specify preferred order of use (1 = highest)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public int? Rank
        {
            get { return RankElement != null ? RankElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  RankElement = null; 
                else
                  RankElement = new Hl7.Fhir.Model.PositiveInt(value);
                OnPropertyChanged("Rank");
            }
        }
        
        /// <summary>
        /// Time period when the contact point was/is in use
        /// </summary>
        [FhirElement("period", InSummary=true, Order=70)]
        [DataMember]
        public Hl7.Fhir.Model.Period Period
        {
            get { return _Period; }
            set { _Period = value; OnPropertyChanged("Period"); }
        }
        
        private Hl7.Fhir.Model.Period _Period;
        

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ContactPoint;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(SystemElement != null) dest.SystemElement = (Code<Hl7.Fhir.Model.ContactPoint.ContactPointSystem>)SystemElement.DeepCopy();
                if(ValueElement != null) dest.ValueElement = (Hl7.Fhir.Model.FhirString)ValueElement.DeepCopy();
                if(UseElement != null) dest.UseElement = (Code<Hl7.Fhir.Model.ContactPoint.ContactPointUse>)UseElement.DeepCopy();
                if(RankElement != null) dest.RankElement = (Hl7.Fhir.Model.PositiveInt)RankElement.DeepCopy();
                if(Period != null) dest.Period = (Hl7.Fhir.Model.Period)Period.DeepCopy();
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new ContactPoint());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ContactPoint;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(SystemElement, otherT.SystemElement)) return false;
            if( !DeepComparable.Matches(ValueElement, otherT.ValueElement)) return false;
            if( !DeepComparable.Matches(UseElement, otherT.UseElement)) return false;
            if( !DeepComparable.Matches(RankElement, otherT.RankElement)) return false;
            if( !DeepComparable.Matches(Period, otherT.Period)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ContactPoint;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(SystemElement, otherT.SystemElement)) return false;
            if( !DeepComparable.IsExactly(ValueElement, otherT.ValueElement)) return false;
            if( !DeepComparable.IsExactly(UseElement, otherT.UseElement)) return false;
            if( !DeepComparable.IsExactly(RankElement, otherT.RankElement)) return false;
            if( !DeepComparable.IsExactly(Period, otherT.Period)) return false;
            
            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                // ContactPoint elements
                if (SystemElement != null) yield return SystemElement;
                if (ValueElement != null) yield return ValueElement;
                if (UseElement != null) yield return UseElement;
                if (RankElement != null) yield return RankElement;
                if (Period != null) yield return Period;
            }
        }
    
    
    }
    
}
