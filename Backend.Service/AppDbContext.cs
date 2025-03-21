using Backend.Api.Models;
using Backend.Api.Entity;
using Microsoft.EntityFrameworkCore;
using System;

namespace Backend.Api
{
    public class AppDbContext : DbContext
    {
        //public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Test> Test { get; set; }

        //private readonly string _connectionString;
        //public AppDbContext(string connectionString)
        //{
        //    _connectionString = connectionString;
        //}

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(_connectionString);
        //}

    }
}
