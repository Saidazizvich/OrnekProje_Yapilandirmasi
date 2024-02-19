using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProje_Entity.Models
{
    public class Publisher
    {
        [Key]
        public int PublisherId { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Location { get; set; }

        public List<Book> Books { get; set; }
    }
}
