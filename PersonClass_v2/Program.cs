using System;

namespace PersonClass_v2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This employee is going to say their name!!");
            System.Threading.Thread.Sleep(1000);
            Employee emp = new Employee() { firstName = "Sample", lastName = "Student" };
            emp.SayName();

            Console.WriteLine("\nWOW!  That's a weird name!");
            Console.Read();
        }
    }
}