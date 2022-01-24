namespace PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main()
        {
            Console.Write("enter last number for finding last prime number:");
            var num = Convert.ToInt32(Console.ReadLine());
            List<int> list = new List<int>();
            list.AddRange(FindPrimeNumbers(num));
            foreach (int i in list)
            {
                Console.WriteLine(i);
            }
        }
        static List<int> FindPrimeNumbers(int num)
        {
            var result = new List<int>();
            for (int i = 2; i <= num; i++)
            {
                var isPrime = true;
                for (int j = 2; j != i; j++)
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
                    result.Add(i);
                }
            }
            return result;
        }
    }
}

