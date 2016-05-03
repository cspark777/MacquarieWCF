using System;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Web;

namespace MacquarieWCF
{
    [ServiceContract]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class WsdlService
    {
        [Description("Returns the details of a user on the team.")]
        [WebGet(UriTemplate = "/")]
        public Stream GetWsdl()
        {
            string url = string.Format("{0}://{1}", HttpContext.Current.Request.Url.Scheme, HttpContext.Current.Request.Url.Authority);
            string wsdlPath=HttpContext.Current.Server.MapPath("~/App_Data/Common_v1.xml");
            string wsdl=File.ReadAllText(wsdlPath);
            wsdl=string.Format(wsdl, url + "/Common_1.0.xsd", url + "/Common10.svc");

            return new MemoryStream(System.Text.Encoding.UTF8.GetBytes(wsdl));
        }
    }
}