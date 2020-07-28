using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mordor.Api.Dto
{
    public class Horda
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public List<Ork> Orks { get; set; }
        public DateTime LastFight { get; set; }
    }
}
