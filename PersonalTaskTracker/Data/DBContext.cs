using Microsoft.EntityFrameworkCore;

public class DBContext : DbContext
{
    public DbSet<Space> Spaces { get; set; }
    public DbSet<Task> Tasks { get; set; }
    public DbSet<User> Users { get; set; }

    public DBContext(DbContextOptions<DBContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Task>()
            .HasOne(t => t.Space)
            .WithMany(s => s.Tasks)
            .HasForeignKey(t => t.IdSpace);

        modelBuilder.Entity<Space>()
            .HasOne(s => s.User)
            .WithMany(u => u.Spaces)
            .HasForeignKey(s => s.IdUser);

        modelBuilder.Entity<Task>()
            .Property(t => t.Status)
            .HasConversion<string>();

        modelBuilder.Entity<User>()
            .Property(u => u.IdUser)
            .HasDefaultValueSql("gen_random_uuid()");

        modelBuilder.Entity<Task>()
            .Property(t => t.IdTask)
            .HasDefaultValueSql("gen_random_uuid()");

        modelBuilder.Entity<Space>()
            .Property(s => s.IdSpace)
            .HasDefaultValueSql("gen_random_uuid()");    
    }
}