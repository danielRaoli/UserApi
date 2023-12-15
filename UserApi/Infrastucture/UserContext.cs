using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserApi.Models.Entities;

namespace UserApi.Infrastucture
{
    public class UserContext : IdentityDbContext<User>
    {
        public UserContext(DbContextOptions<UserContext> opts) : base(opts)
        {
            
        }

       public DbSet<User> Users {  get; set; }
    }
}
