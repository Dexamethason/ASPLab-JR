using Microsoft.AspNetCore.Mvc;
using PhotoCRUD.Services.Interfaces;

namespace PhotoCRUD.Controllers.Api;

[ApiController]
[Route("api/v1/address")]
public class AddressApiController : Controller
{
	private readonly IAddressService _addressService;

	public AddressApiController(IAddressService addressService)
	{
		_addressService = addressService;
	}

	[HttpGet]
	public IActionResult GetAll()
	{
		return Ok(_addressService.GetAllAddress());
	}

	[HttpGet("{id:int}")]
	public IActionResult GetByAuthorId(int id)
	{
		return Ok(_addressService.GetAllAddressByAuthor(id));
	}
}