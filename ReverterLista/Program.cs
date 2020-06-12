using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverterLista
{
    public class Program
    {
        static void Main(string[] args)
        {

            int[] v = { 1, 2, 3, 4, 100, 66 };
            int[] b = { };

            trocar(v, 0, v.Length - 1);

            for (int i = 0; i < v.Length; i++)
            {
                Console.WriteLine(v[i]);
            }

            Console.ReadLine();
        }

        public static void trocar(int[] lista, int i, int j)
        {
            if (i < j)
            {
                int aux = lista[i];
                lista[i] = lista[j];
                lista[j] = aux;
                trocar(lista, i + 1, j - 1);

            }
        }
    }
}
