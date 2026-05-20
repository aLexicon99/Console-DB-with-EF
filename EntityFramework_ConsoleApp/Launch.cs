using System;
using System.Collections.Generic;
using System.Text;

namespace EntityFramework_ConsoleApp
{
    internal class Launch
    {
        public int Id { get; set; }

        public DateTime LaunchDate { get; set; }

        public DateTime ReturnDate { get; set; }

        public int RocketId { get; set; }

        public Rocket Rocket { get; set; }
    }
}
