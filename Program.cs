using System;
using System.Collections.Generic;

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
            Console.WriteLine("Select 2: To View Users Comments ");
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
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Write Your Post!");
            string Cpost = Console.ReadLine();
            Console.ReadLine();



        }
        static void Comments()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Type Something To View Your Comments!");
            string CommentD = Console.ReadLine();
            Console.WriteLine("Your Comment: " + CommentD);
     
            List<CommentData> commentlist = new List<CommentData>();
            commentlist.Add(new CommentData());
            commentlist[0].Data = "~~ " + "Wolfz you wanna play some rainbow six? ";
            commentlist[0].userID = ":"+ " mohammed";
            

            commentlist.Add(new CommentData());
            commentlist[1].userID = ":"+ " wolfz";
            commentlist[1].Data = "~~ " + "Hello XD mohammed! send me a invite ";

            commentlist.Add(new CommentData());
            commentlist[2].Data = "~~ " + "a fresh slushie with this hot weather ";
            commentlist[2].userID = ":" + " don";

            commentlist.Add(new CommentData());
            commentlist[3].Data = "~~ " + "any fun movies to watch? ";
            commentlist[3].userID = ":" + " maria";

            commentlist.Add(new CommentData());
            commentlist[4].Data = "~~ " + "testing my new compressor ";
            commentlist[4].userID = ":" + " Goofy";
            foreach (CommentData Calls in commentlist)
            {
                Console.WriteLine(Calls.getdata());
            }
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
            Environment.Exit(1);


        }

    }
}