﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GUI.StationService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StationService.IStationManagment")]
    public interface IStationManagment {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStationManagment/Add", ReplyAction="http://tempuri.org/IStationManagment/AddResponse")]
        bool Add(string newStationText);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStationManagment/Add", ReplyAction="http://tempuri.org/IStationManagment/AddResponse")]
        System.Threading.Tasks.Task<bool> AddAsync(string newStationText);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStationManagment/AllStations", ReplyAction="http://tempuri.org/IStationManagment/AllStationsResponse")]
        System.Collections.Generic.List<DomainModel.Models.Station> AllStations();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStationManagment/AllStations", ReplyAction="http://tempuri.org/IStationManagment/AllStationsResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<DomainModel.Models.Station>> AllStationsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStationManagment/ChangeStation", ReplyAction="http://tempuri.org/IStationManagment/ChangeStationResponse")]
        bool ChangeStation(DomainModel.Models.Station station, string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStationManagment/ChangeStation", ReplyAction="http://tempuri.org/IStationManagment/ChangeStationResponse")]
        System.Threading.Tasks.Task<bool> ChangeStationAsync(DomainModel.Models.Station station, string text);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStationManagment/ChangeStation2", ReplyAction="http://tempuri.org/IStationManagment/ChangeStation2Response")]
        bool ChangeStation2(DomainModel.Models.Station station, bool archivalChecked);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStationManagment/ChangeStation2", ReplyAction="http://tempuri.org/IStationManagment/ChangeStation2Response")]
        System.Threading.Tasks.Task<bool> ChangeStation2Async(DomainModel.Models.Station station, bool archivalChecked);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStationManagmentChannel : GUI.StationService.IStationManagment, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StationManagmentClient : System.ServiceModel.ClientBase<GUI.StationService.IStationManagment>, GUI.StationService.IStationManagment {
        
        public StationManagmentClient() {
        }
        
        public StationManagmentClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StationManagmentClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StationManagmentClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StationManagmentClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Add(string newStationText) {
            return base.Channel.Add(newStationText);
        }
        
        public System.Threading.Tasks.Task<bool> AddAsync(string newStationText) {
            return base.Channel.AddAsync(newStationText);
        }
        
        public System.Collections.Generic.List<DomainModel.Models.Station> AllStations() {
            return base.Channel.AllStations();
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<DomainModel.Models.Station>> AllStationsAsync() {
            return base.Channel.AllStationsAsync();
        }
        
        public bool ChangeStation(DomainModel.Models.Station station, string text) {
            return base.Channel.ChangeStation(station, text);
        }
        
        public System.Threading.Tasks.Task<bool> ChangeStationAsync(DomainModel.Models.Station station, string text) {
            return base.Channel.ChangeStationAsync(station, text);
        }
        
        public bool ChangeStation2(DomainModel.Models.Station station, bool archivalChecked) {
            return base.Channel.ChangeStation2(station, archivalChecked);
        }
        
        public System.Threading.Tasks.Task<bool> ChangeStation2Async(DomainModel.Models.Station station, bool archivalChecked) {
            return base.Channel.ChangeStation2Async(station, archivalChecked);
        }
    }
}
