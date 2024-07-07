using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Fastorant.Infrastructure;
using Fastorant.Infrastructure.Entities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Fastorant.Host.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProvinceController : ControllerBase
    {
        private readonly FastorantContext _context;

        public ProvinceController(FastorantContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var provinces = await _context.Provinces.ToListAsync();
            return Ok(provinces);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            var province = await _context.Provinces.FindAsync(id);

            if (province == null)
            {
                NotFound(id); 
                return BadRequest();

            }
            return Ok(province);
        }

    }
}
