using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Migrations;
using Mordor.Api.Dto;
using Mordor.Api.Mapper;
using Mordor.Service.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mordor.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HordaController: ControllerBase
    {
        private readonly IHordaService hordaService;
        private readonly IHordaMapper hordaMapper;

        public HordaController(IHordaService hordaService, IHordaMapper hordaMapper)
        {
            this.hordaService = hordaService;
            this.hordaMapper = hordaMapper;
        }

        [HttpGet]
        public IEnumerable<Horda> Get()
        {
            var hordak = hordaService.GetAll();
            return hordak.Select(o => hordaMapper.MapToDto(o));
        }
    }
}
