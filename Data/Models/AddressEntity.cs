using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Data.Models.Enums;

namespace Data.Models;

public class AddressEntity
{
	[Key] public int id { get; set; }

	[Required] [MaxLength(100)] public string Street { get; set; }

	[Required] public string HouseNumber { get; set; }

	[Required] public string PostalCode { get; set; }

	[Required] [MaxLength(100)] public string City { get; set; }

	[Required] public CountryEnum Country { get; set; }

	[ForeignKey("Author")] public int AuthorId { get; set; }

	public AuthorEntity Author { get; set; }
}