using System;
using System.Text;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace EntityFramework_ConsoleApp
{
    internal class Rocket
    {
        public int Id { get; set; }

        [MaxLength(100)]
        public string? RocketName { get; set; }

        [MaxLength(500)]
        public string? RocketDescription { get; set; }

        public List<CrewMember>? CrewMembers { get; set; }
    }
}
