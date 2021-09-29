using System;
using System.Collections.Generic;
using Back_End.Entidades;

namespace Back_End.Repositorios
{
  public interface IRepositorio
  {
		void CrearGenero(Genero genero);
		Guid ObtenerGUID();
		Genero ObtenerPorId(int id);
		List<Genero> ObtenerTodosLosGeneros();
  }
}
