using AutoMapper;
using AutoMapping.Dtos;
using AutoMapping.Models;

namespace AutoMapping.Mapping;

public class MappingProfile: Profile
{
    public MappingProfile() {
        CreateMap<Book,BookDTO>()
        .ForMember(dest=>dest.Id, src=>src.MapFrom(src=>src.BookId))
        .ForMember(dest=>dest.IsFree, src=>src.MapFrom(src=>src.Price == 0))
        .ReverseMap();

        CreateMap<Author, AuthorDTO>().ReverseMap();
    }
}
