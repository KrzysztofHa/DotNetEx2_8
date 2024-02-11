using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace DotNetEx2_8
{
    internal class DotNetEx2_8
    {
        static void Main(string[] args)
        {
            // 1 zadanie program sprawdza ile liczb pierwszych w zakresie od 0-100

            int n = 100;
            bool[] tab = new bool[n + 1];
            for (int i = 2; i * i <= n; i++)
            {
                if (tab[i] == true)
                {
                    continue;
                }

                for (int j = 2 * i; j <= n; j += i)
                {
                    tab[j] = true;
                }
            }

            Console.WriteLine("Liczby pierwsze z zakresu od 1 - 100 :");

            for (int i = 2; i <= n; i++)
            {
                if (tab[i] == false)
                {
                    Console.Write(i + " ");
                }
            }

            Console.Write("Naciśnij dowolny klawisz... ");
            Console.ReadKey();


            //2 zadanie program wyświetla liczby parzyste z akresu od 1- 1000
            int number = 2;
            Console.WriteLine("Liczby parzyste z zakresu od 1 - 1000");

            do
            {
                if (number% == true)
                {
                    Console.WriteLine(number + " ");
                }

                if (number % == 0)
                {

                }


            } while (number <= 1000);


        }




    } 

     
}
