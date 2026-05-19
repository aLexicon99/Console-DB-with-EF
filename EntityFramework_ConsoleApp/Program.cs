//using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework_ConsoleApp
{
    //class Rocket
    //{
    //    public int Id { get; set; }

    //    [MaxLength(100)]
    //    public string? RocketName { get; set; }

    //    [MaxLength(500)]
    //    public string? RocketDescription { get; set; }
    //}
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
            //var FindRockets = Context.Rockets.Where(r => r.Id > 1).ToList();
            //foreach (Rocket rocket in FindRockets)
            //{
            //    Console.WriteLine(rocket.RocketName);
            //}


            //var FindRockets = Context.Rockets.Where(r => r.Id > 1).ToList();
            //foreach (Rocket rocket in FindRockets)
            //{
            //    Console.WriteLine(rocket.RocketName);
            //}


            // Add a new rocket
            //Rocket NewRocket = new Rocket()
            //{
            //    RocketName = "Falcon 9",
            //    RocketDescription = "Partially reusable rocket"
            //};
            //Context.Rockets.Add(NewRocket);
            //Context.SaveChanges();

            //Console.WriteLine(NewRocket.Id);
            //Console.WriteLine(NewRocket.RocketName);


            // UPDATE
            //Rocket R1 = Context.Rockets.Single(r => r.Id == 1);
            //R1.RocketDescription = "Space Launch System (SLS)";
            //Context.SaveChanges();

            Console.WriteLine("Hello, Space!");
            //Console.WriteLine("Total Rockets : " + allRockets.Count());
            //Console.WriteLine("First Rocket Name: " + firstRocket.RocketName);
            //Console.WriteLine(Apollo_rocket.RocketName);
            //Console.WriteLine("\n--- All Rockets -----\n");
            //allRockets.ForEach((r) => Console.WriteLine($"- {r.RocketName}, {r.RocketDescription}"));


            foreach (Rocket rocket in Context.Rockets.ToList())
            {
                Console.WriteLine(rocket.RocketName);
            }
        }
    }
}
