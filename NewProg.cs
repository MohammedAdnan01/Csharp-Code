using System;
using System.Collections.Generic;

namespace Project
{
    class Calculation:Program{
        double result;
        
        public void Add(double num1,double num2)
        {
            result = num1+num2;
            Console.WriteLine($"The Sum of the numbers is {result}");
            GoBackMenu();
            
        }
        public void Add(double num1,double num2,double num3)
        {
            result = num1+num2+num3;
            Console.WriteLine($"The Sum of the numbers is {result}");
            GoBackMenu();
        }
        public void Add(List<double> numList)
        {
            result=0;
            foreach(double number in numList)
            {
                result= result+number;
            }
            Console.WriteLine($"The Sum of the numbers is {result}");
        }
        public void Subtract(double num1,double num2)
        {
            result = num1-num2;
            Console.WriteLine(result);
            GoBackMenu();
        }
        public void Subtract(double num1,double num2,double num3)
        {
            result = num1-num2-num3;
            Console.WriteLine(result);
            GoBackMenu();
        }
        public void Multiply(double num1,double num2)
        {
            result = num1*num2;
            Console.WriteLine(result);
            GoBackMenu();
        }
        public void Multiply(double num1,double num2,double num3)
        {
            result = num1*num2*num3;
            Console.WriteLine(result);
            GoBackMenu();
        }
        public void Divide(double num1,double num2)
        {
            result = num1/num2;
            Console.WriteLine(result);
            GoBackMenu();
        }
        public void GoBackMenu()
        {
            Console.WriteLine("To go back to the prevous menu press any key:");
            Console.ReadKey();
            Choice2(choi1);
        }
        
    }
}