using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProje_Entity.Models
{
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        [Required]
        public string BookName { get; set; }
        [Required]

        public double Price { get; set; }

        [NotMapped]
        public double DiscountPrice { get; set; }

        [Required]
        [MaxLength(15)]
        public string Barkod { get; set; }

        [ForeignKey("Category")]
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        [ForeignKey("BookDetails")]
        public int? BookDetailId { get; set; }

        public BookDetail BookDetails { get; set; }

        [ForeignKey("Publisher")]

        public int PublisherId { get; set; }

        public Publisher Publisher { get; set; }

        public ICollection<Book_Writer> Book_Writers { get; set; }

    }
}
