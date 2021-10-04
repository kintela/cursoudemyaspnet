using System;
using System.Collections.Generic;
using System.Threading.Tasks;
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

		public GenerosController(
      ILogger<GenerosController> logger,
      ApplicationDbContext context)
    {
			this.logger = logger;
			this.context = context;
		}

    [HttpPost]
    public async Task<ActionResult> Post([FromBody] Genero genero)
    {
      context.Add(genero);
      await context.SaveChangesAsync();
      return NoContent();
    }


    [HttpGet]
    public async Task<ActionResult<List<Genero>>> Get()
    {
      return await context.Generos.ToListAsync();
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
