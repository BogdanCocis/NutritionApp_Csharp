﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ClientNutrition.ServiceReference3 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference3.NutritionServiceSoap")]
    public interface NutritionServiceSoap {
        
        // CODEGEN: Generating message contract since element name email from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        ClientNutrition.ServiceReference3.LoginResponse Login(ClientNutrition.ServiceReference3.LoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        System.Threading.Tasks.Task<ClientNutrition.ServiceReference3.LoginResponse> LoginAsync(ClientNutrition.ServiceReference3.LoginRequest request);
        
        // CODEGEN: Generating message contract since element name email from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetGender", ReplyAction="*")]
        ClientNutrition.ServiceReference3.GetGenderResponse GetGender(ClientNutrition.ServiceReference3.GetGenderRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetGender", ReplyAction="*")]
        System.Threading.Tasks.Task<ClientNutrition.ServiceReference3.GetGenderResponse> GetGenderAsync(ClientNutrition.ServiceReference3.GetGenderRequest request);
        
        // CODEGEN: Generating message contract since element name gender from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalculateIdealWeight", ReplyAction="*")]
        ClientNutrition.ServiceReference3.CalculateIdealWeightResponse CalculateIdealWeight(ClientNutrition.ServiceReference3.CalculateIdealWeightRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalculateIdealWeight", ReplyAction="*")]
        System.Threading.Tasks.Task<ClientNutrition.ServiceReference3.CalculateIdealWeightResponse> CalculateIdealWeightAsync(ClientNutrition.ServiceReference3.CalculateIdealWeightRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalculateBMI", ReplyAction="*")]
        double CalculateBMI(double weight, double heightInCm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalculateBMI", ReplyAction="*")]
        System.Threading.Tasks.Task<double> CalculateBMIAsync(double weight, double heightInCm);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Login", Namespace="http://tempuri.org/", Order=0)]
        public ClientNutrition.ServiceReference3.LoginRequestBody Body;
        
        public LoginRequest() {
        }
        
        public LoginRequest(ClientNutrition.ServiceReference3.LoginRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LoginRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string email;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        public LoginRequestBody() {
        }
        
        public LoginRequestBody(string email, string password) {
            this.email = email;
            this.password = password;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="LoginResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClientNutrition.ServiceReference3.LoginResponseBody Body;
        
        public LoginResponse() {
        }
        
        public LoginResponse(ClientNutrition.ServiceReference3.LoginResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class LoginResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string LoginResult;
        
        public LoginResponseBody() {
        }
        
        public LoginResponseBody(string LoginResult) {
            this.LoginResult = LoginResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetGenderRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetGender", Namespace="http://tempuri.org/", Order=0)]
        public ClientNutrition.ServiceReference3.GetGenderRequestBody Body;
        
        public GetGenderRequest() {
        }
        
        public GetGenderRequest(ClientNutrition.ServiceReference3.GetGenderRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetGenderRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string email;
        
        public GetGenderRequestBody() {
        }
        
        public GetGenderRequestBody(string email) {
            this.email = email;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetGenderResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetGenderResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClientNutrition.ServiceReference3.GetGenderResponseBody Body;
        
        public GetGenderResponse() {
        }
        
        public GetGenderResponse(ClientNutrition.ServiceReference3.GetGenderResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetGenderResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetGenderResult;
        
        public GetGenderResponseBody() {
        }
        
        public GetGenderResponseBody(string GetGenderResult) {
            this.GetGenderResult = GetGenderResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalculateIdealWeightRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalculateIdealWeight", Namespace="http://tempuri.org/", Order=0)]
        public ClientNutrition.ServiceReference3.CalculateIdealWeightRequestBody Body;
        
        public CalculateIdealWeightRequest() {
        }
        
        public CalculateIdealWeightRequest(ClientNutrition.ServiceReference3.CalculateIdealWeightRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CalculateIdealWeightRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string gender;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=1)]
        public double height;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int age;
        
        public CalculateIdealWeightRequestBody() {
        }
        
        public CalculateIdealWeightRequestBody(string gender, double height, int age) {
            this.gender = gender;
            this.height = height;
            this.age = age;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class CalculateIdealWeightResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="CalculateIdealWeightResponse", Namespace="http://tempuri.org/", Order=0)]
        public ClientNutrition.ServiceReference3.CalculateIdealWeightResponseBody Body;
        
        public CalculateIdealWeightResponse() {
        }
        
        public CalculateIdealWeightResponse(ClientNutrition.ServiceReference3.CalculateIdealWeightResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class CalculateIdealWeightResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public double CalculateIdealWeightResult;
        
        public CalculateIdealWeightResponseBody() {
        }
        
        public CalculateIdealWeightResponseBody(double CalculateIdealWeightResult) {
            this.CalculateIdealWeightResult = CalculateIdealWeightResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface NutritionServiceSoapChannel : ClientNutrition.ServiceReference3.NutritionServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NutritionServiceSoapClient : System.ServiceModel.ClientBase<ClientNutrition.ServiceReference3.NutritionServiceSoap>, ClientNutrition.ServiceReference3.NutritionServiceSoap {
        
        public NutritionServiceSoapClient() {
        }
        
        public NutritionServiceSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public NutritionServiceSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NutritionServiceSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public NutritionServiceSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientNutrition.ServiceReference3.LoginResponse ClientNutrition.ServiceReference3.NutritionServiceSoap.Login(ClientNutrition.ServiceReference3.LoginRequest request) {
            return base.Channel.Login(request);
        }
        
        public string Login(string email, string password) {
            ClientNutrition.ServiceReference3.LoginRequest inValue = new ClientNutrition.ServiceReference3.LoginRequest();
            inValue.Body = new ClientNutrition.ServiceReference3.LoginRequestBody();
            inValue.Body.email = email;
            inValue.Body.password = password;
            ClientNutrition.ServiceReference3.LoginResponse retVal = ((ClientNutrition.ServiceReference3.NutritionServiceSoap)(this)).Login(inValue);
            return retVal.Body.LoginResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientNutrition.ServiceReference3.LoginResponse> ClientNutrition.ServiceReference3.NutritionServiceSoap.LoginAsync(ClientNutrition.ServiceReference3.LoginRequest request) {
            return base.Channel.LoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientNutrition.ServiceReference3.LoginResponse> LoginAsync(string email, string password) {
            ClientNutrition.ServiceReference3.LoginRequest inValue = new ClientNutrition.ServiceReference3.LoginRequest();
            inValue.Body = new ClientNutrition.ServiceReference3.LoginRequestBody();
            inValue.Body.email = email;
            inValue.Body.password = password;
            return ((ClientNutrition.ServiceReference3.NutritionServiceSoap)(this)).LoginAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientNutrition.ServiceReference3.GetGenderResponse ClientNutrition.ServiceReference3.NutritionServiceSoap.GetGender(ClientNutrition.ServiceReference3.GetGenderRequest request) {
            return base.Channel.GetGender(request);
        }
        
        public string GetGender(string email) {
            ClientNutrition.ServiceReference3.GetGenderRequest inValue = new ClientNutrition.ServiceReference3.GetGenderRequest();
            inValue.Body = new ClientNutrition.ServiceReference3.GetGenderRequestBody();
            inValue.Body.email = email;
            ClientNutrition.ServiceReference3.GetGenderResponse retVal = ((ClientNutrition.ServiceReference3.NutritionServiceSoap)(this)).GetGender(inValue);
            return retVal.Body.GetGenderResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientNutrition.ServiceReference3.GetGenderResponse> ClientNutrition.ServiceReference3.NutritionServiceSoap.GetGenderAsync(ClientNutrition.ServiceReference3.GetGenderRequest request) {
            return base.Channel.GetGenderAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientNutrition.ServiceReference3.GetGenderResponse> GetGenderAsync(string email) {
            ClientNutrition.ServiceReference3.GetGenderRequest inValue = new ClientNutrition.ServiceReference3.GetGenderRequest();
            inValue.Body = new ClientNutrition.ServiceReference3.GetGenderRequestBody();
            inValue.Body.email = email;
            return ((ClientNutrition.ServiceReference3.NutritionServiceSoap)(this)).GetGenderAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ClientNutrition.ServiceReference3.CalculateIdealWeightResponse ClientNutrition.ServiceReference3.NutritionServiceSoap.CalculateIdealWeight(ClientNutrition.ServiceReference3.CalculateIdealWeightRequest request) {
            return base.Channel.CalculateIdealWeight(request);
        }
        
        public double CalculateIdealWeight(string gender, double height, int age) {
            ClientNutrition.ServiceReference3.CalculateIdealWeightRequest inValue = new ClientNutrition.ServiceReference3.CalculateIdealWeightRequest();
            inValue.Body = new ClientNutrition.ServiceReference3.CalculateIdealWeightRequestBody();
            inValue.Body.gender = gender;
            inValue.Body.height = height;
            inValue.Body.age = age;
            ClientNutrition.ServiceReference3.CalculateIdealWeightResponse retVal = ((ClientNutrition.ServiceReference3.NutritionServiceSoap)(this)).CalculateIdealWeight(inValue);
            return retVal.Body.CalculateIdealWeightResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ClientNutrition.ServiceReference3.CalculateIdealWeightResponse> ClientNutrition.ServiceReference3.NutritionServiceSoap.CalculateIdealWeightAsync(ClientNutrition.ServiceReference3.CalculateIdealWeightRequest request) {
            return base.Channel.CalculateIdealWeightAsync(request);
        }
        
        public System.Threading.Tasks.Task<ClientNutrition.ServiceReference3.CalculateIdealWeightResponse> CalculateIdealWeightAsync(string gender, double height, int age) {
            ClientNutrition.ServiceReference3.CalculateIdealWeightRequest inValue = new ClientNutrition.ServiceReference3.CalculateIdealWeightRequest();
            inValue.Body = new ClientNutrition.ServiceReference3.CalculateIdealWeightRequestBody();
            inValue.Body.gender = gender;
            inValue.Body.height = height;
            inValue.Body.age = age;
            return ((ClientNutrition.ServiceReference3.NutritionServiceSoap)(this)).CalculateIdealWeightAsync(inValue);
        }
        
        public double CalculateBMI(double weight, double heightInCm) {
            return base.Channel.CalculateBMI(weight, heightInCm);
        }
        
        public System.Threading.Tasks.Task<double> CalculateBMIAsync(double weight, double heightInCm) {
            return base.Channel.CalculateBMIAsync(weight, heightInCm);
        }
    }
}
