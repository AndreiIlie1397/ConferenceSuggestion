using Microsoft.EntityFrameworkCore;
using ConferenceSuggestion.Models;


namespace ConferenceSuggestion.Data
{
    public partial class ConferenceSuggestionDbContext : DbContext
    {
     
        public ConferenceSuggestionDbContext(DbContextOptions<ConferenceSuggestionDbContext> options): base(options)
        {
        }

        public virtual DbSet<Conference> Conferences { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");
            modelBuilder.Entity<Conference>(entity =>
            {
                entity.ToTable("Conference");
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Name);
                entity.Property(e => e.OrganizerEmail);
                entity.Property(e => e.StartDate);
                entity.Property(e => e.EndDate);
                entity.Property(e => e.ConferenceTypeId);
                entity.Property(e => e.LocationId);
            });
        }
    }
}
