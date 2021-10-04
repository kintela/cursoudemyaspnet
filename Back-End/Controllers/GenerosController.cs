using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Back_End.DTOs;
using Back_End.Entidades;
using Back_End.Filtros;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;

namespace Back_End.Controllers
{
  [Route("api/generos")]
  [ApiController]
  //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
  public class GenerosController:ControllerBase
  {
		private readonly ILogger<GenerosController> logger;
		private readonly ApplicationDbContext context;
		private readonly IMapper mapper;

		public GenerosController(
      ILogger<GenerosController> logger,
      ApplicationDbContext context,
      IMapper mapper)
    {
			this.logger = logger;
			this.context = context;
			this.mapper = mapper;
		}

    [HttpGet]
    public async Task<ActionResult<List<GeneroDTO>>> Get()
    {
      var generos = await context.Generos.ToListAsync();
      return mapper.Map<List<GeneroDTO>>(generos);
    }

    [HttpPost]
    public async Task<ActionResult> Post([FromBody] GeneroCreacionDTO generoCreacionDTO)
    {
      var genero = mapper.Map<Genero>(generoCreacionDTO);
      context.Add(genero);
      await context.SaveChangesAsync();
      return NoContent();
    }


   

    [HttpGet("{id:int}")] 
    public ActionResult<Genero> Get(int id)
    {
      throw new NotImplementedException();      
    }

    

    [HttpPut]
    public ActionResult Put([FromBody] Genero genero)
    {
      throw new NotImplementedException();
    }

    [HttpDelete]
    public ActionResult Delete()
    {
      throw new NotImplementedException();
    }


  }
}
