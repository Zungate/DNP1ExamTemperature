﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TestTemperatureWebService.TemperatureWebService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="TemperatureWebService.TemperatureWebserviceSoap")]
    public interface TemperatureWebserviceSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertToCelsius", ReplyAction="*")]
        double ConvertToCelsius(double temperatureF);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertToCelsius", ReplyAction="*")]
        System.Threading.Tasks.Task<double> ConvertToCelsiusAsync(double temperatureF);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertToFahrenheit", ReplyAction="*")]
        double ConvertToFahrenheit(double temperatureC);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ConvertToFahrenheit", ReplyAction="*")]
        System.Threading.Tasks.Task<double> ConvertToFahrenheitAsync(double temperatureC);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface TemperatureWebserviceSoapChannel : TestTemperatureWebService.TemperatureWebService.TemperatureWebserviceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class TemperatureWebserviceSoapClient : System.ServiceModel.ClientBase<TestTemperatureWebService.TemperatureWebService.TemperatureWebserviceSoap>, TestTemperatureWebService.TemperatureWebService.TemperatureWebserviceSoap {
        
        public TemperatureWebserviceSoapClient() {
        }
        
        public TemperatureWebserviceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public TemperatureWebserviceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TemperatureWebserviceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public TemperatureWebserviceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public double ConvertToCelsius(double temperatureF) {
            return base.Channel.ConvertToCelsius(temperatureF);
        }
        
        public System.Threading.Tasks.Task<double> ConvertToCelsiusAsync(double temperatureF) {
            return base.Channel.ConvertToCelsiusAsync(temperatureF);
        }
        
        public double ConvertToFahrenheit(double temperatureC) {
            return base.Channel.ConvertToFahrenheit(temperatureC);
        }
        
        public System.Threading.Tasks.Task<double> ConvertToFahrenheitAsync(double temperatureC) {
            return base.Channel.ConvertToFahrenheitAsync(temperatureC);
        }
    }
}
