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
        //readonly string DATABASE_NAME = "lex2026";
        //string ConnectionString = "Data Source=.\\SQLEXPRESS;Database=lex2026;Integrated Security=True;Trusted_Connection=True;TrustServerCertificate=True;";
        //string ConnectionString = Environment.GetEnvironmentVariable("SQL_SERVER_STRING") + "Database=" + "lex2026_ef;";
        public DbSet<Rocket> Rockets { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Program.ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {

        }
    }
}
