using AutoMapper;
using Mordor.Api.Dto;
using Mordor.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mordor.Api
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Dto.Ork, Domain.Ork>();
            CreateMap<Domain.Ork, Dto.Ork>();
            //CreateMap<Orc, OrcDetails>();
            //CreateMap<OrcCreateItem, Orc>();
            //CreateMap<DbOrc, Orc>();
            //CreateMap<Orc, DbOrc>();

            //CreateMap<WeaponType, DbWeapon>();
            //CreateMap<DbWeapon, WeaponType>();
            //CreateMap<string, OrcRaceType>().
            //    ConvertUsing(s => OrcRaceType.Parse(s));
            //CreateMap<string, WeaponType>().
            //    ConvertUsing(s => WeaponType.Parse(s));

            //CreateMap<Horde, HordeDetails>();
            //CreateMap<Horde, HordeListItem>();
            //CreateMap<HordeCreateItem, Horde>();
            //CreateMap<Horde, DbHorde>();
            //CreateMap<DbHorde, Horde>();
        }
    }
}
