using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeWorkLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Home Work");
			List<Person> people = new List<Person>()
			{
			new Person("Bill", "Smith", 41, 'M'),
			new Person("Sarah", "Jones", 22, 'F'),
			new Person("Stacy","Baker", 21, 'F'),
			new Person("Vivianne","Dexter", 19, 'F' ),
			new Person("Bob","Smith", 49, 'M' ),
			new Person("Brett","Baker", 51, 'M' ),
			new Person("Mark","Parker", 19, 'M'),
			new Person("Alice","Thompson", 18, 'F'),
			new Person("Evelyn","Thompson", 58, 'F' ),
			new Person("Mort","Martin", 58, 'M'),
			new Person("Eugene","deLauter", 84, 'M' ),
			new Person("Gail","Dawson", 19, 'F' ),
			};

			// Task 01
			// all people aged 50 or more
			Console.WriteLine("============= Task 01 ===============");
            List<Person> people50AgeOrMore = people.Where(x => x.Age >= 50)
									.ToList();
			people50AgeOrMore.ForEach(x => Console.WriteLine(x.Age + " " + x.FirstName));
			// Task 02
			// all people name starts with B
			Console.WriteLine("============= Task 02 ===============");
			List<Person> peopleNameStartWithB = people.Where(x => x.FirstName.ToLower()
												.ToCharArray()[0] == 'b').ToList();
			peopleNameStartWithB.ForEach(x => Console.WriteLine(x.FirstName + " " + x.LastName));


			// Task 03
			// first person whose surname starts with T
			Console.WriteLine("============= Task 03 ===============");
			Person firstPersonSurnameStartWithT = people.FirstOrDefault(x => x.LastName.ToLower()
														.StartsWith("t"));
			Console.WriteLine(firstPersonSurnameStartWithT.LastName + " " + firstPersonSurnameStartWithT.FirstName);

			// Task 04
			// find youngest and oldest person
			Console.WriteLine("============= Task 04 ===============");
			int oldest = people.Max(r => r.Age);
			int youngest = people.Min(r => r.Age);
            List<Person> youngestPerson = people.Where(x => x.Age == youngest).ToList();
            List<Person> OldestPerson = people.Where(x => x.Age == oldest).ToList();
			youngestPerson.ForEach(x => Console.WriteLine($"Youngest person is {x.FirstName} with age: {x.Age}"));
			OldestPerson.ForEach(x => Console.WriteLine($"Youngest person is {x.FirstName} with age: {x.Age}"));
			// Task 05
			// find all male people aged 45 or more
			Console.WriteLine("============= Task 05 ===============");
			var allMaleAged45AndMore = people.Where(x => x.Gender == 'M' && x.Age >= 45).ToList();
			allMaleAged45AndMore.ForEach(x => Console.WriteLine($"Male persons aged 45 and more are: {x.FirstName} with age: {x.Age}"));

			// Task 06
			// find all females whose name starts with V

			Console.WriteLine("============= Task 06 ===============");
			List<Person> femalesNamesStartWithV = people.Where(x => x.FirstName.ToLower()
												.ToCharArray()[0] == 'v' && x.Gender == 'F').ToList();
			femalesNamesStartWithV.ForEach(x => Console.WriteLine(x.FirstName + " " + x.Gender));

			// Task 07
			// find last female person older than 30 whose name starts with p

			Console.WriteLine("============= Task 07 ===============");
			Person lastfemaleOlderThar30andNameP = people.LastOrDefault(x => x.Age > 30 && x.FirstName.StartsWith('P') && x.Gender == 'F');
			Console.WriteLine($"{lastfemaleOlderThar30andNameP} There is not such a person");

			// Task 08
			// find first male younger than 40
			Console.WriteLine("============= Task 08 ===============");
			Person firstMaleYounger40 = people.FirstOrDefault(x => x.Age < 40 && x.Gender == 'M');
			Console.WriteLine($"First male younger than 40 is {firstMaleYounger40.FirstName} with age: {firstMaleYounger40.Age} ");
			// Task 09
			// print the names of the male persons that have firstName longer than lastName
			Console.WriteLine("============= Task 09 ===============");
            List<Person> NameLonger = people.Where(x => x.FirstName.Length > x.LastName.Length
															&& x.Gender == 'M').ToList();
			NameLonger.ForEach(x => Console.WriteLine($"{x.FirstName} {x.LastName} There is now names longer than last names"));

			// Task 10
			// print the lastNames of the female persons that have odd number of ages
			Console.WriteLine("============= Task 10 ===============");
			var femaleOdd = people.Where(x => x.Age % 2 == 0 && x.Gender == 'F').ToList();
			femaleOdd.ForEach(x => Console.WriteLine(x.LastName));

			Console.ReadLine();
		}
    }
}
