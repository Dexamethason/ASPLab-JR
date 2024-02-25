using Microsoft.AspNetCore.Mvc;
using PhotoCRUD.Models;
using PhotoCRUD.Services.Interfaces;

namespace PhotoCRUD.Controllers;

public class AuthorController : Controller
{
	private readonly IAddressService _addressService;
	private readonly IAuthorService _authorService;
	private readonly IPhotoService _photoService;

	public AuthorController(IAuthorService authorService, IPhotoService photoService, IAddressService addressService)
	{
		_authorService = authorService;
		_photoService = photoService;
		_addressService = addressService;
	}


	[HttpGet]
	public IActionResult Create()
	{
		var author = new Author();
		return View(author);
	}

	[HttpGet]
	public IActionResult Index()
	{
		return View(_authorService.GetAllAuthors());
	}

	[HttpPost]
	public IActionResult Create(Author author)
	{
		if (ModelState.IsValid)
		{
			_authorService.AddAuthor(author);
			return RedirectToAction("Index");
		}

		return View(author);
	}

	[HttpGet]
	public IActionResult Edit(int id)
	{
		var author = _authorService.GetAuthor(id);
		author.Photos = _photoService.GetPhotoByAuthorId(author.Id);
		author.Adresses = _addressService.GetAllAddressByAuthor(author.Id);
		return View(author);
	}

	[HttpPost]
	public IActionResult Edit(Author author)
	{
		if (ModelState.IsValid)
		{
			_authorService.EditAuthor(author);
			return RedirectToAction("Index");
		}

		return View(author);
	}

	[HttpGet]
	public IActionResult Delete(int id)
	{
		return View(_authorService.GetAuthor(id));
	}

	[HttpGet]
	public IActionResult DeleteAuthor(int id)
	{
		_authorService.DeleteAuthor(id);
		return RedirectToAction("Index");
	}

	public IActionResult Details(int id)
	{
		var author = _authorService.GetAuthor(id);
		author.Photos = _photoService.GetPhotoByAuthorId(author.Id);
		author.Adresses = _addressService.GetAllAddressByAuthor(author.Id);
		return View(author);
	}
}