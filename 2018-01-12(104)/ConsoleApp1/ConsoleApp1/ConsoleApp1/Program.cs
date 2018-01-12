using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {


        //Fields
        private int rollNumber;
        private string Name;
        private double Fees;
        private string Password;


        //Properties
        public int RollNumber
        {
            get
            {
                return rollNumber;

            }
            set
            {
                rollNumber = value;

            }
        }

        //public void SetPassword(string p)
        //{
        //    //Encrypt
        //    Password = p;
        //}
        //public string getPassword()
        //{
        //    //Decrypt
        //    return Password;
        //}


        //public void SetRollNumber(int r)
        //{
        //    if (r>0&&r!=0)
        //    {
        //        rollNumber = r;
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid Entry");
        //    }
            

        //}

        //public int getRollNumber()
        //{
        //    return rollNumber;
        //}
        //public void SetName(string n)
        //{
        //   Name = n;
        //}

        //public string getName()
        //{
        //    return Name;
        //}
        //public void SetFees(double f)
        //{
        //    Fees = f;
        //}

        //public double getFees()
        //{
        //    return Fees;
        //}



        //Methods
        //public void Input()
        //{
        //    Fees =Convert.ToDouble(Console.ReadLine());
        //    Name = Console.ReadLine();

        //}
        public void Display()
        {
            Console.WriteLine(rollNumber);
            Console.WriteLine(Name);
            Console.WriteLine(Fees);
        }


    }


    class Program
    {
        static void Main(string[] args)
        {

            Student first;
            first = new Student();
            //first.Fees = 11000.00;
            //first.Name = "Hamza";
            //first.rollNumber = 11;
            //first.Input();
        
            //first.SetName("Irshad");
            //first.SetRollNumber(123);
            //first.RollNumber = 123;
            //Console.WriteLine(first.RollNumber);

            //first.SetFees(2000.00);
            first.Display();

            Student second;
            second = new Student();
            //second.Input();
            //second.SetName("Ahmed");
            //second.SetRollNumber(1122);
            //second.SetFees(3000.00);
            second.Display();

            //double feesTotal = first.getFees() + second.getFees();

            //Console.WriteLine(feesTotal);



        }
    }
}
