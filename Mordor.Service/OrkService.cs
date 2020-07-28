using Mordor.Domain;
using Mordor.Repository.Abstractions;
using Mordor.Service.Abstractions;
using System;
using System.Collections.Generic;

namespace Mordor.Service
{
    public class OrkService : IOrkService
    {
        private readonly IOrkRepository orkRepository;

        public OrkService(IOrkRepository orkRepository)
        {
            this.orkRepository = orkRepository;
        }

        public IEnumerable<Ork> GetAll()
        {
            return orkRepository.GetAll();
        }

        public Ork GetOrcById(int id)
        {
            return orkRepository.GetOrcById(id);
        }

        public void SaveOrk(Ork ork)
        {
            orkRepository.SaveOrk(ork);
        }

        public void DeleteOrkById(int id)
        {
            orkRepository.DeleteOrkById(id);
        }

        public void ChangeOrkById(int id, Ork ork)
        {
            orkRepository.ChangeOrkById(id, ork);
        }
    }
}
