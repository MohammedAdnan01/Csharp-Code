using System;
namespace Project
{
    public class Book
    {
        public void UserInput()
        {
            int uInput=int.Parse(Console.ReadLine());
            if(uInput>0 && uInput<5)
            {
                TwoNumberInput(uInput);
            }
            else
            {
                Console.WriteLine("Please Enter a number between 1-5:");
                UserInput();
            }

        }
        private void TwoNumberInput(int UserInput)
        {

            Console.Clear();
            Console.WriteLine("Enter the two numbers");
            int num1 =int.Parse(Console.ReadLine());
            int num2 =int.Parse(Console.ReadLine());
            switch(UserInput)
            {
                case 1:
                    Add(num1,num2);
                    break;
                case 2:
                    Subtract(num1,num2);
                    break;
                case 3:
                    Multiply(num1,num2);
                    break;
                case 4:
                    Divide(num1,num2);
                    break;
                default:
                    Console.WriteLine("invalid input");
                    Program.Main(null);
                    break;
            }

        }
           
        private void Add(int number1,int number2)
        {
            Console.WriteLine(number1+number2);
        }
        private void Subtract(int number1,int number2)
        {
            Console.WriteLine(number1-number2);
        }
        private void Multiply(int number1,int number2)
        {
            Console.WriteLine(number1*number2);
        }
        private void Divide(int number1,int divisor)
        {
            Console.WriteLine(number1/divisor);
        }
    }
}