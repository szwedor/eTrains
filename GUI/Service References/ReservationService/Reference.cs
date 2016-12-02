﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI.ReservationService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ReservationService.IReservationManagment")]
    public interface IReservationManagment {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationManagment/DepartureStations", ReplyAction="http://tempuri.org/IReservationManagment/DepartureStationsResponse")]
        DomainModel.Models.Station[] DepartureStations();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationManagment/DepartureStations", ReplyAction="http://tempuri.org/IReservationManagment/DepartureStationsResponse")]
        System.Threading.Tasks.Task<DomainModel.Models.Station[]> DepartureStationsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationManagment/ArrivalStations", ReplyAction="http://tempuri.org/IReservationManagment/ArrivalStationsResponse")]
        DomainModel.Models.Station[] ArrivalStations();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationManagment/ArrivalStations", ReplyAction="http://tempuri.org/IReservationManagment/ArrivalStationsResponse")]
        System.Threading.Tasks.Task<DomainModel.Models.Station[]> ArrivalStationsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationManagment/FindConnection", ReplyAction="http://tempuri.org/IReservationManagment/FindConnectionResponse")]
        DomainModel.Models.Connection[] FindConnection(DomainModel.Models.Station departure, DomainModel.Models.Station arrival, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationManagment/FindConnection", ReplyAction="http://tempuri.org/IReservationManagment/FindConnectionResponse")]
        System.Threading.Tasks.Task<DomainModel.Models.Connection[]> FindConnectionAsync(DomainModel.Models.Station departure, DomainModel.Models.Station arrival, System.DateTime date);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationManagment/FindEmail", ReplyAction="http://tempuri.org/IReservationManagment/FindEmailResponse")]
        bool FindEmail(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationManagment/FindEmail", ReplyAction="http://tempuri.org/IReservationManagment/FindEmailResponse")]
        System.Threading.Tasks.Task<bool> FindEmailAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationManagment/FindUser", ReplyAction="http://tempuri.org/IReservationManagment/FindUserResponse")]
        DomainModel.Models.User FindUser(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationManagment/FindUser", ReplyAction="http://tempuri.org/IReservationManagment/FindUserResponse")]
        System.Threading.Tasks.Task<DomainModel.Models.User> FindUserAsync(string login);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationManagment/MakeReservation", ReplyAction="http://tempuri.org/IReservationManagment/MakeReservationResponse")]
        int MakeReservation(DomainModel.Models.Connection con);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationManagment/MakeReservation", ReplyAction="http://tempuri.org/IReservationManagment/MakeReservationResponse")]
        System.Threading.Tasks.Task<int> MakeReservationAsync(DomainModel.Models.Connection con);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationManagment/AddUser", ReplyAction="http://tempuri.org/IReservationManagment/AddUserResponse")]
        void AddUser(DomainModel.Models.User a);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IReservationManagment/AddUser", ReplyAction="http://tempuri.org/IReservationManagment/AddUserResponse")]
        System.Threading.Tasks.Task AddUserAsync(DomainModel.Models.User a);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IReservationManagmentChannel : GUI.ReservationService.IReservationManagment, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ReservationManagmentClient : System.ServiceModel.ClientBase<GUI.ReservationService.IReservationManagment>, GUI.ReservationService.IReservationManagment {
        
        public ReservationManagmentClient() {
        }
        
        public ReservationManagmentClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ReservationManagmentClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReservationManagmentClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ReservationManagmentClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public DomainModel.Models.Station[] DepartureStations() {
            return base.Channel.DepartureStations();
        }
        
        public System.Threading.Tasks.Task<DomainModel.Models.Station[]> DepartureStationsAsync() {
            return base.Channel.DepartureStationsAsync();
        }
        
        public DomainModel.Models.Station[] ArrivalStations() {
            return base.Channel.ArrivalStations();
        }
        
        public System.Threading.Tasks.Task<DomainModel.Models.Station[]> ArrivalStationsAsync() {
            return base.Channel.ArrivalStationsAsync();
        }
        
        public DomainModel.Models.Connection[] FindConnection(DomainModel.Models.Station departure, DomainModel.Models.Station arrival, System.DateTime date) {
            return base.Channel.FindConnection(departure, arrival, date);
        }
        
        public System.Threading.Tasks.Task<DomainModel.Models.Connection[]> FindConnectionAsync(DomainModel.Models.Station departure, DomainModel.Models.Station arrival, System.DateTime date) {
            return base.Channel.FindConnectionAsync(departure, arrival, date);
        }
        
        public bool FindEmail(string email) {
            return base.Channel.FindEmail(email);
        }
        
        public System.Threading.Tasks.Task<bool> FindEmailAsync(string email) {
            return base.Channel.FindEmailAsync(email);
        }
        
        public DomainModel.Models.User FindUser(string login) {
            return base.Channel.FindUser(login);
        }
        
        public System.Threading.Tasks.Task<DomainModel.Models.User> FindUserAsync(string login) {
            return base.Channel.FindUserAsync(login);
        }
        
        public int MakeReservation(DomainModel.Models.Connection con) {
            return base.Channel.MakeReservation(con);
        }
        
        public System.Threading.Tasks.Task<int> MakeReservationAsync(DomainModel.Models.Connection con) {
            return base.Channel.MakeReservationAsync(con);
        }
        
        public void AddUser(DomainModel.Models.User a) {
            base.Channel.AddUser(a);
        }
        
        public System.Threading.Tasks.Task AddUserAsync(DomainModel.Models.User a) {
            return base.Channel.AddUserAsync(a);
        }
    }
}