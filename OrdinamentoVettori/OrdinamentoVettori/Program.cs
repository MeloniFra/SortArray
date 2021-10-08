using System;

namespace OrdinamentoVettori
{
    class Program
    {
        static void Main(string[] args)
        {
            //Creazione del vettore
            int [] vettore = new int [10] { 11, 55, -9, 7, 74, 147, -87, 6, 0, 18};
            //Ordinamento del vettore
            Ordina(vettore);
            //Stampa del vettore
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(vettore[i]);
            }

            Console.ReadKey();
        }

        static void Ordina (int[] vettore)//Metodo dell'ordinamento del vettore
        {
            Array.Sort(vettore);
        }

     
    }
}
