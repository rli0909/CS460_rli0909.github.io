namespace HW5_DB.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EFRequestContext : DbContext
    {
        public EFRequestContext()
            : base("name=EFRequestContext")
        {
        }

        public virtual DbSet<Request> Requests { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
