using PhotoCRUD.Models;

namespace PhotoCRUD.Services.Interfaces;

public interface IPhotoService
{
	public List<Photo> GetAllPhotos();
	public Photo GetPhoto(int id);
	public void AddPhoto(Photo photo);
	public void DeletePhoto(int id);
	public void EditPhoto(Photo photo);
	List<Photo> GetPhotoByAuthorId(int id);
}