namespace Factorial
{
    public class Factorial
    {
        static void Main()
        {
            Console.WriteLine("Enter number");
            int number;
            if (int.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Factorial with loop = {0}", MakeFactorialWithLoop(number));
                Console.WriteLine("Factorial without loop = {0}", MakeFactorialWithoutLoop(number));
            }

        }
        public static int MakeFactorialWithLoop(int number)
        {
            var result = 1;
            for (int i = number; i > 1; i--)
            {
                result *= i;
            }
            return result;
        }
        public static int MakeFactorialWithoutLoop(int number)
        {
            if (number > 0)
            {
                return number * MakeFactorialWithoutLoop(number - 1);
            }
            return 1;
        }
    }
}