using Mordor.Domain;
using Mordor.Repository.Abstractions;
using Mordor.Repository.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Mordor.Repository
{
    public class HordaRepository : IHordaRepository
    {
        private readonly IIzeContext izeContext;
        private readonly IHordaMapper hordaMapper;

        public HordaRepository(IIzeContext izeContext, IHordaMapper hordaMapper)
        {
            this.izeContext = izeContext;
            this.hordaMapper = hordaMapper;
        }
        public IEnumerable<Horda> GetAll()
        {
            return izeContext.Horda.Select(h => hordaMapper.MapToDomain(h)).ToList();
        }
    }
}
