using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDocuments.BLL.Interfaces;
using MyDocuments.DAL.Repositories.Interfaces;
using MyDocuments.BLL.DTO;
using MyDocuments.DAL.Entities;

namespace MyDocuments.BLL.Services
{
    public class DocumentService: BaseService, IDocumentService
    {
        public DocumentService(IUnitOfWork db) : base(db)
        {
        }
        public IEnumerable<DocumentDTO> GetAllDocuments()
        {
            var documents = db.Documents.GetAll();
            var documentsDTO = new List<DocumentDTO>();
            if(documents == null)
            {
                return null;
            }
            foreach(var doc in documents)
            {
                documentsDTO.Add(DocumentToDocumentDTO(doc));
            }
            return documentsDTO;
        }
        public DocumentDTO GetDocumentById(int id)
        {
            var document = db.Documents.Get(id);
            if (document == null) return null;
            return DocumentToDocumentDTO(document);
        }
        public bool RemoveDocumentById(int id)
        {
            var document = db.Documents.Get(id);
            if (document != null)
            {
                db.Documents.Remove(id);
                db.Save();
                return true;
            }
            return false;
        }
        public bool UpdateDocumentById(int id, DocumentDTO dto)
        {
            var document = db.Documents.Get(id);
            if (document == null) return false;
            if (!string.IsNullOrEmpty(dto.Name))
            {
                document.Name = dto.Name;
            }
            if (!string.IsNullOrEmpty(dto.Description))
            {
                document.Description = dto.Description;
            }
            if (dto.Modified_Date != null)
            {
                document.Modified_Date = dto.Modified_Date;
            }
            db.Documents.Update(document);
            db.Save();
            return true;
        }
        private DocumentDTO DocumentToDocumentDTO(Document document)
        {
            return new DocumentDTO(document.Id,
                                document.Name,
                                document.Description,
                                document.Author,
                                document.Create_Date,
                                document.Modified_Date!=null? document.Modified_Date :null
                                );
        }
    }
}
