using System.Globalization;

namespace unit_4_6_assignment_b_CondesnsedMilk;

class Program
{
    static void Main(string[] args)
    {
        bool done = false;
        float numInput;

        while (!done)
        {
            Console.WriteLine("Input a number to see if it is a prime!");
            numInput = Convert.ToSingle(Console.ReadLine());
            if (numInput > 0)
            {
                done = true;
                IsPrime(numInput);
            }
            else
            {
                Console.WriteLine("Sorry that is a invalid input. Please keep it positive :)");
            }
        }
    
    }

    static void IsPrime(float numInput)
    {
        int count = 2;
        bool done = false;

        if (numInput == 1)
        {
            Console.WriteLine("This is not a prime number.");
        }
        else
        {
            while (count <= numInput && !done)
            {
                if(numInput%count == 0 && count != numInput)
                {
                    Console.WriteLine("This is not a prime number!");
                    done = true;
                }
                else
                {    
                    if (numInput%count == 0 && count == numInput)
                    {
                        Console.WriteLine("This is a prime number!");
                        done = true;    
                    }
                    count++;
                }

            }
                
        }
        
    }
}
