namespace assignment2.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class items : DbContext
    {
        public items()
            : base("name=itemsConnection")
        {
        }

        public virtual DbSet<item> itemsConnection { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<item>()
                .Property(e => e.ITEMS)
                .IsFixedLength();
        }
    }
}
