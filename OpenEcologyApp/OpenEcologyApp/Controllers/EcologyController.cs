using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OpenEcologyApp.Data;

namespace OpenEcologyApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EcologyController : ControllerBase
    {
        private readonly EcologyDbContext _context;

        public EcologyController(EcologyDbContext context)
        {
            _context = context;
        }

        [HttpGet("{page:int}/{pageSize:int}")]
        public async Task<ActionResult<IEnumerable<EcologyData>>> Get(int page, int pageSize)
        {
            var data = await _context.EcologyItems
                .OrderBy(e => e.Id)
                .Skip((page - 1) * pageSize)
                .Take(pageSize)
                .ToListAsync();

            return Ok(data);
        }


        [HttpPost]
        public async Task<IActionResult> Post([FromBody] List<EcologyData> data)
        {

            if (data == null || !data.Any())
                return BadRequest("Данные пусты или невалидны");

            try
            {
                _context.EcologyItems.AddRange(data);
                await _context.SaveChangesAsync();
                return Ok();
            }
            catch (Exception ex)
            {
                var inner = ex.InnerException?.Message ?? ex.Message;
                return BadRequest($"Ошибка при сохранении: {inner}");
            }
        }
    }
}
