using Microsoft.EntityFrameworkCore;

namespace EntityFramework_ConsoleApp
{
    internal class MyDbContext : DbContext
    {
        private static readonly string DATABASE_NAME = "lex2026_ef;";
        static readonly string ConnectionString = Environment.GetEnvironmentVariable("SQL_SERVER_STRING") + "Database=" + DATABASE_NAME;

        public DbSet<Rocket> Rockets { get; set; }
        public DbSet<Launch> Launches { get; set; } 
        public DbSet<CrewMember> CrewMembers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // we till the app to use the connectionstring
            optionsBuilder.UseSqlServer(ConnectionString);
        }

        protected override void OnModelCreating(ModelBuilder ModelBuilder)
        {

        }
    }
}
