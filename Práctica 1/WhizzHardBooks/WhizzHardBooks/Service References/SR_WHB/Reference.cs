﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.18444
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WhizzHardBooks.SR_WHB {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://localhost/WS_WHB", ConfigurationName="SR_WHB.WS_WHBSoap")]
    public interface WS_WHBSoap {
        
        // CODEGEN: Se está generando un contrato de mensaje, ya que el nombre de elemento HelloWorldResult del espacio de nombres http://localhost/WS_WHB no está marcado para aceptar valores nil.
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WS_WHB/HelloWorld", ReplyAction="*")]
        WhizzHardBooks.SR_WHB.HelloWorldResponse HelloWorld(WhizzHardBooks.SR_WHB.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WS_WHB/HelloWorld", ReplyAction="*")]
        System.Threading.Tasks.Task<WhizzHardBooks.SR_WHB.HelloWorldResponse> HelloWorldAsync(WhizzHardBooks.SR_WHB.HelloWorldRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WS_WHB/prueba", ReplyAction="*")]
        void prueba();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://localhost/WS_WHB/prueba", ReplyAction="*")]
        System.Threading.Tasks.Task pruebaAsync();
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorld", Namespace="http://localhost/WS_WHB", Order=0)]
        public WhizzHardBooks.SR_WHB.HelloWorldRequestBody Body;
        
        public HelloWorldRequest() {
        }
        
        public HelloWorldRequest(WhizzHardBooks.SR_WHB.HelloWorldRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute()]
    public partial class HelloWorldRequestBody {
        
        public HelloWorldRequestBody() {
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class HelloWorldResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="HelloWorldResponse", Namespace="http://localhost/WS_WHB", Order=0)]
        public WhizzHardBooks.SR_WHB.HelloWorldResponseBody Body;
        
        public HelloWorldResponse() {
        }
        
        public HelloWorldResponse(WhizzHardBooks.SR_WHB.HelloWorldResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://localhost/WS_WHB")]
    public partial class HelloWorldResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string HelloWorldResult;
        
        public HelloWorldResponseBody() {
        }
        
        public HelloWorldResponseBody(string HelloWorldResult) {
            this.HelloWorldResult = HelloWorldResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WS_WHBSoapChannel : WhizzHardBooks.SR_WHB.WS_WHBSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WS_WHBSoapClient : System.ServiceModel.ClientBase<WhizzHardBooks.SR_WHB.WS_WHBSoap>, WhizzHardBooks.SR_WHB.WS_WHBSoap {
        
        public WS_WHBSoapClient() {
        }
        
        public WS_WHBSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WS_WHBSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WS_WHBSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WS_WHBSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        WhizzHardBooks.SR_WHB.HelloWorldResponse WhizzHardBooks.SR_WHB.WS_WHBSoap.HelloWorld(WhizzHardBooks.SR_WHB.HelloWorldRequest request) {
            return base.Channel.HelloWorld(request);
        }
        
        public string HelloWorld() {
            WhizzHardBooks.SR_WHB.HelloWorldRequest inValue = new WhizzHardBooks.SR_WHB.HelloWorldRequest();
            inValue.Body = new WhizzHardBooks.SR_WHB.HelloWorldRequestBody();
            WhizzHardBooks.SR_WHB.HelloWorldResponse retVal = ((WhizzHardBooks.SR_WHB.WS_WHBSoap)(this)).HelloWorld(inValue);
            return retVal.Body.HelloWorldResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<WhizzHardBooks.SR_WHB.HelloWorldResponse> WhizzHardBooks.SR_WHB.WS_WHBSoap.HelloWorldAsync(WhizzHardBooks.SR_WHB.HelloWorldRequest request) {
            return base.Channel.HelloWorldAsync(request);
        }
        
        public System.Threading.Tasks.Task<WhizzHardBooks.SR_WHB.HelloWorldResponse> HelloWorldAsync() {
            WhizzHardBooks.SR_WHB.HelloWorldRequest inValue = new WhizzHardBooks.SR_WHB.HelloWorldRequest();
            inValue.Body = new WhizzHardBooks.SR_WHB.HelloWorldRequestBody();
            return ((WhizzHardBooks.SR_WHB.WS_WHBSoap)(this)).HelloWorldAsync(inValue);
        }
        
        public void prueba() {
            base.Channel.prueba();
        }
        
        public System.Threading.Tasks.Task pruebaAsync() {
            return base.Channel.pruebaAsync();
        }
    }
}
