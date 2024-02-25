using PhotoCRUD.Models;

namespace PhotoCRUD.Services.Interfaces;

public interface IAddressService
{
	public List<Address> GetAllAddress();
	public Address GetAddress(int id);
	public List<Address> GetAllAddressByAuthor(int id);
	public void AddAddress(Address photo);
	public void DeleteAddress(int id);
	public void EditAddress(Address photo);
}