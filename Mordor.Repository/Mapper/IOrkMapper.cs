using Mordor.Domain;
using Mordor.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mordor.Repository.Mapper
{
    public interface IOrkMapper
    {
        DbOrk MapToEntity(Ork ork);
        Ork MapToDomain(DbOrk ork);
    }
}
