using System;
using app.entities;
using Microsoft.EntityFrameworkCore;



namespace app.dal
{
    public class Context : DbContext
    {
        public Context(DBcontextOptions options) : base(options)
        {
        }
        public DbSet<Academy> Academies { get; set; }

        protected override void OnModeCreating(ModelBuilder builder)
        {
            builder.Entity<Academy>().hasData(
                new Academy { Id = 1, Email = "mail@mail.com", Name= "test"}
            );
        }


    }
}
