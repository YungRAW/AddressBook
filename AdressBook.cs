using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdressBook
{
    class AdressBook : IAdressBook
    {

        public List<Person> people = new List<Person> {
        new Person("Ion", "Alexandru", "197197197197", new Adress("Craiova", "Romania", "str.Calea Bucuresti", "100")),
        new Person("Miller", "Mihai", "198198198198", new Adress("Craiova", "Romania", "str.Calea Bucuresti", "101")),
        new Person("Sandu", "Alexandru", "222222222222", new Adress("Craiova", "Romania", "str.Calea Bucuresti", "102")),
        new Person("Albulescu", "Matei", "333333333333", new Adress("Bucuresti", "Romania", "str.Nebunilor", "100")),
        new Person("Ionescu", "Ion", "44444444444", new Adress("Pitesti", "Romania", "str.Eroilor", "90")),
        new Person("Mikel", "John", "555555555555", new Adress("Londra", "Anglia", "str. Magnatilor", "1")),
        new Person("Argintaru", "Alin", "666666666666", new Adress("Bucuresti", "Romania", "str.Florilor", "22")),
        new Person("Murloc", "Viorel", "777777777777", new Adress("Bucuresti", "Romania", "str.Programatorilor", "15"))
        };

        public List<Person> ListAllPersons(List<Person> ppl)
        {
            IGraphicUserInterface gui = new ConsoleUserInterface();
            foreach (Person person in ppl)
            {
                gui.PrintPerson(person);
                Console.ReadLine();
            }
            return ppl;
        }

        public Person AddPerson(Person person)
        {
            people.Add(person);
            Console.Write("Person added succesfully.");
            return person;

        }

        public Person RemovePerson(List<Person> people, Person person)
        {
            IGraphicUserInterface gui = new ConsoleUserInterface();
            gui.PrintMessageOnLine("Enter the CNP of the person you would like to remove.");
            string cnp = gui.ReadInput();
            person = people.FirstOrDefault(x => x.CNP == cnp);

            if (person == null)
            {
                gui.PrintMessageOnLine("That person could not be found.");
                gui.ReadInput();
                return null;
            }
            else
            {
                people.Remove(person);
                Console.WriteLine("Person {0} deleted.", person.LastName);
                gui.ReadInput();
                return person;
            }      
        }

        public List<Person> FindPersonByID(List<Person> people, string CNP)
        {
            List<Person> result = new List<Person>();
            result = people.FindAll(person => person.CNP == CNP);
            return result;
        }

        public List<Person> FindAllPersonsInCity(List<Person> people, string City)
        {
            List<Person> result = new List<Person>();
            result = people.FindAll(person => person.adress.City == City);
            return result;
        }


        public List<Person> FindAllPersonsInCountry(List<Person> people, string Country)
        {
            List<Person> result = new List<Person>();
            result = people.FindAll(person => person.adress.Country == Country);
            return result;
        }
    }
}
