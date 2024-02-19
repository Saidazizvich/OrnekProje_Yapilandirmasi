using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProje_Entity.Models
{
    public class BookDetail
    {
        [Key]
        public int BookDetailId { get; set; }
        [Required]
        public int NumberofChapters { get; set; }
        public int ChapterPage { get; set; }

        public int BookDetailWeight { get; set; }

        public Book Book { get; set; }
    }
}
