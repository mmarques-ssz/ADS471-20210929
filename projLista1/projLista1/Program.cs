using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projLista1
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaInteiros;
            listaInteiros = new List<int>();

            listaInteiros.Add(44);
            listaInteiros.Add(33);
            listaInteiros.Add(22);
            listaInteiros.Add(11);
            mostraLista(listaInteiros);

            listaInteiros.Insert(3, 99);
            mostraLista(listaInteiros);

            Console.WriteLine("Posição do 33: {0}", listaInteiros.IndexOf(33));
            Console.WriteLine("Posição do 99: {0}", listaInteiros.IndexOf(99));
            Console.WriteLine("Posição do 77: {0}", listaInteiros.IndexOf(77));
            Console.WriteLine("-----------------");

            Console.WriteLine(listaInteiros.Remove(22) ? "Removeu o 22" : "Não achou o 22");
            Console.WriteLine(listaInteiros.Remove(23) ? "Removeu o 23" : "Não achou o 23");
            Console.WriteLine("-----------------");
            mostraLista(listaInteiros);

            listaInteiros.RemoveAt(2);
            mostraLista(listaInteiros);


            Console.ReadKey();
        }

        static void mostraLista(List<int> lista)
        {
            Console.WriteLine("Qtde: {0}", lista.Count);
            foreach (int i in lista)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("-----------------");
        }

    }
}
