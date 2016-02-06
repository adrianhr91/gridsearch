using System.Data.Entity;

namespace GridSearch.Domain
{
    

    public partial class GridSearchDb : DbContext
    {
        public GridSearchDb()
            : base("name=GridSearchDb")
        {
        }

        public virtual DbSet<Address> Addresses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Address>().ToTable("Postcodes");
            modelBuilder.Entity<Address>().HasKey(x => x.Postcode);
        }
    }
}
