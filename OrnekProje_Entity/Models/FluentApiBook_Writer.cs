using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProje_Entity.Models
{
    public class FluentApiBook_Writer
    {
       
        public int WriterId { get; set; }

       
        public int BookId { get; set; }

        public FluentApiWriter FluentApiWriter { get; set; }

        public FluentApiBook FluentApiBook { get; set; }
    }
}
