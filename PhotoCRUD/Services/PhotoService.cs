using Data;
using PhotoCRUD.Mappers;
using PhotoCRUD.Models;
using PhotoCRUD.Services.Interfaces;

namespace PhotoCRUD.Services;

public class PhotoService : IPhotoService
{
	private readonly AppDbContext _dbContext;

	public PhotoService(AppDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	public List<Photo> GetAllPhotos()
	{
		return _dbContext.Photos.Select(x => PhotoMapper.FromEntity(x)).ToList();
	}

	public Photo GetPhoto(int id)
	{
		return PhotoMapper.FromEntity(_dbContext.Photos.FirstOrDefault(ph => ph.Id == id)!);
	}

	public List<Photo> GetPhotoByAuthorId(int id)
	{
		return _dbContext.Photos.Where(x => x.AuthorId == id).Select(x => PhotoMapper.FromEntity(x)).ToList();
	}

	public void AddPhoto(Photo photo)
	{
		_dbContext.Photos.Add(PhotoMapper.ToEntity(photo));
		_dbContext.SaveChanges();
	}

	public void DeletePhoto(int id)
	{
		var photo = _dbContext.Photos.FirstOrDefault(x => x.Id == id);
		if (photo != null) _dbContext.Photos.Remove(photo);
		_dbContext.SaveChanges();
	}

	public void EditPhoto(Photo photo)
	{
		var toEdit = _dbContext.Photos.FirstOrDefault(x => x.Id == photo.Id);
		if (toEdit != null)
		{
			toEdit.DateTimeTaken = photo.DateTimeTaken;
			toEdit.Description = photo.Description;
			toEdit.Camera = photo.Camera;
			toEdit.AuthorEmail = photo.AuthorEmail;
			toEdit.Resolution = photo.Resolution;
			toEdit.Format = photo.Format;

			_dbContext.Update(toEdit);
		}

		_dbContext.SaveChanges();
	}
}