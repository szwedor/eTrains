﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AdminGUI.ConnectionService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Entity", Namespace="http://schemas.datacontract.org/2004/07/DomainModel")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(AdminGUI.ConnectionService.ConnectionDefinition))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(AdminGUI.ConnectionService.Train))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(AdminGUI.ConnectionService.Station))]
    public partial class Entity : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int IdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] VersionField;
        
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
        public int Id {
            get {
                return this.IdField;
            }
            set {
                if ((this.IdField.Equals(value) != true)) {
                    this.IdField = value;
                    this.RaisePropertyChanged("Id");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] Version {
            get {
                return this.VersionField;
            }
            set {
                if ((object.ReferenceEquals(this.VersionField, value) != true)) {
                    this.VersionField = value;
                    this.RaisePropertyChanged("Version");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="ConnectionDefinition", Namespace="http://schemas.datacontract.org/2004/07/DomainModel.Models")]
    [System.SerializableAttribute()]
    public partial class ConnectionDefinition : AdminGUI.ConnectionService.Entity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AdminGUI.ConnectionService.Station ArrivalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AdminGUI.ConnectionService.Station DepartureField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsArchivalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int PriceField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private AdminGUI.ConnectionService.Train TrainField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private System.TimeSpan TravelTimeField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AdminGUI.ConnectionService.Station Arrival {
            get {
                return this.ArrivalField;
            }
            set {
                if ((object.ReferenceEquals(this.ArrivalField, value) != true)) {
                    this.ArrivalField = value;
                    this.RaisePropertyChanged("Arrival");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AdminGUI.ConnectionService.Station Departure {
            get {
                return this.DepartureField;
            }
            set {
                if ((object.ReferenceEquals(this.DepartureField, value) != true)) {
                    this.DepartureField = value;
                    this.RaisePropertyChanged("Departure");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsArchival {
            get {
                return this.IsArchivalField;
            }
            set {
                if ((this.IsArchivalField.Equals(value) != true)) {
                    this.IsArchivalField = value;
                    this.RaisePropertyChanged("IsArchival");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Price {
            get {
                return this.PriceField;
            }
            set {
                if ((this.PriceField.Equals(value) != true)) {
                    this.PriceField = value;
                    this.RaisePropertyChanged("Price");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public AdminGUI.ConnectionService.Train Train {
            get {
                return this.TrainField;
            }
            set {
                if ((object.ReferenceEquals(this.TrainField, value) != true)) {
                    this.TrainField = value;
                    this.RaisePropertyChanged("Train");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.TimeSpan TravelTime {
            get {
                return this.TravelTimeField;
            }
            set {
                if ((this.TravelTimeField.Equals(value) != true)) {
                    this.TravelTimeField = value;
                    this.RaisePropertyChanged("TravelTime");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Train", Namespace="http://schemas.datacontract.org/2004/07/DomainModel.Models")]
    [System.SerializableAttribute()]
    public partial class Train : AdminGUI.ConnectionService.Entity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsArchivalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int SeatNoField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsArchival {
            get {
                return this.IsArchivalField;
            }
            set {
                if ((this.IsArchivalField.Equals(value) != true)) {
                    this.IsArchivalField = value;
                    this.RaisePropertyChanged("IsArchival");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int SeatNo {
            get {
                return this.SeatNoField;
            }
            set {
                if ((this.SeatNoField.Equals(value) != true)) {
                    this.SeatNoField = value;
                    this.RaisePropertyChanged("SeatNo");
                }
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Station", Namespace="http://schemas.datacontract.org/2004/07/DomainModel.Models")]
    [System.SerializableAttribute()]
    public partial class Station : AdminGUI.ConnectionService.Entity {
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsArchivalField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsArchival {
            get {
                return this.IsArchivalField;
            }
            set {
                if ((this.IsArchivalField.Equals(value) != true)) {
                    this.IsArchivalField = value;
                    this.RaisePropertyChanged("IsArchival");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ConnectionService.IConnectionManagment")]
    public interface IConnectionManagment {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectionManagment/AddNewConnection", ReplyAction="http://tempuri.org/IConnectionManagment/AddNewConnectionResponse")]
        bool AddNewConnection(AdminGUI.ConnectionService.Station departureStation, AdminGUI.ConnectionService.Station arrivalStation, int valueHour, int valueMinute, int price, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectionManagment/AddNewConnection", ReplyAction="http://tempuri.org/IConnectionManagment/AddNewConnectionResponse")]
        System.Threading.Tasks.Task<bool> AddNewConnectionAsync(AdminGUI.ConnectionService.Station departureStation, AdminGUI.ConnectionService.Station arrivalStation, int valueHour, int valueMinute, int price, string name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectionManagment/Find", ReplyAction="http://tempuri.org/IConnectionManagment/FindResponse")]
        AdminGUI.ConnectionService.ConnectionDefinition[] Find(AdminGUI.ConnectionService.Station departure, AdminGUI.ConnectionService.Station arrival, int price, int hour);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectionManagment/Find", ReplyAction="http://tempuri.org/IConnectionManagment/FindResponse")]
        System.Threading.Tasks.Task<AdminGUI.ConnectionService.ConnectionDefinition[]> FindAsync(AdminGUI.ConnectionService.Station departure, AdminGUI.ConnectionService.Station arrival, int price, int hour);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectionManagment/UpdateConnection", ReplyAction="http://tempuri.org/IConnectionManagment/UpdateConnectionResponse")]
        bool UpdateConnection(AdminGUI.ConnectionService.ConnectionDefinition cd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectionManagment/UpdateConnection", ReplyAction="http://tempuri.org/IConnectionManagment/UpdateConnectionResponse")]
        System.Threading.Tasks.Task<bool> UpdateConnectionAsync(AdminGUI.ConnectionService.ConnectionDefinition cd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectionManagment/MakeArchival", ReplyAction="http://tempuri.org/IConnectionManagment/MakeArchivalResponse")]
        bool MakeArchival(AdminGUI.ConnectionService.ConnectionDefinition cd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectionManagment/MakeArchival", ReplyAction="http://tempuri.org/IConnectionManagment/MakeArchivalResponse")]
        System.Threading.Tasks.Task<bool> MakeArchivalAsync(AdminGUI.ConnectionService.ConnectionDefinition cd);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectionManagment/AddNewConnections", ReplyAction="http://tempuri.org/IConnectionManagment/AddNewConnectionsResponse")]
        bool AddNewConnections(AdminGUI.ConnectionService.ConnectionDefinition connectionDefinition, System.DateTime value, System.DateTime dateTime, int days, int h, int m);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IConnectionManagment/AddNewConnections", ReplyAction="http://tempuri.org/IConnectionManagment/AddNewConnectionsResponse")]
        System.Threading.Tasks.Task<bool> AddNewConnectionsAsync(AdminGUI.ConnectionService.ConnectionDefinition connectionDefinition, System.DateTime value, System.DateTime dateTime, int days, int h, int m);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IConnectionManagmentChannel : AdminGUI.ConnectionService.IConnectionManagment, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ConnectionManagmentClient : System.ServiceModel.ClientBase<AdminGUI.ConnectionService.IConnectionManagment>, AdminGUI.ConnectionService.IConnectionManagment {
        
        public ConnectionManagmentClient() {
        }
        
        public ConnectionManagmentClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ConnectionManagmentClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConnectionManagmentClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ConnectionManagmentClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool AddNewConnection(AdminGUI.ConnectionService.Station departureStation, AdminGUI.ConnectionService.Station arrivalStation, int valueHour, int valueMinute, int price, string name) {
            return base.Channel.AddNewConnection(departureStation, arrivalStation, valueHour, valueMinute, price, name);
        }
        
        public System.Threading.Tasks.Task<bool> AddNewConnectionAsync(AdminGUI.ConnectionService.Station departureStation, AdminGUI.ConnectionService.Station arrivalStation, int valueHour, int valueMinute, int price, string name) {
            return base.Channel.AddNewConnectionAsync(departureStation, arrivalStation, valueHour, valueMinute, price, name);
        }
        
        public AdminGUI.ConnectionService.ConnectionDefinition[] Find(AdminGUI.ConnectionService.Station departure, AdminGUI.ConnectionService.Station arrival, int price, int hour) {
            return base.Channel.Find(departure, arrival, price, hour);
        }
        
        public System.Threading.Tasks.Task<AdminGUI.ConnectionService.ConnectionDefinition[]> FindAsync(AdminGUI.ConnectionService.Station departure, AdminGUI.ConnectionService.Station arrival, int price, int hour) {
            return base.Channel.FindAsync(departure, arrival, price, hour);
        }
        
        public bool UpdateConnection(AdminGUI.ConnectionService.ConnectionDefinition cd) {
            return base.Channel.UpdateConnection(cd);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateConnectionAsync(AdminGUI.ConnectionService.ConnectionDefinition cd) {
            return base.Channel.UpdateConnectionAsync(cd);
        }
        
        public bool MakeArchival(AdminGUI.ConnectionService.ConnectionDefinition cd) {
            return base.Channel.MakeArchival(cd);
        }
        
        public System.Threading.Tasks.Task<bool> MakeArchivalAsync(AdminGUI.ConnectionService.ConnectionDefinition cd) {
            return base.Channel.MakeArchivalAsync(cd);
        }
        
        public bool AddNewConnections(AdminGUI.ConnectionService.ConnectionDefinition connectionDefinition, System.DateTime value, System.DateTime dateTime, int days, int h, int m) {
            return base.Channel.AddNewConnections(connectionDefinition, value, dateTime, days, h, m);
        }
        
        public System.Threading.Tasks.Task<bool> AddNewConnectionsAsync(AdminGUI.ConnectionService.ConnectionDefinition connectionDefinition, System.DateTime value, System.DateTime dateTime, int days, int h, int m) {
            return base.Channel.AddNewConnectionsAsync(connectionDefinition, value, dateTime, days, h, m);
        }
    }
}