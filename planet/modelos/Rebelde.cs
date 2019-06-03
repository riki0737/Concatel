using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace planet.modelos
{
    public class Rebelde
    {
        public Rebelde() {
            date = DateTime.Now;        
        }
        public String Name { get; set; }
        public DateTime date { get; set; }

        public int planetaID { get; set; }
    }
}
