namespace EF_LINQ.Models
{
    using System.Data.Entity;

    public partial class toplivoEntities : DbContext
    {
        public toplivoEntities()
            : base("name=toplivoEntities")
        {
        }

        public virtual DbSet<Fuel> Fuels { get; set; }
        public virtual DbSet<Operation> Operations { get; set; }
        public virtual DbSet<Tank> Tanks { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fuel>()
                .HasMany(e => e.Operations)
                .WithOptional(e => e.Fuel)
                .WillCascadeOnDelete();

            modelBuilder.Entity<Tank>()
                .HasMany(e => e.Operations)
                .WithOptional(e => e.Tank)
                .WillCascadeOnDelete();
        }
    }
}
