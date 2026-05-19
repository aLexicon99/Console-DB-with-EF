//using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework_ConsoleApp
{
    class Rocket
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string? RocketName { get; set; }

        [MaxLength(500)]
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
            //Rocket1.RocketName = "Artemis2";
            //Rocket1.RocketDescription = "10-day Moon mission";
            //// ----------
            //Context.Rockets.Add(Rocket1);
            //Context.SaveChanges();
            //Console.WriteLine("Done");
            //// ----------


            //var firstRocket = Context.Rockets.FirstOrDefault();
            //var allRockets = Context.Rockets.OrderBy(r => r.RocketName).ToList();
            //var Apollo_rocket = Context.Rockets.Find(2);
            // Eller context.Rockets.FirstOrDefault(r => r.id == 1)

            // One Object
            //Rocket oneRocket = Context.Rockets.FirstOrDefault(r => r.Id == 1);
            //Console.WriteLine(oneRocket.RocketName);

            // All Rockets
            //List<Rocket> RocketData = Context.Rockets.ToList();
            //foreach (var rocket in RocketData)
            //{
            //    Console.WriteLine(rocket.RocketName);
            //}

            // INSERT/ADD Many Objects
            //List<Rocket> MyRockets = new List<Rocket>();
            //MyRockets.AddRange(Rocket1);
            //MyRockets.AddRange(Rocket2);
            //Context.Rockets.AddRange(MyRockets);
            //Context.SaveChanges();



            // Find with LINQ
            var FindRockets = Context.Rockets.Where(r => r.Id > 1).ToList();
            foreach (Rocket rocket in FindRockets)
            {
                Console.WriteLine(rocket.RocketName);
            }


            Console.WriteLine("Hello, Space!");
            //Console.WriteLine("Total Rockets : " + allRockets.Count());
            //Console.WriteLine("First Rocket Name: " + firstRocket.RocketName);
            //Console.WriteLine(Apollo_rocket.RocketName);
            //Console.WriteLine("\n--- All Rockets -----\n");
            //allRockets.ForEach((r) => Console.WriteLine($"- {r.RocketName}, {r.RocketDescription}"));
        }
    }
}
