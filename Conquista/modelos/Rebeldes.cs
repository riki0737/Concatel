using System;
using System.Collections.Generic;
using System.Text;

namespace Conquista.modelos
{
    
    public class Rebeldes
    {
        private String Name;
        private DateTime datetrobat;

        public Rebeldes(String name)
        {
            this.Name = name;
        }

        //gets
        public String GetName() {
            return this.Name;
        }

        public DateTime GetDate() {
            return datetrobat;
        }
        //sets

        public void SetDate(DateTime date) {
            this.datetrobat = date;
        }
    }
}
