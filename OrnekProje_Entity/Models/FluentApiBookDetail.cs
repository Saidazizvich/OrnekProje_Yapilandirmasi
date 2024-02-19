using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProje_Entity.Models
{
    public class FluentApiBookDetail
    {
      
        public int DetailId { get; set; }
     
        public int NumberofChapters { get; set; }
        public int ChapterPage { get; set; }

        public int BookDetailWeight { get; set; }

        public FluentApiBook FluentApiBook { get; set; }
    }
}
