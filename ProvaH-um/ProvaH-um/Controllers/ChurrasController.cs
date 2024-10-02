using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProvaH_um.Models;
using ProvaH_um.Services;
namespace ProvaH_um.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ChurrasController : ControllerBase
    {
        private readonly IChurrasRepository _churrasRepository;

        public ChurrasController(IChurrasRepository churrasRepository)
        {
            _churrasRepository = churrasRepository;
        }

        [HttpPost]
        public IActionResult CriarChurras(Churras Churras)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _churrasRepository.CriarChurras(Churras);

            return Ok("Churras criado com éxito");
        }

        [HttpGet]
        public IActionResult ListarChurras()
        {
            var churras = _churrasRepository.ListarChurras();

            return Ok(churras);
        }
    }
}
