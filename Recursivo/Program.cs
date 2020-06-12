using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Recursivo
{
    public class Program
    {
        static void Main(string[] args)
        {

            int[] v = { 1, 2, 3, 4, 100, 66 };
            int media = MediaLista(v, v.Length - 1);
            string maiormedia = "";

            Console.WriteLine($"Media da Lista:\t{ media}");

            Console.WriteLine(Maior(v, v.Length - 1));
            Console.ReadLine();

            for (int i = 0; i <= v.Length - 1; i++)
            {
                if (v[i] > media)
                {
                    maiormedia += v[i] + ";";
                }
            }

            Console.WriteLine($"Quantidade de numeros maiores que a media:{maiormedia}");
            Console.ReadLine();
        }

        public static int MediaLista(int[] lista, int ultimo)
        {

            if (ultimo == 0)
            {
                Console.WriteLine(ultimo);
                return lista[0];
            }
            int qtdNumero = ultimo + 1;
            int soma = lista[ultimo] + (qtdNumero - 1) * MediaLista(lista, ultimo - 1);

            return soma / qtdNumero;
        }

        public static int Maior(int[] lista, int n)
        {
            if (n == 0)
            {
                return lista[0];
            }
            else
            {
                int maior = Maior(lista, n - 1);

                if (maior > lista[n - 1])

                    return maior;

                else return lista[n - 1];
            }
        }
    }

}
