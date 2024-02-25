using Data.Models;
using PhotoCRUD.Models;

namespace PhotoCRUD.Mappers;

public static class AuthorMapper
{
	public static Author FromEntity(AuthorEntity entity)
	{
		if (entity == null) return null;
		return new Author
		{
			Id = entity.Id,
			FirstName = entity.FirstName,
			Surname = entity.Surname,
			Adresses = entity.Address != null ? entity.Address!.Select(x => AddressMapper.FromEntity(x)).ToList() : null
		};
	}

	public static AuthorEntity ToEntity(Author entity)
	{
		return new AuthorEntity
		{
			Id = entity.Id,
			FirstName = entity.FirstName,
			Surname = entity.Surname,
			Address = entity.Adresses != null ? entity.Adresses!.Select(x => AddressMapper.ToEntity(x)).ToList() : null
		};
	}
}