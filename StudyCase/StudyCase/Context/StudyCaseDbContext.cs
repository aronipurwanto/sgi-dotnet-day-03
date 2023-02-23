using Microsoft.EntityFrameworkCore;
using StudyCase.Entity;

namespace StudyCase.Context;

public class StudyCaseDbContext : DbContext
{
    public StudyCaseDbContext(DbContextOptions<StudyCaseDbContext> options) : base(options)
    {
        
    }

    public DbSet<ExcepCust01> ExcepCust01s { get; set; }
    public DbSet<ExcepCust01Detail> ExcepCust01Details { get; set; }
    public DbSet<ExcepCust02> ExcepCust02s { get; set; }
    public DbSet<ExcepCust02Detail> ExcepCust02Details { get; set; }
    public DbSet<ExcepCust02Support> ExcepCust02Supports { get; set; }
    public DbSet<StatusTindakLanjut> StatusTindakLanjuts { get; set; }
}