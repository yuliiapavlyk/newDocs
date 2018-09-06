using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDocuments.BLL.DTO
{
    public class DocumentDTO
    {
        public DocumentDTO() { }
        public DocumentDTO(int id, 
            string name,
            string description,
            string author,
            DateTime create_date,
            DateTime? modified_date)
        {
            Id = id;
            Name = name;
            Description = description;
            Author = author;
            Create_Date = create_date;
            Modified_Date = modified_date;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Author { get; set; }
        public DateTime Create_Date { get; set; }
        public DateTime? Modified_Date { get; set; }
    }
}
