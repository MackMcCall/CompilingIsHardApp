using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompilingIsHardConsoleUI
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        private string Address { get; set; }
        public DateTime Dob { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }

        private static readonly int numberOfLegs = 0;
        public int NumberOfLegs { get; init; } = numberOfLegs;

        public void SayName()
        {
            Console.WriteLine($"My name is {Name}");
        }

    }
}
