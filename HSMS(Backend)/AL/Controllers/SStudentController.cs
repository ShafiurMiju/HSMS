using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AL.Controllers.Student
{
    public class SStudentController : ApiController
    {

        [HttpGet]
        [Route("api/student1/{id}/profile")]
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


    }
}