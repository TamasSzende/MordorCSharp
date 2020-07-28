using Mordor.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mordor.Repository.Abstractions
{
    public interface IOrkRepository
    {
        IEnumerable<Ork> GetAll();
        Ork GetOrcById(int id);

        void SaveOrk(Ork ork);

        void DeleteOrkById(int id);

        void ChangeOrkById(int id, Ork ork);
    }
}
