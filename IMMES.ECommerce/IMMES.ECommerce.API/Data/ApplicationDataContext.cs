using IMMES.ECommerce.API.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace IMMES.ECommerce.API.Data
{
    public class ApplicationDataContext : DbContext
    {
        public ApplicationDataContext(DbContextOptions<ApplicationDataContext> options) : base(options) { } 

        public DbSet<Category> Categories { get; set; }
    }
}
