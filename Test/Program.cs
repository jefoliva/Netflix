using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EstructurasDeDatos.Lista;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 100;
            Random r = new Random();
            // add elements 1, ..., n
            Console.WriteLine(n + " random ints between 0 and 99");
            ListaDoble<int> list = new ListaDoble<int>();
            for (int i = 0; i < n; i++)
                list.Agregar(i);
            Console.WriteLine(list);
            Console.WriteLine();


            // go forwards with next() and set()
            Console.WriteLine("forward iteration");
            foreach (int num in list)
                Console.Write(num + " ");

            Console.ReadKey();

    }
}
}
