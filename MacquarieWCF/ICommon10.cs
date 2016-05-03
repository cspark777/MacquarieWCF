using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Xml.Serialization;
using System.Diagnostics;
using System.ServiceModel.Channels;
namespace MacquarieWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "ICommon10" in both code and config file together.
    
    [ServiceContract(Namespace = "http://www.macquarie.com/esi/common/v1", ConfigurationName = "Common10", Name = "Common10")]
    public interface ICommon10
    {

        // CODEGEN: Generating message contract since the operation getAuthenticationExpiry is neither RPC nor document wrapped.
        [OperationContract(Action = "http://www.macquarie.com/esi/common/1.0/getAuthenticationExpiryRequest", ReplyAction = "http://www.macquarie.com/esi/common/1.0/getAuthenticationExpiryResponse")]
        [FaultContract(typeof(www.macquarie.com.esi.common._1._01.ESIFault), Action = "", Name = "ESIFault", Namespace = "http://www.macquarie.com/esi/common/1.0")]
        [XmlSerializerFormat()]
        getAuthenticationExpiryResponse getAuthenticationExpiry(getAuthenticationExpiryRequest request);

        //[System.ServiceModel.OperationContractAttribute(Action = "http://www.macquarie.com/esi/common/1.0/getAuthenticationExpiryRequest", ReplyAction = "http://www.macquarie.com/esi/common/1.0/getAuthenticationExpiryResponse")]
        //System.Threading.Tasks.Task<getAuthenticationExpiryResponse> getAuthenticationExpiryAsync(getAuthenticationExpiryRequest request);
    }

    /// <remarks/>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.macquarie.com/esi/common/1.0")]
    public partial class AuthenticationExpiryRequest
    {
    }

    /// <remarks/>
    [Serializable()]
    [DebuggerStepThrough()]
    [DesignerCategory("code")]
    [XmlType(AnonymousType = true, Namespace = "http://www.macquarie.com/esi/common/1.0")]
    public partial class AuthenticationExpiry
    {
        private System.DateTime expiryDateField;
        /// <remarks/>
        [XmlElement(Order = 0)]
        public System.DateTime ExpiryDate
        {
            get
            {
                return this.expiryDateField;
            }
            set
            {
                this.expiryDateField = value;
            }
        }
    }

    [DebuggerStepThrough()]
    [EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public partial class getAuthenticationExpiryRequest
    {

        [MessageBodyMember(Namespace = "http://www.macquarie.com/esi/common/1.0", Order = 0)]
        public AuthenticationExpiryRequest AuthenticationExpiryRequest;

        public getAuthenticationExpiryRequest()
        {
        }

        public getAuthenticationExpiryRequest(AuthenticationExpiryRequest AuthenticationExpiryRequest)
        {
            this.AuthenticationExpiryRequest = AuthenticationExpiryRequest;
        }
    }

    [DebuggerStepThrough()]
    [EditorBrowsable(EditorBrowsableState.Advanced)]
    [MessageContract(IsWrapped = false)]
    public partial class getAuthenticationExpiryResponse
    {

        [MessageBodyMember(Namespace = "http://www.macquarie.com/esi/common/1.0", Order = 0)]
        public AuthenticationExpiry AuthenticationExpiry;

        public getAuthenticationExpiryResponse()
        {
        }

        public getAuthenticationExpiryResponse(AuthenticationExpiry AuthenticationExpiry)
        {
            this.AuthenticationExpiry = AuthenticationExpiry;
        }
    }

    public interface Common10Channel : ICommon10, System.ServiceModel.IClientChannel
    {
    }

    [DebuggerStepThrough()]
    public partial class Common10Client : System.ServiceModel.ClientBase<ICommon10>, ICommon10
    {

        public Common10Client()
        {
        }

        public Common10Client(string endpointConfigurationName) :
            base(endpointConfigurationName)
        {
        }

        public Common10Client(string endpointConfigurationName, string remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public Common10Client(string endpointConfigurationName, EndpointAddress remoteAddress) :
            base(endpointConfigurationName, remoteAddress)
        {
        }

        public Common10Client(Binding binding, EndpointAddress remoteAddress) :
            base(binding, remoteAddress)
        {
        }

        [EditorBrowsable(System.ComponentModel.EditorBrowsableState.Advanced)]
        getAuthenticationExpiryResponse ICommon10.getAuthenticationExpiry(getAuthenticationExpiryRequest request)
        {
            return base.Channel.getAuthenticationExpiry(request);
        }

        public AuthenticationExpiry getAuthenticationExpiry(AuthenticationExpiryRequest AuthenticationExpiryRequest)
        {
            getAuthenticationExpiryRequest inValue = new getAuthenticationExpiryRequest();
            inValue.AuthenticationExpiryRequest = AuthenticationExpiryRequest;
            getAuthenticationExpiryResponse retVal = ((ICommon10)(this)).getAuthenticationExpiry(inValue);
            return retVal.AuthenticationExpiry;
        }

        //[System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        //System.Threading.Tasks.Task<getAuthenticationExpiryResponse> ICommon10.getAuthenticationExpiryAsync(getAuthenticationExpiryRequest request)
        //{
        //    return base.Channel.getAuthenticationExpiryAsync(request);
        //}

        //public System.Threading.Tasks.Task<getAuthenticationExpiryResponse> getAuthenticationExpiryAsync(AuthenticationExpiryRequest AuthenticationExpiryRequest)
        //{
        //    getAuthenticationExpiryRequest inValue = new getAuthenticationExpiryRequest();
        //    inValue.AuthenticationExpiryRequest = AuthenticationExpiryRequest;
        //    return ((ICommon10)(this)).getAuthenticationExpiryAsync(inValue);
        //}
    }
    namespace www.macquarie.com.esi.common._1._01
    {
        using System.Runtime.Serialization;
        [DebuggerStepThrough()]
        [DataContract(Name = "ESIFault", Namespace = "http://www.macquarie.com/esi/common/1.0")]
        public partial class ESIFault : object, IExtensibleDataObject
        {

            private ExtensionDataObject extensionDataField;

            private string ErrorNumberField;

            private string ErrorDetailsField;

            private string MoreDetailsField;

            public ExtensionDataObject ExtensionData
            {
                get
                {
                    return this.extensionDataField;
                }
                set
                {
                    this.extensionDataField = value;
                }
            }

            [DataMember(IsRequired = true, EmitDefaultValue = false)]
            public string ErrorNumber
            {
                get
                {
                    return this.ErrorNumberField;
                }
                set
                {
                    this.ErrorNumberField = value;
                }
            }

            [DataMember(IsRequired = true, EmitDefaultValue = false, Order = 1)]
            public string ErrorDetails
            {
                get
                {
                    return this.ErrorDetailsField;
                }
                set
                {
                    this.ErrorDetailsField = value;
                }
            }

            [DataMember(EmitDefaultValue = false, Order = 2)]
            public string MoreDetails
            {
                get
                {
                    return this.MoreDetailsField;
                }
                set
                {
                    this.MoreDetailsField = value;
                }
            }
        }
    }

}
