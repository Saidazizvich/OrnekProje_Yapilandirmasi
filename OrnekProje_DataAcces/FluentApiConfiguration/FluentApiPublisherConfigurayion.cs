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
    public class FluentApiPublisherConfigurayion : IEntityTypeConfiguration<FluentApiPublisher>
    {
        public void Configure(EntityTypeBuilder<FluentApiPublisher> builder)
        {
            //publisher
            builder.HasKey(x => x.PublisherId);
           builder.Property(a => a.Name).IsRequired();
           builder.Property(a => a.Location).IsRequired();

        }
    }
}
