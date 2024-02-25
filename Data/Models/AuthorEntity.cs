using System.ComponentModel.DataAnnotations;

namespace Data.Models;

public class AuthorEntity
{
	[Key] public int Id { get; set; }

	[Required] [MaxLength(30)] public string FirstName { get; set; }

	[Required] [MaxLength(50)] public string Surname { get; set; }

	public List<AddressEntity>? Address { get; set; }
}