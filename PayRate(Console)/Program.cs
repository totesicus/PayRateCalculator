using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PayRate_Console_
{
    class Program
    {
        static void Main(string[] args)
        {
            // String variables for user input
            String hoursIn, payRateIn, taxIn, response;

            // Double variables for parsed String output
            double hours, payRate, payRateResult, tax, taxResult, result;

            // Boolean variable for loop set to true
            Boolean loop = true;
            
            Test test = new Test();

            do
            {   
                // Greet the user
                Console.Out.WriteLine("Welcome!\n");

                // Take user input in String format 
                Console.Out.WriteLine("Hours worked:");           
                hoursIn = Console.ReadLine();
                
                test.InputTest(hoursIn);

                // Parse to type double
                hours = double.Parse(hoursIn);

                // Take user input in String format 
                Console.Out.WriteLine("\nPay rate:");
                payRateIn = Console.ReadLine();

                // Parse to type double
                payRate = double.Parse(payRateIn);

                // Take user input in String format 
                Console.Out.WriteLine("\nTax rate:");
                taxIn = Console.ReadLine();
                // Parse to type double
                tax = double.Parse(taxIn);

                // Make calculation:
                // Find amount in taxes taken out of pay rate
                // Subtract that amount from pay rate
                // Calculate approximate pay by multiplying taxed pay rate by hours worked
                taxResult = tax * payRate;
                payRateResult = payRate - taxResult;
                result = hours * payRateResult;

                // Output approximate pay in currency format
                Console.Out.WriteLine("\nYour paycheck for the week will be (approx): " +
                            result.ToString("C"));
                
                // Boolean variable for second loop
                Boolean loop2 = true;

                do
                {
                    // Continue or end the loop via user input
                    Console.Out.WriteLine("Make another calculation? (y/n)");
                    response = Console.ReadLine();

                    // If yes, break from this 'while' loop to re-enter previous 'while' loop
                    if (response.Equals("y"))
                    {
                        break;
                    }
                    // If no, exit program completely
                    else if (response.Equals("n"))
                    {
                        loop2 = false;
                        loop = false;
                    }
                    // If anything other than yes or no, repeat the question
                    else
                    {
                        Console.WriteLine("Please enter y or n.");
                        continue;
                    }
                } while (loop2 == true);

            } while (loop == true);
        }
    }
}

class Test
    {
        public void InputTest(string str)
        {
            if (str.Equals(""))
            {
                Console.Out.WriteLine("Please enter a numeric value.");
            }
        }
    }
