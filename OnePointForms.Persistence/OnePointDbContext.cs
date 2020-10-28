using System;
using System.Collections.Generic;
using System.Text;
using OnePointForms.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.SqlServer;

namespace OnePointForms.Persistence
{
    public class OnePointDbContext  : DbContext
    {
        public OnePointDbContext(DbContextOptions<OnePointDbContext> options) : base(options)
        {

        }
        public DbSet<AcceptStatus> AcceptStatus { get; set; }

        public DbSet<Admin> Admins { get; set; } 
        public DbSet<AllianceRequest> AllianceRequests { get; set; }
        public DbSet<Approval> Approvals { get; set; }
       
        public DbSet<BuyersName> BuyersNames { get; set; }
        public DbSet<DeliverToLocation> DeliverToLocations { get; set; }
    
        public DbSet<GLDept> GLDepts { get; set; }
        public DbSet<Location> Locations { get; set; }
   
       
        public DbSet<NaturalExpense> NaturalExpenses { get; set; }

        public DbSet<Status> Status { get; set; }

        public DbSet<Unit> Units { get; set; }

    }
}
