using System;
using System.Collections.Generic;
using System.Text;
using Wayuu.Entities;
using Wayuu.Helpers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Wayuu.DAL
{
    public class WayuuContext:DbContext
    {
        public DbSet<School> Schools { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<WayuuLog> wayuuLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var ConnectionString = HelperConfiguration.GetAppConfiguration()
                .ConnectionString;

            optionsBuilder.UseNpgsql(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<School>()
                .Property(s => s.Name)
                .HasMaxLength(10)
                .IsRequired();

            modelBuilder.Entity<Teacher>()
                .Property(t => t.Name)
                .IsRequired();

            modelBuilder.Entity<WayuuLog>(
                L => {
                    L.Property(wl => wl.DateTime)
                        .HasDefaultValueSql("now()");
                    L.Property(wl => wl.Type)
                        .HasConversion(new EnumToStringConverter<LogType>())
                        .HasMaxLength(20);
                }
            );
        }
    }
}
