using System;
using System.Collections.Generic;
using System.Text;

namespace Conquista.modelos
{
    
    class Lrebeldes
    {
        private List<Rebeldes> rebeldes = new List<Rebeldes>();
        private int NumRebels;

        public Lrebeldes() {
            this.NumRebels = 0;
        }

        public List<Rebeldes> GetRebeldes() {
            return rebeldes;
        }

        public int GetNumRebels() {
            return NumRebels;
        }

        public void AddRebel(Rebeldes r) {
            rebeldes.Add(r);
            this.NumRebels += 1;
        }

        public bool FindRebel(String nomr) {
            return false;

        }

        public void MostrarRebeldes() {
            Rebeldes r;
            for (int i = 0; i < NumRebels; ++i) {
                r = rebeldes[i];
                Console.Write(r.GetName() + " " + r.GetDate().ToString());
                if (i < NumRebels - 1) Console.Write(", ");
            }
        }

    }
}
