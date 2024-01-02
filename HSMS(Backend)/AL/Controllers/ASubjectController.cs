using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTOs;
using BLL.Services;

namespace YourNamespace.Controllers
{
    public class ASubjectController : ApiController
    {
        [HttpGet]
        [Route("api/subject")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = ASubjectService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/subject/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = ASubjectService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/subject")]
        public HttpResponseMessage Post(SubjectDTO classSubjectDTO)
        {
            try
            {
                var data = ASubjectService.Post(classSubjectDTO);
                return Request.CreateResponse(HttpStatusCode.Created, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/subject")]
        public HttpResponseMessage Update(SubjectDTO classSubjectDTO)
        {
            try
            {
                var data = ASubjectService.Update(classSubjectDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/subject/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = ASubjectService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
