using AutoMapper;
using Back_End.DTOs;
using Back_End.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Back_End.Utilidades
{
	public class AutoMapperProfiles:Profile
	{
		public AutoMapperProfiles()
		{
			CreateMap<Genero, GeneroDTO>().ReverseMap();
			CreateMap<GeneroDTO, Genero>();
		}
	}
}
