using BLL.Entities;
using BLL.Services;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AIUB_Forum_API.Controllers
{
    public class AuthController : ApiController
    {
        [Route("api/login")]
        [HttpPost]
        public HttpResponseMessage Authenticate(LoginModel user)
        {
            var data = AuthService.Authenticate(user.Uname, user.Pass);
            return data != null
                ? Request.CreateResponse(HttpStatusCode.OK, data)
                : Request.CreateResponse(HttpStatusCode.OK, new {msg = "Invalid User"});
        }
    }
}