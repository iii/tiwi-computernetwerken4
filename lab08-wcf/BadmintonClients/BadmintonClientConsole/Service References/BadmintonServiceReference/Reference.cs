﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.296
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BadmintonClientConsole.BadmintonServiceReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="SportClubType", Namespace="http://schemas.datacontract.org/2004/07/BadmintonServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class SportClubType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BadmintonClientConsole.BadmintonServiceReference.LidType[] LedenField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NaamField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BadmintonClientConsole.BadmintonServiceReference.TornooiType[] TornooienField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BadmintonClientConsole.BadmintonServiceReference.LidType[] Leden {
            get {
                return this.LedenField;
            }
            set {
                if ((object.ReferenceEquals(this.LedenField, value) != true)) {
                    this.LedenField = value;
                    this.RaisePropertyChanged("Leden");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Naam {
            get {
                return this.NaamField;
            }
            set {
                if ((object.ReferenceEquals(this.NaamField, value) != true)) {
                    this.NaamField = value;
                    this.RaisePropertyChanged("Naam");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BadmintonClientConsole.BadmintonServiceReference.TornooiType[] Tornooien {
            get {
                return this.TornooienField;
            }
            set {
                if ((object.ReferenceEquals(this.TornooienField, value) != true)) {
                    this.TornooienField = value;
                    this.RaisePropertyChanged("Tornooien");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="LidType", Namespace="http://schemas.datacontract.org/2004/07/BadmintonServiceLibrary")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(BadmintonClientConsole.BadmintonServiceReference.SpelerType))]
    public partial class LidType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BadmintonClientConsole.BadmintonServiceReference.SportClubType ClubField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NaamField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BadmintonClientConsole.BadmintonServiceReference.SportClubType Club {
            get {
                return this.ClubField;
            }
            set {
                if ((object.ReferenceEquals(this.ClubField, value) != true)) {
                    this.ClubField = value;
                    this.RaisePropertyChanged("Club");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Naam {
            get {
                return this.NaamField;
            }
            set {
                if ((object.ReferenceEquals(this.NaamField, value) != true)) {
                    this.NaamField = value;
                    this.RaisePropertyChanged("Naam");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="TornooiType", Namespace="http://schemas.datacontract.org/2004/07/BadmintonServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class TornooiType : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BadmintonClientConsole.BadmintonServiceReference.SpelerType[] DeelnemersField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IDField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NaamField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BadmintonClientConsole.BadmintonServiceReference.SportClubType OrganisatorField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BadmintonClientConsole.BadmintonServiceReference.SpelerType[] Deelnemers {
            get {
                return this.DeelnemersField;
            }
            set {
                if ((object.ReferenceEquals(this.DeelnemersField, value) != true)) {
                    this.DeelnemersField = value;
                    this.RaisePropertyChanged("Deelnemers");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ID {
            get {
                return this.IDField;
            }
            set {
                if ((this.IDField.Equals(value) != true)) {
                    this.IDField = value;
                    this.RaisePropertyChanged("ID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Naam {
            get {
                return this.NaamField;
            }
            set {
                if ((object.ReferenceEquals(this.NaamField, value) != true)) {
                    this.NaamField = value;
                    this.RaisePropertyChanged("Naam");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BadmintonClientConsole.BadmintonServiceReference.SportClubType Organisator {
            get {
                return this.OrganisatorField;
            }
            set {
                if ((object.ReferenceEquals(this.OrganisatorField, value) != true)) {
                    this.OrganisatorField = value;
                    this.RaisePropertyChanged("Organisator");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="SpelerType", Namespace="http://schemas.datacontract.org/2004/07/BadmintonServiceLibrary")]
    [System.SerializableAttribute()]
    public partial class SpelerType : BadmintonClientConsole.BadmintonServiceReference.LidType {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string CategorieField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private BadmintonClientConsole.BadmintonServiceReference.TornooiType[] TornooienField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Categorie {
            get {
                return this.CategorieField;
            }
            set {
                if ((object.ReferenceEquals(this.CategorieField, value) != true)) {
                    this.CategorieField = value;
                    this.RaisePropertyChanged("Categorie");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public BadmintonClientConsole.BadmintonServiceReference.TornooiType[] Tornooien {
            get {
                return this.TornooienField;
            }
            set {
                if ((object.ReferenceEquals(this.TornooienField, value) != true)) {
                    this.TornooienField = value;
                    this.RaisePropertyChanged("Tornooien");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BadmintonServiceReference.IBadminton")]
    public interface IBadminton {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBadminton/GetAlleSportClubs", ReplyAction="http://tempuri.org/IBadminton/GetAlleSportClubsResponse")]
        BadmintonClientConsole.BadmintonServiceReference.SportClubType[] GetAlleSportClubs();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IBadminton/GetLeden", ReplyAction="http://tempuri.org/IBadminton/GetLedenResponse")]
        BadmintonClientConsole.BadmintonServiceReference.LidType[] GetLeden(BadmintonClientConsole.BadmintonServiceReference.SportClubType club);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBadmintonChannel : BadmintonClientConsole.BadmintonServiceReference.IBadminton, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BadmintonClient : System.ServiceModel.ClientBase<BadmintonClientConsole.BadmintonServiceReference.IBadminton>, BadmintonClientConsole.BadmintonServiceReference.IBadminton {
        
        public BadmintonClient() {
        }
        
        public BadmintonClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public BadmintonClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BadmintonClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public BadmintonClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public BadmintonClientConsole.BadmintonServiceReference.SportClubType[] GetAlleSportClubs() {
            return base.Channel.GetAlleSportClubs();
        }
        
        public BadmintonClientConsole.BadmintonServiceReference.LidType[] GetLeden(BadmintonClientConsole.BadmintonServiceReference.SportClubType club) {
            return base.Channel.GetLeden(club);
        }
    }
}
