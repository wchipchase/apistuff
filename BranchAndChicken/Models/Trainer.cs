using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BranchAndChicken.Models
{
    public class Trainer
    {
        public string Name { get; set; }
        public int YearsOfExperience { get; set; }
        public Specialty Specialty { get; set; }
        public List<Chicken> Coop { get; set; }
    }

    public enum Specialty
    {
        Chudo,
        Chousting,
        TaeCluckDoe,
        ChravMcgaw
    }
}
