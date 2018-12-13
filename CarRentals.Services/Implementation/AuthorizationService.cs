using System.Configuration;
using System.Net;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace CarRentals.Services.Implementation
{
    public class AuthorizationService : ServiceAuthorizationManager
    {
   
        protected override bool CheckAccessCore(OperationContext operationContext)
        {
           
            var authorizationHeader = WebOperationContext.Current.IncomingRequest.Headers["Authorization"];
            
            if ((!string.IsNullOrEmpty(authorizationHeader)))
            {

                if ((authorizationHeader == ConfigurationManager.AppSettings["ApiKeyLocalHost"]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
               throw new WebFaultException(HttpStatusCode.Unauthorized);
            }
        }
    }
}