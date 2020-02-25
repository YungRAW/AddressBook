using System;
using System.Collections.Generic;
using System.Text;

namespace AdressBook
{
    public interface IGraphicUserInterface
    {
        void ClearScreen();
        void PrintMessage(string message);
        void PrintMessageOnLine(string message);
        string ReadInput();
        int ReadInputInteger();
        void AwaitUserInput();
        void PrintPerson(Person person);
        Person ReadPerson();
    }
}
