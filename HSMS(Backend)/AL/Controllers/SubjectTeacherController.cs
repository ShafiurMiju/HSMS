using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTOs;
using BLL.Services;

namespace YourNamespace.Controllers
{
    public class SubjectTeacherController : ApiController
    {
        [HttpGet]
        [Route("api/subjectteacher")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = SubjectTeacherService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/subjectteacher/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = SubjectTeacherService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/subjectteacher")]
        public HttpResponseMessage Post(SubjectTeacherDTO subjectTeacherDTO)
        {
            try
            {
                var data = SubjectTeacherService.Post(subjectTeacherDTO);
                return Request.CreateResponse(HttpStatusCode.Created, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/subjectteacher")]
        public HttpResponseMessage Update(SubjectTeacherDTO subjectTeacherDTO)
        {
            try
            {
                var data = SubjectTeacherService.Update(subjectTeacherDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/subjectteacher/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = SubjectTeacherService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
