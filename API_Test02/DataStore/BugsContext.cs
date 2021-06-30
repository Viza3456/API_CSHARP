using System;
using CoreAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace DataStore
{
    public class BugsContext : DbContext
    {
        public BugsContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<Project> Projects { get; set; }

        public DbSet<Ticket> Tickets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Project>()
                .HasMany(p => p.Tickets)
                .WithOne(t => t.Project)
                .HasForeignKey(t => t.ProjectId);
            modelBuilder.Entity<Ticket>().HasData(
                    new Ticket { TicketId = 1, text = "Test1" , ProjectId = 1},
                    new Ticket { TicketId = 2, text = "Test2", ProjectId = 1 },
                    new Ticket { TicketId = 3, text = "Test3", ProjectId = 2 }
                );
        }
    }
}
