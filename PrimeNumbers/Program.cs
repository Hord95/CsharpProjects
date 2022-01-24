namespace PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main()
        {
            Console.Write("enter last number for finding last prime number:");
            int num = Convert.ToInt32(Console.ReadLine());           
            for (int i = 2; i <= num; i++)
            {
                var isPrime = true;
                for (int j = 2;j != i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }
                    isPrime = true;
                }
                if (isPrime)
                {
                    Console.WriteLine(i);
                }
            }
        }
        }
    }
