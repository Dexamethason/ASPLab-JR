using Data.Models;
using PhotoCRUD.Models;

namespace PhotoCRUD.Mappers;

public static class PhotoMapper
{
	public static Photo FromEntity(PhotoEntity entity)
	{
		return new Photo
		{
			Id = entity.Id,
			DateTimeTaken = entity.DateTimeTaken,
			Description = entity.Description,
			Camera = entity.Camera,
			AuthorEmail = entity.AuthorEmail,
			Resolution = entity.Resolution,
			Format = entity.Format,
			Author = entity.Author != null ? AuthorMapper.FromEntity(entity.Author) : null
		};
	}

	public static PhotoEntity ToEntity(Photo entity)
	{
		return new PhotoEntity
		{
			Id = entity.Id,
			DateTimeTaken = entity.DateTimeTaken,
			Description = entity.Description,
			Camera = entity.Camera,
			AuthorEmail = entity.AuthorEmail,
			Resolution = entity.Resolution,
			Format = entity.Format,
			Author = entity.Author != null ? AuthorMapper.ToEntity(entity.Author) : null
		};
	}
}