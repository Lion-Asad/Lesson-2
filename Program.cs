using System;

namespace Lesson2
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            
            int A = 10,B = 15;
            if(A!=B)
            {
                if(A>B)
                {
                    B = A;
                }
                else
                {
                    A = B;
                }
            }
            else
            {
                A = B = 0;
            }
           
            Console.WriteLine(A);
            Console.WriteLine(B);
            
            //2
            Console.WriteLine("Enter the action to be performed");  
            Console.WriteLine("Press 1 for Addition");  
            Console.WriteLine("Press 2 for Subtraction");  
            Console.WriteLine("Press 3 for Multiplication");  
            Console.WriteLine("Press 4 for Division \n");  
            int action = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Enter 1st operand1");  
            int operand1 = Convert.ToInt32(Console.ReadLine());  
            Console.WriteLine("Enter 2nd operand1");  
            int operand2 = Convert.ToInt32(Console.ReadLine());  
            int result = 0;  
            switch (action) {  
                case 1: {  
                    result = operand1 + operand2;  
                    break;  
                }  
                case 2: {  
                    result = operand1 - operand2;  
                    break;  
                }  
                case 3: {  
                    result = operand1 * operand2;   
                    break;  
                }  
                case 4: {  
                    if(operand2!=0)
                    {
                        result = operand1 / operand2; 
                    } 
                    break;  
                }  
                default:  
                    Console.WriteLine("Wrong action!! try again");  
                    break;  
            }  
            Console.WriteLine("The result is {0}", result);  
            Console.ReadKey();

            //3
             Console.WriteLine("Enter Digit");  
            int d = Convert.ToInt32(Console.ReadLine());  
            if(d>0 && d<100)
            {
                if(d>=0 && d<=14)
                {
                     Console.WriteLine("0 - 14");  
                }
                else if(d>=15 && d<=35)
                {
                     Console.WriteLine("15 - 35");  
                }
                else if(d>=36 && d<=50)
                {
                     Console.WriteLine("36 - 50");  
                }
                 else if(d>=50 && d<=100)
                {
                     Console.WriteLine("50 - 100");  
                }
            }
            else
            {
                 Console.WriteLine("digit isnt in rang");  
            }
             
            Console.ReadKey();

            
        }
    }
}
