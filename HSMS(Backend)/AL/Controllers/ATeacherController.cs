using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTOs;
using BLL.Services;
using BLL.Services.ServiceAdmin;

namespace YourNamespace.Controllers
{
    public class TeacherController : ApiController
    {
        [HttpGet]
        [Route("api/teacher")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = ATeacherService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/teacher/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = ATeacherService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/teacher")]
        public HttpResponseMessage Post(TeacherDTO teacherDTO)
        {
            try
            {
                var data = ATeacherService.Post(teacherDTO);
                return Request.CreateResponse(HttpStatusCode.Created, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/teacher")]
        public HttpResponseMessage Update(TeacherDTO teacherDTO)
        {
            try
            {
                var data = ATeacherService.Update(teacherDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/teacher/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = ATeacherService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
