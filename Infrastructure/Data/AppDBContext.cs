using CursoMediatRCQRS.Application.Models;
using Microsoft.EntityFrameworkCore;

namespace CursoMediatRCQRS.Infrastructure.Data
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
