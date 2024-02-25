using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using PhotoCRUD.Models.Enums;

namespace PhotoCRUD.Models;

public class Address
{
	[HiddenInput] public int Id { get; set; }

	[Required(ErrorMessage = "Ulica jest wymagana.")]
	[StringLength(100, ErrorMessage = "Zbyt duża ilość znaków!")]
	[Display(Name = "Ulica")]
	public string Street { get; set; }

	[Required(ErrorMessage = "Numer domu jest wymagany.")]
	[Display(Name = "Numer domu/mieszkania")]
	public string HouseNumber { get; set; }

	[Required(ErrorMessage = "Kod pocztowy jest wymagany.")]
	[RegularExpression(@"^\d{2}-\d{3}$", ErrorMessage = "Kod pocztowy musi być w formacie XX-XXX, gdzie X to cyfra.")]
	[Display(Name = "Kod pocztowy")]
	public string PostalCode { get; set; }

	[Required(ErrorMessage = "Miasto jest wymagane.")]
	[StringLength(100, ErrorMessage = "Zbyt duża ilość znaków!")]
	[Display(Name = "Miasto")]
	public string City { get; set; }

	[Required(ErrorMessage = "Kraj jest wymagany.")]
	[Display(Name = "Kraj")]
	public CountryEnum Country { get; set; }
}