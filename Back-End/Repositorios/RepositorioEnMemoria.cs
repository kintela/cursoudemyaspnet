﻿using System;
using System.Collections.Generic;
using System.Linq;
using Back_End.Entidades;

namespace Back_End.Repositorios
{
  public class RepositorioEnMemoria:IRepositorio
  {
    private List<Genero> _generos;

    public RepositorioEnMemoria()
    {
      _generos = new List<Genero>()
      {
        new Genero(){ Id=1,Nombre="Comedia"},
        new Genero(){ Id=2,Nombre="Acción"}
      };
    }

    public List<Genero> ObtenerTodosLosGeneros()
    {
      return _generos;
    }

    public Genero ObtenerPorId(int id)
    {
      return _generos.FirstOrDefault(x => x.Id == id);
    }
  }
}
