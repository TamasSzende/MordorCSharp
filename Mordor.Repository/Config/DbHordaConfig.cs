using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mordor.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mordor.Repository.Config
{
    public class DbHordaConfig : IEntityTypeConfiguration<DbHorda>
    {
        public void Configure(EntityTypeBuilder<DbHorda> builder)
        {
            builder.ToTable("HordaTable");
            builder.HasKey(horda => horda.ID);
            builder.Property(horda => horda.Name)  
                .IsRequired();                  
            builder.HasIndex(horda => horda.Name)   
                .IsUnique();
        }
    }
}
