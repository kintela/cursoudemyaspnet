using Back_End.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Back_End.Entidades
{
  public class Genero:IValidatableObject
  {
      public int Id { get; set; }
      [Required(ErrorMessage ="El campo {0} es obligatorio")]
      [StringLength(maximumLength:10)]
      //[PrimeraLetraMayuscula]
      public string Nombre  { get; set; }

		public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
		{
			if (!string.IsNullOrEmpty(Nombre))
			{
				var primeraLetra = Nombre[0].ToString();

				if (primeraLetra!=primeraLetra.ToUpper())
				{
					yield return new ValidationResult("Lsa primera letra debe ser mayuscula", new string[] { nameof(Nombre)});
				}
			}
		}
	}
}
