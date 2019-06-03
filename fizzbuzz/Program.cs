using System;
using fizzbuzz.models;

namespace fizzbuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            algoritmo a = new algoritmo();
            Console.WriteLine("Hello!");
            Console.WriteLine("Escriba un número");
            int n = Convert.ToInt32(Console.ReadLine());
            a.algor(n); 
        }
    }
}
