using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTOs;
using BLL.Services;

namespace YourNamespace.Controllers
{
    public class GradeController : ApiController
    {
        [HttpGet]
        [Route("api/grade")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = GradeService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/grade/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = GradeService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/grade")]
        public HttpResponseMessage Post(GradeDTO gradeDTO)
        {
            try
            {
                var data = GradeService.Post(gradeDTO);
                return Request.CreateResponse(HttpStatusCode.Created, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/grade")]
        public HttpResponseMessage Update(GradeDTO gradeDTO)
        {
            try
            {
                var data = GradeService.Update(gradeDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/grade/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = GradeService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
