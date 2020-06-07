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
            Random random = new Random();


            List<Person> peopleDavidov = people.Where(x => x.LastName == "Davidov").ToList();

            var query1= people.Where(x => x.LastName == "Davidov");



            var query2 = query1.Where(x => x.FirstName == "Moshe");

            List<Person> peopleBigger = people.Where(x => x.Age > 10).ToList();
            List<Person> peopleBiggerDavidov = people.Where(x => x.Age > 10 && x.LastName=="Davidov").ToList();
            Dictionary<string, Person> dictpeopleBiggerDavidov = people.Where(x => x.Age > 10 && x.LastName == "Davidov").ToDictionary(x=>x.Id);

            List<Person> peopleDavidovSorted = people.Where(x => x.LastName.StartsWith("D")).OrderBy(x => x.FirstName).ToList();
            List<Person> peopleDavidovSortedDesc = people.Where(x => x.LastName.StartsWith("D")).OrderByDescending(x => x.FirstName).ToList();

            peopleDavidovSorted.ForEach(x => x.Age = x.Age + 3);

            List<Person> peopleDavidovSortedDescOnly3Person = people.Where(x => x.LastName.StartsWith("D")).OrderByDescending(x => x.FirstName).Take(3).ToList();
            List<Person> peopleDavidovSortedDescOnly2PersonFromFirst = people.Where(x => x.LastName.StartsWith("D")).OrderByDescending(x => x.FirstName).Skip(1).Take(2).ToList();

            // print all people earning above 7000
            people.ToList().ForEach(z => z.Salary=random.Next(5000,10000));

            people.Where(p => p.Salary >= 7000).TakeWhile(x=>x.Age>10).ToList().ForEach(z => Console.WriteLine(z.LastName + " " + z.FirstName + " " + z.Salary));


            Console.ReadKey();

        }
    }
}
