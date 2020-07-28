using Mordor.Domain;
using System;
using System.Collections.Generic;

namespace Mordor.Repository.Abstractions
{
    public interface IHordaRepository
    {
        IEnumerable<Horda> GetAll();
    }
}
