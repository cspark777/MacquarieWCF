using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MacquarieWCF
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Common10" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Common10.svc or Common10.svc.cs at the Solution Explorer and start debugging.
    public class Common10 : ICommon10
    {

        public getAuthenticationExpiryResponse getAuthenticationExpiry(getAuthenticationExpiryRequest request)
        {

            var tmp = new getAuthenticationExpiryResponse();
            tmp.AuthenticationExpiry = new AuthenticationExpiry();
            tmp.AuthenticationExpiry.ExpiryDate = DateTime.Now.AddYears(1);
            return tmp;
        }
    }
}
