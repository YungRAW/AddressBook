using System;
using System.Collections.Generic;
using System.Text;

namespace AdressBook
{
    class MenuPrinter
    {
        IGraphicUserInterface gui;

        public MenuPrinter(IGraphicUserInterface gui)
        {
            this.gui = gui;
        }
        
        public void FirstScreen()
        {
            gui.ClearScreen();
            gui.PrintMessageOnLine("Welcome to the adress book! How can we help you?");
            gui.PrintMessageOnLine("1. Add a person");
            gui.PrintMessageOnLine("2. Remove a person");
            gui.PrintMessageOnLine("3. Show all persons");
            gui.PrintMessageOnLine("4. Find a person by CNP");
            gui.PrintMessageOnLine("5. Show all persons in a city");
            gui.PrintMessageOnLine("6. Show all persons in a country");

        }

        public void SecondScreen() // for adding
        {
            gui.ClearScreen();
            gui.PrintMessageOnLine("Add a person.");
        }

        public void ThirdScreen() // for removing
        {
            gui.ClearScreen();
            gui.PrintMessageOnLine("Remove a person.");
        }

        public void FourthScreen() // for searching
        {
            gui.ClearScreen();
            gui.PrintMessageOnLine("Find a person by CNP.");
        }

        public void FifthScreen() // for showing using city
        {
            gui.ClearScreen();
            gui.PrintMessageOnLine("Show all persons in a city.");
        }

        public void SixthScreen() // for showing using Country
        {
            gui.ClearScreen();
            gui.PrintMessageOnLine("Show all persons in a country.");
        }
    }
}
