using AutoMapper;
using Common.BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using TestWebAPICapas.DTOs;

namespace TestWebAPICapas.Controllers
{
    [Route("api/generos")]
    [ApiController]
    public class GenerosController : ControllerBase
    {
        private IGenerosBusinessLogic generosBusinessLogic;
        private readonly IMapper mapper;

        public GenerosController(IGenerosBusinessLogic generosBusinessLogic, IMapper mapper)
        {
            this.generosBusinessLogic = generosBusinessLogic;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult<List<GeneroDTO>>> Get()
        {
            var generos =  await this.generosBusinessLogic.LoadGenerosAsync();
            return mapper.Map<List<GeneroDTO>>(generos);
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromBody] GeneroCreacionDTO generoCreacionDTO)
        {
            var genero = mapper.Map<Genero>(generoCreacionDTO);
             await this.generosBusinessLogic.AddGenerosAsync(genero);
             return NoContent();
        
        }
    }
}
