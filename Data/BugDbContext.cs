using aspcore.Models;
using Microsoft.EntityFrameworkCore;

namespace aspcore.Data;

public class BugDbContext:DbContext{
    public BugDbContext(DbContextOptions<BugDbContext> options):base(options)
    {
        
    }

    public DbSet<Bug> Bugs{get;set;}
}