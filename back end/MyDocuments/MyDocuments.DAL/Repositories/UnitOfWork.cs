using System;
using System.Collections.Generic;
using System.Linq;
using MyDocuments.DAL.Repositories.Interfaces;
using MyDocuments.DAL.Entities;
using MyDocuments.DAL.EF;
using System.Threading.Tasks;

namespace MyDocuments.DAL.Repositories
{
    public class UnitOfWork
    {
        private DocumentContext db;
        private DocumentRepository documentRepository;


        public UnitOfWork(string connectionString)
        {
            db = new DocumentContext(connectionString);
        }
        public IRepository<Document> Documents
        {
            get
            {
                if (documentRepository == null)
                    documentRepository = new DocumentRepository(db);
                return documentRepository;
            }
        }

        public void Save()
        {
            db.SaveChanges();
        }

        private bool disposed = false;

        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
