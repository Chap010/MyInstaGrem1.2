using System;
using System.Collections.Generic;

namespace MyInstaGrem1._2
{


    class MidTerm
    {

        static void MainMenu()

        {
            string mySelection;
            List<Users> userList = new List<Users>();
            List<Comment> CommentList = new List<Comment>();



            while(mySelection!="5")
            { 
            Console.WriteLine("Select 1: User Registration ");
            Console.WriteLine("Select 2: To Create a Comment ");
            Console.WriteLine("Select 3: Print User List ");
            Console.WriteLine("Select 4: Print Comment List");
            Console.WriteLine("Select 5: To Exit ");
            mySelection = Console.ReadLine();
            }

            switch (mySelection)
            {
                case "1":
                        Users users = new Users();
                        userList.Add(users);
                        Users.Email = "chicharones@rtx.com";
                        Users.Password = "bochito2351":
                        Users.UserId = 1;
                        Users.UserName = "rosewell51";
                        Console.WriteLine("You Crested A Username!!!");
                        break;
                        
                 
                case "2":
                      Comment mycomment = new Comment();
                      CommentList.Add(Comment);
                      mycomment.CommentID = 1;
                     mycomment.CommentData = "Hey Bro";
                        break;

                case "3":
                    Console.WriteLine("Current User List: ")
                    foreach(var users in usersList)
                    {
                        Console.WriteLine("Email: " + InsideUsers.Email);
                        Console.WriteLine("HashPass: " + InsideUsers.Password);
                        Console.WriteLine("ID: " + InsideUsers.UserId);
                        Console.WriteLine("Username: " + InsideUsers.UserName);
                    }
                        break;

                case "4":
                        Console.WriteLine("Current Comments List: ")
                    foreach(var comment in CommentList)
                    {
                        Console.WriteLine("CommentID: " + InsideComment.CommentId);
                        Console.WriteLine("Data: " + InsideComment.CommentData);

                    }
                    break;


                case "5":
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

    }
}