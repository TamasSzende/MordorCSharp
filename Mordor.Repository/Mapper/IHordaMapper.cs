using Mordor.Domain;
using Mordor.Repository.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mordor.Repository.Mapper
{
    public interface IHordaMapper
    {
        DbHorda MapToEntity(Horda horda);
        Horda MapToDomain(DbHorda horda);
    }
}
