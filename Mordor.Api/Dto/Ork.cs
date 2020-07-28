using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mordor.Api.Dto
{
    public class Ork
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<string> Weapons { get; set; }
        public int KillCount { get; set; }
    }
}
