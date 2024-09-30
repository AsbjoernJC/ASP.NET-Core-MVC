
using BulkyBookWeb.Models;

namespace BulkyBookWeb.Data
{
    public class ApplicationDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public ApplicationDbContext(Microsoft.EntityFrameworkCore.DbContextOptions<ApplicationDbContext> options):base(options)
        {
        }

        public Microsoft.EntityFrameworkCore.DbSet<Category> Categories { get; set; }
    }
}
