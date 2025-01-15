using DashBoard1.Models;
using Microsoft.EntityFrameworkCore;

namespace DashBoard1.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Payment> Payments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<AttestedSession> AttestedSessions { get; set; }
        public DbSet<EfactRejectionReason> EfactRejectionReasons { get; set; }
        public DbSet<ElectronicInvoice> ElectronicInvoices { get; set; }
        public DbSet<AttestLineItem> AttestLineItems { get; set; }
        

        //public DbSet<User> Users { get; set; }
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {

        }
        
    }
}
