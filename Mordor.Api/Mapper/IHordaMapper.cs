using Mordor.Api.Dto;
using Mordor.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mordor.Api.Mapper
{
    public interface IHordaMapper
    {
        public Dto.Horda MapToDto(Domain.Horda horda);
        public Domain.Horda MapToDomain(Dto.Horda horda);
    }
}
