using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTOs;
using BLL.Services;

namespace YourNamespace.Controllers
{
    public class SchoolInfoController : ApiController
    {
        [HttpGet]
        [Route("api/schoolinfo")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = SchoolInfoService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/schoolinfo/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = SchoolInfoService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/schoolinfo")]
        public HttpResponseMessage Post(SchoolInfoDTO schoolInfoDTO)
        {
            try
            {
                var data = SchoolInfoService.Post(schoolInfoDTO);
                return Request.CreateResponse(HttpStatusCode.Created, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/schoolinfo")]
        public HttpResponseMessage Update(SchoolInfoDTO schoolInfoDTO)
        {
            try
            {
                var data = SchoolInfoService.Update(schoolInfoDTO);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/schoolinfo/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            try
            {
                var data = SchoolInfoService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
