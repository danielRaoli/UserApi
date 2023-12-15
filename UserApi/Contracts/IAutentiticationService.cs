using UserApi.Models.Dtos;
using UserApi.Models.Entities;

namespace UserApi.Contracts
{
    public interface IAutentiticationService
    {
        Task Cadastro(CreateUserDto userDto);
    }
}
