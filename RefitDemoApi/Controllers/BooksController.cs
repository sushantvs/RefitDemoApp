using Microsoft.AspNetCore.Mvc;
using RefitDemoApi.Models;

namespace RefitDemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private static List <BooksModel> books = new List<BooksModel>
        {
            new BooksModel { Id = 1, Title = "Book One", Author = "Author A", Description = "Description of Book One", Publisher = "Publisher A" },
            new BooksModel { Id = 2, Title = "Book Two", Author = "Author B", Description = "Description of Book Two", Publisher = "Publisher B" },
            new BooksModel { Id = 3, Title = "Book Three", Author = "Author C", Description = "Description of Book Three", Publisher = "Publisher C" }
        };

        // GET: api/<BooksController>
        [HttpGet]
        public IEnumerable<BooksModel> Get()
        {
            return books;
        }

        // GET api/<BooksController>/5
        [HttpGet("{id}")]
        public BooksModel Get(int id)
        {
            return books.FirstOrDefault(b => b.Id == id);
        }

        // POST api/<BooksController>
        [HttpPost]
        public void Post([FromBody] BooksModel value)
        {
            books.Add(value);
        }
            

        // PUT api/<BooksController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] BooksModel value)
        {
            books.Remove(books.FirstOrDefault(b => b.Id == id));
            books.Add(value);
        }

        // DELETE api/<BooksController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            books.RemoveAll(b => b.Id == id);
        }
    }
}
