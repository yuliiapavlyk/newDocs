using MyDocuments.BLL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MyDocuments.PL.Controllers
{
    public class DocumentController : ApiController
    {
        

        // GET: api/document
        [HttpGet]
        [Route("api/allDocument")]
        public HttpResponseMessage Get()
        {
            var documents = new List<DocumentDTO>();
            documents.Add(new DocumentDTO { Name = "CV1", Description = "my own cv", Author = "Andrii Lysyi", Create_Date = DateTime.UtcNow });
            documents.Add(new DocumentDTO { Name = "CV2", Description = "my own cv", Author = "Andrii Lysyi", Create_Date = DateTime.UtcNow });
            documents.Add(new DocumentDTO { Name = "CV3", Description = "my own cv", Author = "Andrii Lysyi", Create_Date = DateTime.UtcNow });
            documents.Add(new DocumentDTO { Name = "CV4", Description = "my own cv", Author = "Andrii Lysyi", Create_Date = DateTime.UtcNow });
           
               
            if (documents.Count != 0)
            {
                return Request.CreateResponse<IEnumerable<DocumentDTO>>(HttpStatusCode.OK, documents);
            }
            const string message = "No documents in database.";
            return Request.CreateErrorResponse(HttpStatusCode.NoContent, message);
        }



        // GET: api/document/5
        [HttpGet]
        [Route("api/document/{id}")]
        
        public HttpResponseMessage Get(int id)
        {
            var documents = new List<DocumentDTO>();
            documents.Add(new DocumentDTO { Name = "CV1", Description = "my own cv", Author = "Andrii Lysyi", Create_Date = DateTime.UtcNow });
            return  Request.CreateResponse<IEnumerable<DocumentDTO>>(HttpStatusCode.OK,documents);
        }

        // POST: api/document
        [HttpPost]
        [Route("api/documfent/{id}")]
        public HttpResponseMessage Post([FromBody]string value)
        {
            var documents = new List<DocumentDTO>();
            documents.Add(new DocumentDTO { Name = "CV1", Description = "my own cv", Author = "Andrii Lysyi", Create_Date = DateTime.UtcNow });
            return Request.CreateResponse<IEnumerable<DocumentDTO>>(HttpStatusCode.OK, documents);
        }

        // PUT: api/document/5
        [HttpPut]
        [Route("api/dodcumfent/{id}")]
        public HttpResponseMessage Put(int id, [FromBody]string value)
        {
            var documents = new List<DocumentDTO>();
            documents.Add(new DocumentDTO { Name = "CV1", Description = "my own cv", Author = "Andrii Lysyi", Create_Date = DateTime.UtcNow });
            return Request.CreateResponse<IEnumerable<DocumentDTO>>(HttpStatusCode.OK, documents);
        }

        // DELETE: api/document/5
        [HttpDelete]
        [Route("api/docddumfent/{id}")]
        public HttpResponseMessage Delete(int id)
        {
              var documents = new List<DocumentDTO>();
                documents.Add(new DocumentDTO { Name = "CV1", Description = "my own cv", Author = "Andrii Lysyi", Create_Date = DateTime.UtcNow });
                return Request.CreateResponse<IEnumerable<DocumentDTO>>(HttpStatusCode.OK, documents);


            
           
        }
    }
}
