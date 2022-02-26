using System;
using System.Collections.Generic;

namespace Calc
{

    public class UserInput
    {
        static void Main(string[] args)
        {
            double num1, num2;
            string str1;
            char operation;
            Console.WriteLine("Enter the Operater(+,-,*,/)");
            operation = Console.ReadLine()[0];
            str1 = operation.ToString();

            Calculate usr = new Calculate();



            switch (operation)
            {
                case '+':                    
                    Console.WriteLine("How many numbers you want to enter?");                   
                    int n = Int32.Parse(Console.ReadLine());
                    if (str1.Equals("+"))
                    {                        
                        double[] numbers = new double[n];
                        List<double> inputNumber = new List<double>();
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            Console.Write("Number {0}: ", i + 1);
                            numbers[i] = Convert.ToDouble(Console.ReadLine());
                            inputNumber.Add(numbers[i]);                            
                        }
                        double total = usr.Addition(inputNumber);
                        Console.WriteLine("Total Addition Value : "+total);
                    }
                    break;

                case '-':
                    Console.WriteLine("How many numbers you want to enter?");
                    int n1 = Int32.Parse(Console.ReadLine());
                    if (str1.Equals("-"))
                    {

                        double[] numbers = new double[n1];
                        List<double> inputNumber = new List<double>();
                        for (int i = 0; i < numbers.Length; i++)
                        {
                            Console.Write("Number {0}: ", i + 1);
                            numbers[i] = Convert.ToDouble(Console.ReadLine());
                            inputNumber.Add(numbers[i]);
                        }
                        double subtotal = usr.subtraction(inputNumber);
                        Console.WriteLine("Total Subtraction Value : " + subtotal);
                    }
                    break;


                case '*':
                    Console.WriteLine("Please Enter two numbers");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    num2 = Convert.ToDouble(Console.ReadLine());
                    if (str1.Equals("*"))
                    {
                        double total = usr.Multiplication(num1, num2);
                        Console.WriteLine("Total Multiplication Value : " + total);
                    }
                    break;


                case '/':
                    Console.WriteLine("Please Enter two numbers");
                    num1 = Convert.ToDouble(Console.ReadLine());
                    num2 = Convert.ToDouble(Console.ReadLine());                    
                    if (num2 == 0.0)
                        Console.WriteLine("Divide by zero sitution, Division is not possible.....");
                    else if (str1.Equals("/"))
                    {
                        double total = usr.Division(num1, num2);
                        Console.WriteLine("Total Division Value : " + total);
                    }
                    break;

                default:
                    Console.WriteLine("User enters invalid Operator ....");
                    break;

            }
        }

    }


    public class Calculate
    {
      public double Addition(List<double> num)
        {
            double sum = 0;
            int size = num.Count;
            for (int i = 0; i < size; i++)
            {                
                sum += num[i];
            }
            return sum;
        }     


        public double subtraction(List<double> num)
        {
            double tot = 0;
            int size = num.Count;
            for (int i = 0; i < size; i++)
            {
                tot = tot-num[i];
            }
            return tot;
        }

        public double Multiplication(double num1, double num2)
        {
            double num3;
            num3 = num1 * num2;
            return num3;
        }
        public double Division(double num1, double num2)
        {
            double num3;
            num3 = num1 / num2;
            return num3;
        }
    }
}





    

