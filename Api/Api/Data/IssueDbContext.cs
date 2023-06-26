using Api.Models;
using Microsoft.EntityFrameworkCore;

namespace Api.Data
{
    public class IssueDbContext : DbContext
    {
        public IssueDbContext(DbContextOptions<IssueDbContext> options):base(options)
        { 
        
        }

        public DbSet<Isssue> Issues { get; set; }
    }
}
