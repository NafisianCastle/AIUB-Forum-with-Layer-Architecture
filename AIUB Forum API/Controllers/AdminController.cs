using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.Entities;
using BLL.Services;

namespace AIUB_Forum_API.Controllers
{
    public class AdminController : ApiController
    {
        [Route("api/Admin")]
        [HttpGet]
        public HttpResponseMessage GetAdmin()
        {
            return Request.CreateResponse(HttpStatusCode.OK, AdminService.GetAllAdmin());
        }

        [Route("api/Admin/{id}")]
        [HttpGet]
        public HttpResponseMessage GetAdmin(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, AdminService.GetAdmin(id));
        }

        [Route("api/Admin/create")]
        [HttpPost]
        public HttpResponseMessage Create(AdminModel badge)
        {
            AdminService.AddAdmin(badge);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("api/Admin/edit")]
        [HttpPost]
        public HttpResponseMessage Edit(AdminModel admin)
        {
            AdminService.EditAdmin(admin);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("api/Admin/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            AdminService.DeleteAdmin(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}