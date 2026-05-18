//using Microsoft.EntityFrameworkCore;

namespace EntityFramework_ConsoleApp
{
    class Rocket
    {
        public int Id { get; set; }
        public string RocketName { get; set; }
        public string? RocketDescription { get; set; }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDbContext Context = new MyDbContext();

            // Add new Rocket
            //
            //Rocket Rocket1 = new Rocket();
            //Rocket1.RocketName = "Apollo";
            //Rocket1.RocketDescription = "Moonlanding Mission";
            //// ----------
            //Context.Rockets.Add(Rocket1);
            //Context.SaveChanges();
            //Console.WriteLine("Done");
            //// ----------

            var firstRocket = Context.Rockets.FirstOrDefault();
            var allRockets = Context.Rockets.OrderBy(r => r.RocketName).ToList();

            Console.WriteLine("Hello, Space!");
            Console.WriteLine("Total Rockets : " + allRockets.Count());
            //Console.WriteLine("First Rocket Name: " + firstRocket.RocketName);
            Console.WriteLine("\n--- All Rockets -----\n");
            allRockets.ForEach((r) => Console.WriteLine($"- {r.RocketName}, {r.RocketDescription}"));
        }
    }
}
