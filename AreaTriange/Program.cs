namespace Area
{
    public class Triangle
    {
        static void Main()
        {
            Console.WriteLine("Enter from 1 to 3 values of lines : ");
            var input = Console.ReadLine();
            var values = new List<double>();
            var partsInput = new List<string>();
            partsInput = input.Split(' ').ToList();
            bool isMistake = false;
            for (int i = 0; i < partsInput.Count; i++)
            {                
                    double number;
                     double.TryParse(partsInput[i],out number);
                    if (number <= 0)
                    {
                        Console.WriteLine("Use numbers more than 0");
                        isMistake = true;
                        break;
                    }
                    values.Add(number);  
            }
            if (isMistake)
            {
                if (values.Count > 0 && values.Count <= 3)
                {
                    var area = CalculateAreaTriange(values);
                    Console.WriteLine(area);
                }
                else
                {
                    Console.WriteLine("Try again");
                }
            }
        }
        public static double CalculateAreaTriange(List<double> values)
        {
            switch (values.Count)
            {
                case 3:
                    {
                        double semiperimetr = (values[0] + values[1] + values[2]) / 2;
                        var area = Math.Sqrt(semiperimetr * (semiperimetr - values[0]) * (semiperimetr - values[1]) * (semiperimetr - values[2]));
                        return area;
                    }
                case 2:
                    {
                        var area = values[0] * values[1] / 2;
                        return area;
                    }
                default:
                    {
                        var area = ((Math.Pow(values[0], 2) * Math.Sqrt(3)) / 4);
                        return area;
                    }
            }
        }
    }
}

