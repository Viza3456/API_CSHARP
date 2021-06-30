using System;
using CoreAPI.Model;
using Microsoft.EntityFrameworkCore;

namespace DataStore.EF
{
    public class BugeContext : DbContext
    {
        public BugeContext(DbContextOptions<BugeContext> options) : base(options)
        {
        }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Ticket> Tickets { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<Project>()
        //        .HasMany(p => p.Tickets)
        //        .WithOne(t => t.Project)
        //        .HasForeignKey(p => p.ProjectId);
        //    modelBuilder.Entity<Project>().HasData(
        //            new Project { ProjectId = 1, Name = "ProjectT1"},
        //            new Project { ProjectId = 2, Name = "ProjectT2" }
        //        );
        //    modelBuilder.Entity<Ticket>().HasData(
        //           new Ticket { TicketId = 1, text = "TicketT1" , ProjectId = 1 },
        //           new Ticket { TicketId = 2, text = "TicketT2", ProjectId = 1 },
        //           new Ticket { TicketId = 3, text = "TicketT3", ProjectId = 2 }
        //       );
        //}
    }
}
