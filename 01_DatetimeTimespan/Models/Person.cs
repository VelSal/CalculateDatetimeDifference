using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_DatetimeTimespan.Models
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }

        public Person(string name, DateTime birthDate)
        {
            this.Name = name;
            this.BirthDate = birthDate;
        }
        private static List<Person> EveryPerson()
        {
            List<Person> personList = new List<Person>();

            Person lennert = new Person("Lennert", new DateTime(1989, 07, 25));
            Person simon = new Person("Simon", new DateTime(1989, 03, 01));
            Person joris = new Person("Joris", new DateTime(1989, 04, 05));
            Person rik = new Person("Rik", new DateTime(1989, 02, 09));
            Person lotte = new Person("Lotte", new DateTime(1991, 06, 11));
            Person jelle = new Person("Jelle", new DateTime(1989, 09, 29));

            personList.Add(lennert);
            personList.Add(simon);
            personList.Add(joris);
            personList.Add(rik);
            personList.Add(lotte);
            personList.Add(jelle);

            return personList;
        }

        public static void ChoosePerson()
        {
            Console.WriteLine($"Kiez een persoon: \n0: \t{Person.EveryPerson()[0].Name} " +
                $"\n1: \t{Person.EveryPerson()[1].Name} " +
                $"\n2: \t{Person.EveryPerson()[2].Name} " +
                $"\n3: \t{Person.EveryPerson()[3].Name} " +
                $"\n4: \t{Person.EveryPerson()[4].Name} " +
                $"\n5: \t{Person.EveryPerson()[5].Name} ");

            string userChoiceInput = Console.ReadLine();
            int userChoiceOutput;
            if (int.TryParse(userChoiceInput, out userChoiceOutput) && userChoiceOutput <= Person.EveryPerson().Count)
            {
                Console.Clear();
                Console.WriteLine($"{Person.EveryPerson()[userChoiceOutput].Name} gekozen");
                CalculateDaysDiff(userChoiceOutput);
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Ongeldige invoer...");
            }
        }
        private static void CalculateDaysDiff(int userChoiceOutput)
        {
            for (int i = 0; i < Person.EveryPerson().Count; i++)
            {
                double diffDate = Math.Abs((Person.EveryPerson()[userChoiceOutput].BirthDate - Person.EveryPerson()[i].BirthDate).TotalDays);
                if (Person.EveryPerson()[userChoiceOutput].Name == Person.EveryPerson()[i].Name)
                {
                    continue;
                }
                else
                {
                    if (Person.EveryPerson()[userChoiceOutput].BirthDate > Person.EveryPerson()[i].BirthDate)
                    {
                        Console.WriteLine($"{Person.EveryPerson()[userChoiceOutput].Name} is {diffDate} dagen ouder dan {Person.EveryPerson()[i].Name}.");
                    }
                    else
                    {
                        Console.WriteLine($"{Person.EveryPerson()[userChoiceOutput].Name} is {diffDate} dagen jonger dan {Person.EveryPerson()[i].Name}.");

                    }
                }
            }
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.BirthDate}";
        }
    }
}
