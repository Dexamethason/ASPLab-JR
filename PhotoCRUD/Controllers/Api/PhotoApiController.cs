using Microsoft.AspNetCore.Mvc;
using PhotoCRUD.Services.Interfaces;

namespace PhotoCRUD.Controllers.Api;

[ApiController]
[Route("api/v1/photo")]
public class PhotoApiController : Controller
{
	private readonly IPhotoService _photoService;

	public PhotoApiController(IPhotoService photoService)
	{
		_photoService = photoService;
	}

	[HttpGet]
	public IActionResult GetAll()
	{
		return Ok(_photoService.GetAllPhotos());
	}

	[HttpGet("{id:int}")]
	public IActionResult GetByAuthorId(int id)
	{
		return Ok(_photoService.GetPhotoByAuthorId(id));
	}
}