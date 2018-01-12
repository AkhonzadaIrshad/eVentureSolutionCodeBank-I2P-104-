using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {







        static void Main(string[] args)
        {
            //For 
            //int number;
            //number = Convert.ToInt32(Console.ReadLine());

            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"{number} X {i} = {number*i}");
            //}

            //While

            //int number = Convert.ToInt32(Console.ReadLine());
            //int i = 1;
            //while (number!=0)
            //{
            //    Console.WriteLine($"{number} X {i} = {number * i}");
            //    i++;
            //    number= Convert.ToInt32(Console.ReadLine());

            //}


            //int number;
            //int i = 1;
            //do
            //{
            //    number = Convert.ToInt32(Console.ReadLine());
            //    Console.WriteLine($"{number} X {i} = {number * i}");
            //    i++;

            //} while (number != 0);



            //Calling First Method
            //FirstMethod();

            //string Value = "EVS LAHORE";
            //SecondMethod(Value);//Arguments

            Console.WriteLine("Number One");
            int first = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number Two");
            int second = Convert.ToInt32(Console.ReadLine());
            //Add(first, second);
            Console.WriteLine("Operation (+,-,/,*)");
            char operation = Convert.ToChar(Console.ReadLine());


            

            int result = Calculator(first, second, operation);
            //result = Calculator(first, second, operation);
            //result = Calculator(first, second, operation);
            //result = Calculator(first, second, operation);
            //result = Calculator(first, second, operation);
            if (result != 0)
            {
                Display($"Result : { first } {operation} {second} = {result}");
            }
            else
            {
                Display("Invalid Operation");
            }


            ////Display(Convert.ToString(Calculator(first, second, operation)));

            // Console.WriteLine("Hello From Main Method");

            // Console.WriteLine("Press Any Key....");
            Console.ReadKey();

        }


        static void Display(string Text)
        {
            Console.WriteLine(Text);
        }

        static int Calculator(int first, int second, char operation)
        {

            switch (operation)
            {
                case '+':
                    {
                        return first + second;

                    }
                case '-':
                    {
                        return first - second;

                    }
                case '*':
                    {
                        return first * second;
                    }
                case '/':
                    {
                        return first / second;
                    }
                default:
                    {
                        return 0;
                    }
            }



        }





        static void Add(int first, int second)
        {


            Console.WriteLine($"Addition of Two Numbers {first + second}");

        }





        static void SecondMethod(string Text)//Parameters
        {
            Console.WriteLine($"Your Value : {Text}");
        }

        static void FirstMethod()
        {

            Console.WriteLine("Hello From First Method");

        }

    }
}
