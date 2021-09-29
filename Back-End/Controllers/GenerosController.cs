using System;
using System.Collections.Generic;
using Back_End.Entidades;
using Back_End.Repositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Back_End.Controllers
{
  [Route("api/generos")]
  [ApiController]
  public class GenerosController:ControllerBase
  {
    private readonly IRepositorio repositorio;

    public GenerosController(IRepositorio repositorio)
    {
      this.repositorio = repositorio;
    }

    [HttpGet]
    [HttpGet("listado")] //api/generos/listado
    [HttpGet("/listadogeneros")] // /listadogeneros
    public ActionResult<List<Genero>> Get()
    {
      return repositorio.ObtenerTodosLosGeneros();
    }

    [HttpGet("{id:int}")] //api/generos/3
    public ActionResult<Genero> Get(int id,[FromHeader] string nombre)
    {
      var genero = repositorio.ObtenerPorId(id);

      if (genero == null)
      {
        return NotFound();
      }

      
      return genero;
    }

    [HttpPost]
    public ActionResult Post([FromBody] Genero genero)
    {
      return NoContent();
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
