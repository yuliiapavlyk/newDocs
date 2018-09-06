using System;
using System.Collections.Generic;
using System.Linq;
using MyDocuments.BLL.DTO;
using System.Threading.Tasks;

namespace MyDocuments.BLL.Interfaces
{
    public interface IDocumentService
    {
        IEnumerable<DocumentDTO> GetAllDocuments();
        DocumentDTO GetDocumentById(int id);
        bool RemoveDocumentById(int id);
        bool UpdateDocumentById(int id, DocumentDTO dto);

    }
}
