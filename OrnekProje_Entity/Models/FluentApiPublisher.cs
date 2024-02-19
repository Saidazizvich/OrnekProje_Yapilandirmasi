using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProje_Entity.Models
{
    public class FluentApiPublisher
    {
      
        public int PublisherId { get; set; }
     
        public string Name { get; set; }
 
        public string Location { get; set; }

        public List<FluentApiBook> FluentApiBooks { get; set; }
    }
}
