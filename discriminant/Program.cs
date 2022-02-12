namespace Discriminant
{
    public class Discriminant
    { 
        public static void Main()
        {
            var formula = Console.ReadLine();
            int a, b, c;
            (a,b,c) = SplitAndParse(formula);
            var discriminant = Math.Pow(b, 2) - 4 * a * c;
            if (discriminant < 0 || a==0)
            {
                Console.WriteLine("No roots");
            }
            else if (discriminant == 0)
            {
                double x1;
                double numerator ;
                numerator = (-b + Math.Sqrt(discriminant));
                if (numerator == 0)
                {
                    Console.WriteLine(" no roots");
                }
                else
                {
                    x1 = numerator / (2 * a);
                    Console.WriteLine("x = " + x1);
                }
            }
            else
            {
                double x1, x2;
                double numerator;
                numerator = (-b + Math.Sqrt(discriminant));
                if (numerator == 0)
                {
                    Console.WriteLine("x1 - no root");
                }
                else
                {
                    x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine("x1 = " + x1 );
                }
                numerator = (-b - Math.Sqrt(discriminant));
                if (numerator == 0)
                {
                    Console.WriteLine("x2 - no root");
                }
                else
                {
                    x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    Console.WriteLine("x2 = " + x2);
                }
            }

        }
        public static (int,int ,int ) SplitAndParse(string input)
        {
            var numbers = new List<int>();
            bool sign = false;
            string part = "";
            for (int i = 0; i <= input.Length - 1; i++)
            {
                if (input[i] == '+' || input[i] == '-' || i == input.Length - 1)
                {
                    if (sign)
                    {
                        if (i == input.Length - 1)
                        {
                            part += input[i];
                        }
                        numbers.Add(ParsePart(part));
                        part = "";
                    }
                }
                else
                {
                    sign = true;
                }
                part += input[i];
            }
           int a = numbers[0];
           int b = numbers[1];
           int c = numbers[2];
           return (a,b,c);
        }
        public static int ParsePart(string part)
        {
            int number;
            if (part.Contains("x^2"))
            {
                switch (part)
                {
                    case "x^2": return 1;
                    case "-x^2": return -1;
                    default:
                        int.TryParse((part.Replace("x^2", "")), out number);
                        break;
                }
            }
            else if (part.Contains("x"))
            {
                switch (part)
                {
                    case ("x"): return 1;
                    case ("-x"): return -1;
                    default:
                        int.TryParse((part.Replace("x", "")), out number);
                        break;
                }
            }
            else
            {
                int.TryParse((part.Replace("+", "")), out number);
            }
            return number;
        }
    }
}