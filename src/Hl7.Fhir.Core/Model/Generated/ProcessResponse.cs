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
    /// ProcessResponse resource
    /// </summary>
    [FhirType("ProcessResponse", IsResource=true)]
    [DataContract]
    public partial class ProcessResponse : Hl7.Fhir.Model.DomainResource, System.ComponentModel.INotifyPropertyChanged
    {
        [NotMapped]
        public override ResourceType ResourceType { get { return ResourceType.ProcessResponse; } }
        [NotMapped]
        public override string TypeName { get { return "ProcessResponse"; } }
        
        /// <summary>
        /// This value set includes sample Process Outcome codes.
        /// (url: http://hl7.org/fhir/ValueSet/process-outcome)
        /// </summary>
        [FhirEnumeration("ProcessOutcomeCodes")]
        public enum ProcessOutcomeCodes
        {
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/processoutcomecodes)
            /// </summary>
            [EnumLiteral("complete", "http://hl7.org/fhir/processoutcomecodes"), Description("Complete")]
            Complete,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/processoutcomecodes)
            /// </summary>
            [EnumLiteral("pended", "http://hl7.org/fhir/processoutcomecodes"), Description("Pended")]
            Pended,
            /// <summary>
            /// MISSING DESCRIPTION
            /// (system: http://hl7.org/fhir/processoutcomecodes)
            /// </summary>
            [EnumLiteral("error", "http://hl7.org/fhir/processoutcomecodes"), Description("Error")]
            Error,
        }

        [FhirType("ProcessNoteComponent")]
        [DataContract]
        public partial class ProcessNoteComponent : Hl7.Fhir.Model.BackboneElement, System.ComponentModel.INotifyPropertyChanged
        {
            [NotMapped]
            public override string TypeName { get { return "ProcessNoteComponent"; } }
            
            /// <summary>
            /// display | print | printoper
            /// </summary>
            [FhirElement("type", Order=40)]
            [DataMember]
            public Code<Hl7.Fhir.Model.NoteType> TypeElement
            {
                get { return _TypeElement; }
                set { _TypeElement = value; OnPropertyChanged("TypeElement"); }
            }
            
            private Code<Hl7.Fhir.Model.NoteType> _TypeElement;
            
            /// <summary>
            /// display | print | printoper
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public Hl7.Fhir.Model.NoteType? Type
            {
                get { return TypeElement != null ? TypeElement.Value : null; }
                set
                {
                    if (!value.HasValue)
                        TypeElement = null; 
                    else
                        TypeElement = new Code<Hl7.Fhir.Model.NoteType>(value);
                    OnPropertyChanged("Type");
                }
            }
            
            /// <summary>
            /// Comment on the processing
            /// </summary>
            [FhirElement("text", Order=50)]
            [DataMember]
            public Hl7.Fhir.Model.FhirString TextElement
            {
                get { return _TextElement; }
                set { _TextElement = value; OnPropertyChanged("TextElement"); }
            }
            
            private Hl7.Fhir.Model.FhirString _TextElement;
            
            /// <summary>
            /// Comment on the processing
            /// </summary>
            /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
            [NotMapped]
            [IgnoreDataMemberAttribute]
            public string Text
            {
                get { return TextElement != null ? TextElement.Value : null; }
                set
                {
                    if (value == null)
                        TextElement = null; 
                    else
                        TextElement = new Hl7.Fhir.Model.FhirString(value);
                    OnPropertyChanged("Text");
                }
            }
            
            public override IDeepCopyable CopyTo(IDeepCopyable other)
            {
                var dest = other as ProcessNoteComponent;
                
                if (dest != null)
                {
                    base.CopyTo(dest);
                    if(TypeElement != null) dest.TypeElement = (Code<Hl7.Fhir.Model.NoteType>)TypeElement.DeepCopy();
                    if(TextElement != null) dest.TextElement = (Hl7.Fhir.Model.FhirString)TextElement.DeepCopy();
                    return dest;
                }
                else
                	throw new ArgumentException("Can only copy to an object of the same type", "other");
            }
            
            public override IDeepCopyable DeepCopy()
            {
                return CopyTo(new ProcessNoteComponent());
            }
            
            public override bool Matches(IDeepComparable other)
            {
                var otherT = other as ProcessNoteComponent;
                if(otherT == null) return false;
                
                if(!base.Matches(otherT)) return false;
                if( !DeepComparable.Matches(TypeElement, otherT.TypeElement)) return false;
                if( !DeepComparable.Matches(TextElement, otherT.TextElement)) return false;
                
                return true;
            }
            
            public override bool IsExactly(IDeepComparable other)
            {
                var otherT = other as ProcessNoteComponent;
                if(otherT == null) return false;
                
                if(!base.IsExactly(otherT)) return false;
                if( !DeepComparable.IsExactly(TypeElement, otherT.TypeElement)) return false;
                if( !DeepComparable.IsExactly(TextElement, otherT.TextElement)) return false;
                
                return true;
            }


            [NotMapped]
            public override IEnumerable<Base> Children
            {
                get
                {
                    foreach (var item in base.Children) yield return item;
                    if (TypeElement != null) yield return TypeElement;
                    if (TextElement != null) yield return TextElement;
                }
            }

            [NotMapped]
            internal override IEnumerable<ElementValue> NamedChildren
            {
                get
                {
                    foreach (var item in base.NamedChildren) yield return item;
                    if (TypeElement != null) yield return new ElementValue("type", false, TypeElement);
                    if (TextElement != null) yield return new ElementValue("text", false, TextElement);
                }
            }

            
        }
        
        
        /// <summary>
        /// Business Identifier
        /// </summary>
        [FhirElement("identifier", Order=90)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.Identifier> Identifier
        {
            get { if(_Identifier==null) _Identifier = new List<Hl7.Fhir.Model.Identifier>(); return _Identifier; }
            set { _Identifier = value; OnPropertyChanged("Identifier"); }
        }
        
        private List<Hl7.Fhir.Model.Identifier> _Identifier;
        
        /// <summary>
        /// active | cancelled | draft | entered-in-error
        /// </summary>
        [FhirElement("status", InSummary=true, Order=100)]
        [DataMember]
        public Code<Hl7.Fhir.Model.FinancialResourceStatusCodes> StatusElement
        {
            get { return _StatusElement; }
            set { _StatusElement = value; OnPropertyChanged("StatusElement"); }
        }
        
        private Code<Hl7.Fhir.Model.FinancialResourceStatusCodes> _StatusElement;
        
        /// <summary>
        /// active | cancelled | draft | entered-in-error
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.FinancialResourceStatusCodes? Status
        {
            get { return StatusElement != null ? StatusElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  StatusElement = null; 
                else
                  StatusElement = new Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>(value);
                OnPropertyChanged("Status");
            }
        }
        
        /// <summary>
        /// Creation date
        /// </summary>
        [FhirElement("created", Order=110)]
        [DataMember]
        public Hl7.Fhir.Model.FhirDateTime CreatedElement
        {
            get { return _CreatedElement; }
            set { _CreatedElement = value; OnPropertyChanged("CreatedElement"); }
        }
        
        private Hl7.Fhir.Model.FhirDateTime _CreatedElement;
        
        /// <summary>
        /// Creation date
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
        /// Authoring Organization
        /// </summary>
        [FhirElement("organization", Order=120)]
        [CLSCompliant(false)]
		[References("Organization")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Organization
        {
            get { return _Organization; }
            set { _Organization = value; OnPropertyChanged("Organization"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Organization;
        
        /// <summary>
        /// Request reference
        /// </summary>
        [FhirElement("request", Order=130)]
        [CLSCompliant(false)]
		[References()]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference Request
        {
            get { return _Request; }
            set { _Request = value; OnPropertyChanged("Request"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _Request;
        
        /// <summary>
        /// Processing outcome
        /// </summary>
        [FhirElement("outcome", Order=140)]
        [DataMember]
        public Code<Hl7.Fhir.Model.ProcessResponse.ProcessOutcomeCodes> OutcomeElement
        {
            get { return _OutcomeElement; }
            set { _OutcomeElement = value; OnPropertyChanged("OutcomeElement"); }
        }
        
        private Code<Hl7.Fhir.Model.ProcessResponse.ProcessOutcomeCodes> _OutcomeElement;
        
        /// <summary>
        /// Processing outcome
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public Hl7.Fhir.Model.ProcessResponse.ProcessOutcomeCodes? Outcome
        {
            get { return OutcomeElement != null ? OutcomeElement.Value : null; }
            set
            {
                if (!value.HasValue)
                  OutcomeElement = null; 
                else
                  OutcomeElement = new Code<Hl7.Fhir.Model.ProcessResponse.ProcessOutcomeCodes>(value);
                OnPropertyChanged("Outcome");
            }
        }
        
        /// <summary>
        /// Disposition Message
        /// </summary>
        [FhirElement("disposition", Order=150)]
        [DataMember]
        public Hl7.Fhir.Model.FhirString DispositionElement
        {
            get { return _DispositionElement; }
            set { _DispositionElement = value; OnPropertyChanged("DispositionElement"); }
        }
        
        private Hl7.Fhir.Model.FhirString _DispositionElement;
        
        /// <summary>
        /// Disposition Message
        /// </summary>
        /// <remarks>This uses the native .NET datatype, rather than the FHIR equivalent</remarks>
        [NotMapped]
        [IgnoreDataMemberAttribute]
        public string Disposition
        {
            get { return DispositionElement != null ? DispositionElement.Value : null; }
            set
            {
                if (value == null)
                  DispositionElement = null; 
                else
                  DispositionElement = new Hl7.Fhir.Model.FhirString(value);
                OnPropertyChanged("Disposition");
            }
        }
        
        /// <summary>
        /// Responsible Practitioner
        /// </summary>
        [FhirElement("requestProvider", Order=160)]
        [CLSCompliant(false)]
		[References("Practitioner")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference RequestProvider
        {
            get { return _RequestProvider; }
            set { _RequestProvider = value; OnPropertyChanged("RequestProvider"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _RequestProvider;
        
        /// <summary>
        /// Responsible organization
        /// </summary>
        [FhirElement("requestOrganization", Order=170)]
        [CLSCompliant(false)]
		[References("Organization")]
        [DataMember]
        public Hl7.Fhir.Model.ResourceReference RequestOrganization
        {
            get { return _RequestOrganization; }
            set { _RequestOrganization = value; OnPropertyChanged("RequestOrganization"); }
        }
        
        private Hl7.Fhir.Model.ResourceReference _RequestOrganization;
        
        /// <summary>
        /// Printed Form Identifier
        /// </summary>
        [FhirElement("form", Order=180)]
        [DataMember]
        public Hl7.Fhir.Model.CodeableConcept Form
        {
            get { return _Form; }
            set { _Form = value; OnPropertyChanged("Form"); }
        }
        
        private Hl7.Fhir.Model.CodeableConcept _Form;
        
        /// <summary>
        /// Processing comments or additional requirements
        /// </summary>
        [FhirElement("processNote", Order=190)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ProcessResponse.ProcessNoteComponent> ProcessNote
        {
            get { if(_ProcessNote==null) _ProcessNote = new List<Hl7.Fhir.Model.ProcessResponse.ProcessNoteComponent>(); return _ProcessNote; }
            set { _ProcessNote = value; OnPropertyChanged("ProcessNote"); }
        }
        
        private List<Hl7.Fhir.Model.ProcessResponse.ProcessNoteComponent> _ProcessNote;
        
        /// <summary>
        /// Error code
        /// </summary>
        [FhirElement("error", Order=200)]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.CodeableConcept> Error
        {
            get { if(_Error==null) _Error = new List<Hl7.Fhir.Model.CodeableConcept>(); return _Error; }
            set { _Error = value; OnPropertyChanged("Error"); }
        }
        
        private List<Hl7.Fhir.Model.CodeableConcept> _Error;
        
        /// <summary>
        /// Request for additional information
        /// </summary>
        [FhirElement("communicationRequest", Order=210)]
        [CLSCompliant(false)]
		[References("CommunicationRequest")]
        [Cardinality(Min=0,Max=-1)]
        [DataMember]
        public List<Hl7.Fhir.Model.ResourceReference> CommunicationRequest
        {
            get { if(_CommunicationRequest==null) _CommunicationRequest = new List<Hl7.Fhir.Model.ResourceReference>(); return _CommunicationRequest; }
            set { _CommunicationRequest = value; OnPropertyChanged("CommunicationRequest"); }
        }
        
        private List<Hl7.Fhir.Model.ResourceReference> _CommunicationRequest;
        

        public override void AddDefaultConstraints()
        {
            base.AddDefaultConstraints();

        }

        public override IDeepCopyable CopyTo(IDeepCopyable other)
        {
            var dest = other as ProcessResponse;
            
            if (dest != null)
            {
                base.CopyTo(dest);
                if(Identifier != null) dest.Identifier = new List<Hl7.Fhir.Model.Identifier>(Identifier.DeepCopy());
                if(StatusElement != null) dest.StatusElement = (Code<Hl7.Fhir.Model.FinancialResourceStatusCodes>)StatusElement.DeepCopy();
                if(CreatedElement != null) dest.CreatedElement = (Hl7.Fhir.Model.FhirDateTime)CreatedElement.DeepCopy();
                if(Organization != null) dest.Organization = (Hl7.Fhir.Model.ResourceReference)Organization.DeepCopy();
                if(Request != null) dest.Request = (Hl7.Fhir.Model.ResourceReference)Request.DeepCopy();
                if(OutcomeElement != null) dest.OutcomeElement = (Code<Hl7.Fhir.Model.ProcessResponse.ProcessOutcomeCodes>)OutcomeElement.DeepCopy();
                if(DispositionElement != null) dest.DispositionElement = (Hl7.Fhir.Model.FhirString)DispositionElement.DeepCopy();
                if(RequestProvider != null) dest.RequestProvider = (Hl7.Fhir.Model.ResourceReference)RequestProvider.DeepCopy();
                if(RequestOrganization != null) dest.RequestOrganization = (Hl7.Fhir.Model.ResourceReference)RequestOrganization.DeepCopy();
                if(Form != null) dest.Form = (Hl7.Fhir.Model.CodeableConcept)Form.DeepCopy();
                if(ProcessNote != null) dest.ProcessNote = new List<Hl7.Fhir.Model.ProcessResponse.ProcessNoteComponent>(ProcessNote.DeepCopy());
                if(Error != null) dest.Error = new List<Hl7.Fhir.Model.CodeableConcept>(Error.DeepCopy());
                if(CommunicationRequest != null) dest.CommunicationRequest = new List<Hl7.Fhir.Model.ResourceReference>(CommunicationRequest.DeepCopy());
                return dest;
            }
            else
            	throw new ArgumentException("Can only copy to an object of the same type", "other");
        }
        
        public override IDeepCopyable DeepCopy()
        {
            return CopyTo(new ProcessResponse());
        }
        
        public override bool Matches(IDeepComparable other)
        {
            var otherT = other as ProcessResponse;
            if(otherT == null) return false;
            
            if(!base.Matches(otherT)) return false;
            if( !DeepComparable.Matches(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.Matches(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.Matches(CreatedElement, otherT.CreatedElement)) return false;
            if( !DeepComparable.Matches(Organization, otherT.Organization)) return false;
            if( !DeepComparable.Matches(Request, otherT.Request)) return false;
            if( !DeepComparable.Matches(OutcomeElement, otherT.OutcomeElement)) return false;
            if( !DeepComparable.Matches(DispositionElement, otherT.DispositionElement)) return false;
            if( !DeepComparable.Matches(RequestProvider, otherT.RequestProvider)) return false;
            if( !DeepComparable.Matches(RequestOrganization, otherT.RequestOrganization)) return false;
            if( !DeepComparable.Matches(Form, otherT.Form)) return false;
            if( !DeepComparable.Matches(ProcessNote, otherT.ProcessNote)) return false;
            if( !DeepComparable.Matches(Error, otherT.Error)) return false;
            if( !DeepComparable.Matches(CommunicationRequest, otherT.CommunicationRequest)) return false;
            
            return true;
        }
        
        public override bool IsExactly(IDeepComparable other)
        {
            var otherT = other as ProcessResponse;
            if(otherT == null) return false;
            
            if(!base.IsExactly(otherT)) return false;
            if( !DeepComparable.IsExactly(Identifier, otherT.Identifier)) return false;
            if( !DeepComparable.IsExactly(StatusElement, otherT.StatusElement)) return false;
            if( !DeepComparable.IsExactly(CreatedElement, otherT.CreatedElement)) return false;
            if( !DeepComparable.IsExactly(Organization, otherT.Organization)) return false;
            if( !DeepComparable.IsExactly(Request, otherT.Request)) return false;
            if( !DeepComparable.IsExactly(OutcomeElement, otherT.OutcomeElement)) return false;
            if( !DeepComparable.IsExactly(DispositionElement, otherT.DispositionElement)) return false;
            if( !DeepComparable.IsExactly(RequestProvider, otherT.RequestProvider)) return false;
            if( !DeepComparable.IsExactly(RequestOrganization, otherT.RequestOrganization)) return false;
            if( !DeepComparable.IsExactly(Form, otherT.Form)) return false;
            if( !DeepComparable.IsExactly(ProcessNote, otherT.ProcessNote)) return false;
            if( !DeepComparable.IsExactly(Error, otherT.Error)) return false;
            if( !DeepComparable.IsExactly(CommunicationRequest, otherT.CommunicationRequest)) return false;
            
            return true;
        }

        [NotMapped]
        public override IEnumerable<Base> Children
        {
            get
            {
                foreach (var item in base.Children) yield return item;
				foreach (var elem in Identifier) { if (elem != null) yield return elem; }
				if (StatusElement != null) yield return StatusElement;
				if (CreatedElement != null) yield return CreatedElement;
				if (Organization != null) yield return Organization;
				if (Request != null) yield return Request;
				if (OutcomeElement != null) yield return OutcomeElement;
				if (DispositionElement != null) yield return DispositionElement;
				if (RequestProvider != null) yield return RequestProvider;
				if (RequestOrganization != null) yield return RequestOrganization;
				if (Form != null) yield return Form;
				foreach (var elem in ProcessNote) { if (elem != null) yield return elem; }
				foreach (var elem in Error) { if (elem != null) yield return elem; }
				foreach (var elem in CommunicationRequest) { if (elem != null) yield return elem; }
            }
        }

        [NotMapped]
        internal override IEnumerable<ElementValue> NamedChildren
        {
            get
            {
                foreach (var item in base.NamedChildren) yield return item;
                foreach (var elem in Identifier) { if (elem != null) yield return new ElementValue("identifier", true, elem); }
                if (StatusElement != null) yield return new ElementValue("status", false, StatusElement);
                if (CreatedElement != null) yield return new ElementValue("created", false, CreatedElement);
                if (Organization != null) yield return new ElementValue("organization", false, Organization);
                if (Request != null) yield return new ElementValue("request", false, Request);
                if (OutcomeElement != null) yield return new ElementValue("outcome", false, OutcomeElement);
                if (DispositionElement != null) yield return new ElementValue("disposition", false, DispositionElement);
                if (RequestProvider != null) yield return new ElementValue("requestProvider", false, RequestProvider);
                if (RequestOrganization != null) yield return new ElementValue("requestOrganization", false, RequestOrganization);
                if (Form != null) yield return new ElementValue("form", false, Form);
                foreach (var elem in ProcessNote) { if (elem != null) yield return new ElementValue("processNote", true, elem); }
                foreach (var elem in Error) { if (elem != null) yield return new ElementValue("error", true, elem); }
                foreach (var elem in CommunicationRequest) { if (elem != null) yield return new ElementValue("communicationRequest", true, elem); }
            }
        }

    }
    
}
