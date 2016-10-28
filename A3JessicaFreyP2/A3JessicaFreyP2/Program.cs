/* Program name: A3JessicaFreyP2
 * Purpose: To perform simple calculations
 * Modified History: Jessica Frey October 2016
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A3JessicaFreyP2
{
    class Program
    {
        static void Main(string[] args)
        {
            int option;
            char opperation;
            float firstInput;
            float secondInput;
            float total;          

            option = getOption();
            firstInput = getInput1();
            secondInput = getInput2();

            if (option == 1)
            {
                opperation = 'A';
            }
            else if (option == 2)
            {
                opperation = 'S';
            }
            else if (option == 3)
            {
                opperation = 'M';
            }
            else
            {
                opperation = 'D';
            }
            switch (opperation)
            {
                case 'A':
                    {
                        opperation = '+' ;
                        break;
                    }
                case 'S':
                    {
                        opperation = '-';
                        break;
                    }
                case 'M':
                    {
                        opperation = '*';
                        break;
                    }
                case 'D':
                    {
                        opperation = '/';
                        break;
                    }

            }
            if (opperation == '+' )
            {
                total = firstInput + secondInput;
            }
            else if (opperation == '-')
            {
                total = firstInput - secondInput;
            }
            else if (opperation == '*')
            {
                total = firstInput * secondInput;
            }
            else
            {
                total = firstInput / secondInput;
            }
            Console.WriteLine(firstInput + " " +
                opperation + " " + secondInput + " " + "=" + " " + total);
            Console.ReadLine();

        }
        private static int getOption()
        {
            int option = 0;
            bool isValidOption = false;
            while (!isValidOption)
            {
                try
                {
                    Console.WriteLine("What opperation would you like to do?" );
                    Console.WriteLine("1. Addition");
                    Console.WriteLine("2. Subtraction");
                    Console.WriteLine("3. Multiplication");
                    Console.WriteLine("4. Division");

                    option = int.Parse(Console.ReadLine());
                    isValidOption = true;

                    if (option <1 || option >4)
                    {
                        Console.Clear();
                        Console.WriteLine("You have entered an invalid opperation, please try again.");
                        isValidOption = false;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("You have entered an incorrect opperator. Please choose an option between 1 and 4." );
                    Console.Clear();
                }
            }
            return option;
        }

        private static float getInput1()
        {
            float firstInput = 0;
            bool isValidInput1 = false;
            while (!isValidInput1)
            {
                try
                {
                    Console.WriteLine("Please enter the first number you would like to use between 0 and 9999: ");
                    firstInput = float.Parse(Console.ReadLine());
                    isValidInput1 = true;

                    if (firstInput <0 || firstInput > 9999)
                    {
                        Console.Clear();
                        Console.WriteLine("You have entered an invalid input.");
                        isValidInput1 = false;
                    }                    

                 }
                catch (Exception)
                {
                    Console.WriteLine("You have entered an incorrect input. Please enter the number" +
                        "you would like to use");
                    Console.Clear();

                }
            }
            return firstInput;
        }
        private static float getInput2()
        {
            float secondInput = 0;
            bool isValidInput2 = false;
            while (!isValidInput2)
            {
                try
                {
                    Console.WriteLine("Please enter the second number you would like to use between 0 and 9999: ");
                    secondInput = float.Parse(Console.ReadLine());
                    isValidInput2 = true;

                    if (secondInput < 0 || secondInput > 9999)
                    {
                        Console.Clear();
                        Console.WriteLine("You have entered an invalid input.");
                        isValidInput2 = false;
                    }
                }
                catch (Exception)
                {

                    Console.WriteLine("You have entered an incorrect input. Please enter the number" +
                       "you would like to use");
                    Console.Clear();

                }
            }
            return secondInput;
            
        }
      
    }
}
