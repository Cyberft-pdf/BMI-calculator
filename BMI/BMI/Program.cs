using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace BMI
{
    internal class Program
    {
        static void Main(string[] args)
        {

            do
            {

             //----------hlavicka zacatek-------------------
            string text = "Welcom in BMI calculator\n\n\n\n";

            for (int i = 0; i <= text.Length; i++)
            {
                Console.Clear();
                Console.SetCursorPosition(Console.WindowWidth / 2 - i / 2, Console.WindowHeight / 5);
                Console.Write(text.Substring(0, i));
                Thread.Sleep(100);
            }

            string line = new string('/', Console.WindowWidth);
            Console.WriteLine(line);
            Console.WriteLine(" ");
            //----------hlavicka konec-------------------


            //----------OTAZKY zacatek-------------------
            Console.SetCursorPosition(48, 15);
            Console.Write("Enter the weight in kg: ");
            double hmotnost = Convert.ToDouble(Console.ReadLine());


            Console.SetCursorPosition(50, 17);
            Console.Write("Enter height in m: ");
            double vyska = Convert.ToDouble(Console.ReadLine());
            //----------OTAZKY konec-------------------


            //----------VYPOČET začátek-------------------
            double BMI_vypocet = (hmotnost /  (vyska * vyska));
             //----------VYPOČET konec-------------------



             //----------POROVNANI začátek-------------------


            double BMI_vypocet_zaokrohleno = Math.Round(BMI_vypocet, 2);//zaokrouhlení na 2 desetinná čísla


                switch (BMI_vypocet)
            {


                case double bmi when bmi < 20:
                    Console.SetCursorPosition(50, 23);
                    Console.WriteLine($"You are underweight ({BMI_vypocet_zaokrohleno})"); 
                    break;

                case double bmi when bmi < 25:
                    Console.SetCursorPosition(50, 23);
                    Console.WriteLine($"You are normal ({BMI_vypocet_zaokrohleno})");
                    break;

                case double bmi when bmi < 30:
                    Console.SetCursorPosition(46, 23);
                    Console.WriteLine($"You are slightly overweight ({BMI_vypocet_zaokrohleno})");
                    break;

                case double bmi when bmi < 35:
                    Console.SetCursorPosition(50, 23);

                    Console.WriteLine($"You are obese ({BMI_vypocet_zaokrohleno})");
                    break;

                case double bmi when bmi > 35:
                    Console.SetCursorPosition(47, 23);
                    Console.WriteLine($"You are morbidly obese ({BMI_vypocet_zaokrohleno})");


                    break;


                default: 
                    Console.WriteLine("Neplatný sympol");
                    break;
            
            
            }
            //----------POROVNANI konec-------------------



                Console.Write("\n\nWould you like to continue Y/N: ");
            } while (Console.ReadLine().ToUpper() == "Y");


            Console.WriteLine("Thanks for using my calculator");
            //on github cyberft-pdf
            Console.ReadKey();





        }
    }
}
