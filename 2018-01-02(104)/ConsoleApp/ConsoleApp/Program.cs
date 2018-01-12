using System;
namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {

            //string name;
            //int rollNumber;
            //int marks;
            //char grade;
            //Console.WriteLine("Enter Your Name");
            //name = Console.ReadLine();
            //Console.WriteLine("Enter Your roll Number");
            //rollNumber =Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Your marks");
            //marks = Convert.ToInt32(Console.ReadLine());

            //if (marks>=90&&marks<=100)
            //{
            //    grade = 'A';
            //}
            //else if (marks<90&&marks>=80)
            //{
            //    grade = 'B';
            //}
            //else if (marks<80&&marks>=70)
            //{
            //    grade = 'C';
            //}
            //else if (marks<70&&marks>=60)
            //{
            //    grade = 'D';
            //}
            //else
            //{
            //    grade = 'F';
            //}

            //Console.WriteLine("Student Report"               +
            //                  $"Name       : {name}\n"       +
            //                  $"RollNumber : {rollNumber}\n" +
            //                  $"Marks      : {marks}\n"      +
            //                  $"___________________\n"       +
            //                  $"Grade      : {grade}\n");


            //int[] Numbers = { 2, 3, 5 };
            //int[] numbers = new int[3];
            //Console.WriteLine("Enter Number One");
            //numbers[0] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Number Two");
            //numbers[1] = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("Enter Number Three");
            //numbers[2] = Convert.ToInt32(Console.ReadLine());

            //if (numbers[0]>numbers[1]&&numbers[0]>numbers[2])
            //{
            //    Console.WriteLine($"Number One (value:{numbers[0]}) is Greater ");
            //}
            //else if(numbers[1]>numbers[0]&&numbers[1]>numbers[2])
            //{
            //    Console.WriteLine($"Number Two (value:{numbers[1]}) is Greater ");
            //}
            //else if(numbers[2]>numbers[0]&&numbers[2]>numbers[1])
            //{
            //    Console.WriteLine($"Number Three (value:{numbers[2]}) is Greater ");
            //}
            //else
            //{
            //    Console.WriteLine("Math Error");
            //}


            int size;
            Console.WriteLine("How Many Numbers You Want To Enter ");
            size = Convert.ToInt32(Console.ReadLine());
            int[] numbers = new int[size];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine($"Enter Number {i+1}");
                numbers[i] = Convert.ToInt32(Console.ReadLine());

            }
            //maximum=-4
            //-4,-5,-6

            int maximum = numbers[0];
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i]>maximum)
                {
                    maximum = numbers[i];
                }
            }

            Console.WriteLine($"Maximum Number : {maximum}");
            Console.WriteLine();
            Console.ReadKey();




        }
    }
}
