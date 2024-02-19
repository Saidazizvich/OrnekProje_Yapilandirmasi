using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProje_Entity.Models
{
    public class Book_Writer
    {
        [ForeignKey("Writer")]
        public int WriterId { get; set; }

        [ForeignKey("Book")]
        public int BookId { get; set; }
        public Book Books { get; set; }
        public Writer Writer { get; set; }

    }
}
