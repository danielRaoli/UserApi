using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using UserApi.Contracts;
using UserApi.Infrastucture;
using UserApi.Models.Dtos;
using UserApi.Models.Entities;

namespace UserApi.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMapper _mapper;
        private readonly IAutentiticationService _autentiticationService;

        public UserController(IMapper mapper,IAutentiticationService autentiticationService)
        {
            _mapper = mapper;
            _autentiticationService = autentiticationService;
            
        }

        [HttpPost]
        public async Task<IActionResult> Post([FromForm] CreateUserDto createUserDto)
        {
            _autentiticationService.Cadastro(createUserDto);
            return Ok("user registering carried out with success");
        }
    }
}
