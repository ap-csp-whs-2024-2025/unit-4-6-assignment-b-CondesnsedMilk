using System.Globalization;

namespace unit_4_6_assignment_b_CondesnsedMilk;

class Program
{
    static void Main(string[] args)
    {
        bool isPrime = false;
        bool isPrimeList = false;
        int input;

        Console.WriteLine("Would you like to know if a number is a prime? Press 1: ");
        Console.WriteLine("Would you like if a number is a prime? Press 2: ");
        Console.Write("Input: ");
        input = Convert.ToInt32(Console.ReadLine());

        while (!isPrime && !isPrimeList)
        {
            if (input == 1)
            {
                isPrime = true;
                InputPrime();
            }
            else if (input == 2)
            {
                isPrimeList = true;
                InputPrimeList();
            }
        }
    }

    static void PrimeList(float numInput, bool isPrime)
    {
        List<float> primeList = new List<float>();

        while (numInput > 0)
        {
            IsPrime(numInput, true);

            if (isPrime)
            {
                primeList.Append(numInput);
            }
            numInput--;
            
        }

        for(int i=0; i<primeList.Count; i++)
        {
            Console.WriteLine(primeList[i]);
        }
    }

      static void InputPrimeList()
    {
        bool done = false;
        float numInput;

        while (!done)
        {
            Console.WriteLine("Input a number to see what numbers below it are primes!");
            numInput = Convert.ToSingle(Console.ReadLine());
            if (numInput > 0)
            {
                done = true;
                PrimeList(numInput, false);
            }
            else
            {
                Console.WriteLine("Sorry that is a invalid input. Please stay positive :)");
            }
        }
    }

    static void InputPrime()
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
                IsPrime(numInput, false);
            }
            else
            {
                Console.WriteLine("Sorry that is a invalid input. Please keep it positive :)");
            }
        }
    }

    static void IsPrime(float numInput, bool primeList)
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
                if (primeList)
                {
                    if(numInput%count == 0 && count != numInput)
                    {
                        PrimeList(numInput, false);
                    }
                    else
                    {    
                        if (numInput%count == 0 && count == numInput)
                        {
                            PrimeList(numInput, true);  
                        }
                        count++;
                    }
                }
                else
                {    if(numInput%count == 0 && count != numInput)
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
}
