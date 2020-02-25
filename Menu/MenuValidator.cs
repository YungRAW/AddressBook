using System;
using System.Collections.Generic;
using System.Text;

namespace AdressBook
{
    public class MenuValidator
    {

        public MenuStates ValidateTransition(MenuStates currentStates, string userInput = null)
        {
            switch (userInput)
            {
                case "1":
                    return MenuStates.AddingPerson;

                case "2":
                    return MenuStates.RemovingPerson;

                case "3":
                    return MenuStates.ShowAllPersons;

                case "4":
                    return MenuStates.FindPersonByCNP;

                case "5":
                    return MenuStates.ShowAllPersonsFromCity;

                case "6":
                    return MenuStates.ShowAllPersonsFromCountry;

                case "7":
                    return MenuStates.Exit;

                default:
                    return MenuStates.Initialized;
            }
        }

    }
}
