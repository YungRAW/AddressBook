using System;
using System.Collections.Generic;
using System.Text;

namespace AdressBook
{
    public enum MenuStates
    {
        Initialized,
        AddingPerson,
        RemovingPerson,
        ShowAllPersons,
        FindPersonByCNP,
        ShowAllPersonsFromCity,
        ShowAllPersonsFromCountry,
        Finished,
        Exit
    }
}
