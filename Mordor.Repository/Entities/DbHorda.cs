using System;
using System.Collections.Generic;
using System.Text;

namespace Mordor.Repository.Entities
{
    public class DbHorda
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<DbOrk> Orks { get; set; }
        public DateTime LastFight { get; set; }
    }
}
