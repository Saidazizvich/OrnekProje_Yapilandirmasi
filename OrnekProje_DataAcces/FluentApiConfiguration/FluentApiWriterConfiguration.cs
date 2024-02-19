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
    public class FluentApiWriterConfiguration : IEntityTypeConfiguration<FluentApiWriter>
    {
        public void Configure(EntityTypeBuilder<FluentApiWriter> builder)
        {
            builder.HasKey(x => x.WriterId);
            builder.Property(x => x.WriterName).IsRequired();
           builder.Property(X => X.WriterSurName).IsRequired();
            builder.Ignore(x => x.FullName);
        }
    }
}
