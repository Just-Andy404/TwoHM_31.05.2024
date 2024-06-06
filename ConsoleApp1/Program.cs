using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Пользователь вводит словами цифру от 0 до 9. Приложение
//должно перевести слово в цифру. Например, если пользователь
//ввел five, приложение должно вывести на экран 5. 

namespace ConsoleApp1
{
    internal class Program
    {
        public static void Transformation(string arr, out int sum)
        {
            sum = -1; 
            if (arr.Length > 0)
            {
                switch (arr.ToLower()) 
                {
                    case "zero":
                        sum = 0;
                        break;
                    case "one":
                        sum = 1;
                        break;
                    case "two":
                        sum = 2;
                        break;
                    case "three":
                        sum = 3;
                        break;
                    case "four":
                        sum = 4;
                        break;
                    case "five":
                        sum = 5;
                        break;
                    case "six":
                        sum = 6;
                        break;
                    case "seven":
                        sum = 7;
                        break;
                    case "eight":
                        sum = 8;
                        break;
                    case "nine":
                        sum = 9;
                        break;
                    default:
                        sum = -1; 
                        break;
                }
            }
        }


        static void Main(string[] args)
        {
            int sum;
            Console.WriteLine("Enter the number in letters: ");
            string word = Console.ReadLine();
            Transformation(word, out sum);  
            if (sum == -1)
            {
                Console.WriteLine("Input was not recognized as a number from zero to nine.");
            }
            else
            {
                Console.WriteLine("The numeric value is: " + sum);
            }
            Console.ReadLine();
        }
    }
}
