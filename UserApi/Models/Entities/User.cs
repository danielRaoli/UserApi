using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace UserApi.Models.Entities
{
    
    public class User : IdentityUser
    {
        public DateTime BirthDate { get; set; }
        public string Photo { get; set; }

    }
}
