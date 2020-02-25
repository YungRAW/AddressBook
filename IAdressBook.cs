using System;
using System.Collections.Generic;
using System.Text;

namespace AdressBook
{
    interface IAdressBook
    {
        List<Person> ListAllPersons(List<Person> ppl);
        Person AddPerson(Person person);
        Person RemovePerson(List<Person> people, Person person);
        List<Person> FindPersonByID(List<Person> people, string CNP);
        List<Person> FindAllPersonsInCity(List<Person> people, string City);
        List<Person> FindAllPersonsInCountry(List<Person> people, string Country);
    }
}
