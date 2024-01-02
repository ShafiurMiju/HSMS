using BLL.DTOs;
using BLL.Services;
using BLL.Services.ServiceAdmin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AL.Controllers.ControllerStudent
{
    public class STeacherStudentChatsController : ApiController
    {

        [HttpGet]
        [Route("api/TeacherStudentChats")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = STeacherStudentService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [HttpGet]
        [Route("api/TeacherStudentChats/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = STeacherStudentService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/TeacherStudentChats/create")]
        public HttpResponseMessage Post(TeacherStudentDTO d)
        {
            try
            {
                var data = STeacherStudentService.Post(d);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/TeacherStudentChats/update")]
        public HttpResponseMessage Update(TeacherStudentDTO d)
        {
            try
            {
                var data = STeacherStudentService.Update(d);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/TeacherStudentChats/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = STeacherStudentService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}