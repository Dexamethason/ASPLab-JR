using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace PhotoCRUD.Models.Enums;

public enum CountryEnum
{
	[Display(Name = "Polska")] Poland = 1,
	[Display(Name = "Niemcy")] Germany = 2,
	[Display(Name = "Austria")] Austria = 3,
	[Display(Name = "Czechy")] ChechRepublic = 4,
	[Display(Name = "Słowacja")] Slovakia = 5,
	[Display(Name = "Ukraina")] Ukraine = 6,
	[Display(Name = "Anglia")] UK = 7,
	[Display(Name = "Francja")] France = 8
}