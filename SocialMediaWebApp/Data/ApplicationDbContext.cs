using Microsoft.EntityFrameworkCore;
using SocialMediaWebApp.Models;

namespace SocialMediaWebApp.Data
{
    public class ApplicationDbContext : DbContext
    {


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            
        }

        public DbSet<User> Users {  get; set; }
    }
}
