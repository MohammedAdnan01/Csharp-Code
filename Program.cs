using System;
using System.Collections.Generic;


namespace Project
{
    class Program
    {
        public static void Main(string[] arge)
        {
            Console.Clear();
            Book clc =new Book();
            Console.WriteLine("1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n5.Square\n6.Cube\n7.Square Root\n8.Cube Root\n9.Exit\n");
            try
            {
                clc.UserInput();
            }
            catch(FormatException)
            {
                Console.WriteLine("Error!!Please try entering a number");
                clc.UserInput();
            }    
        }
        
    }
}