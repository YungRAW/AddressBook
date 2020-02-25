using System;
using System.Collections.Generic;

namespace AdressBook
{
    class Program
    {
        static void Main(string[] args)
        {
            IGraphicUserInterface gui = new ConsoleUserInterface();
            Menu menu = new Menu(gui);
            menu.Start();
        }
    }
}
