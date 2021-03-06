﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BioMatcher.BioMatcherAsmxReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MatchRequest", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class MatchRequest : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] FingerprintField;
        
        private int LocaleIdField;
        
        private int ExtraRefCodeField;
        
        private System.DateTime RequestDateField;
        
        private bool SkipLocaleField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false)]
        public byte[] Fingerprint {
            get {
                return this.FingerprintField;
            }
            set {
                if ((object.ReferenceEquals(this.FingerprintField, value) != true)) {
                    this.FingerprintField = value;
                    this.RaisePropertyChanged("Fingerprint");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int LocaleId {
            get {
                return this.LocaleIdField;
            }
            set {
                if ((this.LocaleIdField.Equals(value) != true)) {
                    this.LocaleIdField = value;
                    this.RaisePropertyChanged("LocaleId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int ExtraRefCode {
            get {
                return this.ExtraRefCodeField;
            }
            set {
                if ((this.ExtraRefCodeField.Equals(value) != true)) {
                    this.ExtraRefCodeField = value;
                    this.RaisePropertyChanged("ExtraRefCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=3)]
        public System.DateTime RequestDate {
            get {
                return this.RequestDateField;
            }
            set {
                if ((this.RequestDateField.Equals(value) != true)) {
                    this.RequestDateField = value;
                    this.RaisePropertyChanged("RequestDate");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public bool SkipLocale {
            get {
                return this.SkipLocaleField;
            }
            set {
                if ((this.SkipLocaleField.Equals(value) != true)) {
                    this.SkipLocaleField = value;
                    this.RaisePropertyChanged("SkipLocale");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MatchResult", Namespace="http://tempuri.org/")]
    [System.SerializableAttribute()]
    public partial class MatchResult : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        private bool FoundField;
        
        private int ScoreField;
        
        private int MemberIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ExtraField;
        
        private int ExtraRefCodeField;
        
        private System.DateTime RequestDateField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool Found {
            get {
                return this.FoundField;
            }
            set {
                if ((this.FoundField.Equals(value) != true)) {
                    this.FoundField = value;
                    this.RaisePropertyChanged("Found");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public int Score {
            get {
                return this.ScoreField;
            }
            set {
                if ((this.ScoreField.Equals(value) != true)) {
                    this.ScoreField = value;
                    this.RaisePropertyChanged("Score");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=2)]
        public int MemberId {
            get {
                return this.MemberIdField;
            }
            set {
                if ((this.MemberIdField.Equals(value) != true)) {
                    this.MemberIdField = value;
                    this.RaisePropertyChanged("MemberId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string Extra {
            get {
                return this.ExtraField;
            }
            set {
                if ((object.ReferenceEquals(this.ExtraField, value) != true)) {
                    this.ExtraField = value;
                    this.RaisePropertyChanged("Extra");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=4)]
        public int ExtraRefCode {
            get {
                return this.ExtraRefCodeField;
            }
            set {
                if ((this.ExtraRefCodeField.Equals(value) != true)) {
                    this.ExtraRefCodeField = value;
                    this.RaisePropertyChanged("ExtraRefCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true, Order=5)]
        public System.DateTime RequestDate {
            get {
                return this.RequestDateField;
            }
            set {
                if ((this.RequestDateField.Equals(value) != true)) {
                    this.RequestDateField = value;
                    this.RaisePropertyChanged("RequestDate");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BioMatcherAsmxReference.BioMatcherServiceSoap")]
    public interface BioMatcherServiceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Initialize", ReplyAction="*")]
        void Initialize();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Initialize", ReplyAction="*")]
        System.Threading.Tasks.Task InitializeAsync();
        
        // CODEGEN: Generating message contract since element name request from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Identify", ReplyAction="*")]
        BioMatcher.BioMatcherAsmxReference.IdentifyResponse Identify(BioMatcher.BioMatcherAsmxReference.IdentifyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Identify", ReplyAction="*")]
        System.Threading.Tasks.Task<BioMatcher.BioMatcherAsmxReference.IdentifyResponse> IdentifyAsync(BioMatcher.BioMatcherAsmxReference.IdentifyRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateCache", ReplyAction="*")]
        void UpdateCache(int localeId, bool fullUpdate);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/UpdateCache", ReplyAction="*")]
        System.Threading.Tasks.Task UpdateCacheAsync(int localeId, bool fullUpdate);
        
        // CODEGEN: Generating message contract since element name GetCacheStatusResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCacheStatus", ReplyAction="*")]
        BioMatcher.BioMatcherAsmxReference.GetCacheStatusResponse GetCacheStatus(BioMatcher.BioMatcherAsmxReference.GetCacheStatusRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetCacheStatus", ReplyAction="*")]
        System.Threading.Tasks.Task<BioMatcher.BioMatcherAsmxReference.GetCacheStatusResponse> GetCacheStatusAsync(BioMatcher.BioMatcherAsmxReference.GetCacheStatusRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class IdentifyRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Identify", Namespace="http://tempuri.org/", Order=0)]
        public BioMatcher.BioMatcherAsmxReference.IdentifyRequestBody Body;
        
        public IdentifyRequest() {
        }
        
        public IdentifyRequest(BioMatcher.BioMatcherAsmxReference.IdentifyRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class IdentifyRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public BioMatcher.BioMatcherAsmxReference.MatchRequest request;
        
        public IdentifyRequestBody() {
        }
        
        public IdentifyRequestBody(BioMatcher.BioMatcherAsmxReference.MatchRequest request) {
            this.request = request;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class IdentifyResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="IdentifyResponse", Namespace="http://tempuri.org/", Order=0)]
        public BioMatcher.BioMatcherAsmxReference.IdentifyResponseBody Body;
        
        public IdentifyResponse() {
        }
        
        public IdentifyResponse(BioMatcher.BioMatcherAsmxReference.IdentifyResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class IdentifyResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public BioMatcher.BioMatcherAsmxReference.MatchResult IdentifyResult;
        
        public IdentifyResponseBody() {
        }
        
        public IdentifyResponseBody(BioMatcher.BioMatcherAsmxReference.MatchResult IdentifyResult) {
            this.IdentifyResult = IdentifyResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCacheStatusRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCacheStatus", Namespace="http://tempuri.org/", Order=0)]
        public BioMatcher.BioMatcherAsmxReference.GetCacheStatusRequestBody Body;
        
        public GetCacheStatusRequest() {
        }
        
        public GetCacheStatusRequest(BioMatcher.BioMatcherAsmxReference.GetCacheStatusRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetCacheStatusRequestBody {
        
        public GetCacheStatusRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetCacheStatusResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetCacheStatusResponse", Namespace="http://tempuri.org/", Order=0)]
        public BioMatcher.BioMatcherAsmxReference.GetCacheStatusResponseBody Body;
        
        public GetCacheStatusResponse() {
        }
        
        public GetCacheStatusResponse(BioMatcher.BioMatcherAsmxReference.GetCacheStatusResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetCacheStatusResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetCacheStatusResult;
        
        public GetCacheStatusResponseBody() {
        }
        
        public GetCacheStatusResponseBody(string GetCacheStatusResult) {
            this.GetCacheStatusResult = GetCacheStatusResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface BioMatcherServiceSoapChannel : BioMatcher.BioMatcherAsmxReference.BioMatcherServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BioMatcherServiceSoapClient : System.ServiceModel.ClientBase<BioMatcher.BioMatcherAsmxReference.BioMatcherServiceSoap>, BioMatcher.BioMatcherAsmxReference.BioMatcherServiceSoap {
        
        public BioMatcherServiceSoapClient() {
        }
        
        public BioMatcherServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BioMatcherServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BioMatcherServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BioMatcherServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void Initialize() {
            base.Channel.Initialize();
        }
        
        public System.Threading.Tasks.Task InitializeAsync() {
            return base.Channel.InitializeAsync();
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BioMatcher.BioMatcherAsmxReference.IdentifyResponse BioMatcher.BioMatcherAsmxReference.BioMatcherServiceSoap.Identify(BioMatcher.BioMatcherAsmxReference.IdentifyRequest request) {
            return base.Channel.Identify(request);
        }
        
        public BioMatcher.BioMatcherAsmxReference.MatchResult Identify(BioMatcher.BioMatcherAsmxReference.MatchRequest request) {
            BioMatcher.BioMatcherAsmxReference.IdentifyRequest inValue = new BioMatcher.BioMatcherAsmxReference.IdentifyRequest();
            inValue.Body = new BioMatcher.BioMatcherAsmxReference.IdentifyRequestBody();
            inValue.Body.request = request;
            BioMatcher.BioMatcherAsmxReference.IdentifyResponse retVal = ((BioMatcher.BioMatcherAsmxReference.BioMatcherServiceSoap)(this)).Identify(inValue);
            return retVal.Body.IdentifyResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BioMatcher.BioMatcherAsmxReference.IdentifyResponse> BioMatcher.BioMatcherAsmxReference.BioMatcherServiceSoap.IdentifyAsync(BioMatcher.BioMatcherAsmxReference.IdentifyRequest request) {
            return base.Channel.IdentifyAsync(request);
        }
        
        public System.Threading.Tasks.Task<BioMatcher.BioMatcherAsmxReference.IdentifyResponse> IdentifyAsync(BioMatcher.BioMatcherAsmxReference.MatchRequest request) {
            BioMatcher.BioMatcherAsmxReference.IdentifyRequest inValue = new BioMatcher.BioMatcherAsmxReference.IdentifyRequest();
            inValue.Body = new BioMatcher.BioMatcherAsmxReference.IdentifyRequestBody();
            inValue.Body.request = request;
            return ((BioMatcher.BioMatcherAsmxReference.BioMatcherServiceSoap)(this)).IdentifyAsync(inValue);
        }
        
        public void UpdateCache(int localeId, bool fullUpdate) {
            base.Channel.UpdateCache(localeId, fullUpdate);
        }
        
        public System.Threading.Tasks.Task UpdateCacheAsync(int localeId, bool fullUpdate) {
            return base.Channel.UpdateCacheAsync(localeId, fullUpdate);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        BioMatcher.BioMatcherAsmxReference.GetCacheStatusResponse BioMatcher.BioMatcherAsmxReference.BioMatcherServiceSoap.GetCacheStatus(BioMatcher.BioMatcherAsmxReference.GetCacheStatusRequest request) {
            return base.Channel.GetCacheStatus(request);
        }
        
        public string GetCacheStatus() {
            BioMatcher.BioMatcherAsmxReference.GetCacheStatusRequest inValue = new BioMatcher.BioMatcherAsmxReference.GetCacheStatusRequest();
            inValue.Body = new BioMatcher.BioMatcherAsmxReference.GetCacheStatusRequestBody();
            BioMatcher.BioMatcherAsmxReference.GetCacheStatusResponse retVal = ((BioMatcher.BioMatcherAsmxReference.BioMatcherServiceSoap)(this)).GetCacheStatus(inValue);
            return retVal.Body.GetCacheStatusResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<BioMatcher.BioMatcherAsmxReference.GetCacheStatusResponse> BioMatcher.BioMatcherAsmxReference.BioMatcherServiceSoap.GetCacheStatusAsync(BioMatcher.BioMatcherAsmxReference.GetCacheStatusRequest request) {
            return base.Channel.GetCacheStatusAsync(request);
        }
        
        public System.Threading.Tasks.Task<BioMatcher.BioMatcherAsmxReference.GetCacheStatusResponse> GetCacheStatusAsync() {
            BioMatcher.BioMatcherAsmxReference.GetCacheStatusRequest inValue = new BioMatcher.BioMatcherAsmxReference.GetCacheStatusRequest();
            inValue.Body = new BioMatcher.BioMatcherAsmxReference.GetCacheStatusRequestBody();
            return ((BioMatcher.BioMatcherAsmxReference.BioMatcherServiceSoap)(this)).GetCacheStatusAsync(inValue);
        }
    }
}
