using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LinqExample
{
    class Program
    {
        static void Main(string[] args)
        {

            Person pers1 = new Person("Moshe", "Davidov", 15);
            Person pers2 = new Person("Dany", "Davidov", 2);
            Person pers3 = new Person("Alex", "Davidov", 22);
            Person pers4 = new Person("Rahel", "Davidov", 55);

            List<Person> people = new List<Person>();
            people.Add(pers1);
            people.Add(pers2);
            people.Add(pers3);
            people.Add(pers4);


            List<Person> peopleDavidov = people.Where(x => x.LastName == "Davidov").ToList();
            List<Person> peopleBigger = people.Where(x => x.Age > 10).ToList();
            List<Person> peopleBiggerDavidov = people.Where(x => x.Age > 10 && x.LastName=="Davidov").ToList();
            Dictionary<string, Person> dictpeopleBiggerDavidov = people.Where(x => x.Age > 10 && x.LastName == "Davidov").ToDictionary(x=>x.Id);



        }
    }
}
