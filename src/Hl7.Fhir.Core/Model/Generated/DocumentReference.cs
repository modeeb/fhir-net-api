﻿using System;
using System.Collections.Generic;
using Hl7.Fhir.Introspection;
using Hl7.Fhir.Validation;
using System.Linq;
using System.Runtime.Serialization;
using Hl7.Fhir.Utility;

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

#pragma warning disable 1591 // suppress XML summary warnings 

//
// Generated for FHIR v3.2.0
//
namespace Hl7.Fhir.Model
{
    /// <summary>
    /// A reference to a document
    /// </summary>
    [FhirType("DocumentReference", IsResource=true)]
    [DataContract]
    public partial class DocumentReference : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.DocumentReference; } }
        [NotMapped]
        public override string TypeName { get { return "DocumentReference"; } }
        
        [FhirType("AgentComponent")]
        [DataContract]
        public partial class AgentComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "AgentComponent"; } }
            
            /// <summary>
            /// How agent participated
            /// </summary>
            [FhirElement("type", InSummary=true, Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept Type
            {
                get { return _Type; }
                set { _Type = value; OnPropertyChanged("Type"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _Type;
            
            /// <summary>
            /// Who and/or what authored the document
            /// </summary>
            [FhirElement("who", InSummary=true, Order=50)]
            [CLSCompliant(false)]
			[References("Practitioner","PractitionerRole","Organization","Device","Patient","RelatedPerson")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Who
            {
                get { return _Who; }
                set { _Who = value; OnPropertyChanged("Who"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _Who;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as AgentComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                    if(Who != null) dest.Who = (Hl7.Fhir.Model.ResourceReference)Who.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new AgentComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as AgentComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Type, otherT.Type)) return false;
                if( !DeepComparable.Matches(Who, otherT.Who)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as AgentComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
                if( !DeepComparable.IsExactly(Who, otherT.Who)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Type != null) yield return Type;
                    if (Who != null) yield return Who;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Type != null) yield return new ElementValue("type", false, Type);
                    if (Who != null) yield return new ElementValue("who", false, Who);
                }
            }

            
        }
        
        
        [FhirType("RelatesToComponent")]
        [DataContract]
        public partial class RelatesToComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "RelatesToComponent"; } }
            
            /// <summary>
            /// replaces | transforms | signs | appends
            /// </summary>
            [FhirElement("code", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Code<Hl7.Fhir.Model.DocumentRelationshipType> CodeElement
            {
                get { return _CodeElement; }
                set { _CodeElement = value; OnPropertyChanged("CodeElement"); }
            }
            
            private Code<Hl7.Fhir.Model.DocumentRelationshipType> _CodeElement;
            
            /// <summary>
            /// replaces | transforms | signs | appends
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.DocumentRelationshipType? Code
            {
                get { return CodeElement != null ? CodeElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        CodeElement = null; 
                    else
                        CodeElement = new Code<Hl7.Fhir.Model.DocumentRelationshipType>(value);
                    OnPropertyChanged("Code");
                }
            }
            
            /// <summary>
            /// Target of the relationship
            /// </summary>
            [FhirElement("target", InSummary=true, Order=50)]
            [CLSCompliant(false)]
			[References("DocumentReference")]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Target
            {
                get { return _Target; }
                set { _Target = value; OnPropertyChanged("Target"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _Target;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RelatesToComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(CodeElement != null) dest.CodeElement = (Code<Hl7.Fhir.Model.DocumentRelationshipType>)CodeElement.DeepCopy();
                    if(Target != null) dest.Target = (Hl7.Fhir.Model.ResourceReference)Target.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new RelatesToComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RelatesToComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(CodeElement, otherT.CodeElement)) return false;
                if( !DeepComparable.Matches(Target, otherT.Target)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RelatesToComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(CodeElement, otherT.CodeElement)) return false;
                if( !DeepComparable.IsExactly(Target, otherT.Target)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (CodeElement != null) yield return CodeElement;
                    if (Target != null) yield return Target;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (CodeElement != null) yield return new ElementValue("code", false, CodeElement);
                    if (Target != null) yield return new ElementValue("target", false, Target);
                }
            }

            
        }
        
        
        [FhirType("ContentComponent")]
        [DataContract]
        public partial class ContentComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ContentComponent"; } }
            
            /// <summary>
            /// Where to access the document
            /// </summary>
            [FhirElement("attachment", InSummary=true, Order=40)]
            [Cardinality(Min=1,Max=1)]
            [DataMember]
            public Hl7.Fhir.Model.Attachment Attachment
            {
                get { return _Attachment; }
                set { _Attachment = value; OnPropertyChanged("Attachment"); }
            }
            
            private Hl7.Fhir.Model.Attachment _Attachment;
            
            /// <summary>
            /// Format/content rules for the document
            /// </summary>
            [FhirElement("format", InSummary=true, Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.Coding Format
            {
                get { return _Format; }
                set { _Format = value; OnPropertyChanged("Format"); }
            }
            
            private Hl7.Fhir.Model.Coding _Format;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContentComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Attachment != null) dest.Attachment = (Hl7.Fhir.Model.Attachment)Attachment.DeepCopy();
                    if(Format != null) dest.Format = (Hl7.Fhir.Model.Coding)Format.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ContentComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContentComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Attachment, otherT.Attachment)) return false;
                if( !DeepComparable.Matches(Format, otherT.Format)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContentComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Attachment, otherT.Attachment)) return false;
                if( !DeepComparable.IsExactly(Format, otherT.Format)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Attachment != null) yield return Attachment;
                    if (Format != null) yield return Format;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Attachment != null) yield return new ElementValue("attachment", false, Attachment);
                    if (Format != null) yield return new ElementValue("format", false, Format);
                }
            }

            
        }
        
        
        [FhirType("ContextComponent")]
        [DataContract]
        public partial class ContextComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ContextComponent"; } }
            
            /// <summary>
            /// Context of the document  content
            /// </summary>
            [FhirElement("encounter", Order=40)]
            [CLSCompliant(false)]
			[References("Encounter")]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Encounter
            {
                get { return _Encounter; }
                set { _Encounter = value; OnPropertyChanged("Encounter"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _Encounter;
            
            /// <summary>
            /// Main clinical acts documented
            /// </summary>
            [FhirElement("event", Order=50)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.CodeableConcept> Event
            {
                get { if(_Event==null) _Event = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Event; }
                set { _Event = value; OnPropertyChanged("Event"); }
            }
            
            private List<Hl7.Fhir.Model.CodeableConcept> _Event;
            
            /// <summary>
            /// Time of service that is being documented
            /// </summary>
            [FhirElement("period", InSummary=true, Order=60)]
            [DataMember]
            public Hl7.Fhir.Model.Period Period
            {
                get { return _Period; }
                set { _Period = value; OnPropertyChanged("Period"); }
            }
            
            private Hl7.Fhir.Model.Period _Period;
            
            /// <summary>
            /// Kind of facility where patient was seen
            /// </summary>
            [FhirElement("facilityType", Order=70)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept FacilityType
            {
                get { return _FacilityType; }
                set { _FacilityType = value; OnPropertyChanged("FacilityType"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _FacilityType;
            
            /// <summary>
            /// Additional details about where the content was created (e.g. clinical specialty)
            /// </summary>
            [FhirElement("practiceSetting", Order=80)]
            [DataMember]
            public Hl7.Fhir.Model.CodeableConcept PracticeSetting
            {
                get { return _PracticeSetting; }
                set { _PracticeSetting = value; OnPropertyChanged("PracticeSetting"); }
            }
            
            private Hl7.Fhir.Model.CodeableConcept _PracticeSetting;
            
            /// <summary>
            /// Patient demographics from source
            /// </summary>
            [FhirElement("sourcePatientInfo", Order=90)]
            [CLSCompliant(false)]
			[References("Patient")]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference SourcePatientInfo
            {
                get { return _SourcePatientInfo; }
                set { _SourcePatientInfo = value; OnPropertyChanged("SourcePatientInfo"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _SourcePatientInfo;
            
            /// <summary>
            /// Related identifiers or resources
            /// </summary>
            [FhirElement("related", Order=100)]
            [Cardinality(Min=0,Max=-1)]
            [DataMember]
            public List<Hl7.Fhir.Model.DocumentReference.RelatedComponent> Related
            {
                get { if(_Related==null) _Related = new List<Hl7.Fhir.Model.DocumentReference.RelatedComponent>(); return _Related; }
                set { _Related = value; OnPropertyChanged("Related"); }
            }
            
            private List<Hl7.Fhir.Model.DocumentReference.RelatedComponent> _Related;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ContextComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Encounter != null) dest.Encounter = (Hl7.Fhir.Model.ResourceReference)Encounter.DeepCopy();
                    if(Event != null) dest.Event = new List<Hl7.Fhir.Model.CodeableConcept>(Event.DeepCopy());
                    if(Period != null) dest.Period = (Hl7.Fhir.Model.Period)Period.DeepCopy();
                    if(FacilityType != null) dest.FacilityType = (Hl7.Fhir.Model.CodeableConcept)FacilityType.DeepCopy();
                    if(PracticeSetting != null) dest.PracticeSetting = (Hl7.Fhir.Model.CodeableConcept)PracticeSetting.DeepCopy();
                    if(SourcePatientInfo != null) dest.SourcePatientInfo = (Hl7.Fhir.Model.ResourceReference)SourcePatientInfo.DeepCopy();
                    if(Related != null) dest.Related = new List<Hl7.Fhir.Model.DocumentReference.RelatedComponent>(Related.DeepCopy());
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ContextComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ContextComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Encounter, otherT.Encounter)) return false;
                if( !DeepComparable.Matches(Event, otherT.Event)) return false;
                if( !DeepComparable.Matches(Period, otherT.Period)) return false;
                if( !DeepComparable.Matches(FacilityType, otherT.FacilityType)) return false;
                if( !DeepComparable.Matches(PracticeSetting, otherT.PracticeSetting)) return false;
                if( !DeepComparable.Matches(SourcePatientInfo, otherT.SourcePatientInfo)) return false;
                if( !DeepComparable.Matches(Related, otherT.Related)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ContextComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Encounter, otherT.Encounter)) return false;
                if( !DeepComparable.IsExactly(Event, otherT.Event)) return false;
                if( !DeepComparable.IsExactly(Period, otherT.Period)) return false;
                if( !DeepComparable.IsExactly(FacilityType, otherT.FacilityType)) return false;
                if( !DeepComparable.IsExactly(PracticeSetting, otherT.PracticeSetting)) return false;
                if( !DeepComparable.IsExactly(SourcePatientInfo, otherT.SourcePatientInfo)) return false;
                if( !DeepComparable.IsExactly(Related, otherT.Related)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Encounter != null) yield return Encounter;
                    foreach (var elem in Event) { if (elem != null) yield return elem; }
                    if (Period != null) yield return Period;
                    if (FacilityType != null) yield return FacilityType;
                    if (PracticeSetting != null) yield return PracticeSetting;
                    if (SourcePatientInfo != null) yield return SourcePatientInfo;
                    foreach (var elem in Related) { if (elem != null) yield return elem; }
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Encounter != null) yield return new ElementValue("encounter", false, Encounter);
                    foreach (var elem in Event) { if (elem != null) yield return new ElementValue("event", true, elem); }
                    if (Period != null) yield return new ElementValue("period", false, Period);
                    if (FacilityType != null) yield return new ElementValue("facilityType", false, FacilityType);
                    if (PracticeSetting != null) yield return new ElementValue("practiceSetting", false, PracticeSetting);
                    if (SourcePatientInfo != null) yield return new ElementValue("sourcePatientInfo", false, SourcePatientInfo);
                    foreach (var elem in Related) { if (elem != null) yield return new ElementValue("related", true, elem); }
                }
            }

            
        }
        
        
        [FhirType("RelatedComponent")]
        [DataContract]
        public partial class RelatedComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "RelatedComponent"; } }
            
            /// <summary>
            /// Identifier of related objects or events
            /// </summary>
            [FhirElement("identifier", Order=40)]
            [DataMember]
            public Hl7.Fhir.Model.Identifier Identifier
            {
                get { return _Identifier; }
                set { _Identifier = value; OnPropertyChanged("Identifier"); }
            }
            
            private Hl7.Fhir.Model.Identifier _Identifier;
            
            /// <summary>
            /// Related Resource
            /// </summary>
            [FhirElement("ref", Order=50)]
            [CLSCompliant(false)]
			[References()]
            [DataMember]
            public Hl7.Fhir.Model.ResourceReference Ref
            {
                get { return _Ref; }
                set { _Ref = value; OnPropertyChanged("Ref"); }
            }
            
            private Hl7.Fhir.Model.ResourceReference _Ref;
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as RelatedComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(Identifier != null) dest.Identifier = (Hl7.Fhir.Model.Identifier)Identifier.DeepCopy();
                    if(Ref != null) dest.Ref = (Hl7.Fhir.Model.ResourceReference)Ref.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new RelatedComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as RelatedComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
                if( !DeepComparable.Matches(Ref, otherT.Ref)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as RelatedComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
                if( !DeepComparable.IsExactly(Ref, otherT.Ref)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (Identifier != null) yield return Identifier;
                    if (Ref != null) yield return Ref;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (Identifier != null) yield return new ElementValue("identifier", false, Identifier);
                    if (Ref != null) yield return new ElementValue("ref", false, Ref);
                }
            }

            
        }
        
        
        /// <summary>
        /// Master Version Specific Identifier
        /// </summary>
        [FhirElement("masterIdentifier", InSummary=true, Order=90)]
        [DataMember]
        public Hl7.Fhir.Model.Identifier MasterIdentifier
        {
            get { return _MasterIdentifier; }
            set { _MasterIdentifier = value; OnPropertyChanged("MasterIdentifier"); }
        }
        
        private Hl7.Fhir.Model.Identifier _MasterIdentifier;
        
        /// <summary>
        /// Other identifiers for the document
        /// </summary>
        [FhirElement("identifier", InSummary=true, Order=100)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.Identifier> _Identifier;
        
        /// <summary>
        /// current | superseded | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=110)]
        [Cardinality(Min=1,Max=1)]
        [DataMember]
        public Code<Hl7.Fhir.Model.DocumentReferenceStatus> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.DocumentReferenceStatus> _StatusElement;
        
        /// <summary>
        /// current | superseded | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.DocumentReferenceStatus? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.DocumentReferenceStatus>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// preliminary | final | appended | amended | entered-in-error
        /// </summary>
        [FhirElement("docStatus", InSummary=true, Order=120)]
        [DataMember]
        public Code<Hl7.Fhir.Model.CompositionStatus> DocStatusElement
        {
            get { return _DocStatusElement; }
            set { _DocStatusElement = value; OnPropertyChanged("DocStatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.CompositionStatus> _DocStatusElement;
        
        /// <summary>
        /// preliminary | final | appended | amended | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.CompositionStatus? DocStatus
        {
            get { return DocStatusElement != null ? DocStatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  DocStatusElement = null; 
                else
                  DocStatusElement = new Code<Hl7.Fhir.Model.CompositionStatus>(value);
                OnPropertyChanged("DocStatus");
            }
        }
        
        /// <summary>
        /// Kind of document (LOINC if possible)
        /// </summary>
        [FhirElement("type", InSummary=true, Order=130)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Type
        {
            get { return _Type; }
            set { _Type = value; OnPropertyChanged("Type"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Type;
        
        /// <summary>
        /// Categorization of document
        /// </summary>
        [FhirElement("class", InSummary=true, Order=140)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Class
        {
            get { return _Class; }
            set { _Class = value; OnPropertyChanged("Class"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Class;
        
        /// <summary>
        /// Who/what is the subject of the document
        /// </summary>
        [FhirElement("subject", InSummary=true, Order=150)]
        [CLSCompliant(false)]
		[References("Patient","Practitioner","Group","Device")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Subject
        {
            get { return _Subject; }
            set { _Subject = value; OnPropertyChanged("Subject"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Subject;
        
        /// <summary>
        /// Document creation time
        /// </summary>
        [FhirElement("created", Order=160)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime CreatedElement
        {
            get { return _CreatedElement; }
            set { _CreatedElement = value; OnPropertyChanged("CreatedElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _CreatedElement;
        
        /// <summary>
        /// Document creation time
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Created
        {
            get { return CreatedElement != null ? CreatedElement.Value : null; }
            set
            {
                if (value == null)
                  CreatedElement = null; 
                else
                  CreatedElement = new Hl7.Fhir.Model.FhirDateTime(value);
                OnPropertyChanged("Created");
            }
        }
        
        /// <summary>
        /// When this document reference was created
        /// </summary>
        [FhirElement("date", InSummary=true, Order=170)]
        [DataMember]
        public Hl7.Fhir.Model.Instant DateElement
        {
            get { return _DateElement; }
            set { _DateElement = value; OnPropertyChanged("DateElement"); }
        }
        
        private Hl7.Fhir.Model.Instant _DateElement;
        
        /// <summary>
        /// When this document reference was created
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public DateTimeOffset? Date
        {
            get { return DateElement != null ? DateElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  DateElement = null; 
                else
                  DateElement = new Hl7.Fhir.Model.Instant(value);
                OnPropertyChanged("Date");
            }
        }
        
        /// <summary>
        /// Agent involved
        /// </summary>
        [FhirElement("agent", InSummary=true, Order=180)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.DocumentReference.AgentComponent> Agent
        {
            get { if(_Agent==null) _Agent = new List<Hl7.Fhir.Model.DocumentReference.AgentComponent>(); return _Agent; }
            set { _Agent = value; OnPropertyChanged("Agent"); }
        }
        
        private List<Hl7.Fhir.Model.DocumentReference.AgentComponent> _Agent;
        
        /// <summary>
        /// Who/what authenticated the document
        /// </summary>
        [FhirElement("authenticator", Order=190)]
        [CLSCompliant(false)]
		[References("Practitioner","Organization")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Authenticator
        {
            get { return _Authenticator; }
            set { _Authenticator = value; OnPropertyChanged("Authenticator"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Authenticator;
        
        /// <summary>
        /// Organization which maintains the document
        /// </summary>
        [FhirElement("custodian", Order=200)]
        [CLSCompliant(false)]
		[References("Organization")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Custodian
        {
            get { return _Custodian; }
            set { _Custodian = value; OnPropertyChanged("Custodian"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Custodian;
        
        /// <summary>
        /// Relationships to other documents
        /// </summary>
        [FhirElement("relatesTo", InSummary=true, Order=210)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.DocumentReference.RelatesToComponent> RelatesTo
        {
            get { if(_RelatesTo==null) _RelatesTo = new List<Hl7.Fhir.Model.DocumentReference.RelatesToComponent>(); return _RelatesTo; }
            set { _RelatesTo = value; OnPropertyChanged("RelatesTo"); }
        }
        
        private List<Hl7.Fhir.Model.DocumentReference.RelatesToComponent> _RelatesTo;
        
        /// <summary>
        /// Human-readable description (title)
        /// </summary>
        [FhirElement("description", InSummary=true, Order=220)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString DescriptionElement
        {
            get { return _DescriptionElement; }
            set { _DescriptionElement = value; OnPropertyChanged("DescriptionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _DescriptionElement;
        
        /// <summary>
        /// Human-readable description (title)
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Description
        {
            get { return DescriptionElement != null ? DescriptionElement.Value : null; }
            set
            {
                if (value == null)
                  DescriptionElement = null; 
                else
                  DescriptionElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Description");
            }
        }
        
        /// <summary>
        /// Document security-tags
        /// </summary>
        [FhirElement("securityLabel", InSummary=true, Order=230)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> SecurityLabel
        {
            get { if(_SecurityLabel==null) _SecurityLabel = new List<Hl7.Fhir.Model.CodeableConcept>(); return _SecurityLabel; }
            set { _SecurityLabel = value; OnPropertyChanged("SecurityLabel"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _SecurityLabel;
        
        /// <summary>
        /// Document referenced
        /// </summary>
        [FhirElement("content", InSummary=true, Order=240)]
        [Cardinality(Min=1,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.DocumentReference.ContentComponent> Content
        {
            get { if(_Content==null) _Content = new List<Hl7.Fhir.Model.DocumentReference.ContentComponent>(); return _Content; }
            set { _Content = value; OnPropertyChanged("Content"); }
        }
        
        private List<Hl7.Fhir.Model.DocumentReference.ContentComponent> _Content;
        
        /// <summary>
        /// Clinical context of document
        /// </summary>
        [FhirElement("context", InSummary=true, Order=250)]
        [DataMember]
        public Hl7.Fhir.Model.DocumentReference.ContextComponent Context
        {
            get { return _Context; }
            set { _Context = value; OnPropertyChanged("Context"); }
        }
        
        private Hl7.Fhir.Model.DocumentReference.ContextComponent _Context;
        

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as DocumentReference;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(MasterIdentifier != null) dest.MasterIdentifier = (Hl7.Fhir.Model.Identifier)MasterIdentifier.DeepCopy();
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.DocumentReferenceStatus>)StatusElement.DeepCopy();
                if(DocStatusElement != null) dest.DocStatusElement = (Code<Hl7.Fhir.Model.CompositionStatus>)DocStatusElement.DeepCopy();
                if(Type != null) dest.Type = (Hl7.Fhir.Model.CodeableConcept)Type.DeepCopy();
                if(Class != null) dest.Class = (Hl7.Fhir.Model.CodeableConcept)Class.DeepCopy();
                if(Subject != null) dest.Subject = (Hl7.Fhir.Model.ResourceReference)Subject.DeepCopy();
                if(CreatedElement != null) dest.CreatedElement = (Hl7.Fhir.Model.FhirDateTime)CreatedElement.DeepCopy();
                if(DateElement != null) dest.DateElement = (Hl7.Fhir.Model.Instant)DateElement.DeepCopy();
                if(Agent != null) dest.Agent = new List<Hl7.Fhir.Model.DocumentReference.AgentComponent>(Agent.DeepCopy());
                if(Authenticator != null) dest.Authenticator = (Hl7.Fhir.Model.ResourceReference)Authenticator.DeepCopy();
                if(Custodian != null) dest.Custodian = (Hl7.Fhir.Model.ResourceReference)Custodian.DeepCopy();
                if(RelatesTo != null) dest.RelatesTo = new List<Hl7.Fhir.Model.DocumentReference.RelatesToComponent>(RelatesTo.DeepCopy());
                if(DescriptionElement != null) dest.DescriptionElement = (Hl7.Fhir.Model.FhirString)DescriptionElement.DeepCopy();
                if(SecurityLabel != null) dest.SecurityLabel = new List<Hl7.Fhir.Model.CodeableConcept>(SecurityLabel.DeepCopy());
                if(Content != null) dest.Content = new List<Hl7.Fhir.Model.DocumentReference.ContentComponent>(Content.DeepCopy());
                if(Context != null) dest.Context = (Hl7.Fhir.Model.DocumentReference.ContextComponent)Context.DeepCopy();
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new DocumentReference());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as DocumentReference;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(MasterIdentifier, otherT.MasterIdentifier)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(DocStatusElement, otherT.DocStatusElement)) return false;
            if( !DeepComparable.Matches(Type, otherT.Type)) return false;
            if( !DeepComparable.Matches(Class, otherT.Class)) return false;
            if( !DeepComparable.Matches(Subject, otherT.Subject)) return false;
            if( !DeepComparable.Matches(CreatedElement, otherT.CreatedElement)) return false;
            if( !DeepComparable.Matches(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.Matches(Agent, otherT.Agent)) return false;
            if( !DeepComparable.Matches(Authenticator, otherT.Authenticator)) return false;
            if( !DeepComparable.Matches(Custodian, otherT.Custodian)) return false;
            if( !DeepComparable.Matches(RelatesTo, otherT.RelatesTo)) return false;
            if( !DeepComparable.Matches(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.Matches(SecurityLabel, otherT.SecurityLabel)) return false;
            if( !DeepComparable.Matches(Content, otherT.Content)) return false;
            if( !DeepComparable.Matches(Context, otherT.Context)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as DocumentReference;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(MasterIdentifier, otherT.MasterIdentifier)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(DocStatusElement, otherT.DocStatusElement)) return false;
            if( !DeepComparable.IsExactly(Type, otherT.Type)) return false;
            if( !DeepComparable.IsExactly(Class, otherT.Class)) return false;
            if( !DeepComparable.IsExactly(Subject, otherT.Subject)) return false;
            if( !DeepComparable.IsExactly(CreatedElement, otherT.CreatedElement)) return false;
            if( !DeepComparable.IsExactly(DateElement, otherT.DateElement)) return false;
            if( !DeepComparable.IsExactly(Agent, otherT.Agent)) return false;
            if( !DeepComparable.IsExactly(Authenticator, otherT.Authenticator)) return false;
            if( !DeepComparable.IsExactly(Custodian, otherT.Custodian)) return false;
            if( !DeepComparable.IsExactly(RelatesTo, otherT.RelatesTo)) return false;
            if( !DeepComparable.IsExactly(DescriptionElement, otherT.DescriptionElement)) return false;
            if( !DeepComparable.IsExactly(SecurityLabel, otherT.SecurityLabel)) return false;
            if( !DeepComparable.IsExactly(Content, otherT.Content)) return false;
            if( !DeepComparable.IsExactly(Context, otherT.Context)) return false;
            
            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
				if (MasterIdentifier != null) yield return MasterIdentifier;
				foreach (var elem in Identifier) { if (elem != null) yield return elem; }
				if (StatusElement != null) yield return StatusElement;
				if (DocStatusElement != null) yield return DocStatusElement;
				if (Type != null) yield return Type;
				if (Class != null) yield return Class;
				if (Subject != null) yield return Subject;
				if (CreatedElement != null) yield return CreatedElement;
				if (DateElement != null) yield return DateElement;
				foreach (var elem in Agent) { if (elem != null) yield return elem; }
				if (Authenticator != null) yield return Authenticator;
				if (Custodian != null) yield return Custodian;
				foreach (var elem in RelatesTo) { if (elem != null) yield return elem; }
				if (DescriptionElement != null) yield return DescriptionElement;
				foreach (var elem in SecurityLabel) { if (elem != null) yield return elem; }
				foreach (var elem in Content) { if (elem != null) yield return elem; }
				if (Context != null) yield return Context;
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                if (MasterIdentifier != null) yield return new ElementValue("masterIdentifier", false, MasterIdentifier);
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", true, elem); }
                if (StatusElement != null) yield return new ElementValue("status", false, StatusElement);
                if (DocStatusElement != null) yield return new ElementValue("docStatus", false, DocStatusElement);
                if (Type != null) yield return new ElementValue("type", false, Type);
                if (Class != null) yield return new ElementValue("class", false, Class);
                if (Subject != null) yield return new ElementValue("subject", false, Subject);
                if (CreatedElement != null) yield return new ElementValue("created", false, CreatedElement);
                if (DateElement != null) yield return new ElementValue("date", false, DateElement);
                foreach (var elem in Agent) { if (elem != null) yield return new ElementValue("agent", true, elem); }
                if (Authenticator != null) yield return new ElementValue("authenticator", false, Authenticator);
                if (Custodian != null) yield return new ElementValue("custodian", false, Custodian);
                foreach (var elem in RelatesTo) { if (elem != null) yield return new ElementValue("relatesTo", true, elem); }
                if (DescriptionElement != null) yield return new ElementValue("description", false, DescriptionElement);
                foreach (var elem in SecurityLabel) { if (elem != null) yield return new ElementValue("securityLabel", true, elem); }
                foreach (var elem in Content) { if (elem != null) yield return new ElementValue("content", true, elem); }
                if (Context != null) yield return new ElementValue("context", false, Context);
            }
        }

    }
    
}
