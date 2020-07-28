using Mordor.Domain;
using System;
using System.Collections.Generic;

namespace Mordor.Service.Abstractions
{
    public interface IHordaService
    {
        IEnumerable<Horda> GetAll();
    }
}
