using CQRS.Api.Entities;
using Microsoft.EntityFrameworkCore;

namespace CQRS.Api.Context
{
    public class CQRSContext : DbContext
    {
        public CQRSContext(DbContextOptions options) : base(options) {}
        
        public DbSet<Person> People { get; set; }
    }
}
