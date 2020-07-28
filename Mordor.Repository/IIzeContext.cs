using Microsoft.EntityFrameworkCore;
using Mordor.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mordor.Repository
{
    public interface IIzeContext
    {
        DbSet<DbHorda> Horda { get; set; }
        DbSet<DbOrk> Orkok { get; set; }
        DbSet<DbOrkWeapon> Weapons { get; set; }
    }
}
