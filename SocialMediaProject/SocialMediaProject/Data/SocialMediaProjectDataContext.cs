using Microsoft.EntityFrameworkCore;
using SocialMediaProject.Entities;

namespace SocialMediaProject.Data
{
    public class SocialMediaProjectDataContext : DbContext
    {
        public SocialMediaProjectDataContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {

        }

        public DbSet<AppUser> Users  { get; set; }
    }
}
