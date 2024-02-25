using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;

namespace PhotoCRUD.Models;

public class Author
{
	[HiddenInput] public int Id { get; set; }

	[Required(ErrorMessage = "Pole 'Imię' nie może być puste!")]
	[StringLength(30, ErrorMessage = "Zbyt duża ilość znaków!")]
	[Display(Name = "Imie")]
	public string FirstName { get; set; }

	[Required(ErrorMessage = "Pole 'Nazwisko' nie może być puste!")]
	[StringLength(50, ErrorMessage = "Zbyt duża ilość znaków!")]
	[Display(Name = "Nazwisko")]
	public string Surname { get; set; }

	public List<Photo>? Photos { get; set; }

	public List<Address>? Adresses { get; set; }
}