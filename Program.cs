using System;

namespace MyInstaGrem1._2
{


    class Program
    {

        static void Main(string[] args)
        {
            Register();
            MainMenu();
        }

        static void Register()
        {

            Console.WriteLine("Welcome To MyGrem A Console APP Version!!");
            Console.WriteLine();
            Console.WriteLine("Please Enter Your Username To Register To MyGrem: ");
            string Users = Console.ReadLine();
            Console.WriteLine("Hello Welcome To InstaGrem " + Users);


        }


        static void MainMenu()

        {
            Console.WriteLine("Select 1: To Post On Your Profile ");
            Console.WriteLine("Select 2: To View Reply Comments ");
            Console.WriteLine("Select 3: To Search Users ");
            Console.WriteLine("Select 4: To Exit ");
            string mySelection;
            mySelection = Console.ReadLine();
            

            switch (mySelection)
            {
                case "1":
                        Post();
                    break;
                case "2":
                        Comments();
                    break;
                case "3":
                        Users();
                    break;
                case "4":
                        Exit();
                    break;

            }
            MainMenu();
        }

        static void Post()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Write Your Post!");
            Console.ReadLine();



        }
        static void Comments()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("View Your Comments!");
            Console.ReadLine();



        }
        static void Users()
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Type Username To Search Them");
            Console.ReadLine();



        }
        static void Exit()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Are You Sure You Want to Quit? ");
            Console.WriteLine("Type Enter To Confirm!");
            Console.ReadLine();
            System.Environment.Exit(1);


        }

    }
}