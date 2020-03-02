using System;
using System.Collections.Generic;
using System.Text;

// Page 176

namespace PersonClass_v2
{
    // This class cannot be instantiated
    public abstract class Person
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public void SayName()
        {
            Console.WriteLine("Name: {0} {1}", firstName, lastName);
        }

    }
}