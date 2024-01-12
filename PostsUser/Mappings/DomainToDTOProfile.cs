using AutoMapper;
using PostsUser.DTO;
using PostsUser.Models;

namespace PostsUser.Mappings
{
    public class DomainToDTOProfile : Profile
    {
        public DomainToDTOProfile() 
        { 
            CreateMap<PostModel, PostDTO>().ReverseMap();
        }
    }
}
