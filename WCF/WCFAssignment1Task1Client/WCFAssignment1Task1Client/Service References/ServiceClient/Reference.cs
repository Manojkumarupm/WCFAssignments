﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.36415
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WCFAssignment1Task1Client.ServiceClient {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceClient.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SayHello", ReplyAction="http://tempuri.org/IService1/SayHelloResponse")]
        string SayHello(string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SayHello", ReplyAction="http://tempuri.org/IService1/SayHelloResponse")]
        System.Threading.Tasks.Task<string> SayHelloAsync(string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TodayProgram", ReplyAction="http://tempuri.org/IService1/TodayProgramResponse")]
        string TodayProgram(string Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/TodayProgram", ReplyAction="http://tempuri.org/IService1/TodayProgramResponse")]
        System.Threading.Tasks.Task<string> TodayProgramAsync(string Name);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : WCFAssignment1Task1Client.ServiceClient.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<WCFAssignment1Task1Client.ServiceClient.IService1>, WCFAssignment1Task1Client.ServiceClient.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string SayHello(string Name) {
            return base.Channel.SayHello(Name);
        }
        
        public System.Threading.Tasks.Task<string> SayHelloAsync(string Name) {
            return base.Channel.SayHelloAsync(Name);
        }
        
        public string TodayProgram(string Name) {
            return base.Channel.TodayProgram(Name);
        }
        
        public System.Threading.Tasks.Task<string> TodayProgramAsync(string Name) {
            return base.Channel.TodayProgramAsync(Name);
        }
    }
}