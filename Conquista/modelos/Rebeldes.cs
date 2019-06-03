using System;
using System.Collections.Generic;
using System.Text;

namespace Conquista.modelos
{
    
    class Rebeldes
    {
        private String Name;
        private bool trobat = false;
        private DateTime datetrobat;
        
        public Rebeldes(String name)
        {
            this.Name = name;
        }

        //gets
        public String GetName() {
            return this.Name;
        }

        public bool Gettrbat() {
            return this.trobat;
        }

        public DateTime GetDate() {
            return datetrobat;
        }
        //sets
        public void SetTrobat(bool trobat) {
            this.trobat = trobat;
        }

        public void SetDate(DateTime date) {
            this.datetrobat = date;
        }
    }
}
