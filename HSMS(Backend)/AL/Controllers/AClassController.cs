using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AL.Controllers
{
    public class AClassController : ApiController
    {
        [HttpGet]
        [Route("api/class")]
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
        [Route("api/class/{id}")]
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

        [HttpPost]
        [Route("api/class/create")]
        public HttpResponseMessage Post(ClassDTO d)
        {
            try
            {
                var data = AClassService.Post(d);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/class/update")]
        public HttpResponseMessage Update(ClassDTO d)
        {
            try
            {
                var data = AClassService.Update(d);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/class/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = AClassService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/class/{id}/student")]
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
