using System;
using System.Collections.Generic;
using Back_End.Entidades;
using Back_End.Repositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.Extensions.Logging;

namespace Back_End.Controllers
{
  [Route("api/generos")]
  [ApiController]
  public class GenerosController:ControllerBase
  {
    private readonly IRepositorio repositorio;
		private readonly WeatherForecastController weatherForecastController;
		private readonly ILogger<GenerosController> logger;

		public GenerosController(IRepositorio repositorio, WeatherForecastController weatherForecastController, ILogger<GenerosController> logger)
    {
      this.repositorio = repositorio;
			this.weatherForecastController = weatherForecastController;
			this.logger = logger;
		}

    [HttpPost]
    public ActionResult Post([FromBody] Genero genero)
    {
      repositorio.CrearGenero(genero);
      return NoContent();
    }

    [HttpGet("guid")] // api/generos/guid
    public ActionResult<Guid> GetGUID()
    {
      return Ok(new
      {
        GUID_GenerosController=repositorio.ObtenerGUID(),
        GUID_WeatherForeCastController=weatherForecastController.ObtenerGUIDWeatherForecastController()
      });
    }

    [HttpGet]
    [HttpGet("listado")] //api/generos/listado
    [HttpGet("/listadogeneros")] // /listadogeneros
    public ActionResult<List<Genero>> Get()
    {
      logger.LogInformation("Vamos a mostrar todos los géneros");

      return repositorio.ObtenerTodosLosGeneros();
    }

    [HttpGet("{id:int}")] //api/generos/3
    public ActionResult<Genero> Get(int id,[FromHeader] string nombre)
    {

      logger.LogDebug($"obteniendo un género por el id {id}");

      var genero = repositorio.ObtenerPorId(id);

      if (genero == null)
      {
        logger.LogWarning($"No pudimos encontrra el género de id {id}");
        return NotFound();
      }

      
      return genero;
    }

    

    [HttpPut]
    public ActionResult Put([FromBody] Genero genero)
    {
      return NoContent();
    }

    [HttpDelete]
    public ActionResult Delete()
    {
      return NoContent();
    }


  }
}
