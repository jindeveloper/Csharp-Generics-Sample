using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Generics.Model;
using Generics.ServiceLayer;

namespace Generics.WebApi.Controllers
{
    public class GenericsController : ApiController
    {
        public IEnumerable<Customer> Get()
        {
            CustomerService service = new CustomerService();

            var result = service.GetCustomers();

            if (!result.Success)
            {
                throw new HttpResponseException(Request.CreateErrorResponse(HttpStatusCode.InternalServerError, 
                            result.ErrorMessage));
            }

            return result.Result;

        }
    }
}
