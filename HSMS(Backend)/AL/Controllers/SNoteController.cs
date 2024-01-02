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
    public class SNoteController : ApiController
    {
        [HttpGet]
        [Route("api/student1/note")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = SNoteService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/student1/note/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = SNoteService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}