using System;
using System.Collections.Generic;
using System.Text;

namespace AdressBook
{
    public class Menu
    {

        private IGraphicUserInterface gui;
        private MenuStates currentState;
        private MenuPrinter menuPrinter;
        private MenuValidator menuValidator;
        private bool isStarted;
        private AdressBook adressBook;
        private Person person;

        private List<Person> people = new List<Person> {
        new Person("Ion", "Alexandru", "197197197197", new Adress("Craiova", "Romania", "str.Calea Bucuresti", "100")),
        new Person("Miller", "Mihai", "198198198198", new Adress("Craiova", "Romania", "str.Calea Bucuresti", "101")),
        new Person("Sandu", "Alexandru", "222222222222", new Adress("Craiova", "Romania", "str.Calea Bucuresti", "102")),
        new Person("Albulescu", "Matei", "333333333333", new Adress("Bucuresti", "Romania", "str.Nebunilor", "100")),
        new Person("Ionescu", "Ion", "44444444444", new Adress("Pitesti", "Romania", "str.Eroilor", "90")),
        new Person("Mikel", "John", "555555555555", new Adress("Londra", "Anglia", "str. Magnatilor", "1")),
        new Person("Argintaru", "Alin", "666666666666", new Adress("Bucuresti", "Romania", "str.Florilor", "22")),
        new Person("Murloc", "Viorel", "777777777777", new Adress("Bucuresti", "Romania", "str.Programatorilor", "15"))
        };

        public Menu(IGraphicUserInterface gui)
        {
            this.gui = gui;
            this.currentState = MenuStates.Initialized;
            this.menuPrinter = new MenuPrinter(gui);
            this.menuValidator = new MenuValidator();
            this.isStarted = false;
            this.adressBook = new AdressBook();
        }

        public void Start()
        {
            isStarted = true;
            while (isStarted)
            {
                string userInput;

                switch (currentState)
                {
                    case MenuStates.Initialized:
                        menuPrinter.FirstScreen();
                        userInput = gui.ReadInput();
                        currentState = menuValidator.ValidateTransition(currentState, userInput);
                        break;

                    case MenuStates.AddingPerson:
                        menuPrinter.SecondScreen();
                        person = gui.ReadPerson();
                        adressBook.AddPerson(person);
                        currentState = menuValidator.ValidateTransition(currentState);
                        break;

                    case MenuStates.RemovingPerson:
                        menuPrinter.ThirdScreen();
                        adressBook.RemovePerson(adressBook.people, person);
                        currentState = menuValidator.ValidateTransition(currentState);
                        break;

                    case MenuStates.FindPersonByCNP:
                        menuPrinter.FourthScreen();
                        gui.PrintMessageOnLine("Insert the CNP of the person that you wish to search for.");
                        userInput = gui.ReadInput();
                        adressBook.ListAllPersons(adressBook.FindPersonByID(people, userInput));
                        currentState = menuValidator.ValidateTransition(currentState, userInput);
                        break;

                    case MenuStates.ShowAllPersons:
                        menuPrinter.SeventhScreen();
                        adressBook.ListAllPersons(adressBook.people);
                        currentState = menuValidator.ValidateTransition(currentState);
                        break;

                    case MenuStates.ShowAllPersonsFromCity:
                        menuPrinter.FifthScreen();
                        gui.PrintMessageOnLine("Insert the city of the person that you wish to search for.");
                        userInput = gui.ReadInput();
                        adressBook.ListAllPersons(adressBook.FindAllPersonsInCity(people, userInput));
                        currentState = menuValidator.ValidateTransition(currentState, userInput);
                        break;

                    case MenuStates.ShowAllPersonsFromCountry:
                        menuPrinter.SixthScreen();
                        gui.PrintMessageOnLine("Insert the CNP of the person that you wish to search for.");
                        userInput = gui.ReadInput();
                        adressBook.ListAllPersons(adressBook.FindAllPersonsInCountry(people, userInput));                      
                        currentState = menuValidator.ValidateTransition(currentState, userInput);
                        break;

                    case MenuStates.Finished:
                        menuPrinter.SeventhScreen();
                        currentState = menuValidator.ValidateTransition(currentState);
                        break;

                    case MenuStates.Exit:
                        isStarted = false;
                        break;
                }
            }
        }
    }
}
