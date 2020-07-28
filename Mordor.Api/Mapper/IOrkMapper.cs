using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mordor.Api.Mapper
{
    public interface IOrkMapper
    {
        public Dto.Ork MapToDto(Domain.Ork ork);
        public Domain.Ork MapToDomain(Dto.Ork ork);
    }
}
