﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Nutrition.ServiceNutrition {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceNutrition.NutritionServiceSoap")]
    public interface NutritionServiceSoap {
        
        // CODEGEN: Generating message contract since element name email from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        Nutrition.ServiceNutrition.LoginResponse Login(Nutrition.ServiceNutrition.LoginRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/Login", ReplyAction="*")]
        System.Threading.Tasks.Task<Nutrition.ServiceNutrition.LoginResponse> LoginAsync(Nutrition.ServiceNutrition.LoginRequest request);
        
        // CODEGEN: Generating message contract since element name email from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetGender", ReplyAction="*")]
        Nutrition.ServiceNutrition.GetGenderResponse GetGender(Nutrition.ServiceNutrition.GetGenderRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetGender", ReplyAction="*")]
        System.Threading.Tasks.Task<Nutrition.ServiceNutrition.GetGenderResponse> GetGenderAsync(Nutrition.ServiceNutrition.GetGenderRequest request);
        
        // CODEGEN: Generating message contract since element name gender from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalculateIdealWeight", ReplyAction="*")]
        Nutrition.ServiceNutrition.CalculateIdealWeightResponse CalculateIdealWeight(Nutrition.ServiceNutrition.CalculateIdealWeightRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalculateIdealWeight", ReplyAction="*")]
        System.Threading.Tasks.Task<Nutrition.ServiceNutrition.CalculateIdealWeightResponse> CalculateIdealWeightAsync(Nutrition.ServiceNutrition.CalculateIdealWeightRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalculateBMI", ReplyAction="*")]
        double CalculateBMI(double weight, double heightInCm);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/CalculateBMI", ReplyAction="*")]
        System.Threading.Tasks.Task<double> CalculateBMIAsync(double weight, double heightInCm);
        
        // CODEGEN: Generating message contract since element name GetAllFoodsResult from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllFoods", ReplyAction="*")]
        Nutrition.ServiceNutrition.GetAllFoodsResponse GetAllFoods(Nutrition.ServiceNutrition.GetAllFoodsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/GetAllFoods", ReplyAction="*")]
        System.Threading.Tasks.Task<Nutrition.ServiceNutrition.GetAllFoodsResponse> GetAllFoodsAsync(Nutrition.ServiceNutrition.GetAllFoodsRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class LoginRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Login", Namespace="http://tempuri.org/", Order=0)]
        public Nutrition.ServiceNutrition.LoginRequestBody Body;
        
        public LoginRequest() {
        }
        
        public LoginRequest(Nutrition.ServiceNutrition.LoginRequestBody Body) {
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
        public Nutrition.ServiceNutrition.LoginResponseBody Body;
        
        public LoginResponse() {
        }
        
        public LoginResponse(Nutrition.ServiceNutrition.LoginResponseBody Body) {
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
        public Nutrition.ServiceNutrition.GetGenderRequestBody Body;
        
        public GetGenderRequest() {
        }
        
        public GetGenderRequest(Nutrition.ServiceNutrition.GetGenderRequestBody Body) {
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
        public Nutrition.ServiceNutrition.GetGenderResponseBody Body;
        
        public GetGenderResponse() {
        }
        
        public GetGenderResponse(Nutrition.ServiceNutrition.GetGenderResponseBody Body) {
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
        public Nutrition.ServiceNutrition.CalculateIdealWeightRequestBody Body;
        
        public CalculateIdealWeightRequest() {
        }
        
        public CalculateIdealWeightRequest(Nutrition.ServiceNutrition.CalculateIdealWeightRequestBody Body) {
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
        public Nutrition.ServiceNutrition.CalculateIdealWeightResponseBody Body;
        
        public CalculateIdealWeightResponse() {
        }
        
        public CalculateIdealWeightResponse(Nutrition.ServiceNutrition.CalculateIdealWeightResponseBody Body) {
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
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllFoodsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllFoods", Namespace="http://tempuri.org/", Order=0)]
        public Nutrition.ServiceNutrition.GetAllFoodsRequestBody Body;
        
        public GetAllFoodsRequest() {
        }
        
        public GetAllFoodsRequest(Nutrition.ServiceNutrition.GetAllFoodsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class GetAllFoodsRequestBody {
        
        public GetAllFoodsRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetAllFoodsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetAllFoodsResponse", Namespace="http://tempuri.org/", Order=0)]
        public Nutrition.ServiceNutrition.GetAllFoodsResponseBody Body;
        
        public GetAllFoodsResponse() {
        }
        
        public GetAllFoodsResponse(Nutrition.ServiceNutrition.GetAllFoodsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetAllFoodsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetAllFoodsResult;
        
        public GetAllFoodsResponseBody() {
        }
        
        public GetAllFoodsResponseBody(string GetAllFoodsResult) {
            this.GetAllFoodsResult = GetAllFoodsResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface NutritionServiceSoapChannel : Nutrition.ServiceNutrition.NutritionServiceSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class NutritionServiceSoapClient : System.ServiceModel.ClientBase<Nutrition.ServiceNutrition.NutritionServiceSoap>, Nutrition.ServiceNutrition.NutritionServiceSoap {
        
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
        Nutrition.ServiceNutrition.LoginResponse Nutrition.ServiceNutrition.NutritionServiceSoap.Login(Nutrition.ServiceNutrition.LoginRequest request) {
            return base.Channel.Login(request);
        }
        
        public string Login(string email, string password) {
            Nutrition.ServiceNutrition.LoginRequest inValue = new Nutrition.ServiceNutrition.LoginRequest();
            inValue.Body = new Nutrition.ServiceNutrition.LoginRequestBody();
            inValue.Body.email = email;
            inValue.Body.password = password;
            Nutrition.ServiceNutrition.LoginResponse retVal = ((Nutrition.ServiceNutrition.NutritionServiceSoap)(this)).Login(inValue);
            return retVal.Body.LoginResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Nutrition.ServiceNutrition.LoginResponse> Nutrition.ServiceNutrition.NutritionServiceSoap.LoginAsync(Nutrition.ServiceNutrition.LoginRequest request) {
            return base.Channel.LoginAsync(request);
        }
        
        public System.Threading.Tasks.Task<Nutrition.ServiceNutrition.LoginResponse> LoginAsync(string email, string password) {
            Nutrition.ServiceNutrition.LoginRequest inValue = new Nutrition.ServiceNutrition.LoginRequest();
            inValue.Body = new Nutrition.ServiceNutrition.LoginRequestBody();
            inValue.Body.email = email;
            inValue.Body.password = password;
            return ((Nutrition.ServiceNutrition.NutritionServiceSoap)(this)).LoginAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Nutrition.ServiceNutrition.GetGenderResponse Nutrition.ServiceNutrition.NutritionServiceSoap.GetGender(Nutrition.ServiceNutrition.GetGenderRequest request) {
            return base.Channel.GetGender(request);
        }
        
        public string GetGender(string email) {
            Nutrition.ServiceNutrition.GetGenderRequest inValue = new Nutrition.ServiceNutrition.GetGenderRequest();
            inValue.Body = new Nutrition.ServiceNutrition.GetGenderRequestBody();
            inValue.Body.email = email;
            Nutrition.ServiceNutrition.GetGenderResponse retVal = ((Nutrition.ServiceNutrition.NutritionServiceSoap)(this)).GetGender(inValue);
            return retVal.Body.GetGenderResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Nutrition.ServiceNutrition.GetGenderResponse> Nutrition.ServiceNutrition.NutritionServiceSoap.GetGenderAsync(Nutrition.ServiceNutrition.GetGenderRequest request) {
            return base.Channel.GetGenderAsync(request);
        }
        
        public System.Threading.Tasks.Task<Nutrition.ServiceNutrition.GetGenderResponse> GetGenderAsync(string email) {
            Nutrition.ServiceNutrition.GetGenderRequest inValue = new Nutrition.ServiceNutrition.GetGenderRequest();
            inValue.Body = new Nutrition.ServiceNutrition.GetGenderRequestBody();
            inValue.Body.email = email;
            return ((Nutrition.ServiceNutrition.NutritionServiceSoap)(this)).GetGenderAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Nutrition.ServiceNutrition.CalculateIdealWeightResponse Nutrition.ServiceNutrition.NutritionServiceSoap.CalculateIdealWeight(Nutrition.ServiceNutrition.CalculateIdealWeightRequest request) {
            return base.Channel.CalculateIdealWeight(request);
        }
        
        public double CalculateIdealWeight(string gender, double height, int age) {
            Nutrition.ServiceNutrition.CalculateIdealWeightRequest inValue = new Nutrition.ServiceNutrition.CalculateIdealWeightRequest();
            inValue.Body = new Nutrition.ServiceNutrition.CalculateIdealWeightRequestBody();
            inValue.Body.gender = gender;
            inValue.Body.height = height;
            inValue.Body.age = age;
            Nutrition.ServiceNutrition.CalculateIdealWeightResponse retVal = ((Nutrition.ServiceNutrition.NutritionServiceSoap)(this)).CalculateIdealWeight(inValue);
            return retVal.Body.CalculateIdealWeightResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Nutrition.ServiceNutrition.CalculateIdealWeightResponse> Nutrition.ServiceNutrition.NutritionServiceSoap.CalculateIdealWeightAsync(Nutrition.ServiceNutrition.CalculateIdealWeightRequest request) {
            return base.Channel.CalculateIdealWeightAsync(request);
        }
        
        public System.Threading.Tasks.Task<Nutrition.ServiceNutrition.CalculateIdealWeightResponse> CalculateIdealWeightAsync(string gender, double height, int age) {
            Nutrition.ServiceNutrition.CalculateIdealWeightRequest inValue = new Nutrition.ServiceNutrition.CalculateIdealWeightRequest();
            inValue.Body = new Nutrition.ServiceNutrition.CalculateIdealWeightRequestBody();
            inValue.Body.gender = gender;
            inValue.Body.height = height;
            inValue.Body.age = age;
            return ((Nutrition.ServiceNutrition.NutritionServiceSoap)(this)).CalculateIdealWeightAsync(inValue);
        }
        
        public double CalculateBMI(double weight, double heightInCm) {
            return base.Channel.CalculateBMI(weight, heightInCm);
        }
        
        public System.Threading.Tasks.Task<double> CalculateBMIAsync(double weight, double heightInCm) {
            return base.Channel.CalculateBMIAsync(weight, heightInCm);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Nutrition.ServiceNutrition.GetAllFoodsResponse Nutrition.ServiceNutrition.NutritionServiceSoap.GetAllFoods(Nutrition.ServiceNutrition.GetAllFoodsRequest request) {
            return base.Channel.GetAllFoods(request);
        }
        
        public string GetAllFoods() {
            Nutrition.ServiceNutrition.GetAllFoodsRequest inValue = new Nutrition.ServiceNutrition.GetAllFoodsRequest();
            inValue.Body = new Nutrition.ServiceNutrition.GetAllFoodsRequestBody();
            Nutrition.ServiceNutrition.GetAllFoodsResponse retVal = ((Nutrition.ServiceNutrition.NutritionServiceSoap)(this)).GetAllFoods(inValue);
            return retVal.Body.GetAllFoodsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Nutrition.ServiceNutrition.GetAllFoodsResponse> Nutrition.ServiceNutrition.NutritionServiceSoap.GetAllFoodsAsync(Nutrition.ServiceNutrition.GetAllFoodsRequest request) {
            return base.Channel.GetAllFoodsAsync(request);
        }
        
        public System.Threading.Tasks.Task<Nutrition.ServiceNutrition.GetAllFoodsResponse> GetAllFoodsAsync() {
            Nutrition.ServiceNutrition.GetAllFoodsRequest inValue = new Nutrition.ServiceNutrition.GetAllFoodsRequest();
            inValue.Body = new Nutrition.ServiceNutrition.GetAllFoodsRequestBody();
            return ((Nutrition.ServiceNutrition.NutritionServiceSoap)(this)).GetAllFoodsAsync(inValue);
        }
    }
}
