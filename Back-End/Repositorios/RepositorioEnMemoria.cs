using System;
using System.Collections.Generic;
using System.Linq;
using Back_End.Entidades;

namespace Back_End.Repositorios
{
  public class RepositorioEnMemoria:IRepositorio
  {
    private List<Genero> _generos;

    public Guid _guid; //genera un string aleatorio con una estructura tipo 123456-DFHGF-FGFFD-DFR

    public RepositorioEnMemoria()
    {
      _generos = new List<Genero>()
      {
        new Genero(){ Id=1,Nombre="Comedia"},
        new Genero(){ Id=2,Nombre="Acción"}
      };

      _guid = Guid.NewGuid();
    }

    public void CrearGenero(Genero genero)
    {
      genero.Id = _generos.Count() + 1;
      _generos.Add(genero);
    }

    public Guid ObtenerGUID()
    {
      return _guid;
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
