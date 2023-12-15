using AutoMapper;
using UserApi.Models.Dtos;
using UserApi.Models.Entities;

namespace UserApi.Services
{
    public class MappingService : Profile
    {

        public MappingService()
        {
            CreateMap<CreateUserDto, User>().ReverseMap();
        }
    }
}
