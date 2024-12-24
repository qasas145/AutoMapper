
namespace AutoMapping.Dtos;

public class BookDTO
{
    
    public int Id{get;set;}
    public string Title{get;set;}
    public AuthorDTO Author{get;set;}
    public double Price{get;set;}
    public bool IsFree{get;set;}
}
