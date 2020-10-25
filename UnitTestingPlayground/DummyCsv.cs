using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace UnitTestingPlayground
{
    public static class DummyCsv
    {

        private static string _FileName = "people.txt";

        public static void AddPerson (Person person)
        {

            List<Person> PeopleList = LoadPeople(_FileName);
            PeopleList.Add(person);
            List<string> csvLines = ConvertToCsv(PeopleList);
            File.WriteAllLines(_FileName, csvLines);

        }

        public static List<string> ConvertToCsv(List<Person> People)
        {
            List<string> cvsLines = new List<string> { };

            foreach(Person person in People)
            {
                cvsLines.Add($"{person.FirstName},{person.LastName}");
            }

            return cvsLines;
        }

        public static List<Person> LoadPeople(string filename)
        {
            List<Person> people = new List<Person> { };

            
            string[] content = File.ReadAllLines(filename);

            foreach (string line in content)
            {
                string[] data = line.Split(",");
                Person newPerson = new Person { FirstName = data[0], LastName = data[1] };
                people.Add(newPerson);

            }              

            return people;

        }

    }
}
