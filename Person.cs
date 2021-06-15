using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Person
    {
        public Person(string firstName, string lastName, int age, string address)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.address = address;
        }

        private string firstName { get; set; }
        private string lastName { get; set; }
        private int age { get; set; }
        private string address { get; set; }

        
    }
}
