using System.ComponentModel.DataAnnotations;
using PhotoCRUD.Models;

namespace Tests.Models;

public class PhotoTests
{
	[Fact]
	public void Description_WhenExceedingMaxLength_ShouldHaveStringLengthErrorMessage()
	{
		// Arrange
		var photo = new Photo
		{
			Description = new string('a', 501), Camera = "Camera", Format = ".jpg", Resolution = "300x200",
			AuthorEmail = "adres@mail.com", DateTimeTaken = DateTime.Now
		};

		// Act
		var validationContext = new ValidationContext(photo);
		var validationResults = new List<ValidationResult>();
		var isValid = Validator.TryValidateObject(photo, validationContext, validationResults, true);

		// Assert
		Assert.False(isValid);
		var validationResult = Assert.Single(validationResults);
		Assert.Equal("Opis może mieć maksymalnie 500 znaków.", validationResult.ErrorMessage);
		Assert.Equal("Description", validationResult.MemberNames.Single());
	}

	[Fact]
	public void Camera_WhenNotProvided_ShouldHaveRequiredErrorMessage()
	{
		// Arrange
		var photo = new Photo
		{
			Description = new string('a', 500), Format = ".jpg", Resolution = "300x200", AuthorEmail = "adres@mail.com",
			DateTimeTaken = DateTime.Now
		};

		// Act
		var validationContext = new ValidationContext(photo);
		var validationResults = new List<ValidationResult>();
		var isValid = Validator.TryValidateObject(photo, validationContext, validationResults, true);

		// Assert
		Assert.False(isValid);
		var validationResult = Assert.Single(validationResults);
		Assert.Equal("Model aparatu jest wymagany.", validationResult.ErrorMessage);
		Assert.Equal("Camera", validationResult.MemberNames.Single());
	}

	[Fact]
	public void AuthorEmail_WhenInvalidFormat_ShouldHaveEmailAddressErrorMessage()
	{
		// Arrange
		var photo = new Photo
		{
			Description = new string('a', 500), Camera = "Camera", Format = ".jpg", Resolution = "300x200",
			DateTimeTaken = DateTime.Now, AuthorEmail = "invalidemail"
		};

		// Act
		var validationContext = new ValidationContext(photo);
		var validationResults = new List<ValidationResult>();
		var isValid = Validator.TryValidateObject(photo, validationContext, validationResults, true);

		// Assert
		Assert.False(isValid);
		var validationResult = Assert.Single(validationResults);
		Assert.Equal("Nieprawidłowy format adresu e-mail.", validationResult.ErrorMessage);
		Assert.Equal("AuthorEmail", validationResult.MemberNames.Single());
	}

	[Fact]
	public void Resolution_WhenInvalidFormat_ShouldHaveRegularExpressionErrorMessage()
	{
		// Arrange
		var photo = new Photo
		{
			Description = new string('a', 500), Camera = "Camera", Format = ".jpg", AuthorEmail = "adres@mail.com",
			DateTimeTaken = DateTime.Now, Resolution = "invalid_resolution"
		};

		// Act
		var validationContext = new ValidationContext(photo);
		var validationResults = new List<ValidationResult>();
		var isValid = Validator.TryValidateObject(photo, validationContext, validationResults, true);

		// Assert
		Assert.False(isValid);
		var validationResult = Assert.Single(validationResults);
		Assert.Equal("Rozdzielczość musi być w formacie 'szerokość x wysokość', gdzie obie wartości są liczbami.",
			validationResult.ErrorMessage);
		Assert.Equal("Resolution", validationResult.MemberNames.Single());
	}
}