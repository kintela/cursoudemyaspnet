using System;
using Back_End.Repositorios;

namespace Back_End.Controllers
{
  public class GenerosController
  {
    private readonly IRepositorio repositorio;

    public GenerosController(IRepositorio repositorio)
    {
      this.repositorio = repositorio;
    }
  }
}
