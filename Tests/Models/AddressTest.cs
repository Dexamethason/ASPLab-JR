using System.ComponentModel.DataAnnotations;
using PhotoCRUD.Models;
using PhotoCRUD.Models.Enums;

namespace Tests.Models;

public class AddressValidationTests
{
	[Fact]
	public void Street_WhenNotProvided_ShouldHaveRequiredErrorMessage()
	{
		// Arrange
		var address = new Address
			{ City = new string('a', 100), Country = CountryEnum.Austria, HouseNumber = "aaa", PostalCode = "13-123" };

		// Act
		var validationContext = new ValidationContext(address);
		var validationResults = new List<ValidationResult>();
		var isValid = Validator.TryValidateObject(address, validationContext, validationResults, true);

		// Assert
		Assert.False(isValid);
		var validationResult = Assert.Single(validationResults);
		Assert.Equal("Ulica jest wymagana.", validationResult.ErrorMessage);
		Assert.Equal("Street", validationResult.MemberNames.Single());
	}

	[Fact]
	public void Street_WhenExceedingMaxLength_ShouldHaveStringLengthErrorMessage()
	{
		// Arrange
		var address = new Address
		{
			Street = new string('a', 101), City = new string('a', 100), Country = CountryEnum.Austria,
			HouseNumber = "aaa", PostalCode = "13-123"
		};

		// Act
		var validationContext = new ValidationContext(address);
		var validationResults = new List<ValidationResult>();
		var isValid = Validator.TryValidateObject(address, validationContext, validationResults, true);

		// Assert
		Assert.False(isValid);
		var validationResult = Assert.Single(validationResults);
		Assert.Equal("Zbyt duża ilość znaków!", validationResult.ErrorMessage);
		Assert.Equal("Street", validationResult.MemberNames.Single());
	}

	[Fact]
	public void HouseNumber_WhenNotProvided_ShouldHaveRequiredErrorMessage()
	{
		// Arrange
		var address = new Address
		{
			Street = new string('a', 100), PostalCode = "12-345", City = new string('a', 100),
			Country = CountryEnum.Austria
		};

		// Act
		var validationContext = new ValidationContext(address);
		var validationResults = new List<ValidationResult>();
		var isValid = Validator.TryValidateObject(address, validationContext, validationResults, true);

		// Assert
		Assert.False(isValid);
		var validationResult = Assert.Single(validationResults);
		Assert.Equal("Numer domu jest wymagany.", validationResult.ErrorMessage);
		Assert.Equal("HouseNumber", validationResult.MemberNames.Single());
	}

	[Fact]
	public void PostalCode_WhenNotProvided_ShouldHaveRequiredErrorMessage()
	{
		// Arrange
		var address = new Address
		{
			Street = new string('a', 100), City = new string('a', 100), Country = CountryEnum.Austria,
			HouseNumber = "aaa"
		};

		// Act
		var validationContext = new ValidationContext(address);
		var validationResults = new List<ValidationResult>();
		var isValid = Validator.TryValidateObject(address, validationContext, validationResults, true);

		// Assert
		Assert.False(isValid);
		var validationResult = Assert.Single(validationResults);
		Assert.Equal("Kod pocztowy jest wymagany.", validationResult.ErrorMessage);
		Assert.Equal("PostalCode", validationResult.MemberNames.Single());
	}

	[Fact]
	public void PostalCode_WhenInvalidFormat_ShouldHaveRegularExpressionErrorMessage()
	{
		// Arrange
		var address = new Address
		{
			PostalCode = "12345", Street = new string('a', 100), City = new string('a', 100),
			Country = CountryEnum.Austria, HouseNumber = "aaa"
		};

		// Act
		var validationContext = new ValidationContext(address);
		var validationResults = new List<ValidationResult>();
		var isValid = Validator.TryValidateObject(address, validationContext, validationResults, true);

		// Assert
		Assert.False(isValid);
		var validationResult = Assert.Single(validationResults);
		Assert.Equal("Kod pocztowy musi być w formacie XX-XXX, gdzie X to cyfra.", validationResult.ErrorMessage);
		Assert.Equal("PostalCode", validationResult.MemberNames.Single());
	}

	[Fact]
	public void City_WhenNotProvided_ShouldHaveRequiredErrorMessage()
	{
		// Arrange
		var address = new Address
		{
			Street = new string('a', 100), Country = CountryEnum.Austria, HouseNumber = "aaa", PostalCode = "13-123"
		};

		// Act
		var validationContext = new ValidationContext(address);
		var validationResults = new List<ValidationResult>();
		var isValid = Validator.TryValidateObject(address, validationContext, validationResults, true);

		// Assert
		Assert.False(isValid);
		var validationResult = Assert.Single(validationResults);
		Assert.Equal("Miasto jest wymagane.", validationResult.ErrorMessage);
		Assert.Equal("City", validationResult.MemberNames.Single());
	}

	[Fact]
	public void City_WhenExceedingMaxLength_ShouldHaveStringLengthErrorMessage()
	{
		// Arrange
		var address = new Address
		{
			City = new string('a', 101), Street = new string('a', 100), Country = CountryEnum.Austria,
			HouseNumber = "aaa", PostalCode = "13-123"
		};

		// Act
		var validationContext = new ValidationContext(address);
		var validationResults = new List<ValidationResult>();
		var isValid = Validator.TryValidateObject(address, validationContext, validationResults, true);

		// Assert
		Assert.False(isValid);
		var validationResult = Assert.Single(validationResults);
		Assert.Equal("Zbyt duża ilość znaków!", validationResult.ErrorMessage);
		Assert.Equal("City", validationResult.MemberNames.Single());
	}
}