using RoadOfDreams.Data;
using RoadOfDreams.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Passagens.Controllers
{

    [ApiController]
    [Route("api/passagem")]
    public class PassagensController : ControllerBase
    {

        private readonly DataContext _dataContext;


        public PassagensController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }


        [HttpGet]
        public async Task<ActionResult<IEnumerable<Passagem>>> GetPassagens()
        {
            return await _dataContext.Passagens.ToListAsync();
        }


        [HttpGet("{id}")]
        public async Task<ActionResult<Passagem>> GetPassagensById(int id)
        {
            var passagem = await _dataContext.Passagens.FindAsync(id);
            if (passagem == null)
            {
                return NotFound();
            }

            return Ok(passagem);
        }





    }

}