using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace projLista2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Coisa> listaCoisas;
            listaCoisas = new List<Coisa>();

            listaCoisas.Add(new Coisa(1, "UM"));
            listaCoisas.Add(new Coisa(2, "DOIS"));
            listaCoisas.Add(new Coisa(3, "TRÊS"));
            mostraLista(listaCoisas);
            
            Coisa coisinha = new Coisa(9, "NOVE");

            listaCoisas.Insert(2, coisinha);
            mostraLista(listaCoisas);
            
            coisinha.Y = "NONONO";
            mostraLista(listaCoisas);

            Console.WriteLine("Posição: {0}", listaCoisas.IndexOf(new Coisa(100)));
            Console.WriteLine("-------------------");

            Console.WriteLine(listaCoisas.Remove(new Coisa(1)) ? "Removeu" : "Não removeu");
            Console.WriteLine("-------------------");
            mostraLista(listaCoisas);
                        
            Console.ReadKey();
        }

        static void mostraLista(List<Coisa> lista)
        {
            Console.WriteLine("Qtde de coisas na lista: {0}", lista.Count);
            foreach (Coisa coisinha in lista)
            {
                Console.Write(coisinha.ToString());
            }
            Console.WriteLine("-------------------");
        }

    }
}
