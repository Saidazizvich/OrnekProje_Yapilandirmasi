using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProje_Entity.Models
{
    public class FluentApiBook
    {
       // burasi fluentapidir yani direk olarak biz dbcontext class icina tamomliyoruz neden cunku
       // hem guvenli hem profeseonal yaklasimdir
        public int BookId { get; set; }
     
        public string BookName { get; set; }
      

        public double Price { get; set; }

      
        public double DiscountPrice { get; set; }

   
        public string Barkod { get; set; }

        public int DetailId  { get; set; }

        public FluentApiBookDetail FluentApiBookDetail { get; set; }

        public int PublisherId { get; set; }

        public FluentApiPublisher FluentApiPublisher { get; set; }

        public ICollection<FluentApiBook_Writer> FluentApiBook_Writers { get; set; }
    }
}
