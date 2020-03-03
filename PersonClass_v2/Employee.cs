using System;
using System.Collections.Generic;
using System.Text;

namespace PersonClass_v2
{
    public class Employee : Person, IQuittable
    {
        public void Quit()
        {
            Console.WriteLine("This job sucks!  I quit!");
            System.Threading.Thread.Sleep(1500);
            System.Environment.Exit(0);
        }

        public override void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }
    }
}