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
    public class ClassController : ApiController
    {
        [HttpGet]
        [Route("api/class")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = ClassService.Get();
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
                var data = ClassService.Get(id);
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
                var data = ClassService.Post(d);
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
                var data = ClassService.Update(d);
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
                var data = ClassService.Delete(id);
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
                var data = ClassService.GetClassStudent(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
