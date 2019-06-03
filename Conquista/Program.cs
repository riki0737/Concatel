using System;
using Conquista.control;

namespace Conquista
{
    public class Program
    {
        
        static void Main(string[] args)
        {
            problema p = new problema();
            Console.WriteLine("Esciba el nombre de los planetas pero antes el número");
            int n = Convert.ToInt32(Console.ReadLine());
            String nomp;
            for (int i = 0; i < n; ++i) {
                nomp = Console.ReadLine();
                p.AddPlaneta(nomp);
            }
            String sn;
            Console.WriteLine("Quiere mostrar los planetas que ha añadido?");
            sn = Console.ReadLine();
            if (sn == "si" || sn == "Si" || sn == "SI") { p.mostrarPlanetas(); }

            p.MostrarOpciones();

            n = Convert.ToInt32(Console.ReadLine());

            while (n != 0)
            {
                if (n == 1)
                {
                    p.AddRebelde();
                }
                else if (n == 2)
                {
                    p.findRebel();
                }
                else if (n == 3)
                {
                    p.MostrarRebeldes();
                }
                Console.WriteLine();
                Console.ReadKey();
                p.MostrarOpciones();
                n = Convert.ToInt32(Console.ReadLine());
            }

        }
    }
}
