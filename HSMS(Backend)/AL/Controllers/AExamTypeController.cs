using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTOs;
using BLL.Services;

namespace YourNamespace.Controllers
{
    public class ExamTypeController : ApiController
    {
        [HttpGet]
        [Route("api/examtype")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = AExamTypeService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/examtype/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = AExamTypeService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/examtype")]
        public HttpResponseMessage Post(ExamTypeDTO examTypeDTO)
        {
            try
            {
                var data = AExamTypeService.Post(examTypeDTO);
                return Request.CreateResponse(HttpStatusCode.Created, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/examtype")]
        public HttpResponseMessage Update(ExamTypeDTO examTypeDTO)
        {
            try
            {
                var data = AExamTypeService.Update(examTypeDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/examtype/{id}")]
        public HttpResponseMessage DeleteExamType(int id)
        {
            try
            {
                var data = AExamTypeService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
