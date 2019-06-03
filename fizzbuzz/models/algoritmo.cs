using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace fizzbuzz.models
{
    class algoritmo
    {
        Random ran = new Random();
        public void algor(int n) {
            int r = ran.Next(n + 1, 100);
            String line;
            StreamWriter sf;
            try
            {
                sf = new StreamWriter(@"C:\Users\ricar\Documents\proyecto\fibuzz.txt");
                using (sf)
                {
                    for (int i = n; i < r; ++i)
                    {
                        if (i % 5 == 0 && i % 3 == 0) line = "fizzbuzz";
                        else if (i % 3 == 0) line = "fizz";
                        else if (i % 5 == 0) line = "Buzz";
                        else line = Convert.ToString(i);
                        if (i < r - 1) line += ", ";
                        sf.Write(line);
                    }
                    sf.Close();
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
    }
}
