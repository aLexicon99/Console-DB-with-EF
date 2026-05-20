using System;
using System.Text;
using System.Collections.Generic;

namespace EntityFramework_ConsoleApp
{
    internal class CrewMember
    {
        public int Id { get; set; }

        public string? CrewName { get; set; }

        //public int? RocketId { get; set; }

        public List<Rocket>? Rockets { get; set; }
    }
}
