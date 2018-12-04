using System;

namespace Salary
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Anonymous Income Comparison Progaram");
            Console.ReadLine();

            Console.WriteLine("Person 1");
            Console.WriteLine("What is your hourly rate?");
            string person1 = Console.ReadLine();
            int per1 = Convert.ToInt32(person1);
            Console.WriteLine("How many hours per week do you work?");
            string person1week = Console.ReadLine();
            int per1week = Convert.ToInt32(person1week);
            

            Console.WriteLine("Person 2");
            Console.WriteLine("What is your hourly rate?");
            string person2 = Console.ReadLine();
            int per2 = Convert.ToInt32(person2);
            Console.WriteLine("How many hours per week do you work?");
            string person2week = Console.ReadLine();
            int per2week = Convert.ToInt32(person2week);
            

            Console.WriteLine("Weekly Salary For Person 1");
            int person1salary = (per1 * per1week);
            Console.WriteLine(person1salary);
           

            Console.WriteLine("Weekly Salary For Person 2");
            int person2salary = (per2 * per2week);
            Console.WriteLine(person2salary);
            

            Console.WriteLine("Does Person1 make more than Person 2 each week?");
            bool trueOrFalse = person1salary > person2salary;
            Console.WriteLine(trueOrFalse.ToString());
            Console.ReadLine();
              



        }
    }
}
