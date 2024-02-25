using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using PhotoCRUD.Models;
using PhotoCRUD.Services.Interfaces;

namespace PhotoCRUD.Controllers;

[Authorize]
public class AddressController : Controller
{
	private readonly IAddressService _addressService;

	public AddressController(IAddressService addressService)
	{
		_addressService = addressService;
	}


	[HttpGet]
	public IActionResult Create()
	{
		var address = new Address();
		return View(address);
	}


	[AllowAnonymous]
	[HttpGet]
	public IActionResult Index()
	{
		return View(_addressService.GetAllAddress());
	}

	[HttpPost]
	public IActionResult Create(Address address)
	{
		if (ModelState.IsValid)
		{
			_addressService.AddAddress(address);
			return RedirectToAction("Index");
		}

		return View(address);
	}

	[HttpGet]
	public IActionResult Edit(int id)
	{
		return View(_addressService.GetAddress(id));
	}

	[HttpPost]
	public IActionResult Edit(Address address)
	{
		if (ModelState.IsValid)
		{
			_addressService.EditAddress(address);
			return RedirectToAction("Index");
		}

		return View(address);
	}

	[HttpGet]
	public IActionResult Delete(int id)
	{
		return View(_addressService.GetAddress(id));
	}

	[HttpGet]
	public IActionResult DeleteAddress(int id)
	{
		_addressService.DeleteAddress(id);
		return RedirectToAction("Index");
	}

	public IActionResult Details(int id)
	{
		return View(_addressService.GetAddress(id));
	}
}