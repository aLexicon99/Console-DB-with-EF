//using ConsoleAppEf1;
using Microsoft.EntityFrameworkCore;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.ConstrainedExecution;
//using System.Text;
//using System.Threading.Tasks;


namespace EntityFramework_ConsoleApp
{
    internal class MyDbContext : DbContext
    {
        private static readonly string DATABASE_NAME = "lex2026_ef;";
        static readonly string ConnectionString = Environment.GetEnvironmentVariable("SQL_SERVER_STRING") + "Database=" + DATABASE_NAME;

        public DbSet<Rocket> Rockets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {

        }
    }
}
