using System;
using System.Security;
using System.IO;
using System.Text.RegularExpressions;

namespace iDontKnow
{
    public class LogIn : ReadFile
    {
        private string password;
        private string username;

        public LogIn()
        {
         
            Console.Write("Username : ");
            username = Console.ReadLine();
            Console.Write("Password : ");
            password = Console.ReadLine();
            ReadAndWrite(username,password);
        }
    }
}