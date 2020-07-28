using Mordor.Domain;
using Mordor.Repository.Abstractions;
using Mordor.Service.Abstractions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mordor.Service
{
    public class HordaService : IHordaService
    {
        private readonly IHordaRepository hordaRepository;

        public HordaService(IHordaRepository hordaRepository)
        {
            this.hordaRepository = hordaRepository;
        }
        public IEnumerable<Horda> GetAll()
        {
            return hordaRepository.GetAll();
        }
    }
}
