using System;
using RRModels;
using System.Collections.Generic;
namespace RRUI
{
    class Program
    {
        static void Main(string[] args)
        {
            IMenu menu = new MainMenu();
            menu.Start();
        }
    }
}