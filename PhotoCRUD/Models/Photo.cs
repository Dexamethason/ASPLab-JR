using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;

namespace PhotoCRUD.Models;

public class Photo
{
	[Required] [HiddenInput] public int Id { get; set; }

	[Required(ErrorMessage = "Data i godzina wykonania są wymagane.")]
	[Display(Name = "Data i godzina wykonania")]
	[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy HH:mm}", ApplyFormatInEditMode = true)]
	public DateTime DateTimeTaken { get; set; }

	[Required(ErrorMessage = "Opis jest wymagany.")]
	[StringLength(500, ErrorMessage = "Opis może mieć maksymalnie 500 znaków.")]
	[Display(Name = "Opis zdjęcia")]
	public string Description { get; set; }

	[Required(ErrorMessage = "Model aparatu jest wymagany.")]
	[Display(Name = "Model aparatu")]
	public string Camera { get; set; }

	[Required(ErrorMessage = "E-mail autora jest wymagany.")]
	[EmailAddress(ErrorMessage = "Nieprawidłowy format adresu e-mail.")]
	[Display(Name = "E-mail autora")]
	public string AuthorEmail { get; set; }

	[Required(ErrorMessage = "Rozdzielczość jest wymagana.")]
	[RegularExpression(@"^\d+x\d+$",
		ErrorMessage = "Rozdzielczość musi być w formacie 'szerokość x wysokość', gdzie obie wartości są liczbami.")]
	[Display(Name = "Rozdzielczość zdjęcia")]
	public string Resolution { get; set; }

	[Required(ErrorMessage = "Format pliku jest wymagany.")]
	[RegularExpression(@"^(.png|.jpg|.jpeg)$",
		ErrorMessage = "Nieobsługiwany format pliku. Dozwolone formaty to: .png, .jpg, .jpeg")]
	[Display(Name = "Format pliku")]
	public string Format { get; set; }

	[ValidateNever] public Author Author { get; set; }
}