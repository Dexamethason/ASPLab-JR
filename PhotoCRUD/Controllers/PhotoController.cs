using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PhotoCRUD.Models;
using PhotoCRUD.Services.Interfaces;

namespace PhotoCRUD.Controllers;

[Authorize]
public class PhotoController : Controller
{
	private readonly IPhotoService _photoService;

	public PhotoController(IPhotoService photoService)
	{
		_photoService = photoService;
	}


	[HttpGet]
	public IActionResult Create()
	{
		var photo = new Photo();
		return View(photo);
	}


	[AllowAnonymous]
	[HttpGet]
	public IActionResult Index()
	{
		return View(_photoService.GetAllPhotos());
	}

	[HttpPost]
	public IActionResult Create(Photo photo)
	{
		if (ModelState.IsValid)
		{
			_photoService.AddPhoto(photo);
			return RedirectToAction("Index");
		}

		return View(photo);
	}

	[HttpGet]
	public IActionResult Edit(int id)
	{
		var photo = _photoService.GetPhoto(id);
		return View(_photoService.GetPhoto(id));
	}

	[HttpPost]
	public IActionResult Edit(Photo photo)
	{
		if (ModelState.IsValid)
		{
			_photoService.EditPhoto(photo);
			return RedirectToAction("Index");
		}

		return View(photo);
	}

	[HttpGet]
	public IActionResult Delete(int id)
	{
		return View(_photoService.GetPhoto(id));
	}

	[HttpGet]
	public IActionResult DeletePhoto(int id)
	{
		_photoService.DeletePhoto(id);
		return RedirectToAction("Index");
	}

	public IActionResult Details(int id)
	{
		return View(_photoService.GetPhoto(id));
	}
}