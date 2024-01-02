using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AL.Controllers.ControllerStudent
{
    public class SClassController : ApiController
    {
        [HttpGet]
        [Route("api/student1/class")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = AClassService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }


        [HttpGet]
        [Route("api/student1/class/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = AClassService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/student1/class/{id}/student")]
        public HttpResponseMessage GetClassStudent(int id)
        {
            try
            {
                var data = AClassService.GetClassStudent(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}