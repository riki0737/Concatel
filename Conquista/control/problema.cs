using System;
using System.Collections.Generic;
using System.Text;
using Conquista.modelos;

namespace Conquista.control
{
    class problema
    {
        Planetas p = new Planetas();
        public problema() { }

        public void AddPlaneta(String nomp) {
            p.AddPlaneta(nomp);
        }

        public void mostrarPlanetas() {
            p.MostrarPlanetas();
        }

        public void AddRebelde() {
            p.AddRebelde();
        }

        public void MostrarRebeldes() {
            p.MostrarRebeldes();

        }

        public void findRebel()
        {
            p.findRebel();
        }

        public void MostrarOpciones()
        {
            Console.WriteLine("Qué quieres hacer?");
            Console.WriteLine("1: He cogido un rebelde");
            Console.WriteLine("2: Buscar un rebelde");
            Console.WriteLine("3: Mirar los rebeldes de un planeta");
        }
    }
}
