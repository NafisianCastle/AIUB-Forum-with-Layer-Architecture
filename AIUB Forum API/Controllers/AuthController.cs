using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.Entities;
using BLL.Services;

namespace AIUB_Forum_API.Controllers
{
    public class AuthController : ApiController
    {
        [Route("api/login")]
        [HttpPost]
        public HttpResponseMessage Login(LoginModel login)
        {
            var token = AuthService.Authenticate(login.Email, login.Password);
            return token != null
                ? Request.CreateResponse(HttpStatusCode.OK, new {token.Tkey, token.CreationDate})
                : Request.CreateResponse(HttpStatusCode.NotFound, new {Msg = "User Not found"});
        }
    }
}