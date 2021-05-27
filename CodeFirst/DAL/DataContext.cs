using CodeFirst.Model;
using CodeFirst.Model.ModelConfigurations;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFirst.DAL
{
    public class EntertainmentDbContext : DbContext
    {
          
        public EntertainmentDbContext() : base()
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // set special settings fro each model 
            modelBuilder.Configurations.Add(new ProductionConfig());

            //set table name 
            modelBuilder.Entity<Movie>().ToTable("Movies");

            //create stored procedure for this data table
            modelBuilder.Entity<Movie>().MapToStoredProcedures();

            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Production> Productions { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Actor> Actors { get; set; }
    }
}
