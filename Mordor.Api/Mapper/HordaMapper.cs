using Mordor.Api.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mordor.Api.Mapper
{
    public class HordaMapper : IHordaMapper
    {
        private readonly IOrkMapper orkMapper;

        public HordaMapper(IOrkMapper orkMapper)
        {
            this.orkMapper = orkMapper;
        }
        public Domain.Horda MapToDomain(Horda horda)
        {
            return new Domain.Horda
            {
                ID = horda.ID,
                Name = horda.Name,
                LastFight = horda.LastFight,
                Orks = horda.Orks.Select(o =>orkMapper.MapToDomain(o)).ToList(),

            };
        }

        public Horda MapToDto(Domain.Horda horda)
        {
            return new Horda
            {
                ID = horda.ID,
                Name = horda.Name,
                LastFight= horda.LastFight,
                Orks = (horda.Orks ?? new List<Domain.Ork>()).Select(o => orkMapper.MapToDto(o)).ToList()
                
            };
        }
    }
}
