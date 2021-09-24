using System;
using System.Collections.Generic;
using Back_End.Entidades;

namespace Back_End.Repositorios
{
  public interface IRepositorio
  {
    List<Genero> ObtenerTodosLosGeneros();
  }
}
