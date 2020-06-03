using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    public class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private string id;
       
        public Person(string firstName, string lastName, int age)
        {
            this.id = Guid.NewGuid().ToString();
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public int Age { get => age; set => age = value; }
        public string Id { get => id; set => id = value; }
    }
}
