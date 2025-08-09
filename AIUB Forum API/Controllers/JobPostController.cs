﻿using BLL.Entities;
using BLL.Services;
using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AIUB_Forum_API.Controllers
{
    public class JobPostController : ApiController
    {
        [HttpGet]
        [Route("api/JobPost")]
        public HttpResponseMessage Get()
        {
            var cp = JobPostService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, cp);
        }


        [HttpGet]
        [Route("api/JobPost/{id}")]
        public HttpResponseMessage Get(int id)
        {
            var cp = JobPostService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, cp);
        }


        [Route("api/Job/GetByTitle/{Title}")]
        [HttpGet]
        public HttpResponseMessage GetByTitle(string Title)
        {
            var cp = JobPostService.GetByTitle(Title);
            return Request.CreateResponse(HttpStatusCode.OK, cp);

        }


        [Route("api/Job/GetByCreateDate/{date}")]
        [HttpGet]
        public HttpResponseMessage GetByCreateDate(DateTime date)
        {
            var cp = JobPostService.GetByCreateDate(date);
            return Request.CreateResponse(HttpStatusCode.OK, cp);

        }


        [Route("api/JobPost/create")]
        [HttpPost]
        public HttpResponseMessage Create(JobPostModel job)
        {
            JobPostService.Add(job);
            return Request.CreateResponse(HttpStatusCode.OK, "Created");
        }

        [Route("api/JobPost/edit")]
        [HttpPost]
        public HttpResponseMessage Edit(JobPostModel job)
        {
            JobPostService.Edit(job);
            return Request.CreateResponse(HttpStatusCode.OK, "Edited");
        }

        [Route("api/JobPost/delete/{id}")]
        [HttpGet]
        public HttpResponseMessage Delete(int id)
        {
            JobPostService.Delete(id);
            return Request.CreateResponse(HttpStatusCode.OK, "Deleted");
        }
    }
}