using Data;
using Data.Models.Enums;
using PhotoCRUD.Mappers;
using PhotoCRUD.Models;
using PhotoCRUD.Services.Interfaces;

namespace PhotoCRUD.Services;

public class AddressService : IAddressService
{
	private readonly AppDbContext _dbContext;

	public AddressService(AppDbContext dbContext)
	{
		_dbContext = dbContext;
	}


	public List<Address> GetAllAddress()
	{
		return _dbContext.Address.Select(x => AddressMapper.FromEntity(x)).ToList();
	}

	public Address GetAddress(int id)
	{
		return AddressMapper.FromEntity(_dbContext.Address.FirstOrDefault(ph => ph.id == id)!);
	}

	public List<Address> GetAllAddressByAuthor(int id)
	{
		return _dbContext.Address.Where(x => x.AuthorId == id).Select(x => AddressMapper.FromEntity(x)).ToList();
	}

	public void AddAddress(Address address)
	{
		_dbContext.Address.Add(AddressMapper.ToEntity(address));
		_dbContext.SaveChanges();
	}

	public void DeleteAddress(int id)
	{
		var address = _dbContext.Address.FirstOrDefault(x => x.id == id);
		if (address != null) _dbContext.Address.Remove(address);
		_dbContext.SaveChanges();
	}

	public void EditAddress(Address address)
	{
		var toEdit = _dbContext.Address.FirstOrDefault(x => x.id == address.Id);
		if (toEdit != null)
		{
			toEdit.Street = address.Street;
			toEdit.HouseNumber = address.HouseNumber;
			toEdit.PostalCode = address.PostalCode;
			toEdit.City = address.City;
			toEdit.Country = (CountryEnum)address.Country;

			_dbContext.Update(toEdit);
		}

		_dbContext.SaveChanges();
	}
}