namespace HW7.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class GiphyRequestContext : DbContext
    {
        public GiphyRequestContext()
            : base("name=GiphyRequestContext")
        {
        }

        public virtual DbSet<UserInput> UserInputs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
