using Data.Models;
using Data.Models.Enums;
using PhotoCRUD.Mappers;
using PhotoCRUD.Models;

namespace Tests.Mappers;

public class AddressMapperTests
{
	[Fact]
	public void FromEntity_Converts_Entity_To_Address()
	{
		// Arrange
		var addressEntity = new AddressEntity
		{
			id = 1,
			Street = "Street",
			HouseNumber = "123",
			PostalCode = "12345",
			City = "City",
			Country = (CountryEnum)PhotoCRUD.Models.Enums.CountryEnum.Poland
		};

		// Act
		var address = AddressMapper.FromEntity(addressEntity);

		// Assert
		Assert.NotNull(address);
		Assert.Equal(1, address.Id);
		Assert.Equal("Street", address.Street);
		Assert.Equal("123", address.HouseNumber);
		Assert.Equal("12345", address.PostalCode);
		Assert.Equal("City", address.City);
		Assert.Equal(PhotoCRUD.Models.Enums.CountryEnum.Poland, address.Country);
	}

	[Fact]
	public void ToEntity_Converts_Address_To_Entity()
	{
		// Arrange
		var address = new Address
		{
			Id = 1,
			Street = "Street",
			HouseNumber = "123",
			PostalCode = "12345",
			City = "City",
			Country = PhotoCRUD.Models.Enums.CountryEnum.Poland
		};

		// Act
		var addressEntity = AddressMapper.ToEntity(address);

		// Assert
		Assert.NotNull(addressEntity);
		Assert.Equal(1, addressEntity.id);
		Assert.Equal("Street", addressEntity.Street);
		Assert.Equal("123", addressEntity.HouseNumber);
		Assert.Equal("12345", addressEntity.PostalCode);
		Assert.Equal("City", addressEntity.City);
		Assert.Equal(CountryEnum.Poland, addressEntity.Country);
	}
}