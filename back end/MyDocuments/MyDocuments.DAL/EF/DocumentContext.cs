using System;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyDocuments.DAL.Entities;

namespace MyDocuments.DAL.EF
{
    public class DocumentContext: DbContext
    {
        public DbSet<Document> Documents { get; set; }

        static DocumentContext()
        {
            Database.SetInitializer<DocumentContext>(new DocumentDbInitializer());
        }
        public DocumentContext(string connectionString)
            : base(connectionString)
        {
        }
    }

    public class DocumentDbInitializer : DropCreateDatabaseIfModelChanges<DocumentContext>
    {
        protected override void Seed(DocumentContext db)
        {
            db.Documents.Add(new Document { Name = "CV", Description = "my own cv", Author="Andrii Lysyi",Create_Date = DateTime.UtcNow });
            db.Documents.Add(new Document { Name = "CV1", Description = "my own cv1", Author = "Andrii Lysyi2", Create_Date = DateTime.UtcNow });
            db.Documents.Add(new Document { Name = "CV2", Description = "my own cv2", Author = "Andrii Lysyi3", Create_Date = DateTime.UtcNow });
            db.SaveChanges();
        }
    }
}
