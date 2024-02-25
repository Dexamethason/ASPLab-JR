using Microsoft.AspNetCore.Mvc;
using PhotoCRUD.Services.Interfaces;

namespace PhotoCRUD.Controllers.Api;

[ApiController]
[Route("api/v1/author")]
public class AuthorApiController : Controller
{
	private readonly IAuthorService _authorService;

	public AuthorApiController(IAuthorService authorService)
	{
		_authorService = authorService;
	}

	[HttpGet]
	public IActionResult GetAll()
	{
		return Ok(_authorService.GetAllAuthors());
	}

	[HttpGet("{id:int}")]
	public IActionResult GetByAuthorId(int id)
	{
		return Ok(_authorService.GetAuthor(id));
	}
}