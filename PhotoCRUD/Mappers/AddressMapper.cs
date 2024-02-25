using Data.Models;
using PhotoCRUD.Models;
using PhotoCRUD.Models.Enums;

namespace PhotoCRUD.Mappers;

public static class AddressMapper
{
	public static Address FromEntity(AddressEntity entity)
	{
		return new Address
		{
			Id = entity.id,
			Street = entity.Street,
			HouseNumber = entity.HouseNumber,
			PostalCode = entity.PostalCode,
			City = entity.City,
			Country = (CountryEnum)(int)entity.Country
		};
	}

	public static AddressEntity ToEntity(Address entity)
	{
		return new AddressEntity
		{
			id = entity.Id,
			Street = entity.Street,
			HouseNumber = entity.HouseNumber,
			PostalCode = entity.PostalCode,
			City = entity.City,
			Country = (Data.Models.Enums.CountryEnum)entity.Country
		};
	}
}