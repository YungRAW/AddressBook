using System;
using System.Collections.Generic;
using System.Text;

namespace AdressBook
{
    public class ConsoleUserInterface : IGraphicUserInterface
    {
        public void PrintMessage(string message)
        {
            Console.Write(message);
        }

        public void PrintMessageOnLine(string message)
        {
            Console.WriteLine(message);
        }

        public string ReadInput()
        {
            Console.Write("Your input: ");
            String userInput;
            userInput = Console.ReadLine();
            return userInput;
        }

        public int ReadInputInteger()
        {
            int value = -1;
            if (int.TryParse(ReadInput(), out value))
            {
                return value;
            }

            return 0;
        }

        public void AwaitUserInput()
        {
           Console.WriteLine("Press any key to continue..");
           Console.ReadLine();
        }

        public void ClearScreen()
        {
            Console.Clear();
        }

        public void PrintPerson(Person person)
        {
            Console.WriteLine("First Name: " + person.FirstName);
            Console.WriteLine("Last Name: " + person.LastName);
            Console.WriteLine("Phone Number: " + person.CNP);
            Console.WriteLine("City : " + person.adress.City);
            Console.WriteLine("Country : " + person.adress.Country);
            Console.WriteLine("Street : " + person.adress.Street);
            Console.WriteLine("Street Number : " + person.adress.StreetNumber);
            Console.WriteLine("-------------------------------------------");
        }

        public Person ReadPerson()
        {
            string FirstName, LastName, CNP, City, Country, Street, StreetNo;

            this.PrintMessageOnLine("Insert first name:");
            FirstName = this.ReadInput();
            this.PrintMessageOnLine("Insert last name:");
            LastName = this.ReadInput();
            this.PrintMessageOnLine("Insert CNP:");
            CNP = this.ReadInput();
            this.PrintMessageOnLine("Insert city:");
            City = this.ReadInput();
            this.PrintMessageOnLine("Insert country:");
            Country = this.ReadInput();
            this.PrintMessageOnLine("Insert street:");
            Street = this.ReadInput();
            this.PrintMessageOnLine("Insert street number:");
            StreetNo = this.ReadInput();

            Person generatedPerson = new Person(FirstName,LastName, CNP, new Adress(City, Country, Street, StreetNo));

            Console.WriteLine("Here are the details that you entered.");

            PrintPerson(generatedPerson);

            return generatedPerson;
        } 
    }
}
