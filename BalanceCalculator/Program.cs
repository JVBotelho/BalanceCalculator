using System;
using System.Collections.Generic;

namespace BalanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> listaMetas = new List<double>();
            List<double> listaEntrada = new List<double>();
            double valorDes = 0;
            double diff = 0;
            Console.WriteLine("Hello World!");

            Console.WriteLine("Entre com o valor da carteira");
            listaEntrada.Add(double.Parse(Console.ReadLine()));

            Console.WriteLine("Entre com a meta % da carteira");
            listaMetas.Add(double.Parse(Console.ReadLine()));

            Console.WriteLine("Entre com o valor da Reserva");
            listaEntrada.Add(double.Parse(Console.ReadLine()));

            Console.WriteLine("Entre com a meta % da reserva");
            listaMetas.Add(double.Parse(Console.ReadLine()));

            var total = listaEntrada[0] + listaEntrada[1];
            var percMeta2 = Math.Round((listaEntrada[1] / total)*100,2);

            while(percMeta2 < listaMetas[1])
            {
                valorDes = Math.Round((listaMetas[1]/100) * total, 2);
                diff = Math.Round(valorDes - listaEntrada[1], 2);
                total = Math.Round(listaEntrada[0] + valorDes, 2);
                percMeta2 = Math.Round((valorDes / total) * 100, 2);
            }
            Console.WriteLine("O valor a ser investido na reserva é de R$" + diff);
            Console.ReadLine();
        }
    }
}
