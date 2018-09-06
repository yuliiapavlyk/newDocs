using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using MyDocuments.BLL.Interfaces;
using MyDocuments.BLL.DTO;

namespace MyDocuments.PL.Controllers
{
    public class DocumentController : ApiController
    {
        private readonly IDocumentService documentService;
        public DocumentController(IDocumentService serv)
        {
            this.documentService = serv;
        }

        /// <summary>
        /// Return all documents in our system
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [Route("api/allDocuments")]
        public HttpResponseMessage Get()
        {
            var documents = documentService.GetAllDocuments();

            if (documents.Count()!= 0)
            {
                return Request.CreateResponse<IEnumerable<DocumentDTO>>(HttpStatusCode.OK, documents);
            }
            const string message = "No documents in database.";
            return Request.CreateErrorResponse(HttpStatusCode.NoContent, message);
        }



        /// <summary>
        /// Return specific document by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpGet]
        [Route("api/document/{id}")]

        public HttpResponseMessage Get(int id)
        {
            var document = documentService.GetDocumentById(id);
            if (document != null)
            {
                return Request.CreateResponse(HttpStatusCode.OK, document);
            }

            return Request.CreateErrorResponse(HttpStatusCode.NotFound, $"There isn't document with id = {id}");
        }


        /// <summary>
        /// Create new document
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        [HttpPost]
        [Route("api/newDocument")]
       public HttpResponseMessage Post([FromBody]string value)
        {
            var documents = documentService.GetAllDocuments();


            return Request.CreateResponse<IEnumerable<DocumentDTO>>(HttpStatusCode.OK, documents);
        }

        /// <summary>
        /// Update specific document by id
        /// </summary>
        /// <param name="id">Id of document where we need to set new data</param>
        /// <param name="value"> Data which we need to change</param>
        /// <returns></returns>
        [HttpPut]
        [Route("api/updateDocument/{id}/update/{value}")]
        public HttpResponseMessage Put(int id, [FromBody]string value)
        {
            var documents = new List<DocumentDTO>();
            return Request.CreateResponse<IEnumerable<DocumentDTO>>(HttpStatusCode.OK, documents);

        }


        /// <summary>
        /// Delete specific document by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete]
        [Route("api/deleteDocument/{id}")]
        public HttpResponseMessage Delete(int id)
        {
            var documents = new List<DocumentDTO>();
            return Request.CreateResponse<IEnumerable<DocumentDTO>>(HttpStatusCode.OK, documents);
        }
    }
}
