using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using OrnekProje_Entity.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace OrnekProje_DataAcces.FluentApiConfiguration
{
    public class FluentApiBook_WriterConfiguration : IEntityTypeConfiguration<FluentApiBook_Writer>
    {
        public void Configure(EntityTypeBuilder<FluentApiBook_Writer> builder)
        {
            // coka cok ilkisi fluentapibook ve fluentapiwriter ayri bir tabla acmakdayiz coka cok ilikisi yapmakdayiz Icollection diye 
           builder.HasKey(bw => new { bw.WriterId, bw.BookId }); // primary key

            // coka cok ilkisi fluentapibook ve fluentapiwriter ayri bir tabla acmakdayiz coka cok ilikisi yapmakdayiz Icollection diye 
           builder.HasKey(bw => new { bw.WriterId, bw.BookId }); // primary key

            // bire cok ilikisi
            builder.HasOne(a => a.FluentApiBook).WithMany(a => a.FluentApiBook_Writers).HasForeignKey(a => a.BookId);
           builder.HasOne(z => z.FluentApiWriter).WithMany(z => z.FluentApiBook_Writers).HasForeignKey(z => z.WriterId);

            //// bire cok ilikisi
            //modelBuilder.Entity<FluentApiBook_Writer>().HasOne(a => a.FluentApiBook).WithMany(a => a.FluentApiBook_Writers).HasForeignKey(a => a.BookId);
            //modelBuilder.Entity<FluentApiBook_Writer>().HasOne(z => z.FluentApiWriter).WithMany(z => z.FluentApiBook_Writers).HasForeignKey(z => z.WriterId);
        }
    }
}
