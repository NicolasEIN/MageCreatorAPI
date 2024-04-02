using MageCreatorAPI.Services.MageServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace MageCreatorAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MagicianController : ControllerBase
    {
        private readonly IMageService _mageService;
       public MagicianController(IMageService mageService) 
        {
            _mageService = mageService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Magician>>> GetAllMages()
        {
            return await _mageService.GetAllMages();
            
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSingleMage(int id)
        {
            var result = await _mageService.GetMage(id);
            if(result == null)
            {
                return NotFound("O Mago não existe");
            }
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> AddMage(Magician mage)
        {
            var result = await _mageService.AddMage(mage);
            return Ok(result);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateMage(int id, Magician Request)
        {
            var result = await _mageService.UpdateMage(id, Request);
            if( result == null )
            {
                return NotFound("O Mago não existe");
            }
            return Ok(result);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMage(int id)
        {
            var result = await _mageService.RemoveMage(id);
            if(result == null){
                return NotFound(" O Mago não existe");
            }

            return Ok(result);
        }
    }


}
