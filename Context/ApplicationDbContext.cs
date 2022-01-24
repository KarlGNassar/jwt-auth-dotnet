using JwtAuth.Models;
using Microsoft.EntityFrameworkCore;

namespace JwtAuth.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<UserModel> Users { get; set; }
    }
}
