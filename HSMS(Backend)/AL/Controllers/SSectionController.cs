using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AL.Controllers.ControllerStudent
{
    public class SSectionController : ApiController
    {
        [HttpGet]
        [Route("api/student1/section")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = ASectionService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/student1/section/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = ASectionService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
        [HttpGet]
        [Route("api/student1/section/{id}/student")]
        public HttpResponseMessage GetSectionStudent(int id)
        {
            try
            {
                var data = ASectionService.GetSectionStudent(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

    }
}