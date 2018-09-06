using System;
using System.Collections.Generic;
using System.Linq;
using MyDocuments.DAL.Repositories.Interfaces;
using MyDocuments.DAL.Entities;
using MyDocuments.DAL.EF;
using System.Threading.Tasks;
using System.Data.Entity;

namespace MyDocuments.DAL.Repositories
{
    public class DocumentRepository : IRepository<Document>
    {
        private DocumentContext db;

        public DocumentRepository(DocumentContext context)
        {
            this.db = context;
        }
        public IEnumerable<Document> GetAll()
        {
            return db.Documents;
        }
        public Document Get(int id)
        {
            return db.Documents.Find(id);
        }
        public void Add (Document Doc)
        {
            db.Documents.Add(Doc);
        }
        public void Update(Document Doc)
        {
            db.Entry(Doc).State =EntityState.Modified;
        }
        public void Remove(int id)
        {
            Document Doc = db.Documents.Find(id);
            if (Doc != null)
                db.Documents.Remove(Doc);
        }
    }
}
