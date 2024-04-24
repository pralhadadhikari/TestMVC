using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using TestMVC.Models;
using static System.Net.Mime.MediaTypeNames;

namespace TestMVC.Data
{
    public class ApplicationDbContext:IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> contextOptions)
            : base(contextOptions)
        {
        }
        public DbSet<Student> Students { get; set; }
    }
}
