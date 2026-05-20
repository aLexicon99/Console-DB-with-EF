using Microsoft.EntityFrameworkCore;

namespace EntityFramework_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyDbContext Context = new MyDbContext();

            ////////////// CREATE
            ///
            // Add new Rocket
            //
            //Rocket Rocket1 = new Rocket();
            //Rocket1.RocketName = "Artemis2";
            //Rocket1.RocketDescription = "10-day Moon mission";
            //
            //Context.Rockets.Add(Rocket1);
            //Context.SaveChanges();
            //Console.WriteLine("Done");
            //
            //
            // -------- Add a new rocket
            //Rocket NewRocket = new Rocket()
            //{
            //    RocketName = "Falcon 9",
            //    RocketDescription = "Partially reusable rocket"
            //};
            //Context.Rockets.Add(NewRocket);
            //Context.SaveChanges();

            //Console.WriteLine(NewRocket.Id);
            //Console.WriteLine(NewRocket.RocketName);
            //
            //
            //
            //------- INSERT/ADD Many Objects
            //List<Rocket> MyRockets = new List<Rocket>();
            //MyRockets.AddRange(Rocket1);
            //MyRockets.AddRange(Rocket2);
            //Context.Rockets.AddRange(MyRockets);
            //Context.SaveChanges();
            //
            //----- ADD Launch
            //
            //Launch Launch1 = new Launch()
            //{
            //    LaunchDate = new DateTime(1999, 1, 01),
            //    ReturnDate = new DateTime(1999, 1, 20),
            //    RocketId = 1,
            //};
            //Context.Add(Launch1);
            //Context.SaveChanges();
            //




            ////////////// READ
            ///
            /// 
            //var firstRocket = Context.Rockets.FirstOrDefault();
            //var allRockets = Context.Rockets.OrderBy(r => r.RocketName).ToList();
            //var Apollo_rocket = Context.Rockets.Find(2);
            //----- Eller context.Rockets.FirstOrDefault(r => r.id == 1)
            //
            //
            //
            //------ One Object
            //Rocket oneRocket = Context.Rockets.FirstOrDefault(r => r.Id == 1);
            //Console.WriteLine(oneRocket.RocketName);
            //
            //
            //
            // ------All Rockets
            //List<Rocket> RocketData = Context.Rockets.ToList();
            //foreach (var rocket in RocketData)
            //{
            //    Console.WriteLine(rocket.RocketName);
            //}
            /// 
            // ------ Find with LINQ
            //var FindRockets = Context.Rockets.Where(r => r.Id > 1).ToList();
            //foreach (Rocket rocket in FindRockets)
            //{
            //    Console.WriteLine(rocket.RocketName);
            //}
            //
            //
            //
            var LaunchFromDb = Context.Launches.Where(l => l.Id == 1).Include(l => l.Rocket).Single();
            Console.WriteLine(LaunchFromDb.Rocket.RocketName);
            Console.WriteLine($"Launched : {LaunchFromDb.LaunchDate.ToShortDateString()}\nReturn Date : {LaunchFromDb.ReturnDate.ToShortDateString()}");
            // -------- Hämtar endast RocketId (int)
            //int rocketId = Context.Launches.Where(l => l.Id == 1).Select(l => l.RocketId).FirstOrDefault();
            //Console.WriteLine(Context.Rockets.Find(rocketId).RocketName);
            // Använd FirstOrDefault() om det kan finnas 0 resultat


            ////////////// UPDATE
            ///
            // UPDATE
            //Rocket R1 = Context.Rockets.Single(r => r.Id == 1);
            //R1.RocketDescription = "Space Launch System (SLS)";
            //Context.SaveChanges();

            ////////////// DELETE











            Console.WriteLine("Hello, Space!");
            //Console.WriteLine("Total Rockets : " + allRockets.Count());
            //Console.WriteLine("First Rocket Name: " + firstRocket.RocketName);
            //Console.WriteLine(Apollo_rocket.RocketName);
            //Console.WriteLine("\n--- All Rockets -----\n");
            //allRockets.ForEach((r) => Console.WriteLine($"- {r.RocketName}, {r.RocketDescription}"));


            //foreach (Rocket r in Context.Rockets.ToList())
            //{
            //    Console.WriteLine(r.RocketName);
            //}

            //foreach (Launch l in Context.Launches.ToList())
            //{
            //    Console.WriteLine(l.LaunchDate);
            //}
        }
    }
}
