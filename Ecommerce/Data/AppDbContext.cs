using Ecommerce.Models;
using Ecommerce.Models.ViewModel;
using Microsoft.EntityFrameworkCore;

namespace Ecommerce.Data
{ 
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<AccounInfoModel> AccounInfos { get; set; }
        public DbSet<Category> Categories { get; set; }

    }
}
