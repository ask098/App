using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore;
using Wayuu.Entities;
using Wayuu.Helpers;

namespace Wayuu.DAL
{
    public class WayuuContext : DbContext
    {
        public DbSet<School> Schools { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Log> Logs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseNpgsql(
            //    "Host=localhost;Database=wayuu;Username=wayuuadmin;Password=wayuu1234"
            //    );
            var ConnectionString = HelperConfiguration.GetAppConfiguration()
                .ConnectionString;

            optionsBuilder.UseNpgsql(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<School>(
                S =>
                {
                    S.Property(field => field.Name).HasMaxLength(10).IsRequired();
                    S.Property(field => field.Creation_date).HasDefaultValueSql("now()");
                });

            modelBuilder.Entity<Teacher>(
                T =>
                {
                    T.Property(field => field.Name).IsRequired();
                });

            modelBuilder.Entity<Log>(
                L => {
                    L.Property(wl => wl.DateTime).HasDefaultValueSql("now()");
                    L.Property(wl => wl.Type).HasConversion(new EnumToStringConverter<LogType>()).HasMaxLength(20);
                }
            );
        }
    }
}
