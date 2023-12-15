using System.ComponentModel.DataAnnotations;

namespace UserApi.Models.Dtos
{
    public class CreateUserDto
    {
        [Required(ErrorMessage ="the user name is required")]
        public string UserName { get;  set; }

        [Required(ErrorMessage ="the user password is required")]
        public string Password { get;  set; }

        [Required(ErrorMessage ="the confirmation of password is required")]
        [Compare("Password",ErrorMessage ="Confirm password should be equal the user password")]
        public string ConfirmPassword { get;  set; }

        public DateTime BirthDate { get;  set; }

        public IFormFile Photo { get; set; }




    }
}
