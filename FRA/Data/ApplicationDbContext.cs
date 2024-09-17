

using FRA.Models;
using Microsoft.EntityFrameworkCore;
using System;
using ServiceProvider = FRA.Models.ServiceProvider;


namespace FRA.Data
{
    public class ApplicationDbContext : DbContext


    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<TecnicalGrop> Technicals { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<ServiceProvider> Services { get; set; }
        public DbSet<ServiceType> Types { get; set; }
        public DbSet<Category> Categoties { get; set; }
        public DbSet<Evaluation> Evaluations { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Ticket> Tickets { get; set; }
        public DbSet<Ticket_case> Ticket_cases { get; set; }

        

    }
}
