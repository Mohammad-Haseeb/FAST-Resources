﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WS_Cal1.MyCalculatorService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MyCalculatorService.MyCalculatorSoap")]
    public interface MyCalculatorSoap {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        int Add(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add", ReplyAction="*")]
        System.Threading.Tasks.Task<int> AddAsync(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add2", ReplyAction="*")]
        int Add2(int num1, int num2, int num3);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Add2", ReplyAction="*")]
        System.Threading.Tasks.Task<int> Add2Async(int num1, int num2, int num3);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Subtract", ReplyAction="*")]
        int Subtract(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Subtract", ReplyAction="*")]
        System.Threading.Tasks.Task<int> SubtractAsync(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Divide", ReplyAction="*")]
        int Divide(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Divide", ReplyAction="*")]
        System.Threading.Tasks.Task<int> DivideAsync(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Exponent", ReplyAction="*")]
        int Exponent(int num1, int num2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Exponent", ReplyAction="*")]
        System.Threading.Tasks.Task<int> ExponentAsync(int num1, int num2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface MyCalculatorSoapChannel : WS_Cal1.MyCalculatorService.MyCalculatorSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MyCalculatorSoapClient : System.ServiceModel.ClientBase<WS_Cal1.MyCalculatorService.MyCalculatorSoap>, WS_Cal1.MyCalculatorService.MyCalculatorSoap {
        
        public MyCalculatorSoapClient() {
        }
        
        public MyCalculatorSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MyCalculatorSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyCalculatorSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MyCalculatorSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int Add(int num1, int num2) {
            return base.Channel.Add(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> AddAsync(int num1, int num2) {
            return base.Channel.AddAsync(num1, num2);
        }
        
        public int Add2(int num1, int num2, int num3) {
            return base.Channel.Add2(num1, num2, num3);
        }
        
        public System.Threading.Tasks.Task<int> Add2Async(int num1, int num2, int num3) {
            return base.Channel.Add2Async(num1, num2, num3);
        }
        
        public int Subtract(int num1, int num2) {
            return base.Channel.Subtract(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> SubtractAsync(int num1, int num2) {
            return base.Channel.SubtractAsync(num1, num2);
        }
        
        public int Divide(int num1, int num2) {
            return base.Channel.Divide(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> DivideAsync(int num1, int num2) {
            return base.Channel.DivideAsync(num1, num2);
        }
        
        public int Exponent(int num1, int num2) {
            return base.Channel.Exponent(num1, num2);
        }
        
        public System.Threading.Tasks.Task<int> ExponentAsync(int num1, int num2) {
            return base.Channel.ExponentAsync(num1, num2);
        }
    }
}
