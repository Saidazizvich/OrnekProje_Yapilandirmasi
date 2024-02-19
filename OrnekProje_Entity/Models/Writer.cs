using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProje_Entity.Models
{
    public class Writer
    {
        [Key]
        public int WriterId { get; set; }
        [Required]
        public string WriterName { get; set; }
        [Required]
        public string WriterSurName { get; set; }

        public string Location { get; set; }

        public DateTime Birthday { get; set; }

        public string FullName
        {
            get { return $"{WriterName} {WriterSurName}"; }
        }

        public ICollection<Book_Writer> Book_Writers { get; set; }

    }
}
