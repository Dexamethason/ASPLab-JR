using Moq;
using PhotoCRUD.Models;
using PhotoCRUD.Services.Interfaces;

namespace Tests.Services;

public class AuthorServiceTests
{
	[Fact]
	public void GetAllAuthors_Calls_GetAllAuthors_Method_Once()
	{
		// Arrange
		var mockAuthorService = new Mock<IAuthorService>();

		// Act
		mockAuthorService.Object.GetAllAuthors();

		// Assert
		mockAuthorService.Verify(s => s.GetAllAuthors(), Times.Once);
	}

	[Fact]
	public void GetAuthor_Calls_GetAuthor_Method_Once()
	{
		// Arrange
		var mockAuthorService = new Mock<IAuthorService>();
		var authorId = 1;

		// Act
		mockAuthorService.Object.GetAuthor(authorId);

		// Assert
		mockAuthorService.Verify(s => s.GetAuthor(authorId), Times.Once);
	}

	[Fact]
	public void AddAuthor_Calls_AddAuthor_Method_Once()
	{
		// Arrange
		var mockAuthorService = new Mock<IAuthorService>();
		var author = new Author();

		// Act
		mockAuthorService.Object.AddAuthor(author);

		// Assert
		mockAuthorService.Verify(s => s.AddAuthor(author), Times.Once);
	}

	[Fact]
	public void DeleteAuthor_Calls_DeleteAuthor_Method_Once()
	{
		// Arrange
		var mockAuthorService = new Mock<IAuthorService>();
		var authorId = 1;

		// Act
		mockAuthorService.Object.DeleteAuthor(authorId);

		// Assert
		mockAuthorService.Verify(s => s.DeleteAuthor(authorId), Times.Once);
	}

	[Fact]
	public void EditAuthor_Calls_EditAuthor_Method_Once()
	{
		// Arrange
		var mockAuthorService = new Mock<IAuthorService>();
		var author = new Author();

		// Act
		mockAuthorService.Object.EditAuthor(author);

		// Assert
		mockAuthorService.Verify(s => s.EditAuthor(author), Times.Once);
	}
}