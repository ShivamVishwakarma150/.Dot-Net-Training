using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionDemo
{
    abstract class AppClass
    {
        public abstract Boolean AppLogin(string userName,string password); // incomplete Method

        public void printDetails()
        {
            Console.WriteLine("Welcome to App!...");
        }
    }

   interface IGame
    {
        // All the methods are abstract methods
        bool InstallGame();
        void getGame(String gameName);
    }

    // Mulitple Inheriteance is not possible using classes it can possible with interfaces
    class Facebook : AppClass,IGame
    {
        public override bool AppLogin(string userName, string password)
        {
            if(userName=="Shivam" && password == "123")
            {
                base.printDetails();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool InstallGame()
        {
            Console.WriteLine("Game Installed");
            return true;
        }
        public void getGame(String gameName)
        {
            Console.WriteLine("ABC");
        }
    }

    class Twitter:AppClass,IGame
    {
        public override bool AppLogin(string userName, string password)
        {
            if (userName == "Vikash" && password == "321")
            {
                base.printDetails();
                return true;
            }
            else
            {
                return false;
            }
        }
        public bool InstallGame()
        {
            Console.WriteLine("Game Installed");
            return true;
        }
        public void getGame(String gameName)
        {
            Console.WriteLine("XYZ");
        }
    }

}
