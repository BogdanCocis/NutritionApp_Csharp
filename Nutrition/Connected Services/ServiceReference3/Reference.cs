﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nutrition.ServiceReference3 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference3.NutritionServiceSoap")]
    public interface NutritionServiceSoap {
        
        // CODEGEN: Generating message contract since element name email from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        Nutrition.ServiceReference3.LoginResponse Login(Nutrition.ServiceReference3.LoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        System.Threading.Tasks.Task<Nutrition.ServiceReference3.LoginResponse> LoginAsync(Nutrition.ServiceReference3.LoginRequest request);
        
        // CODEGEN: Generating message contract since element name email from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetGender", ReplyAction="*")]
        Nutrition.ServiceReference3.GetGenderResponse GetGender(Nutrition.ServiceReference3.GetGenderRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetGender", ReplyAction="*")]
        System.Threading.Tasks.Task<Nutrition.ServiceReference3.GetGenderResponse> GetGenderAsync(Nutrition.ServiceReference3.GetGenderRequest request);
        
        // CODEGEN: Generating message contract since element name gender from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalculateIdealWeight", ReplyAction="*")]
        Nutrition.ServiceReference3.CalculateIdealWeightResponse CalculateIdealWeight(Nutrition.ServiceReference3.CalculateIdealWeightRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalculateIdealWeight", ReplyAction="*")]
        System.Threading.Tasks.Task<Nutrition.ServiceReference3.CalculateIdealWeightResponse> CalculateIdealWeightAsync(Nutrition.ServiceReference3.CalculateIdealWeightRequest request);
        
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
        public Nutrition.ServiceReference3.LoginRequestBody Body;
        
        public LoginRequest() {
        }
        
        public LoginRequest(Nutrition.ServiceReference3.LoginRequestBody Body) {
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
        public Nutrition.ServiceReference3.LoginResponseBody Body;
        
        public LoginResponse() {
        }
        
        public LoginResponse(Nutrition.ServiceReference3.LoginResponseBody Body) {
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
        public Nutrition.ServiceReference3.GetGenderRequestBody Body;
        
        public GetGenderRequest() {
        }
        
        public GetGenderRequest(Nutrition.ServiceReference3.GetGenderRequestBody Body) {
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
        public Nutrition.ServiceReference3.GetGenderResponseBody Body;
        
        public GetGenderResponse() {
        }
        
        public GetGenderResponse(Nutrition.ServiceReference3.GetGenderResponseBody Body) {
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
        public Nutrition.ServiceReference3.CalculateIdealWeightRequestBody Body;
        
        public CalculateIdealWeightRequest() {
        }
        
        public CalculateIdealWeightRequest(Nutrition.ServiceReference3.CalculateIdealWeightRequestBody Body) {
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
        public Nutrition.ServiceReference3.CalculateIdealWeightResponseBody Body;
        
        public CalculateIdealWeightResponse() {
        }
        
        public CalculateIdealWeightResponse(Nutrition.ServiceReference3.CalculateIdealWeightResponseBody Body) {
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
    public interface NutritionServiceSoapChannel : Nutrition.ServiceReference3.NutritionServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NutritionServiceSoapClient : System.ServiceModel.ClientBase<Nutrition.ServiceReference3.NutritionServiceSoap>, Nutrition.ServiceReference3.NutritionServiceSoap {
        
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
        Nutrition.ServiceReference3.LoginResponse Nutrition.ServiceReference3.NutritionServiceSoap.Login(Nutrition.ServiceReference3.LoginRequest request) {
            return base.Channel.Login(request);
        }
        
        public string Login(string email, string password) {
            Nutrition.ServiceReference3.LoginRequest inValue = new Nutrition.ServiceReference3.LoginRequest();
            inValue.Body = new Nutrition.ServiceReference3.LoginRequestBody();
            inValue.Body.email = email;
            inValue.Body.password = password;
            Nutrition.ServiceReference3.LoginResponse retVal = ((Nutrition.ServiceReference3.NutritionServiceSoap)(this)).Login(inValue);
            return retVal.Body.LoginResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Nutrition.ServiceReference3.LoginResponse> Nutrition.ServiceReference3.NutritionServiceSoap.LoginAsync(Nutrition.ServiceReference3.LoginRequest request) {
            return base.Channel.LoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<Nutrition.ServiceReference3.LoginResponse> LoginAsync(string email, string password) {
            Nutrition.ServiceReference3.LoginRequest inValue = new Nutrition.ServiceReference3.LoginRequest();
            inValue.Body = new Nutrition.ServiceReference3.LoginRequestBody();
            inValue.Body.email = email;
            inValue.Body.password = password;
            return ((Nutrition.ServiceReference3.NutritionServiceSoap)(this)).LoginAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Nutrition.ServiceReference3.GetGenderResponse Nutrition.ServiceReference3.NutritionServiceSoap.GetGender(Nutrition.ServiceReference3.GetGenderRequest request) {
            return base.Channel.GetGender(request);
        }
        
        public string GetGender(string email) {
            Nutrition.ServiceReference3.GetGenderRequest inValue = new Nutrition.ServiceReference3.GetGenderRequest();
            inValue.Body = new Nutrition.ServiceReference3.GetGenderRequestBody();
            inValue.Body.email = email;
            Nutrition.ServiceReference3.GetGenderResponse retVal = ((Nutrition.ServiceReference3.NutritionServiceSoap)(this)).GetGender(inValue);
            return retVal.Body.GetGenderResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Nutrition.ServiceReference3.GetGenderResponse> Nutrition.ServiceReference3.NutritionServiceSoap.GetGenderAsync(Nutrition.ServiceReference3.GetGenderRequest request) {
            return base.Channel.GetGenderAsync(request);
        }
        
        public System.Threading.Tasks.Task<Nutrition.ServiceReference3.GetGenderResponse> GetGenderAsync(string email) {
            Nutrition.ServiceReference3.GetGenderRequest inValue = new Nutrition.ServiceReference3.GetGenderRequest();
            inValue.Body = new Nutrition.ServiceReference3.GetGenderRequestBody();
            inValue.Body.email = email;
            return ((Nutrition.ServiceReference3.NutritionServiceSoap)(this)).GetGenderAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Nutrition.ServiceReference3.CalculateIdealWeightResponse Nutrition.ServiceReference3.NutritionServiceSoap.CalculateIdealWeight(Nutrition.ServiceReference3.CalculateIdealWeightRequest request) {
            return base.Channel.CalculateIdealWeight(request);
        }
        
        public double CalculateIdealWeight(string gender, double height, int age) {
            Nutrition.ServiceReference3.CalculateIdealWeightRequest inValue = new Nutrition.ServiceReference3.CalculateIdealWeightRequest();
            inValue.Body = new Nutrition.ServiceReference3.CalculateIdealWeightRequestBody();
            inValue.Body.gender = gender;
            inValue.Body.height = height;
            inValue.Body.age = age;
            Nutrition.ServiceReference3.CalculateIdealWeightResponse retVal = ((Nutrition.ServiceReference3.NutritionServiceSoap)(this)).CalculateIdealWeight(inValue);
            return retVal.Body.CalculateIdealWeightResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Nutrition.ServiceReference3.CalculateIdealWeightResponse> Nutrition.ServiceReference3.NutritionServiceSoap.CalculateIdealWeightAsync(Nutrition.ServiceReference3.CalculateIdealWeightRequest request) {
            return base.Channel.CalculateIdealWeightAsync(request);
        }
        
        public System.Threading.Tasks.Task<Nutrition.ServiceReference3.CalculateIdealWeightResponse> CalculateIdealWeightAsync(string gender, double height, int age) {
            Nutrition.ServiceReference3.CalculateIdealWeightRequest inValue = new Nutrition.ServiceReference3.CalculateIdealWeightRequest();
            inValue.Body = new Nutrition.ServiceReference3.CalculateIdealWeightRequestBody();
            inValue.Body.gender = gender;
            inValue.Body.height = height;
            inValue.Body.age = age;
            return ((Nutrition.ServiceReference3.NutritionServiceSoap)(this)).CalculateIdealWeightAsync(inValue);
        }
        
        public double CalculateBMI(double weight, double heightInCm) {
            return base.Channel.CalculateBMI(weight, heightInCm);
        }
        
        public System.Threading.Tasks.Task<double> CalculateBMIAsync(double weight, double heightInCm) {
            return base.Channel.CalculateBMIAsync(weight, heightInCm);
        }
    }
}