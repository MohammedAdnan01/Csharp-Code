using System;
using System.Collections.Generic;

namespace Project
{
    class Program
    {
        public int choi1;
        public int choi2;
        public double number1,number2,number3;
        public List<double> numList=new List<double>();
        
        public static void Main(string[] arge)
        {
            Program strt=new Program();
            strt.Beginning();
            
        }
        public void Beginning()
        {
            Console.Clear();
            Console.WriteLine("Enter your choice:\n1.Addition\n2.Subtraction\n3.Multiplication\n4.Division\n5.Exit");
            try{
            choi1= int.Parse(Console.ReadLine());
            Choice(choi1);        
            }
            catch(FormatException)
            {
                RetryStatement();
            }
            catch(OverflowException)
            {
                RetryStatement();
            }
        }
     
        
        public void Choice(int choi1)
        {
            
            switch(choi1)
            {
                case 1:
                    Choice2(choi1); 
                    break;
                case 2:
                    Choice2(choi1);               
                    break;
                case 3:
                    Choice2(choi1);
                    break;
                case 4:
                    Choice2(choi1);
                    break;
                case 5:
                    Console.Clear();
                    Console.WriteLine("To exit press any key");
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Please enter a valid number\nPress any key to Retry");
                    Console.ReadKey();
                    Beginning();
                    break;
            }
        
        }
        public void Choice2(int choi1)
        {
            Calculation clc= new Calculation();
            Console.Clear();
            Console.WriteLine("1. 2 numbers\n2. 3 nubers\n3. n numbers\n4. Back to previous menu");
            try{
            choi2=int.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                RetryStatement2();
            }
            catch(OverflowException)
            {
                RetryStatement2();
            }
            
            switch (choi2)
            {
                case 1:
                    GetTwoValue();
                    if(choi1==1){
                        clc.Add(number1,number2);
                    }
                    else if (choi1==2){
                        clc.Subtract(number1,number2);
                    }
                    else if( choi1==3){
                        clc.Multiply(number1,number2);
                    }
                    else if (choi1==4){
                        clc.Divide(number1,number2);
                    }
                    break;
                case 2:
                    GetThreeValue();
                    if(choi1==1){
                        clc.Add(number1,number2,number3);
                    }
                    else if (choi1==2){
                        clc.Subtract(number1,number2,number3);
                    }
                    else if( choi1==3){
                        clc.Multiply(number1,number2,number3);
                    }
                    else if (choi1>=4){
                        Console.WriteLine("Not possible to divide three numbers\n...... Please Try again.....");
                    }
                    break;

                case 3:
                    nNumbers();
                    clc.Add(numList);
                    break;
                case 4:
                    Beginning();
                    break;
                    
                default:
                    Console.WriteLine("Please enter a valid input\nTo try again press any key");
                    Console.ReadKey();
                    Choice2(choi1);
                    break;
            }
            

        }
        public void GetTwoValue()
        {
            try{
                Console.Clear();
                Console.WriteLine("Enter the first number");
                number1=double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                number2=double.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Enter valid input numbers\nPress any key to retry");
                Console.ReadKey();
                GetTwoValue();
            }
            catch(OverflowException)
            {
                Console.WriteLine("The number entered is too big try a smaller bumber\nPress any key to retry");
                Console.ReadKey();
                GetTwoValue();
            }
        }
        public void GetThreeValue()
        {
            try{
            Console.Clear();
            Console.WriteLine("Enter the first number");
            number1=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            number2=double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the third number");
            number3=double.Parse(Console.ReadLine());
            }
            catch(FormatException)
            {
                Console.WriteLine("Enter valid input numbers\nPress any key to retry");
                Console.ReadKey();
                GetThreeValue();
            }
            catch(OverflowException)
            {
                Console.WriteLine("The number entered is too big try a smaller bumber\nPress any key to retry");
                Console.ReadKey();
                GetThreeValue();
            }
        }
        public void nNumbers()
        {
            Console.Clear();
            Console.WriteLine("Enter the number of elements you want to calculate");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("Start Entering your numbers;");
            for(int i=0;i<n;i++)
            {
                double num =int.Parse(Console.ReadLine());
                numList.Add(num);
            }
        }
        public void RetryStatement()
        {
            Console.WriteLine("Please enter a valid number\nPress any key to try again");
            Console.ReadKey();
            Beginning();
        }
        public void RetryStatement2()
        {
            Console.WriteLine("Please enter a valid number\nPress any key to try again");
            Console.ReadKey();
            Choice2(choi1);
        }
       

    }
}