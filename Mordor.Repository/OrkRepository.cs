using Mordor.Domain;
using Mordor.Repository.Abstractions;
using Mordor.Repository.Mapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Mordor.Repository
{
    public class OrkRepository : IOrkRepository

    {
        private readonly IIzeContext izeContext;
        private readonly IOrkMapper orkMapper;

        public OrkRepository(IIzeContext izeContext, IOrkMapper orkMapper)
        {
            this.izeContext = izeContext;
            this.orkMapper = orkMapper;
        }

        public IEnumerable<Ork> GetAll()
        {
            return izeContext.Orkok.Select(o => orkMapper.MapToDomain(o)).ToList();

        }

        public Ork GetOrcById(int id)
        {
            var ork = izeContext.Orkok.Single(o => o.Id == id);
            return orkMapper.MapToDomain(ork);
        }

        public void SaveOrk(Ork ork)
        {
            using IzeContext context = new IzeContext();
            context.Orkok.Add(orkMapper.MapToEntity(ork));
            context.SaveChanges();
        }

        public void DeleteOrkById(int id)
        {
            using IzeContext context = new IzeContext();
            var ork = context.Orkok.Single(o => o.Id == id);
            context.Orkok.Remove(ork);
            context.SaveChanges();

        }

        public void ChangeOrkById(int id, Ork ork)
        {
            using IzeContext context = new IzeContext();
            var changedOrk = context.Orkok.Single(o => o.Id == id);
            changedOrk.Name = ork.Name;
            changedOrk.KillCount = ork.KillCount;
            //changedOrk.Weapons = ork.Weapons;
            context.Orkok.Update(changedOrk);
            context.SaveChanges();
        }
    }
}
