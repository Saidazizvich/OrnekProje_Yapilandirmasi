using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProje_Entity.Models
{
    public class Round
    {
        [Key]
        public int RoundId { get; set; }

        public string Name { get; set; }

        public int DisplayOrder { get; set; }
    }
}
