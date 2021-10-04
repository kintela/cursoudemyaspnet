using Back_End.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Back_End.DTOs
{
	public class GeneroCreacionDTO
	{
		[Required(ErrorMessage = "El campo {0} es obligatorio")]
		[StringLength(maximumLength: 50)]
		[PrimeraLetraMayuscula]
		public string Nombre { get; set; }
	}
}
