﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ProcesSMSRegistration.WS_SendSMS {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WS_SendSMS.SendMessageSoap")]
    public interface SendMessageSoap {
        
        // CODEGEN: Generating message contract since element name userName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSms", ReplyAction="*")]
        ProcesSMSRegistration.WS_SendSMS.SendSmsResponse SendSms(ProcesSMSRegistration.WS_SendSMS.SendSmsRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSms", ReplyAction="*")]
        System.Threading.Tasks.Task<ProcesSMSRegistration.WS_SendSMS.SendSmsResponse> SendSmsAsync(ProcesSMSRegistration.WS_SendSMS.SendSmsRequest request);
        
        // CODEGEN: Generating message contract since element name userName from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSmsDetailed", ReplyAction="*")]
        ProcesSMSRegistration.WS_SendSMS.SendSmsDetailedResponse SendSmsDetailed(ProcesSMSRegistration.WS_SendSMS.SendSmsDetailedRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSmsDetailed", ReplyAction="*")]
        System.Threading.Tasks.Task<ProcesSMSRegistration.WS_SendSMS.SendSmsDetailedResponse> SendSmsDetailedAsync(ProcesSMSRegistration.WS_SendSMS.SendSmsDetailedRequest request);
        
        // CODEGEN: Generating message contract since element name xmlData from namespace http://tempuri.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSmsXml", ReplyAction="*")]
        ProcesSMSRegistration.WS_SendSMS.SendSmsXmlResponse SendSmsXml(ProcesSMSRegistration.WS_SendSMS.SendSmsXmlRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/SendSmsXml", ReplyAction="*")]
        System.Threading.Tasks.Task<ProcesSMSRegistration.WS_SendSMS.SendSmsXmlResponse> SendSmsXmlAsync(ProcesSMSRegistration.WS_SendSMS.SendSmsXmlRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSmsRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSms", Namespace="http://tempuri.org/", Order=0)]
        public ProcesSMSRegistration.WS_SendSMS.SendSmsRequestBody Body;
        
        public SendSmsRequest() {
        }
        
        public SendSmsRequest(ProcesSMSRegistration.WS_SendSMS.SendSmsRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SendSmsRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string userName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string message;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string recipients;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string senderName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string senderNumber;
        
        public SendSmsRequestBody() {
        }
        
        public SendSmsRequestBody(string userName, string password, string message, string recipients, string senderName, string senderNumber) {
            this.userName = userName;
            this.password = password;
            this.message = message;
            this.recipients = recipients;
            this.senderName = senderName;
            this.senderNumber = senderNumber;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSmsResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSmsResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProcesSMSRegistration.WS_SendSMS.SendSmsResponseBody Body;
        
        public SendSmsResponse() {
        }
        
        public SendSmsResponse(ProcesSMSRegistration.WS_SendSMS.SendSmsResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SendSmsResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string SendSmsResult;
        
        public SendSmsResponseBody() {
        }
        
        public SendSmsResponseBody(string SendSmsResult) {
            this.SendSmsResult = SendSmsResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSmsDetailedRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSmsDetailed", Namespace="http://tempuri.org/", Order=0)]
        public ProcesSMSRegistration.WS_SendSMS.SendSmsDetailedRequestBody Body;
        
        public SendSmsDetailedRequest() {
        }
        
        public SendSmsDetailedRequest(ProcesSMSRegistration.WS_SendSMS.SendSmsDetailedRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SendSmsDetailedRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string userName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string password;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=2)]
        public string message;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=3)]
        public string messagePelephone;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=4)]
        public string messageCellcom;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=5)]
        public string messageOrange;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=6)]
        public string messageMirs;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=7)]
        public string recipients;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=8)]
        public string customerParameter;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=9)]
        public string customerMessageId;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=10)]
        public int messageInterval;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=11)]
        public System.DateTime timeToSend;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=12)]
        public string senderName;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=13)]
        public string senderNumber;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=14)]
        public int maxSegments;
        
        public SendSmsDetailedRequestBody() {
        }
        
        public SendSmsDetailedRequestBody(string userName, string password, string message, string messagePelephone, string messageCellcom, string messageOrange, string messageMirs, string recipients, string customerParameter, string customerMessageId, int messageInterval, System.DateTime timeToSend, string senderName, string senderNumber, int maxSegments) {
            this.userName = userName;
            this.password = password;
            this.message = message;
            this.messagePelephone = messagePelephone;
            this.messageCellcom = messageCellcom;
            this.messageOrange = messageOrange;
            this.messageMirs = messageMirs;
            this.recipients = recipients;
            this.customerParameter = customerParameter;
            this.customerMessageId = customerMessageId;
            this.messageInterval = messageInterval;
            this.timeToSend = timeToSend;
            this.senderName = senderName;
            this.senderNumber = senderNumber;
            this.maxSegments = maxSegments;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSmsDetailedResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSmsDetailedResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProcesSMSRegistration.WS_SendSMS.SendSmsDetailedResponseBody Body;
        
        public SendSmsDetailedResponse() {
        }
        
        public SendSmsDetailedResponse(ProcesSMSRegistration.WS_SendSMS.SendSmsDetailedResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SendSmsDetailedResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string SendSmsDetailedResult;
        
        public SendSmsDetailedResponseBody() {
        }
        
        public SendSmsDetailedResponseBody(string SendSmsDetailedResult) {
            this.SendSmsDetailedResult = SendSmsDetailedResult;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSmsXmlRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSmsXml", Namespace="http://tempuri.org/", Order=0)]
        public ProcesSMSRegistration.WS_SendSMS.SendSmsXmlRequestBody Body;
        
        public SendSmsXmlRequest() {
        }
        
        public SendSmsXmlRequest(ProcesSMSRegistration.WS_SendSMS.SendSmsXmlRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SendSmsXmlRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string xmlData;
        
        public SendSmsXmlRequestBody() {
        }
        
        public SendSmsXmlRequestBody(string xmlData) {
            this.xmlData = xmlData;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class SendSmsXmlResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="SendSmsXmlResponse", Namespace="http://tempuri.org/", Order=0)]
        public ProcesSMSRegistration.WS_SendSMS.SendSmsXmlResponseBody Body;
        
        public SendSmsXmlResponse() {
        }
        
        public SendSmsXmlResponse(ProcesSMSRegistration.WS_SendSMS.SendSmsXmlResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class SendSmsXmlResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string SendSmsXmlResult;
        
        public SendSmsXmlResponseBody() {
        }
        
        public SendSmsXmlResponseBody(string SendSmsXmlResult) {
            this.SendSmsXmlResult = SendSmsXmlResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface SendMessageSoapChannel : ProcesSMSRegistration.WS_SendSMS.SendMessageSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class SendMessageSoapClient : System.ServiceModel.ClientBase<ProcesSMSRegistration.WS_SendSMS.SendMessageSoap>, ProcesSMSRegistration.WS_SendSMS.SendMessageSoap {
        
        public SendMessageSoapClient() {
        }
        
        public SendMessageSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public SendMessageSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SendMessageSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public SendMessageSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProcesSMSRegistration.WS_SendSMS.SendSmsResponse ProcesSMSRegistration.WS_SendSMS.SendMessageSoap.SendSms(ProcesSMSRegistration.WS_SendSMS.SendSmsRequest request) {
            return base.Channel.SendSms(request);
        }
        
        public string SendSms(string userName, string password, string message, string recipients, string senderName, string senderNumber) {
            ProcesSMSRegistration.WS_SendSMS.SendSmsRequest inValue = new ProcesSMSRegistration.WS_SendSMS.SendSmsRequest();
            inValue.Body = new ProcesSMSRegistration.WS_SendSMS.SendSmsRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.password = password;
            inValue.Body.message = message;
            inValue.Body.recipients = recipients;
            inValue.Body.senderName = senderName;
            inValue.Body.senderNumber = senderNumber;
            ProcesSMSRegistration.WS_SendSMS.SendSmsResponse retVal = ((ProcesSMSRegistration.WS_SendSMS.SendMessageSoap)(this)).SendSms(inValue);
            return retVal.Body.SendSmsResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProcesSMSRegistration.WS_SendSMS.SendSmsResponse> ProcesSMSRegistration.WS_SendSMS.SendMessageSoap.SendSmsAsync(ProcesSMSRegistration.WS_SendSMS.SendSmsRequest request) {
            return base.Channel.SendSmsAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProcesSMSRegistration.WS_SendSMS.SendSmsResponse> SendSmsAsync(string userName, string password, string message, string recipients, string senderName, string senderNumber) {
            ProcesSMSRegistration.WS_SendSMS.SendSmsRequest inValue = new ProcesSMSRegistration.WS_SendSMS.SendSmsRequest();
            inValue.Body = new ProcesSMSRegistration.WS_SendSMS.SendSmsRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.password = password;
            inValue.Body.message = message;
            inValue.Body.recipients = recipients;
            inValue.Body.senderName = senderName;
            inValue.Body.senderNumber = senderNumber;
            return ((ProcesSMSRegistration.WS_SendSMS.SendMessageSoap)(this)).SendSmsAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProcesSMSRegistration.WS_SendSMS.SendSmsDetailedResponse ProcesSMSRegistration.WS_SendSMS.SendMessageSoap.SendSmsDetailed(ProcesSMSRegistration.WS_SendSMS.SendSmsDetailedRequest request) {
            return base.Channel.SendSmsDetailed(request);
        }
        
        public string SendSmsDetailed(string userName, string password, string message, string messagePelephone, string messageCellcom, string messageOrange, string messageMirs, string recipients, string customerParameter, string customerMessageId, int messageInterval, System.DateTime timeToSend, string senderName, string senderNumber, int maxSegments) {
            ProcesSMSRegistration.WS_SendSMS.SendSmsDetailedRequest inValue = new ProcesSMSRegistration.WS_SendSMS.SendSmsDetailedRequest();
            inValue.Body = new ProcesSMSRegistration.WS_SendSMS.SendSmsDetailedRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.password = password;
            inValue.Body.message = message;
            inValue.Body.messagePelephone = messagePelephone;
            inValue.Body.messageCellcom = messageCellcom;
            inValue.Body.messageOrange = messageOrange;
            inValue.Body.messageMirs = messageMirs;
            inValue.Body.recipients = recipients;
            inValue.Body.customerParameter = customerParameter;
            inValue.Body.customerMessageId = customerMessageId;
            inValue.Body.messageInterval = messageInterval;
            inValue.Body.timeToSend = timeToSend;
            inValue.Body.senderName = senderName;
            inValue.Body.senderNumber = senderNumber;
            inValue.Body.maxSegments = maxSegments;
            ProcesSMSRegistration.WS_SendSMS.SendSmsDetailedResponse retVal = ((ProcesSMSRegistration.WS_SendSMS.SendMessageSoap)(this)).SendSmsDetailed(inValue);
            return retVal.Body.SendSmsDetailedResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProcesSMSRegistration.WS_SendSMS.SendSmsDetailedResponse> ProcesSMSRegistration.WS_SendSMS.SendMessageSoap.SendSmsDetailedAsync(ProcesSMSRegistration.WS_SendSMS.SendSmsDetailedRequest request) {
            return base.Channel.SendSmsDetailedAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProcesSMSRegistration.WS_SendSMS.SendSmsDetailedResponse> SendSmsDetailedAsync(string userName, string password, string message, string messagePelephone, string messageCellcom, string messageOrange, string messageMirs, string recipients, string customerParameter, string customerMessageId, int messageInterval, System.DateTime timeToSend, string senderName, string senderNumber, int maxSegments) {
            ProcesSMSRegistration.WS_SendSMS.SendSmsDetailedRequest inValue = new ProcesSMSRegistration.WS_SendSMS.SendSmsDetailedRequest();
            inValue.Body = new ProcesSMSRegistration.WS_SendSMS.SendSmsDetailedRequestBody();
            inValue.Body.userName = userName;
            inValue.Body.password = password;
            inValue.Body.message = message;
            inValue.Body.messagePelephone = messagePelephone;
            inValue.Body.messageCellcom = messageCellcom;
            inValue.Body.messageOrange = messageOrange;
            inValue.Body.messageMirs = messageMirs;
            inValue.Body.recipients = recipients;
            inValue.Body.customerParameter = customerParameter;
            inValue.Body.customerMessageId = customerMessageId;
            inValue.Body.messageInterval = messageInterval;
            inValue.Body.timeToSend = timeToSend;
            inValue.Body.senderName = senderName;
            inValue.Body.senderNumber = senderNumber;
            inValue.Body.maxSegments = maxSegments;
            return ((ProcesSMSRegistration.WS_SendSMS.SendMessageSoap)(this)).SendSmsDetailedAsync(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        ProcesSMSRegistration.WS_SendSMS.SendSmsXmlResponse ProcesSMSRegistration.WS_SendSMS.SendMessageSoap.SendSmsXml(ProcesSMSRegistration.WS_SendSMS.SendSmsXmlRequest request) {
            return base.Channel.SendSmsXml(request);
        }
        
        public string SendSmsXml(string xmlData) {
            ProcesSMSRegistration.WS_SendSMS.SendSmsXmlRequest inValue = new ProcesSMSRegistration.WS_SendSMS.SendSmsXmlRequest();
            inValue.Body = new ProcesSMSRegistration.WS_SendSMS.SendSmsXmlRequestBody();
            inValue.Body.xmlData = xmlData;
            ProcesSMSRegistration.WS_SendSMS.SendSmsXmlResponse retVal = ((ProcesSMSRegistration.WS_SendSMS.SendMessageSoap)(this)).SendSmsXml(inValue);
            return retVal.Body.SendSmsXmlResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<ProcesSMSRegistration.WS_SendSMS.SendSmsXmlResponse> ProcesSMSRegistration.WS_SendSMS.SendMessageSoap.SendSmsXmlAsync(ProcesSMSRegistration.WS_SendSMS.SendSmsXmlRequest request) {
            return base.Channel.SendSmsXmlAsync(request);
        }
        
        public System.Threading.Tasks.Task<ProcesSMSRegistration.WS_SendSMS.SendSmsXmlResponse> SendSmsXmlAsync(string xmlData) {
            ProcesSMSRegistration.WS_SendSMS.SendSmsXmlRequest inValue = new ProcesSMSRegistration.WS_SendSMS.SendSmsXmlRequest();
            inValue.Body = new ProcesSMSRegistration.WS_SendSMS.SendSmsXmlRequestBody();
            inValue.Body.xmlData = xmlData;
            return ((ProcesSMSRegistration.WS_SendSMS.SendMessageSoap)(this)).SendSmsXmlAsync(inValue);
        }
    }
}