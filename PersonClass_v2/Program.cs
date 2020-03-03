using System;

namespace PersonClass_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This employee is going to say their name!!");
            System.Threading.Thread.Sleep(1500);
            Employee emp1 = new Employee() { firstName = "Sample", lastName = "Student" };
            emp1.SayName();

            System.Threading.Thread.Sleep(1500);
            Console.WriteLine();

            Console.WriteLine("This is another employee.  What do they have to say?");
            System.Threading.Thread.Sleep(1500);
            IQuittable emp2 = new Employee() { firstName = "Sample", lastName = "Student" };
            emp2.Quit();

            Console.Read();
        }
    }
}