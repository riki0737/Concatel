using System;
using System.Collections.Generic;
using System.Text;

namespace Conquista.modelos
{ 
    
    class Planeta
    {
        private String Nom;
        private Lrebeldes l;

        public Planeta()
        {
            
        }

        public Planeta(String nom) {
            this.Nom = nom;
            this.l = new Lrebeldes();
        }

        

        public String GetNom()
        {
            return this.Nom;

        }

        public List<Rebeldes> GetRebeldes() {
            return l.GetRebeldes();
        }

        public int GetNumREbels() {
            return l.GetNumRebels();
        }

        public void SetRebel(String nom, DateTime date)
        {
            Rebeldes r = new Rebeldes(nom);
            r.SetDate(date);
            r.SetTrobat(true);
            l.AddRebel(r);
        }

        public bool BuscarRebel(string nomr)
        {
            return l.FindRebel(nomr);
        }

        public void MostrarRebeldes()
        {
            l.MostrarRebeldes();
        }

    }
}
