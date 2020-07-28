using Mordor.Domain;
using Mordor.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mordor.Repository.Mapper
{
    public class HordaMapper : IHordaMapper
    {
        private readonly IOrkMapper orkMapper;

        public HordaMapper(IOrkMapper orkMapper)
        {
            this.orkMapper = orkMapper;
        }
        public Horda MapToDomain(DbHorda horda)
        {
            var mapped = new Horda
            {
                ID = horda.ID,
                Name = horda.Name,
                LastFight = horda.LastFight,
                //Orks = horda.Orks.Select(o => orkMapper.MapToDomain(o)).ToList(),
            };
            return mapped;
        }

        public DbHorda MapToEntity(Horda horda)
        {
            var mapped = new DbHorda
            {
                ID = horda.ID,
                Name = horda.Name,
                LastFight = horda.LastFight,
                //Orks = horda.Orks.Select(o => orkMapper.MapToDto(o)).ToList()
            };
            return mapped;
        }
    }
}
