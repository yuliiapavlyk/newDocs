using System;
using MyDocuments.DAL.Entities;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDocuments.DAL.Repositories.Interfaces
{
    interface IUnitOfWork : IDisposable
    {
        IRepository<Document> Documents { get; }
        void Save();
    }
}
