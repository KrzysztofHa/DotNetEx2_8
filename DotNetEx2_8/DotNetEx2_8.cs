using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection.Metadata;
using System.ComponentModel.DataAnnotations;


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

            Console.Write("\nNaciśnij dowolny klawisz... ");
            Console.ReadKey();


            //2 zadanie program wyświetla liczby parzyste z akresu od 1- 1000
            int number = 2;
            Console.Clear();
            Console.WriteLine("Liczby parzyste z zakresu od 1 - 1000");
                        
            do
            {
                if (number % 2  == 0)
                {
                    Console.Write(number + " ");
                }
                number++;
            } while (number <= 1000);

            Console.Write("\nNaciśnij dowolny klawisz... ");
            Console.ReadKey();

            //3 zadanie program implementuje ciąg fibonaciego
            Console.Clear();
            Console.WriteLine("Ciąg fibonacciego");
            int
                a1 = 0, 
                b1 = 0, 
                c1 ;

            for (int i = 0; i <= 20; i++)
            {
                if (i > 1)
                {
                    c1 = a1 + b1;
                    a1 = b1;
                    b1 = c1;
                }
                else
                {
                    c1 = i;
                    b1 = c1;
                }
                Console.WriteLine($"{i + 1}: {c1}, ");
            }
            Console.Write("\nNaciśnij dowolny klawisz... ");
            Console.ReadKey();

            //4 piramida liczb od 1 do podanej

            while (true) 
            {
                Console.Clear();
                Console.WriteLine("Piramida liczb");
                Console.WriteLine("Podaj liczbę ");
                var stringNumber = Console.ReadLine();
                if (int.TryParse(stringNumber, out number) && number > 0)
                {
                    Console.Clear();
                    int writeNumber = 1;
                    for (int i = 1; i <= number; i++)
                    {
                        for (int i1 = 1; i1 <= i; i1++)
                        {
                            Console.Write(writeNumber + " ");
                            writeNumber++;
                            if (writeNumber == number + 1)
                            {
                                i = number + 1;
                                break;
                            }
                        }
                        Console.WriteLine(" ");
                    }
                    Console.Write("\nNaciśnij dowolny klawisz... ");
                    Console.ReadKey();
                    break;
                }
            } 

            //5 zadanie wyświetl 3 potęgę dla liczb z zakresu od 1-20

            Console.Clear();
            Console.WriteLine("wyświetla 3 potęgę dla liczb z zakresu od 1-20");
            for (int i = 1 ; i <= 20; i++)
            {
                Console.WriteLine($"{i}^{3} = {(long)Math.Pow(i, 3):N0}");
            }
            Console.Write("\nNaciśnij dowolny klawisz... ");
            Console.ReadKey();

            //6 zadanie oblicza sumę 

            Console.Clear();
            Console.WriteLine("Oblicza sumę liczb od 0-20 według wzoru ");
            Console.WriteLine("!!! nie dzielimy przez zero");

            decimal sum = 0;
            for (int i = 1; i <= 20; i++) 
            {
                for (int j = 1; j <= 20; j++)
                {
                    sum = sum + (decimal)i / j;                   
                }
                Console.Write("\n{0}: {1:N3}", i, sum);                
            }
            Console.Write("\nNaciśnij dowolny klawisz... ");
            Console.ReadKey();
            Console.Clear();

            //7 zadanie Program, który dla zadanej liczby narysuje diament

            int windowWidth = Console.WindowWidth;
            int windowHeight = Console.WindowHeight;
            int diagonal;            

            if (windowWidth > windowHeight) 
            {
                diagonal = windowHeight -2;            
            }else 
            {
                diagonal = windowWidth;
            }

            if (diagonal % 2 == 0)
            {
                diagonal--;
            }
            
            while (true)
            {                
                Console.WriteLine("Podaj dodatnią nieparzystą liczbę z przedziału od 3 - " + diagonal);
                Console.WriteLine("");
                string readNumber = Console.ReadLine();
                if (int.TryParse(readNumber, out int readDiagonal) && readDiagonal >= 3 && (readDiagonal % 2 != 0) && readDiagonal <= diagonal)
                {
                    int numberOfSpace = Math.Abs(readDiagonal / 2);
                    int numberOfAsterisk = 1;
                    int numberOfScctionI = readDiagonal - numberOfSpace - 1;
                    Console.Clear();

                    for (int i = 0; i <= numberOfScctionI; i++)
                    {
                        for (int j = 1; j <= numberOfSpace - i; j++)
                        {
                            Console.Write(" ");
                        }

                        for (int k = 1; k <= numberOfAsterisk + i; k++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();
                        numberOfAsterisk++;
                    }

                    numberOfSpace = 1;
                    numberOfAsterisk = readDiagonal - 2;
                    int numberOfScctionII = readDiagonal - (Math.Abs(readDiagonal / 2)) - 2;

                    for (int i = 0; i <= numberOfScctionII; i++)
                    {
                        for (int k = 1; k <= numberOfSpace + i; k++)
                        {
                            Console.Write(" ");
                        }

                        for (int j = 1; j <= numberOfAsterisk - i; j++)
                        {
                            Console.Write("*");
                        }
                        Console.WriteLine();

                        numberOfAsterisk--;
                    }

                    Console.Write("\nNaciśnij dowolny klawisz... ");
                    Console.ReadKey();
                    Console.Clear();                    
                    break;
                }               
            }

            //8 zadanie odwracanie wprowadzonych ciągów
            string readSequence = string.Empty;
            string invertedSequence = string.Empty;
            while (true)
            {
                Console.WriteLine("Podaj ciąg znaków");
                readSequence = Console.ReadLine();
                if (string.IsNullOrEmpty(readSequence))
                {
                    Console.WriteLine("Niepodałeś żadnego ciągu");
                }
                else{
                    readSequence = readSequence.ToLower();
                    readSequence = readSequence.Trim();                    

                    for (int i = readSequence.Length - 1; i >= 0; i--)
                    {
                        if (i == readSequence.Length - 1)
                        {
                            invertedSequence += readSequence[i];
                            invertedSequence = invertedSequence.ToUpper();
                        }
                        else
                        {
                            invertedSequence += readSequence[i];
                        }
                    }
                    Console.Clear();
                    Console.WriteLine(invertedSequence);
                    break;
                }                               
            }
            Console.Write("\nNaciśnij dowolny klawisz... ");
            Console.ReadKey();

            //9 zamiana liczby dziesiętnej na binarną

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Konwersja liczb");
                Console.WriteLine("Podaj liczbę ");
                var stringNumber = Console.ReadLine();

                if (decimal.TryParse(stringNumber, out decimal decimalNumber) && decimalNumber != 0)
                {                    
                    stringNumber = string.Empty;
                    int[] decimalToBits = decimal.GetBits(decimalNumber);              
                    Console.WriteLine();
                    foreach (var value in decimalToBits)
                    {                        
                        Console.Write(Convert.ToString(value, toBase: 2)+" ");
                    }
                    break;
                    Console.ReadKey(true);
                }  
            }
            Console.Write("\nNaciśnij dowolny klawisz... ");
            Console.ReadKey();
            Console.Clear();

            //10 znajdz najmniejszą wspulną wielokrotność dla dwóch liczb
            Console.WriteLine("najmniejsza wspólna wielokrotność dwóch liczb");

            int number1,number2;
            while (true)
            {
                Console.WriteLine("Podaj pierwszą liczbę");
                string string1 = Console.ReadLine(); 
                if(int.TryParse(string1, out number1) && number1 != 0)
                {
                    break;
                }
            }
            while (true)            
            {
                Console.WriteLine("Podaj drugą liczbę");
                string string2 = Console.ReadLine(); 
                if(int.TryParse(string2, out number2) && number2 != 0) 
                {  
                    break;
                }
            }

            int a = number1,
                b = number2,
                temp = b;
            while (b != 0)
            {
                temp = b;
                b = a % b;
                a = temp;
            }
            int lcm = (number1 / temp) * number2;
            Console.WriteLine("najmniejsza wspólna wielokrotność dla podanych liczb {1} i {2} to {0}", lcm, number1, number2);

        } //main
    }      
}
