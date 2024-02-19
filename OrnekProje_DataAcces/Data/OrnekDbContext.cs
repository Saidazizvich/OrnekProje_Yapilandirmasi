using Microsoft.EntityFrameworkCore;
using OrnekProje_DataAcces.FluentApiConfiguration;
using OrnekProje_Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProje_DataAcces.Data
{
    public class OrnekDbContext : DbContext
    {
        public OrnekDbContext(DbContextOptions<OrnekDbContext> options) : base(options) 
        {

        }

        public DbSet<FluentApiBook> FluentApiBooks { get; set; } //
        public DbSet<FluentApiBookDetail> FluentApiBookDetails { get; set; }//

        public DbSet<FluentApiWriter> FluentApiWriters { get; set; }//

        public DbSet<FluentApiPublisher> FluentApiPublishers { get; set; } //
        public DbSet<FluentApiBook_Writer> FluentApiBook_Writers { get; set; }//

        public DbSet<BookDetail> BookDetails { get; set; }
        public DbSet<Book_Writer> Book_Writers { get; set; }


        public DbSet<Category> Categories { get; set; }

        public DbSet<Round> Rounds { get; set; }

        public DbSet<Writer> Writers { get; set; }

        public DbSet<Publisher> Publishers { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) // fluent api codefirst daha profesonal yontem 
        {
            //book // burda islem primary key tamomliyoruz dikkat ve iki tablo birlestiriyoruz
            modelBuilder.Entity<Book_Writer>().HasKey(x => new { x.WriterId, x.BookId });


            modelBuilder.Entity<Category>().ToTable("tbl_CategoryNew");
            modelBuilder.Entity<Category>().Property(c => c.CategoryName).HasColumnName("CategoryName");

            // book_writer
            //modelBuilder.Entity<FluentApiBook_Writer>().HasKey(x => new { x.WriterId, x.BookId });



            modelBuilder.ApplyConfiguration(new FluentApiWriterConfiguration());
            modelBuilder.ApplyConfiguration(new FluentApiBookConfiguration());
            modelBuilder.ApplyConfiguration(new FluentApiBookDetailConfiguration());
            modelBuilder.ApplyConfiguration(new FluentApiPublisherConfigurayion());
            modelBuilder.ApplyConfiguration(new FluentApiBook_WriterConfiguration());

        }
            //modelBuilder.Entity<Category>().HasData(
            //    new Category()
            //    {
            //       CategoryId = 1,  
            //       CategoryName ="Scared",
            //    },
            //     new Category()
            //     {
            //         CategoryId = 2,
            //         CategoryName = "Horror",
            //     },
            //      new Category()
            //      {
            //          CategoryId = 3,
            //          CategoryName = "Comedy",
            //      },

            //        new Category()
            //        {
            //            CategoryId = 4,
            //            CategoryName = "Drama",
            //        }

                //);


            
        //}
    }
}
