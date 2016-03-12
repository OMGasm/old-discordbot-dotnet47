﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace discordbot
{
    [Obsolete]
    class Auth
    {
        public static string email { get { return getEmailConsole(); } }
        public static string token { get; set; }
        public static string password { get { return getPasswordConsole(); } }

        static string getEmailConsole()
        {
            Console.Write("Email: ");
            return Console.ReadLine();
        }

        static string getPasswordConsole()
        {
            Console.Write("Password: ");
            string password = "";
            ConsoleKeyInfo k;
            while (true)
            {
                k = Console.ReadKey(true);
                if (k.Key == ConsoleKey.Enter)
                {
                    Console.Write('\n');
                    break;
                }
                else if (k.Key == ConsoleKey.Backspace)
                {
                    if (password.Length > 0)
                    {
                        password = password.Substring(0, password.Length - 1);
                        Console.Write("\b \b");
                    }
                }
                else
                {
                    password += k.KeyChar;
                    Console.Write('*');
                }
                
            }
            return password;
        }
    }
}
