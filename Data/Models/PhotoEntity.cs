using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Data.Models;

public class PhotoEntity
{
	[Required] [Key] public int Id { get; set; }

	[Required] [Column("taken_date")] public DateTime DateTimeTaken { get; set; }

	[Required] [MaxLength(500)] public string Description { get; set; }

	[Required] public string Camera { get; set; }

	[Required] public string AuthorEmail { get; set; }

	[Required] public string Resolution { get; set; }

	[Required] public string Format { get; set; }

	[ForeignKey("Author")] public int? AuthorId { get; set; }

	public AuthorEntity? Author { get; set; }
}