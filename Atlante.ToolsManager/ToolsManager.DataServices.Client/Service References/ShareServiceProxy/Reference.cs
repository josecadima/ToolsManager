﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ToolsManager.DataServices.Client.ShareServiceProxy {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ShareServiceProxy.IShareManagerService")]
    public interface IShareManagerService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShareManagerService/ShareTask", ReplyAction="http://tempuri.org/IShareManagerService/ShareTaskResponse")]
        void ShareTask(string machineSource, string machineTarget, System.Guid viewId, string viewDescription, ToolsManager.DataServices.Common.TaskInfoDTO task);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShareManagerService/UnshareTask", ReplyAction="http://tempuri.org/IShareManagerService/UnshareTaskResponse")]
        void UnshareTask(string machineSource, string machineTarget, System.Guid viewId, ToolsManager.DataServices.Common.TaskInfoDTO task);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IShareManagerService/GetSharedTasks", ReplyAction="http://tempuri.org/IShareManagerService/GetSharedTasksResponse")]
        ToolsManager.DataServices.Common.SharedTaskDTO[] GetSharedTasks(string machineTarget);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IShareManagerServiceChannel : ToolsManager.DataServices.Client.ShareServiceProxy.IShareManagerService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ShareManagerServiceClient : System.ServiceModel.ClientBase<ToolsManager.DataServices.Client.ShareServiceProxy.IShareManagerService>, ToolsManager.DataServices.Client.ShareServiceProxy.IShareManagerService {
        
        public ShareManagerServiceClient() {
        }
        
        public ShareManagerServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ShareManagerServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShareManagerServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ShareManagerServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void ShareTask(string machineSource, string machineTarget, System.Guid viewId, string viewDescription, ToolsManager.DataServices.Common.TaskInfoDTO task) {
            base.Channel.ShareTask(machineSource, machineTarget, viewId, viewDescription, task);
        }
        
        public void UnshareTask(string machineSource, string machineTarget, System.Guid viewId, ToolsManager.DataServices.Common.TaskInfoDTO task) {
            base.Channel.UnshareTask(machineSource, machineTarget, viewId, task);
        }
        
        public ToolsManager.DataServices.Common.SharedTaskDTO[] GetSharedTasks(string machineTarget) {
            return base.Channel.GetSharedTasks(machineTarget);
        }
    }
}
