using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTOs;
using BLL.Services;

namespace AL.Controllers
{
    public class ResultController : ApiController
    {
        [HttpGet]
        [Route("api/result")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = ResultService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/result/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = ResultService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/result")]
        public HttpResponseMessage Post(ResultDTO result)
        {
            try
            {
                var data = ResultService.Post(result);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/result")]
        public HttpResponseMessage Update(ResultDTO result)
        {
            try
            {
                var data = ResultService.Update(result);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/result/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = ResultService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/result/student/{studentId}")]
        public HttpResponseMessage GetResultsByStudent(int studentId)
        {
            try
            {
                var data = ResultService.GetResultsByStudent(studentId);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/result/student/average/{studentId}")]
        public HttpResponseMessage CalculateAverageMarks(int studentId)
        {
            try
            {
                var averageMarks = ResultService.CalculateAverageMarks(studentId);
                return Request.CreateResponse(HttpStatusCode.OK, averageMarks);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
