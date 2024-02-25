using Data;
using PhotoCRUD.Mappers;
using PhotoCRUD.Models;
using PhotoCRUD.Services.Interfaces;

namespace PhotoCRUD.Services;

public class AuthorService : IAuthorService
{
	private readonly AppDbContext _dbContext;

	public AuthorService(AppDbContext dbContext)
	{
		_dbContext = dbContext;
	}

	public List<Author> GetAllAuthors()
	{
		return _dbContext.Authors.Select(x => AuthorMapper.FromEntity(x)).ToList();
	}

	public Author GetAuthor(int id)
	{
		return AuthorMapper.FromEntity(_dbContext.Authors.FirstOrDefault(ph => ph.Id == id)!);
	}

	public void AddAuthor(Author author)
	{
		_dbContext.Authors.Add(AuthorMapper.ToEntity(author));
		_dbContext.SaveChanges();
	}

	public void DeleteAuthor(int id)
	{
		var author = _dbContext.Authors.FirstOrDefault(x => x.Id == id);
		if (author != null)
		{
			var photos = _dbContext.Photos.Where(x => x.AuthorId == author.Id);
			var address = _dbContext.Address.Where(x => x.AuthorId == author.Id);

			_dbContext.Photos.RemoveRange(photos);
			_dbContext.Address.RemoveRange(address);
		}
		

		if (author != null) _dbContext.Authors.Remove(author);
		_dbContext.SaveChanges();
	}

	public void EditAuthor(Author author)
	{
		var toEdit = _dbContext.Authors.FirstOrDefault(x => x.Id == author.Id);
		if (toEdit != null)
		{
			toEdit.FirstName = author.FirstName;
			toEdit.Surname = author.Surname;

			_dbContext.Update(toEdit);
		}

		_dbContext.SaveChanges();
	}
}