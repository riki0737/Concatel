using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace planet.modelos
{
    public class Planeta
    {
        public Planeta() {
            rebeldes = new List<Rebelde>();
        }
        public String Name { get; set; }

        public int Id { get; set; }

        public List<Rebelde> rebeldes { get; set; }
    }
}
