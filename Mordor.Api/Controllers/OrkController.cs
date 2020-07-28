using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Mordor.Api.Dto;
using Mordor.Api.Mapper;
using Mordor.Service.Abstractions;

namespace Mordor.Api.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class OrkController : ControllerBase
    {

        private readonly IOrkService orkService;
        private readonly IOrkMapper orkMapper;
        private readonly IMapper mapper;

        public OrkController(IOrkService orkService, IOrkMapper orkMapper,IMapper mapper)
        {
            this.orkService = orkService;
            this.orkMapper = orkMapper;
            this.mapper = mapper;
        }
        
        [HttpGet]
        public IEnumerable<Ork> Get()
        {
            var orks = orkService.GetAll();
            return orks.Select(o => orkMapper.MapToDto(o));
        }
         
        [HttpGet("{id}")]
        public Ork GetOrk(int id)
        {
            return orkMapper.MapToDto(orkService.GetOrcById(id));
        }      

        [HttpPost]
        public void SaveOrk(Ork ork)
        {
            //orkService.SaveOrk(orkMapper.MapToDomain(ork));
            orkService.SaveOrk(mapper.Map<Domain.Ork>(ork));
        }
         
        [HttpDelete("{id}")]
        public void DeleteOrk(int id)
        {
            orkService.DeleteOrkById(id);
        }
         
        [HttpPut("{id}")]
        public void ChangeOrk(int id, Ork ork)
        {
            orkService.ChangeOrkById(id, orkMapper.MapToDomain(ork));
        }
    }
}

