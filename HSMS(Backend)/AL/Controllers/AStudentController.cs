using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web;
using System.Web.Http;

namespace AL.Controllers
{
    public class AStudentController : ApiController
    {
        [HttpGet]
        [Route("api/student")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = AStudentService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/student/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = AStudentService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/student/create")]
        public HttpResponseMessage Post( StudentDTO s)
        {

            try
            {
                var data = AStudentService.Post(s);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.NotFound, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/student/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = AStudentService.Delete(id);
                Debugger.Break();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                Debugger.Break();
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/student/update")]
        public HttpResponseMessage Update(StudentDTO d)
        {
            try
            {
                var data = AStudentService.Update(d);
                Debugger.Break();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
