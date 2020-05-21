//Patrik Sullivan psullivan8@cnm.edu
//ExceptionsDemo 05/21/20

using System;

namespace ExceptionDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            String doAnother;
            do
            {
                try
                {
                    Console.Write("Please enter num1: ");
                    string num1Str = Console.ReadLine();
                    int num1 = int.Parse(num1Str);
                    Console.Write("Please enter num2: ");
                    string num2Str = Console.ReadLine();
                    int num2 = int.Parse(num2Str);

                    Console.WriteLine("Num1/Num2: {0}", num1 / num2);
                }
                catch (FormatException)
                {
                    Console.WriteLine("You must provide a value!");
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("You cannot divide by zero!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Number is too large or too small.");
                }
                catch (Exception exc)
                {
                    Console.WriteLine("There was an error. " + exc.Message + "\nException" +
                        "type: " + exc.GetType());
                }
                finally
                {
                    Console.WriteLine("This section always executes!");
                }
                Console.Write("Do another? (y/n): ");
                doAnother = Console.ReadLine();
            } while (doAnother == "y");
            Console.WriteLine("Hello World!");
        }
    }
}