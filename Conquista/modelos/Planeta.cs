using System;
using System.Collections.Generic;
using System.Text;

namespace Conquista.modelos
{ 
    
    public class Planeta
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


        public void SetRebel(String nom, DateTime date)
        {
            Rebeldes r = new Rebeldes(nom);
            r.SetDate(date);
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
