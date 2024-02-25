using Data.Models;
using Data.Models.Enums;
using PhotoCRUD.Mappers;
using PhotoCRUD.Models;

namespace Tests.Mappers;

public class AuthorMapperTests
{
	[Fact]
	public void FromEntity_Converts_Entity_To_Author()
	{
		// Arrange
		var addressEntity1 = new AddressEntity
		{
			id = 1, Street = "Street 1", HouseNumber = "123", PostalCode = "12345", City = "City 1",
			Country = CountryEnum.Poland
		};
		var addressEntity2 = new AddressEntity
		{
			id = 2, Street = "Street 2", HouseNumber = "456", PostalCode = "54321", City = "City 2",
			Country = CountryEnum.Poland
		};
		var authorEntity = new AuthorEntity
		{
			Id = 1,
			FirstName = "John",
			Surname = "Doe",
			Address = new List<AddressEntity> { addressEntity1, addressEntity2 }
		};

		// Act
		var author = AuthorMapper.FromEntity(authorEntity);

		// Assert
		Assert.NotNull(author);
		Assert.Equal(1, author.Id);
		Assert.Equal("John", author.FirstName);
		Assert.Equal("Doe", author.Surname);
		Assert.Equal(2, author.Adresses.Count);
		Assert.Equal("Street 1", author.Adresses[0].Street);
		Assert.Equal("Street 2", author.Adresses[1].Street);
	}

	[Fact]
	public void ToEntity_Converts_Author_To_Entity()
	{
		// Arrange
		var address1 = new Address
		{
			Id = 1, Street = "Street 1", HouseNumber = "123", PostalCode = "12345", City = "City 1",
			Country = PhotoCRUD.Models.Enums.CountryEnum.Poland
		};
		var address2 = new Address
		{
			Id = 2, Street = "Street 2", HouseNumber = "456", PostalCode = "54321", City = "City 2",
			Country = PhotoCRUD.Models.Enums.CountryEnum.Poland
		};
		var author = new Author
		{
			Id = 1,
			FirstName = "John",
			Surname = "Doe",
			Adresses = new List<Address> { address1, address2 }
		};

		// Act
		var authorEntity = AuthorMapper.ToEntity(author);

		// Assert
		Assert.NotNull(authorEntity);
		Assert.Equal(1, authorEntity.Id);
		Assert.Equal("John", authorEntity.FirstName);
		Assert.Equal("Doe", authorEntity.Surname);
		Assert.Equal(2, authorEntity.Address.Count);
		Assert.Equal("Street 1", authorEntity.Address[0].Street);
		Assert.Equal("Street 2", authorEntity.Address[1].Street);
	}
}