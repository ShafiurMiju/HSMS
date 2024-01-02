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
    public class ADepartmentController : ApiController
    {
        [HttpGet]
        [Route("api/department")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = ADepartmentService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/department/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = ADepartmentService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/department/create")]
        public HttpResponseMessage Post(DepartmentDTO d)
        {
            try
            {
                var data = ADepartmentService.Post(d);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/department/update")]
        public HttpResponseMessage Update(DepartmentDTO d)
        {
            try
            {
                var data = ADepartmentService.Update(d);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/department/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = ADepartmentService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/department/{id}/teacher")]
        public HttpResponseMessage GetDepartmentTeacher(int id)
        {
            try
            {
                var data = ADepartmentService.GetDepartmentTeacher(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
