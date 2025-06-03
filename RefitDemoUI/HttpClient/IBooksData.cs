using Refit;
using RefitDemoUI.Models;

namespace RefitDemoUI.HttpClient
{
    public interface IBooksData
    {
        [Get("/Books")]
        Task<List<BooksModel>> GetBooksAsync();

        [Get("/Books/{id}")]
        Task<BooksModel> GetBookAsync(int id);

        [Post("/Books")]
        Task AddBookAsync([Body] BooksModel book);

        [Put("/Books/{id}")]
        Task UpdateBookAsync(int id, [Body] BooksModel book);

        [Delete("/Books/{id}")]
        Task DeleteBookAsync(int id);
    }
}
