using System.ComponentModel.DataAnnotations;

namespace Data.Models.Enums;

public enum CountryEnum
{
	[Display(Name = "Polska")] Poland = 1,
	[Display(Name = "Niemcy")] Germany = 2,
	[Display(Name = "Austria")] Austria = 3,
	[Display(Name = "Czechy")] ChechRepublic = 4,
	[Display(Name = "Słowacja")] Slovakia = 5,
	[Display(Name = "Ukraina")] Ukraine = 6
}