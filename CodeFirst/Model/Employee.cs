using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;

namespace CodeFirst.Model
{
    public class EntertainmentDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=entertainment.db");
        public DbSet<Production> Productions { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<Series> Series { get; set; }
        public DbSet<Rating> Ratings { get; set; }
        public DbSet<Character> Characters { get; set; }
        public DbSet<Actor> Actors { get; set; }
    }
    public abstract class Production
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Release { get; set; }


        public List<Character> Characters { get; set; } = new List<Character>();
        public List<Rating> Ratings { get; set; } = new List<Rating>();
    }

    public class Movie : Production
    {
        public int DurationInMinutes { get; set; }
        public double WorldwideBoxOfficeGross { get; set; }
    }

    public class Series : Production
    {
        public int NumberOfEpisodes { get; set; }
    }
    public class Rating
    {
        public int Id { get; set; }
        public int ProductionId { get; set; }
        public Production Production { get; set; }
        public string Source { get; set; }
        public int Stars { get; set; }
    }
    public class Character
    {
        public int Id { get; set; }
        public int ProductionId { get; set; }
        public Production Production { get; set; }
        public string Name { get; set; }
        public Actor Actor { get; set; }
        public int ActorId { get; set; }
    }
    public class Actor
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Character> Characters { get; set; } = new List<Character>();
    }
}
