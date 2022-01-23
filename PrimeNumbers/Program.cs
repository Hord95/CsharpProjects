namespace PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main()
        {
            int num;
            Console.Write("enter last number for finding last prime number:");
            num = Convert.ToInt32(Console.ReadLine());
            int divisor;
            bool isPrime=true;
            for (int i = 2; i <= num; i++)
            {
                for (divisor=2;divisor<num; divisor++)
                {
                    if (i % divisor == 0 && divisor!=i)
                    {
                        isPrime = false;
                        break;
                    }
                    isPrime = true;
                }
                if (isPrime == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
        }
    }
