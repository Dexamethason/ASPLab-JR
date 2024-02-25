using Moq;
using PhotoCRUD.Models;
using PhotoCRUD.Services.Interfaces;

namespace Tests.Services;

public class AddressServiceTests
{
	[Fact]
	public void AddAddress_Calls_AddAddress_Method_Once()
	{
		// Arrange
		var mockAddressService = new Mock<IAddressService>();
		var address = new Address();

		// Act
		mockAddressService.Object.AddAddress(address);

		// Assert
		mockAddressService.Verify(s => s.AddAddress(address), Times.Once);
	}

	[Fact]
	public void DeleteAddress_Calls_DeleteAddress_Method_Once()
	{
		// Arrange
		var mockAddressService = new Mock<IAddressService>();
		var addressId = 1;

		// Act
		mockAddressService.Object.DeleteAddress(addressId);

		// Assert
		mockAddressService.Verify(s => s.DeleteAddress(addressId), Times.Once);
	}

	[Fact]
	public void EditAddress_Calls_EditAddress_Method_Once()
	{
		// Arrange
		var mockAddressService = new Mock<IAddressService>();
		var address = new Address();

		// Act
		mockAddressService.Object.EditAddress(address);

		// Assert
		mockAddressService.Verify(s => s.EditAddress(address), Times.Once);
	}

	[Fact]
	public void GetAllAddress_Calls_GetAllAddress_Method_Once()
	{
		// Arrange
		var mockAddressService = new Mock<IAddressService>();

		// Act
		mockAddressService.Object.GetAllAddress();

		// Assert
		mockAddressService.Verify(s => s.GetAllAddress(), Times.Once);
	}

	[Fact]
	public void GetAddress_Calls_GetAddress_Method_Once()
	{
		// Arrange
		var mockAddressService = new Mock<IAddressService>();
		var addressId = 1;

		// Act
		mockAddressService.Object.GetAddress(addressId);

		// Assert
		mockAddressService.Verify(s => s.GetAddress(addressId), Times.Once);
	}
}