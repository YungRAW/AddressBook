using System;
using System.Collections.Generic;
using System.Text;

namespace AdressBook
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CNP { get; set; }
        public Adress adress { get; set; }

        public Person(string FirstName, string LastName, string CNP, Adress adress)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.CNP = CNP;
            this.adress = adress;
        }
    }
}
