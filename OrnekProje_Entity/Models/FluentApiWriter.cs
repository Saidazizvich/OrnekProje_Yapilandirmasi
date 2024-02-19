using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProje_Entity.Models
{
    public class FluentApiWriter
    {

    
        public int WriterId { get; set; }
       
        public string WriterName { get; set; }
     
        public string WriterSurName { get; set; }

        public string Location { get; set; }

        public DateTime Birthday { get; set; }

        public string FullName
        {
            get { return $"{WriterName} {WriterSurName}"; }
        }

        public ICollection<FluentApiBook_Writer> FluentApiBook_Writers { get; set; }
    }
}
