using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Mordor.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mordor.Repository.Config
{
    public class DbOrkConfig : IEntityTypeConfiguration<DbOrk>
    {
        public void Configure(EntityTypeBuilder<DbOrk> builder)
        {
            builder.ToTable("OrkTable");        //  Tábla nevét állítjuk
            builder.HasKey(ork => ork.Id);      //  HasKey = id a primary key. Tábla szintű constraint(kikötés)
            builder.Property(ork => ork.Name)   //  a Name Propertyn végez valamit, azaz
                .IsRequired();                  //  IsRequired azt jelenti: nem lehet null
            builder.HasIndex(ork => ork.Name)   //  HasIndex - Ez azt definiálja, hogy az Orkokból 
                .IsUnique();                    //  nem lehet 2 azonos nevű. Tábla szintű constraint(kikötés)

        }
    }
}
