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
    public class FluentApiBookDetailConfiguration : IEntityTypeConfiguration<FluentApiBookDetail>
    {
        public void Configure(EntityTypeBuilder<FluentApiBookDetail> builder)
        {
           builder.HasKey(e => e.DetailId);
         builder.Property(w => w.ChapterPage).IsRequired();
        }
    }
}
