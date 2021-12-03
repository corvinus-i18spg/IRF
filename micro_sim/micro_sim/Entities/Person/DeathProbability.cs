using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace micro_sim.Entities.Person
{
    class DeathProbability
    {
        public Gender Gender { get; set; }
        public int Age { get; set; }
        public double P { get; set; }

    }
}
