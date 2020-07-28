using System;
using System.Collections.Generic;
using System.Text;

namespace Mordor.Repository.Entities
{
    public class DbOrk
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int KillCount { get; set; }
        public DbHorda Horda { get; set; }
        public List<DbOrkWeapon> Weapons { get; set; }
    }
}
