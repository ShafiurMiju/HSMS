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
    public class SectionController : ApiController
    {
        [HttpGet]
        [Route("api/section")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = SectionService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/section/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = SectionService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/section/create")]
        public HttpResponseMessage Post(SectionDTO d)
        {
            try
            {
                var data = SectionService.Post(d);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/section/update")]
        public HttpResponseMessage Update(SectionDTO d)
        {
            try
            {
                var data = SectionService.Update(d);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/section/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = SectionService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/section/{id}/student")]
        public HttpResponseMessage GetSectionStudent(int id)
        {
            try
            {
                var data = SectionService.GetSectionStudent(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
