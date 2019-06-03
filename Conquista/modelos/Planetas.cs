using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Conquista.modelos
{
    public class Planetas
    {
        private List<Planeta> planetas = new List<Planeta>();
        private int Numplanetas;
        public Planetas()
        {
            this.Numplanetas = 0;
        }

        public void AddPlaneta(String nomp)
        {
            Planeta p = new Planeta(nomp);
            planetas.Add(p);
            this.Numplanetas = this.Numplanetas + 1;
        }

        public void AddRebelde()
        {
            Console.WriteLine("Escribe el nobre del rebelde y el planeta");
            string entrada = Console.ReadLine();
            StreamWriter sw;
            try
            {
                sw = new StreamWriter(@"C:\Users\ricar\Documents\proyecto\ejemplo.txt", true);
                using (sw)
                {
                    while (entrada != "fin")
                    {
                        String nomr = entrada.Substring(0, entrada.IndexOf(" "));
                        String nomp = entrada.Substring(entrada.IndexOf(" ") + 1);
                        DateTime date = DateTime.Now;
                        String linea = nomr + " " + nomp + " " + date.ToString() + ".";
                        Planeta p = Planeta(nomp);
                        if (p == null) Console.WriteLine("Es error el planeta");
                        else
                        {
                            p.SetRebel(nomr, date);
                            sw.WriteLine(linea);

                        }
                        entrada = Console.ReadLine();
                    }
                    sw.Close();
                }
            }

            catch (FileNotFoundException e)
            {
                Console.WriteLine($"No se ha encontrado el fichero '{e}'");
            }

            catch (DirectoryNotFoundException e)
            {
                Console.WriteLine($"No se ha encontrado el directorio '{e}'");
            }

            catch (IOException e)
            {
                Console.WriteLine($"No se ha podido abrir el documento '{e}'");
            }

        }

        //muestra
        public void MostrarPlanetas()
        {
            for (int i = 0; i < this.Numplanetas; ++i) {
                Console.Write(planetas[i].GetNom());
                if (i < this.Numplanetas - 1) Console.Write(", ");
            }
            Console.WriteLine();
        }

        public void MostrarRebeldes() {
            String nomp = Console.ReadLine();
            Planeta p = Planeta(nomp);
            p.MostrarRebeldes();
        }

        public void findRebel()
        {
            Console.WriteLine("Escribe el nombre del rebelde");
            String nomr = Console.ReadLine();
            bool trobat = false;
            int i = 0;
            while (!trobat && i < Numplanetas) {
                if (planetas[i].BuscarRebel(nomr))
                {
                    trobat = true;
                    Console.WriteLine(planetas[i].GetNom());
                }
                ++i;
            }
        }

        private Planeta Planeta(String nomp) {
            for (int i = 0; i < Numplanetas; ++i)
            {
                if (nomp == planetas[i].GetNom()) return planetas[i];
            }
            return null;
        }
    }
}
