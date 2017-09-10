﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientMvc5.StudentServices {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="StudentServices.IStudent")]
    public interface IStudent {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/AddStudent", ReplyAction="http://tempuri.org/IStudent/AddStudentResponse")]
        void AddStudent(string fullName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/AddStudent", ReplyAction="http://tempuri.org/IStudent/AddStudentResponse")]
        System.Threading.Tasks.Task AddStudentAsync(string fullName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/EditStudent", ReplyAction="http://tempuri.org/IStudent/EditStudentResponse")]
        void EditStudent(string fullName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/EditStudent", ReplyAction="http://tempuri.org/IStudent/EditStudentResponse")]
        System.Threading.Tasks.Task EditStudentAsync(string fullName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/DeleteStudent", ReplyAction="http://tempuri.org/IStudent/DeleteStudentResponse")]
        void DeleteStudent(string fullName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/DeleteStudent", ReplyAction="http://tempuri.org/IStudent/DeleteStudentResponse")]
        System.Threading.Tasks.Task DeleteStudentAsync(string fullName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/GetStudents", ReplyAction="http://tempuri.org/IStudent/GetStudentsResponse")]
        string[] GetStudents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudent/GetStudents", ReplyAction="http://tempuri.org/IStudent/GetStudentsResponse")]
        System.Threading.Tasks.Task<string[]> GetStudentsAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStudentChannel : ClientMvc5.StudentServices.IStudent, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StudentClient : System.ServiceModel.ClientBase<ClientMvc5.StudentServices.IStudent>, ClientMvc5.StudentServices.IStudent {
        
        public StudentClient() {
        }
        
        public StudentClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public StudentClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public StudentClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void AddStudent(string fullName) {
            base.Channel.AddStudent(fullName);
        }
        
        public System.Threading.Tasks.Task AddStudentAsync(string fullName) {
            return base.Channel.AddStudentAsync(fullName);
        }
        
        public void EditStudent(string fullName) {
            base.Channel.EditStudent(fullName);
        }
        
        public System.Threading.Tasks.Task EditStudentAsync(string fullName) {
            return base.Channel.EditStudentAsync(fullName);
        }
        
        public void DeleteStudent(string fullName) {
            base.Channel.DeleteStudent(fullName);
        }
        
        public System.Threading.Tasks.Task DeleteStudentAsync(string fullName) {
            return base.Channel.DeleteStudentAsync(fullName);
        }
        
        public string[] GetStudents() {
            return base.Channel.GetStudents();
        }
        
        public System.Threading.Tasks.Task<string[]> GetStudentsAsync() {
            return base.Channel.GetStudentsAsync();
        }
    }
}