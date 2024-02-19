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
    public class FluentApiBookConfiguration : IEntityTypeConfiguration<FluentApiBook>
    {
       

        public void Configure(EntityTypeBuilder<FluentApiBook> builder)
        {
              //book
                builder.HasKey(f => f.BookId);
                builder.Property(a => a.BookName).IsRequired();
                builder.Property(a => a.Price).IsRequired();
                builder.Property(a => a.DiscountPrice).IsRequired();
                builder.Property(a => a.Barkod).HasMaxLength(13).IsRequired();

            // bire cok ilkisi fluentapibook<list>  ve fluentapipublisher publisheriId 
          builder.HasOne(z => z.FluentApiPublisher).WithMany(z => z.FluentApiBooks).HasForeignKey(z => z.PublisherId);

            // simdi burasi bire bir ilikisi oldu fleuntapibook 1   ve fleuntapibookdetails1
            builder.HasOne(a => a.FluentApiBookDetail).WithOne(a => a.FluentApiBook).HasForeignKey<FluentApiBook>("DetailId");


        }
    }
}
