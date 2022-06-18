using BLL.Entities;
using BLL.Services;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AIUB_Forum_API.Controllers
{
    public class PostController : ApiController
    {
        [HttpGet]
        [Route("api/Post/get/{id}")]
        public HttpResponseMessage Get(int id)
        {
            //return PostServices.Get(id);
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, PostServices.Get(id));
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Not found");
            }
        }

        [HttpGet]
        [Route("api/Post/getall/")]
        public HttpResponseMessage GetAll()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, PostServices.Get());
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Not found");
            }
        }

        [HttpPost]
        [Route("api/Post/add")]
        public HttpResponseMessage Add(PostModel p)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, PostServices.Add(p) ? "added" : "not added");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server error");
            }
        }

        [HttpPost]
        [Route("api/Post/edit")]
        public HttpResponseMessage Edit(PostModel p)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, PostServices.Edit(p) ? "Edited" : "not Edited");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server error");
            }
        }

        [HttpPost]
        [Route("api/Post/delete/{id}")]
        public HttpResponseMessage Del(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, PostServices.Delete(id) ? "Deleted" : "not Deleted");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server Error");
            }
        }


        [HttpGet]
        [Route("api/Post/answer/get/{id}")]
        public HttpResponseMessage Getans(int id)
        {
            //return PostServices.Get(id);
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, AnswerServices.Get(id));
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Not found");
            }
        }

        [HttpGet]
        [Route("api/Post/answer/getall/")]
        public HttpResponseMessage GetAllans()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, AnswerServices.Get());
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Not found");
            }
        }

        [HttpPost]
        [Route("api/Post/answer/add")]
        public HttpResponseMessage Addans(AnswerModel p)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, AnswerServices.Add(p) ? "added" : "not added");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server error");
            }
        }

        [HttpPost]
        [Route("api/Post/answer/edit")]
        public HttpResponseMessage Editans(AnswerModel p)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, AnswerServices.Edit(p) ? "Edited" : "not Edited");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server error");
            }
        }

        [HttpPost]
        [Route("api/Post/answer/delete/{id}")]
        public HttpResponseMessage Delans(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, AnswerServices.Delete(id) ? "Deleted" : "not Deleted");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server Error");
            }
        }


        [HttpGet]
        [Route("api/Post/comment/get/{id}")]
        public HttpResponseMessage Getcmt(int id)
        {
            //return PostServices.Get(id);
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, CommentServices.Get(id));
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Not found");
            }
        }

        [HttpGet]
        [Route("api/Post/comment/getall/")]
        public HttpResponseMessage GetAllcmt()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, CommentServices.Get());
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Not found");
            }
        }

        [HttpPost]
        [Route("api/Post/comment/add")]
        public HttpResponseMessage Addcmt(CommentModel p)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, CommentServices.Add(p) ? "added" : "not added");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server error");
            }
        }

        [HttpPost]
        [Route("api/Post/comment/edit")]
        public HttpResponseMessage Editcmt(CommentModel p)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, CommentServices.Edit(p) ? "Edited" : "not Edited");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server error");
            }
        }

        [HttpPost]
        [Route("api/Post/comment/delete/{id}")]
        public HttpResponseMessage Delcmt(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK,
                    CommentServices.Delete(id) ? "Deleted" : "not Deleted");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server Error");
            }
        }


        [HttpGet]
        [Route("api/Post/answercomment/get/{id}")]
        public HttpResponseMessage Getanscmt(int id)
        {
            //return PostServices.Get(id);
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, AnswerCommentServices.Get(id));
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Not found");
            }
        }

        [HttpGet]
        [Route("api/Post/answercomment/getall/")]
        public HttpResponseMessage GetAllanscmt()
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, AnswerCommentServices.Get());
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.NotFound, "Not found");
            }
        }

        [HttpPost]
        [Route("api/Post/answercomment/add")]
        public HttpResponseMessage Addanscmt(AnswerCommentModel p)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, AnswerCommentServices.Add(p) ? "added" : "not added");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server error");
            }
        }

        [HttpPost]
        [Route("api/Post/answercomment/edit")]
        public HttpResponseMessage Editanscmt(AnswerCommentModel p)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK, AnswerCommentServices.Edit(p) ? "Edited" : "not Edited");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server error");
            }
        }

        [HttpPost]
        [Route("api/Post/answercomment/delete/{id}")]
        public HttpResponseMessage Delanscmt(int id)
        {
            try
            {
                return Request.CreateResponse(HttpStatusCode.OK,
                    AnswerCommentServices.Delete(id) ? "Deleted" : "not Deleted");
            }
            catch
            {
                return Request.CreateResponse(HttpStatusCode.OK, "Server Error");
            }
        }
    }
}