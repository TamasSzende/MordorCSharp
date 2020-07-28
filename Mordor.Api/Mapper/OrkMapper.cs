using Mordor.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mordor.Api.Mapper
{
    public class OrkMapper: IOrkMapper
    {
        public Ork MapToDomain(Dto.Ork ork)
        {
            return new Ork
            {
                Id = ork.Id,
                KillCount = ork.KillCount,
                Name = ork.Name,
                Weapons = (ork.Weapons ?? new List<string>()).Select(w => Enum.Parse<Weapons>(w)).ToList()  //át kell mappelni stringet -> enum-ra
            };

        }

        public Dto.Ork MapToDto(Ork ork)
        {
            return new Dto.Ork
            {
                Id = ork.Id,
                KillCount = ork.KillCount,
                Name = ork.Name,
                Weapons = ork.Weapons.Select(w => w.ToString()).ToList()  //enum-ot Stringre mappel
            };
        }
    }
}
