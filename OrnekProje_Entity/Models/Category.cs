using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProje_Entity.Models
{
    [Table("tbl_Category")]
    public class Category
    {
        
        public int CategoryId { get; set; }

        [Column("Ad")]  
        public string CategoryName { get; set; }

        
    }
}
