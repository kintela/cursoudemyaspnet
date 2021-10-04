using System;
using System.Collections.Generic;
using Back_End.Entidades;
using Back_End.Filtros;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;

namespace Back_End.Controllers
{
  [Route("api/generos")]
  [ApiController]
  //[Authorize(AuthenticationSchemes = JwtBearerDefaults.AuthenticationScheme)]
  public class GenerosController:ControllerBase
  {
		private readonly ILogger<GenerosController> logger;

		public GenerosController(ILogger<GenerosController> logger)
    {
			this.logger = logger;
		}

    [HttpPost]
    public ActionResult Post([FromBody] Genero genero)
    {
      return NoContent();
    }


    [HttpGet]
    public ActionResult<List<Genero>> Get()
    {
      return new List<Genero>() { new Genero() { Id = 1, Nombre = "Comedia" } };
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
