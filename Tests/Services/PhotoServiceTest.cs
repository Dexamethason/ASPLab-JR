using Moq;
using PhotoCRUD.Models;
using PhotoCRUD.Services.Interfaces;

namespace Tests.Services;

public class PhotoServiceTests
{
	[Fact]
	public void GetAllPhotos_Calls_GetAllPhotos_Method_Once()
	{
		// Arrange
		var mockPhotoService = new Mock<IPhotoService>();

		// Act
		mockPhotoService.Object.GetAllPhotos();

		// Assert
		mockPhotoService.Verify(s => s.GetAllPhotos(), Times.Once);
	}

	[Fact]
	public void GetPhoto_Calls_GetPhoto_Method_Once()
	{
		// Arrange
		var mockPhotoService = new Mock<IPhotoService>();
		var photoId = 1;

		// Act
		mockPhotoService.Object.GetPhoto(photoId);

		// Assert
		mockPhotoService.Verify(s => s.GetPhoto(photoId), Times.Once);
	}

	[Fact]
	public void GetPhotoByAuthorId_Calls_GetPhotoByAuthorId_Method_Once()
	{
		// Arrange
		var mockPhotoService = new Mock<IPhotoService>();
		var authorId = 1;

		// Act
		mockPhotoService.Object.GetPhotoByAuthorId(authorId);

		// Assert
		mockPhotoService.Verify(s => s.GetPhotoByAuthorId(authorId), Times.Once);
	}

	[Fact]
	public void AddPhoto_Calls_AddPhoto_Method_Once()
	{
		// Arrange
		var mockPhotoService = new Mock<IPhotoService>();
		var photo = new Photo();

		// Act
		mockPhotoService.Object.AddPhoto(photo);

		// Assert
		mockPhotoService.Verify(s => s.AddPhoto(photo), Times.Once);
	}

	[Fact]
	public void DeletePhoto_Calls_DeletePhoto_Method_Once()
	{
		// Arrange
		var mockPhotoService = new Mock<IPhotoService>();
		var photoId = 1;

		// Act
		mockPhotoService.Object.DeletePhoto(photoId);

		// Assert
		mockPhotoService.Verify(s => s.DeletePhoto(photoId), Times.Once);
	}

	[Fact]
	public void EditPhoto_Calls_EditPhoto_Method_Once()
	{
		// Arrange
		var mockPhotoService = new Mock<IPhotoService>();
		var photo = new Photo();

		// Act
		mockPhotoService.Object.EditPhoto(photo);

		// Assert
		mockPhotoService.Verify(s => s.EditPhoto(photo), Times.Once);
	}
}