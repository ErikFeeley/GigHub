using System.Data.Entity;
using Microsoft.AspNet.Identity.EntityFramework;

namespace GigHub.Models
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Gig> Gigs { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Attendance> Attendances { get; set; }

        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Attendance>()
                .HasRequired(a => a.Gig) // each attendance has a required gig
                .WithMany() // reverse direction of relationship. from gig to attendances each gig can have many attendances... aka people attending the gig
                .WillCascadeOnDelete(false); // disable cascade deletion to make sql server happy

            // calling base here to make sure the identitydbcontext fluent api overrides are go.
            base.OnModelCreating(modelBuilder);
        }
    }
}