namespace AutoMapping.Controllers;

using AutoMapper;
using AutoMapping.Dtos;
using AutoMapping.Models;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("/api/[controller]")]
public class BookController : ControllerBase
{
    private readonly IMapper _mapper;
    public BookController(IMapper mapper) {
        _mapper = mapper;
    }
    public List<Book> Books = new List<Book>() {
        new Book(){BookId = 1, Author = "Muhammad", Price=129.72, Title="new book"},
        new Book(){BookId = 2, Author = "Qasas", Price=0, Title="new book2"},
        new Book(){BookId = 3, Author = "Ahmed", Price=19.72, Title="new book3"},
    };
    [HttpGet]
    public IActionResult GetAllBooks() {

        return Ok(_mapper.Map<IEnumerable<BookDTO>>(Books));
    }
    [HttpPost("create")]
    public IActionResult CreateBook(BookDTO book) {
        return Ok(_mapper.Map<Book>(book));
    }
}
