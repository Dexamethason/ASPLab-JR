using Data.Models;
using PhotoCRUD.Mappers;
using PhotoCRUD.Models;

namespace Tests.Mappers;

public class PhotoMapperTests
{
	[Fact]
	public void FromEntity_Converts_Entity_To_Photo()
	{
		// Arrange
		var authorEntity = new AuthorEntity { Id = 1, FirstName = "John", Surname = "Doe" };
		var photoEntity = new PhotoEntity
		{
			Id = 1,
			DateTimeTaken = new DateTime(2022, 1, 1),
			Description = "Test Description",
			Camera = "Test Camera",
			AuthorEmail = "test@test.com",
			Resolution = "Test Resolution",
			Format = ".jpg",
			Author = authorEntity
		};

		// Act
		var photo = PhotoMapper.FromEntity(photoEntity);

		// Assert
		Assert.NotNull(photo);
		Assert.Equal(1, photo.Id);
		Assert.Equal(new DateTime(2022, 1, 1), photo.DateTimeTaken);
		Assert.Equal("Test Description", photo.Description);
		Assert.Equal("Test Camera", photo.Camera);
		Assert.Equal("test@test.com", photo.AuthorEmail);
		Assert.Equal("Test Resolution", photo.Resolution);
		Assert.Equal(".jpg", photo.Format);
		Assert.NotNull(photo.Author);
		Assert.Equal(1, photo.Author.Id);
		Assert.Equal("John", photo.Author.FirstName);
		Assert.Equal("Doe", photo.Author.Surname);
	}

	[Fact]
	public void ToEntity_Converts_Photo_To_Entity()
	{
		// Arrange
		var photo = new Photo
		{
			Id = 1,
			DateTimeTaken = new DateTime(2022, 1, 1),
			Description = "Test Description",
			Camera = "Test Camera",
			AuthorEmail = "test@test.com",
			Resolution = "Test Resolution",
			Format = ".jpg"
		};

		// Act
		var photoEntity = PhotoMapper.ToEntity(photo);

		// Assert
		Assert.NotNull(photoEntity);
		Assert.Equal(1, photoEntity.Id);
		Assert.Equal(new DateTime(2022, 1, 1), photoEntity.DateTimeTaken);
		Assert.Equal("Test Description", photoEntity.Description);
		Assert.Equal("Test Camera", photoEntity.Camera);
		Assert.Equal("test@test.com", photoEntity.AuthorEmail);
		Assert.Equal("Test Resolution", photoEntity.Resolution);
		Assert.Equal(".jpg", photoEntity.Format);
	}
}