using System;
namespace MyInstaGrem1._2
{
    public class CommentData
    {
        public string Comment { get; }

        public string Data;
        public string userID;
        public string getdata()

        // public string CommentData { get; set; }//
        {
            return this.Data + this.userID;
        }

    }
}
