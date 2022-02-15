namespace Area
{
    public class Triangle
    {
        static void Main()
        {
            Console.WriteLine("Enter from 1 to 3 side lenghts  : ");
            var input = Console.ReadLine();
            var partsInput = new List<string>(input.Split(' ').ToList());
            if (partsInput.Count < 1 || partsInput.Count > 3)
            {
                Console.WriteLine("Enter from 1 to 3 side lenghts ");
                return;
            }
            var values = new List<double>();
            foreach (var part in partsInput)
            {
                double number;
                if (!double.TryParse(part, out number))
                {
                    return;
                }
                values.Add(number);
            }
            var area = CalculateAreaTriangle(values);
            Console.WriteLine(area);
        }
        public static double CalculateAreaTriangle(List<double> values)
        {
            switch (values.Count)
            {
                case 3:
                    {
                        double semiPerimetr = (values[0] + values[1] + values[2]) / 2;
                        return Math.Sqrt(semiPerimetr * (semiPerimetr - values[0]) * (semiPerimetr - values[1]) * (semiPerimetr - values[2]));
                    }
                case 2:
                    {
                        return values[0] * values[1] / 2;
                    }
                case 1:
                    {
                        return ((Math.Pow(values[0], 2) * Math.Sqrt(3)) / 4);
                    }
                default:
                    {
                        throw new ArgumentException(String.Format("A lot of values"));
                    }
            }
        }
    }
}

