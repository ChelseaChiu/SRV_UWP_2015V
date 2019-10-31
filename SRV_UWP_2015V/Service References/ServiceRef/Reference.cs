﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.VisualStudio.ServiceReference.Platforms, version 14.0.23107.0
// 
namespace SRV_UWP_2015V.ServiceRef {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Student", Namespace="http://schemas.datacontract.org/2004/07/SRV_WcfService")]
    public partial class Student : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string EmailAddressField;
        
        private string GivenNameField;
        
        private string LastNameField;
        
        private SRV_UWP_2015V.ServiceRef.Qualification QualificationField;
        
        private string StudentIDField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string EmailAddress {
            get {
                return this.EmailAddressField;
            }
            set {
                if ((object.ReferenceEquals(this.EmailAddressField, value) != true)) {
                    this.EmailAddressField = value;
                    this.RaisePropertyChanged("EmailAddress");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GivenName {
            get {
                return this.GivenNameField;
            }
            set {
                if ((object.ReferenceEquals(this.GivenNameField, value) != true)) {
                    this.GivenNameField = value;
                    this.RaisePropertyChanged("GivenName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string LastName {
            get {
                return this.LastNameField;
            }
            set {
                if ((object.ReferenceEquals(this.LastNameField, value) != true)) {
                    this.LastNameField = value;
                    this.RaisePropertyChanged("LastName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public SRV_UWP_2015V.ServiceRef.Qualification Qualification {
            get {
                return this.QualificationField;
            }
            set {
                if ((object.ReferenceEquals(this.QualificationField, value) != true)) {
                    this.QualificationField = value;
                    this.RaisePropertyChanged("Qualification");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StudentID {
            get {
                return this.StudentIDField;
            }
            set {
                if ((object.ReferenceEquals(this.StudentIDField, value) != true)) {
                    this.StudentIDField = value;
                    this.RaisePropertyChanged("StudentID");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Qualification", Namespace="http://schemas.datacontract.org/2004/07/SRV_WcfService")]
    public partial class Qualification : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Collections.Generic.List<SRV_UWP_2015V.ServiceRef.Competency> CompetenciesField;
        
        private int CoreUnitsField;
        
        private int DoneCField;
        
        private int DoneEField;
        
        private int DoneLEField;
        
        private int DoneTotalField;
        
        private int ElectedUnitsField;
        
        private string NationalQualCodeField;
        
        private string QualCodeField;
        
        private string QualNameField;
        
        private int ReqListedElectedUnitsField;
        
        private string TafeQualCodeField;
        
        private int TotalUnitsField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<SRV_UWP_2015V.ServiceRef.Competency> Competencies {
            get {
                return this.CompetenciesField;
            }
            set {
                if ((object.ReferenceEquals(this.CompetenciesField, value) != true)) {
                    this.CompetenciesField = value;
                    this.RaisePropertyChanged("Competencies");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int CoreUnits {
            get {
                return this.CoreUnitsField;
            }
            set {
                if ((this.CoreUnitsField.Equals(value) != true)) {
                    this.CoreUnitsField = value;
                    this.RaisePropertyChanged("CoreUnits");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DoneC {
            get {
                return this.DoneCField;
            }
            set {
                if ((this.DoneCField.Equals(value) != true)) {
                    this.DoneCField = value;
                    this.RaisePropertyChanged("DoneC");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DoneE {
            get {
                return this.DoneEField;
            }
            set {
                if ((this.DoneEField.Equals(value) != true)) {
                    this.DoneEField = value;
                    this.RaisePropertyChanged("DoneE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DoneLE {
            get {
                return this.DoneLEField;
            }
            set {
                if ((this.DoneLEField.Equals(value) != true)) {
                    this.DoneLEField = value;
                    this.RaisePropertyChanged("DoneLE");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int DoneTotal {
            get {
                return this.DoneTotalField;
            }
            set {
                if ((this.DoneTotalField.Equals(value) != true)) {
                    this.DoneTotalField = value;
                    this.RaisePropertyChanged("DoneTotal");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ElectedUnits {
            get {
                return this.ElectedUnitsField;
            }
            set {
                if ((this.ElectedUnitsField.Equals(value) != true)) {
                    this.ElectedUnitsField = value;
                    this.RaisePropertyChanged("ElectedUnits");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NationalQualCode {
            get {
                return this.NationalQualCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.NationalQualCodeField, value) != true)) {
                    this.NationalQualCodeField = value;
                    this.RaisePropertyChanged("NationalQualCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string QualCode {
            get {
                return this.QualCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.QualCodeField, value) != true)) {
                    this.QualCodeField = value;
                    this.RaisePropertyChanged("QualCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string QualName {
            get {
                return this.QualNameField;
            }
            set {
                if ((object.ReferenceEquals(this.QualNameField, value) != true)) {
                    this.QualNameField = value;
                    this.RaisePropertyChanged("QualName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ReqListedElectedUnits {
            get {
                return this.ReqListedElectedUnitsField;
            }
            set {
                if ((this.ReqListedElectedUnitsField.Equals(value) != true)) {
                    this.ReqListedElectedUnitsField = value;
                    this.RaisePropertyChanged("ReqListedElectedUnits");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TafeQualCode {
            get {
                return this.TafeQualCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.TafeQualCodeField, value) != true)) {
                    this.TafeQualCodeField = value;
                    this.RaisePropertyChanged("TafeQualCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int TotalUnits {
            get {
                return this.TotalUnitsField;
            }
            set {
                if ((this.TotalUnitsField.Equals(value) != true)) {
                    this.TotalUnitsField = value;
                    this.RaisePropertyChanged("TotalUnits");
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
    [System.Runtime.Serialization.DataContractAttribute(Name="Competency", Namespace="http://schemas.datacontract.org/2004/07/SRV_WcfService")]
    public partial class Competency : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Collections.Generic.List<SRV_UWP_2015V.ServiceRef.Competency> CompetenciesField;
        
        private string CompetencyNameField;
        
        private string NationalCodeField;
        
        private string ResultsField;
        
        private string StudyPlanField;
        
        private string SubjectCodeField;
        
        private string SubjectNameField;
        
        private string TafeCodeField;
        
        private string TrainingPakckageUsageField;
        
        private System.Collections.Generic.List<SRV_UWP_2015V.ServiceRef.Competency> competencies1Field;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public System.Collections.Generic.List<SRV_UWP_2015V.ServiceRef.Competency> Competencies {
            get {
                return this.CompetenciesField;
            }
            set {
                if ((object.ReferenceEquals(this.CompetenciesField, value) != true)) {
                    this.CompetenciesField = value;
                    this.RaisePropertyChanged("Competencies");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string CompetencyName {
            get {
                return this.CompetencyNameField;
            }
            set {
                if ((object.ReferenceEquals(this.CompetencyNameField, value) != true)) {
                    this.CompetencyNameField = value;
                    this.RaisePropertyChanged("CompetencyName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string NationalCode {
            get {
                return this.NationalCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.NationalCodeField, value) != true)) {
                    this.NationalCodeField = value;
                    this.RaisePropertyChanged("NationalCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Results {
            get {
                return this.ResultsField;
            }
            set {
                if ((object.ReferenceEquals(this.ResultsField, value) != true)) {
                    this.ResultsField = value;
                    this.RaisePropertyChanged("Results");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string StudyPlan {
            get {
                return this.StudyPlanField;
            }
            set {
                if ((object.ReferenceEquals(this.StudyPlanField, value) != true)) {
                    this.StudyPlanField = value;
                    this.RaisePropertyChanged("StudyPlan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SubjectCode {
            get {
                return this.SubjectCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.SubjectCodeField, value) != true)) {
                    this.SubjectCodeField = value;
                    this.RaisePropertyChanged("SubjectCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string SubjectName {
            get {
                return this.SubjectNameField;
            }
            set {
                if ((object.ReferenceEquals(this.SubjectNameField, value) != true)) {
                    this.SubjectNameField = value;
                    this.RaisePropertyChanged("SubjectName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TafeCode {
            get {
                return this.TafeCodeField;
            }
            set {
                if ((object.ReferenceEquals(this.TafeCodeField, value) != true)) {
                    this.TafeCodeField = value;
                    this.RaisePropertyChanged("TafeCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string TrainingPakckageUsage {
            get {
                return this.TrainingPakckageUsageField;
            }
            set {
                if ((object.ReferenceEquals(this.TrainingPakckageUsageField, value) != true)) {
                    this.TrainingPakckageUsageField = value;
                    this.RaisePropertyChanged("TrainingPakckageUsage");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(Name="competencies")]
        public System.Collections.Generic.List<SRV_UWP_2015V.ServiceRef.Competency> competencies1 {
            get {
                return this.competencies1Field;
            }
            set {
                if ((object.ReferenceEquals(this.competencies1Field, value) != true)) {
                    this.competencies1Field = value;
                    this.RaisePropertyChanged("competencies1");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceRef.IStudentService")]
    public interface IStudentService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/GetStudentById", ReplyAction="http://tempuri.org/IStudentService/GetStudentByIdResponse")]
        System.Threading.Tasks.Task<SRV_UWP_2015V.ServiceRef.Student> GetStudentByIdAsync(string studentId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/Login", ReplyAction="http://tempuri.org/IStudentService/LoginResponse")]
        System.Threading.Tasks.Task<bool> LoginAsync(string inUserId);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/CalQualProgress", ReplyAction="http://tempuri.org/IStudentService/CalQualProgressResponse")]
        System.Threading.Tasks.Task<double> CalQualProgressAsync(string studentID, string qualCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/GetQualificationList", ReplyAction="http://tempuri.org/IStudentService/GetQualificationListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<SRV_UWP_2015V.ServiceRef.Qualification>> GetQualificationListAsync(string studentID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/GetCompetencyList", ReplyAction="http://tempuri.org/IStudentService/GetCompetencyListResponse")]
        System.Threading.Tasks.Task<System.Collections.Generic.List<SRV_UWP_2015V.ServiceRef.Competency>> GetCompetencyListAsync(string studentID, string qualificationID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IStudentService/GetQualification", ReplyAction="http://tempuri.org/IStudentService/GetQualificationResponse")]
        System.Threading.Tasks.Task<SRV_UWP_2015V.ServiceRef.Qualification> GetQualificationAsync(string qualCode);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IStudentServiceChannel : SRV_UWP_2015V.ServiceRef.IStudentService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class StudentServiceClient : System.ServiceModel.ClientBase<SRV_UWP_2015V.ServiceRef.IStudentService>, SRV_UWP_2015V.ServiceRef.IStudentService {
        
        /// <summary>
        /// Implement this partial method to configure the service endpoint.
        /// </summary>
        /// <param name="serviceEndpoint">The endpoint to configure</param>
        /// <param name="clientCredentials">The client credentials</param>
        static partial void ConfigureEndpoint(System.ServiceModel.Description.ServiceEndpoint serviceEndpoint, System.ServiceModel.Description.ClientCredentials clientCredentials);
        
        public StudentServiceClient(EndpointConfiguration endpointConfiguration) : 
                base(StudentServiceClient.GetBindingForEndpoint(endpointConfiguration), StudentServiceClient.GetEndpointAddress(endpointConfiguration)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StudentServiceClient(EndpointConfiguration endpointConfiguration, string remoteAddress) : 
                base(StudentServiceClient.GetBindingForEndpoint(endpointConfiguration), new System.ServiceModel.EndpointAddress(remoteAddress)) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StudentServiceClient(EndpointConfiguration endpointConfiguration, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(StudentServiceClient.GetBindingForEndpoint(endpointConfiguration), remoteAddress) {
            this.Endpoint.Name = endpointConfiguration.ToString();
            ConfigureEndpoint(this.Endpoint, this.ClientCredentials);
        }
        
        public StudentServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Threading.Tasks.Task<SRV_UWP_2015V.ServiceRef.Student> GetStudentByIdAsync(string studentId) {
            return base.Channel.GetStudentByIdAsync(studentId);
        }
        
        public System.Threading.Tasks.Task<bool> LoginAsync(string inUserId) {
            return base.Channel.LoginAsync(inUserId);
        }
        
        public System.Threading.Tasks.Task<double> CalQualProgressAsync(string studentID, string qualCode) {
            return base.Channel.CalQualProgressAsync(studentID, qualCode);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<SRV_UWP_2015V.ServiceRef.Qualification>> GetQualificationListAsync(string studentID) {
            return base.Channel.GetQualificationListAsync(studentID);
        }
        
        public System.Threading.Tasks.Task<System.Collections.Generic.List<SRV_UWP_2015V.ServiceRef.Competency>> GetCompetencyListAsync(string studentID, string qualificationID) {
            return base.Channel.GetCompetencyListAsync(studentID, qualificationID);
        }
        
        public System.Threading.Tasks.Task<SRV_UWP_2015V.ServiceRef.Qualification> GetQualificationAsync(string qualCode) {
            return base.Channel.GetQualificationAsync(qualCode);
        }
        
        public virtual System.Threading.Tasks.Task OpenAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndOpen));
        }
        
        public virtual System.Threading.Tasks.Task CloseAsync() {
            return System.Threading.Tasks.Task.Factory.FromAsync(((System.ServiceModel.ICommunicationObject)(this)).BeginClose(null, null), new System.Action<System.IAsyncResult>(((System.ServiceModel.ICommunicationObject)(this)).EndClose));
        }
        
        private static System.ServiceModel.Channels.Binding GetBindingForEndpoint(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IStudentService)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                return result;
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpsBinding_IStudentService)) {
                System.ServiceModel.BasicHttpBinding result = new System.ServiceModel.BasicHttpBinding();
                result.MaxBufferSize = int.MaxValue;
                result.ReaderQuotas = System.Xml.XmlDictionaryReaderQuotas.Max;
                result.MaxReceivedMessageSize = int.MaxValue;
                result.AllowCookies = true;
                result.Security.Mode = System.ServiceModel.BasicHttpSecurityMode.Transport;
                return result;
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        private static System.ServiceModel.EndpointAddress GetEndpointAddress(EndpointConfiguration endpointConfiguration) {
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpBinding_IStudentService)) {
                return new System.ServiceModel.EndpointAddress("http://srvwcfservice.azurewebsites.net/services/StudentService.svc");
            }
            if ((endpointConfiguration == EndpointConfiguration.BasicHttpsBinding_IStudentService)) {
                return new System.ServiceModel.EndpointAddress("https://srvwcfservice.azurewebsites.net/services/StudentService.svc");
            }
            throw new System.InvalidOperationException(string.Format("Could not find endpoint with name \'{0}\'.", endpointConfiguration));
        }
        
        public enum EndpointConfiguration {
            
            BasicHttpBinding_IStudentService,
            
            BasicHttpsBinding_IStudentService,
        }
    }
}