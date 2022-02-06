namespace Discriminant
{
    public class Discriminant
    {
        public static void Main()
        {
            var formula = Console.ReadLine();
            List<int> variables = new List<int>();
            variables = SplitAndParse(formula);
            var a = variables[0];
            var b = variables[1];
            var c = variables[2];
            double x1, x2;
            var discriminant = Math.Pow(b,2) - 4 * a * c;
            if (discriminant < 0)
            {
                Console.WriteLine("No roots");
            }
            else if (discriminant==0)
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("x = "+ x1);
            }
            else   
            {
                x1 = (-b + Math.Sqrt(discriminant)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminant)) / (2 * a);
                Console.WriteLine("x1 = " + x1 + " x2 = " + x2);
            }

        }
            public static List<int> SplitAndParse(string input)
            {
                List<int> numbers = new List<int>();
                bool sign = false;
                string temp = "";
                for (int i=0;i<=input.Length-1;i++)
                {
                    if (input[i] == '+' || input[i] == '-' || i==input.Length-1)
                    {
                        if (sign)
                        {
                            if (i == input.Length - 1)
                            {
                                temp += input[i];
                            }
                            numbers.Add(ParsePart(temp));
                            temp = "";
                        }
                    }
                    else
                    {
                        sign = true;
                    }
                    temp += input[i];
                }
                return numbers;
            }
            public static int ParsePart (string part)
            {
                int number;
                if (part.Contains("x^2"))
                {
                    if (part == "x^2")
                    {
                        number = 1;
                    }
                        else if (part == "-x^2")
                    {
                        number = -1;
                    }
                    else
                    {
                        int.TryParse((part.Replace("x^2", "").Replace("+", "")), out number);
                    }
                }
                else if (part.Contains("x"))
                {
                    if (part == "x")
                    {
                        number = 1;
                    }
                    else if (part == "-x")
                    {
                        number = -1;
                    }
                    else
                    {
                        int.TryParse((part.Replace("x", "").Replace("+", "")), out number);
                    }
                }
                else
                {
                   int.TryParse((part.Replace("+", "")),out number);
                }
                return number;
            }
        }
    }