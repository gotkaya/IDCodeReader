﻿using System;

namespace IDCodeReader
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your ID code:");
            string userID = Console.ReadLine();
            if(Validate(userID))
            {
                Console.WriteLine("Welcome!");
            }else
            {
                Console.WriteLine("Wrong format.Try again.");
            }


        }

        public static bool Validate(string idCode)
        {
            if(idCode.Length == 11)
            {
                try
                {
                    long.Parse(idCode);
                    return true;
                }
                catch(Exception e)
                {
                    Console.WriteLine($"Wrong format: {e}");
                    return false;
                }
                
            }
            else
            {
                return false;
            }



        }



    }
}
