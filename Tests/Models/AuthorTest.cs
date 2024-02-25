using System.ComponentModel.DataAnnotations;
using PhotoCRUD.Models;

namespace Tests.Models;

public class AuthorValidationTests
{
	[Fact]
	public void FirstName_WhenNotProvided_ShouldHaveRequiredErrorMessage()
	{
		// Arrange
		var author = new Author { Surname = "bbb" }; // Not providing FirstName

		// Act
		var validationContext = new ValidationContext(author);
		var validationResults = new List<ValidationResult>();
		var isValid = Validator.TryValidateObject(author, validationContext, validationResults, true);

		// Assert
		Assert.False(isValid);
		var validationResult = Assert.Single(validationResults);
		Assert.Equal("Pole 'Imię' nie może być puste!", validationResult.ErrorMessage);
		Assert.Equal("FirstName", validationResult.MemberNames.Single());
	}

	[Fact]
	public void FirstName_WhenExceedingMaxLength_ShouldHaveStringLengthErrorMessage()
	{
		// Arrange
		var author = new Author { FirstName = new string('a', 31), Surname = "bbb" }; // Exceeding max length

		// Act
		var validationContext = new ValidationContext(author);
		var validationResults = new List<ValidationResult>();
		var isValid = Validator.TryValidateObject(author, validationContext, validationResults, true);

		// Assert
		Assert.False(isValid);
		var validationResult = Assert.Single(validationResults);
		Assert.Equal("Zbyt duża ilość znaków!", validationResult.ErrorMessage);
		Assert.Equal("FirstName", validationResult.MemberNames.Single());
	}

	[Fact]
	public void Surname_WhenNotProvided_ShouldHaveRequiredErrorMessage()
	{
		// Arrange
		var author = new Author { FirstName = "aaa" }; // Not providing Surname

		// Act
		var validationContext = new ValidationContext(author);
		var validationResults = new List<ValidationResult>();
		var isValid = Validator.TryValidateObject(author, validationContext, validationResults, true);

		// Assert
		Assert.False(isValid);
		var validationResult = Assert.Single(validationResults);
		Assert.Equal("Pole 'Nazwisko' nie może być puste!", validationResult.ErrorMessage);
		Assert.Equal("Surname", validationResult.MemberNames.Single());
	}

	[Fact]
	public void Surname_WhenExceedingMaxLength_ShouldHaveStringLengthErrorMessage()
	{
		// Arrange
		var author = new Author { FirstName = "aaa", Surname = new string('a', 51) }; // Exceeding max length

		// Act
		var validationContext = new ValidationContext(author);
		var validationResults = new List<ValidationResult>();
		var isValid = Validator.TryValidateObject(author, validationContext, validationResults, true);

		// Assert
		Assert.False(isValid);
		var validationResult = Assert.Single(validationResults);
		Assert.Equal("Zbyt duża ilość znaków!", validationResult.ErrorMessage);
		Assert.Equal("Surname", validationResult.MemberNames.Single());
	}
}