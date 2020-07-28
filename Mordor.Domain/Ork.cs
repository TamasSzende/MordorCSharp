using System;
using System.Collections.Generic;

namespace Mordor.Domain
{
    public class Ork
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Weapons> Weapons { get; set; }
        public int KillCount { get; set; }
    }
}
