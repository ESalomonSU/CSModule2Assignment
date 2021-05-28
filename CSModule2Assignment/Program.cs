using System;

namespace Module2Assignment
{
    class Program 
    {
        static void Main(string[] args)
        { 
            Users myUser = new Users ();                         
            myUser.UserNumber = 8007;
            myUser.UserName = "Esteban Salomon";    

            Console.WriteLine(myUser.UserNumber);
            Console.WriteLine(myUser.UserName);
        }

        public class Users 
        {
            public int UserNumber { get; set; }       
            public string UserName { get; set; }   
        }

        public class Roles
        {
            public int RoleNumber { get; set; }
            public string RoleName { get; set; }
        }

        public class Images
        {
            public int ImageNumber { get; set; }
            public string ImageDescription { get; set; }
        }

        public class Posts
        {
            public int PostNumber { get; set; }
            public string PostDate { get; set; }
        }

        public class Comments
        {
            public int CommentsCounter { get; set; }
            public string CommentsType { get; set; }
        }
    }
}




