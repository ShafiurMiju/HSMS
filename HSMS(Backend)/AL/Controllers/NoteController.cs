using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL.DTOs;
using BLL.Services;

namespace AL.Controllers
{
    public class NoteController : ApiController
    {
        [HttpGet]
        [Route("api/note")]
        public HttpResponseMessage Get()
        {
            try
            {
                var data = NoteService.Get();
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        [Route("api/note/{id}")]
        public HttpResponseMessage Get(int id)
        {
            try
            {
                var data = NoteService.Get(id);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        [Route("api/note")]
        public HttpResponseMessage Post()
        {
            try
            {
                var noteDTO = new NoteDTO();
                var fileStream = Request.Content.ReadAsStreamAsync().Result;
                var fileName = Request.Content.Headers.ContentDisposition.FileName;

                var data = NoteService.Post(noteDTO, fileStream, fileName);
                return Request.CreateResponse(HttpStatusCode.Created, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpPut]
        [Route("api/note")]
        public HttpResponseMessage Update()
        {
            try
            {
                var noteDTO = new NoteDTO();
                var fileStream = Request.Content.ReadAsStreamAsync().Result;
                var fileName = Request.Content.Headers.ContentDisposition.FileName;

                var data = NoteService.Update(noteDTO, fileStream, fileName);
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }

        [HttpDelete]
        [Route("api/note/{id}")]
        public HttpResponseMessage DeleteNote(int id)
        {
            try
            {
                var data = NoteService.Delete(id);
                return Request.CreateResponse(HttpStatusCode.NoContent);
            }
            catch (Exception ex)
            {
                return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, ex.Message);
            }
        }
    }
}
