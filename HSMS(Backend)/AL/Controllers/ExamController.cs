using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTOs;
using BLL.Services;

namespace AL.Controllers
{
    public class ExamController : ApiController
    {
        [HttpGet]
        [Route("api/exams")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = ExamService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/exams/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = ExamService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/exams")]
        public HttpResponseMessage Post(ExamDTO exam)
        {
            try
            {
                var data = ExamService.Post(exam);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/exams")]
        public HttpResponseMessage Update(ExamDTO exam)
        {
            try
            {
                var data = ExamService.Update(exam);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/exams/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = ExamService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
