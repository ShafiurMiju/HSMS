using BLL.DTOs;
using BLL.Services;
using BLL.Services.ServiceAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AL.Controllers.ControllerAdmin
{
    public class ATeacherController : ApiController
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
        [Route("api/teacher/create")]
        public HttpResponseMessage Post(TeacherDTO s)
        {

            try
            {
                var data = ATeacherService.Post(s);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message);
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

        [HttpPut]
        [Route("api/teacher/update")]
        public HttpResponseMessage Update(TeacherDTO d)
        {
            try
            {
                var data = ATeacherService.Update(d);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
