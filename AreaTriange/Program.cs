namespace Area
{
    class Triangle
    {
        static void Main()
        {
            var values = new List<double>();
            Console.WriteLine("Enter from 1 to 3 values of lines : ");
            var lines = Console.ReadLine();
            values = SplitAndParse(lines);
            var area = AreaTriange(values);
            if (area != -1)
            {
                Console.WriteLine(area);
            }
        }
        public static List<double> SplitAndParse(string input)
        {
            var values = new List<double>();
            var partsInput = new List<string>();
            partsInput = input.Split(' ').ToList();
            for (int i = 0; i < partsInput.Count; i++)
            {
                if (!string.IsNullOrWhiteSpace(partsInput[i]))
                {
                    values.Add(double.Parse(partsInput[i]));
                }
            }
            return values;
        }
        public static double AreaTriange(List<double> values)
        {
            switch (values.Count)
            {
                case 3:
                    {
                        double semiperimetr = (values[0] + values[1] + values[2]) / 2;
                        double area = Math.Sqrt(semiperimetr * (semiperimetr - values[0]) * (semiperimetr - values[1]) * (semiperimetr - values[2]));
                        return area;
                    }
                case 2:
                    {
                        double area = values[0] * values[1] / 2;
                        return area;
                    }
                case 1:
                    {
                        double area = ((Math.Pow(values[0], 2) * Math.Sqrt(3)) / 4);
                        return area;
                    }
                default:
                    {
                        Console.WriteLine("Try again!");
                        break;
                    }
            }
            return -1;
        }
    }
}

