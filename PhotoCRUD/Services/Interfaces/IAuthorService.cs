using PhotoCRUD.Models;

namespace PhotoCRUD.Services.Interfaces;

public interface IAuthorService
{
	public List<Author> GetAllAuthors();
	public Author GetAuthor(int id);
	public void AddAuthor(Author photo);
	public void DeleteAuthor(int id);
	public void EditAuthor(Author photo);
}