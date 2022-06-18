using BLL.Entities;
using BLL.Services;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AIUB_Forum_API.Controllers
{
    public class ModeratorController : ApiController
    {
        [Route("api/Moderator")]
        [HttpGet]
        public HttpResponseMessage GetModerator()
        {
            return Request.CreateResponse(HttpStatusCode.OK, ModeratorService.GetAllModerator());
        }

        [Route("api/Moderator/{id}")]
        [HttpGet]
        public HttpResponseMessage GetModerator(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, ModeratorService.GetModerator(id));
        }

        [Route("api/Moderator/create")]
        [HttpPost]
        public HttpResponseMessage Create(ModeratorModel modarator)
        {
            ModeratorService.AddModerator(modarator);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("api/Moderator/edit")]
        [HttpPost]
        public HttpResponseMessage Edit(ModeratorModel modarator)
        {
            ModeratorService.EditModerator(modarator);
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [Route("api/Moderator/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            ModeratorService.DeleteModerator(id);
            return Request.CreateResponse(HttpStatusCode.OK);
        }
    }
}