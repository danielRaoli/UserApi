using Microsoft.AspNetCore.Identity;
using UserApi.Contracts;
using UserApi.Models.Dtos;
using UserApi.Models.Entities;

namespace UserApi.Services.ApplicationServices
{
    public class AutenticationService : IAutentiticationService
    {
        private readonly UserManager<User> _userManager;

        public AutenticationService(UserManager<User> userManager)
        {
            _userManager = userManager;
        }

        public async Task Cadastro(CreateUserDto createUserDto)
        {

            var filePath = Path.Combine("Storage", createUserDto.Photo.FileName);

            using Stream fileStream = new FileStream(filePath, FileMode.Create);

            createUserDto.Photo.CopyTo(fileStream);

            User user = new User { UserName = createUserDto.UserName, BirthDate = createUserDto.BirthDate, Photo = filePath };

            var result = await _userManager.CreateAsync(user, createUserDto.Password);

            if (!result.Succeeded) throw new ApplicationException("error in registering of user"); 

            
        }
    }
}
