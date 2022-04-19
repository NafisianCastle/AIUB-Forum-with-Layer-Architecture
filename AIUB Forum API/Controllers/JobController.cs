using BLL.Entities;
using BLL.Services;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AIUB_Forum_API.Controllers
{
    public class JobController : ApiController
    {
        [HttpGet]
        [Route("api/Job")]
        public HttpResponseMessage Get()
        {
            var cp = JobService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, cp);
        }

        [HttpGet]
        [Route("api/Job/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var cp = JobService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, cp);
        }

        [Route("api/Job/GetByCompanyId/{id}")]
        [HttpGet]
        public HttpResponseMessage GetByCompanyId(int id)
        {
            var cp = JobService.GetByCompanyId(id);
            return Request.CreateResponse(HttpStatusCode.OK, cp);

        }
        [Route("api/Job/GetByPostion/{Postion}")]
        [HttpGet]
        public HttpResponseMessage GetByPositionName(string Postion)
        {
            var cp = JobService.GetByPositionName(Postion);
            return Request.CreateResponse(HttpStatusCode.OK, cp);

        }


        [Route("api/Job/create")]
        [HttpPost]
        public HttpResponseMessage Create(JobModel job)
        {
            JobService.Add(job);
            return Request.CreateResponse(HttpStatusCode.OK, "Created");
        }

        [Route("api/Job/edit")]
        [HttpPost]
        public HttpResponseMessage Edit(JobModel job)
        {
            JobService.Edit(job);
            return Request.CreateResponse(HttpStatusCode.OK, "Edited");
        }

        [Route("api/Job/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            JobService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        }
    }
}
