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

            //int i = 10;
            //if (i != 0)
            //{
            //    Console.WriteLine("i is not zero");
            //    if (i % 2 == 0)
            //    {
            //        Console.WriteLine("i is zero and even too");

            //    }
            //    else
            //    {
            //        Console.WriteLine("i is not even");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("i is zero");
            //}



            int[] numbers = new int[10];

            numbers[0] = 12;
        
            //for (int i = 0; i < 10; i++)
            //{
            //    numbers[i]=Convert.ToInt32(Console.ReadLine());
            //}


            //int[,]numbers2d=new int[2,2];
            //numbers2d[0, 0] = 12;
            //for (int x = 0; x < 2; x++)
            //{
            //    for (int y = 0; y < 3; y++)
            //    {
            //        numbers2d[x, y] = Convert.ToInt32(Console.ReadLine());
            //    }
            //}


            //for (int x = 0; x < 2; x++)
            //{
            //    for (int y = 0; y < 2; y++)
            //    {
            //        Console.WriteLine(numbers2d[x,y]);
            //    }
            //}











            //int count = 0;

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = 0; j < 10; j++)
            //    {
            //        Console.WriteLine($"{count++}");
            //    }
            //}






            int rows;
            rows = Convert.ToInt32(Console.ReadLine());
            int temp = rows;
            for (int i = 0; i < rows; i++)
            {
                for (int j = i; j < rows; j++)
                {
                    Console.Write(" ");
                }


                for (int k = temp; k <= rows; k++)
                {
                    Console.Write("* ");
                }

                temp--;
                Console.Write("\n");


            }
            Console.ReadKey();


        }
    }
}
