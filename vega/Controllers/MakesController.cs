using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Controllers.Resources;
using vega.Model;
using vega.Persistence;

namespace vega.Controllers
{
    public class MakesController : Controller
    {
        private readonly VegaDbContext context;
        private readonly IMapper iMapper;

        public MakesController(VegaDbContext context, IMapper iMapper)
        {
            this.context = context;
            this.iMapper = iMapper;
        }

        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakesAsync()
        {
            var makes = await context.Makes.Include(m => m.Models).ToListAsync();
            return iMapper.Map<List<Make>, List<MakeResource>>(makes);
        }
    }
}