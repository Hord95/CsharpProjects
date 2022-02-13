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
            AreaTriange(values);
        }
        public static List<double> SplitAndParse(string input)
        {
            var values = new List<double>();
            var partsInput = new List<string>();
            partsInput = input.Split(' ').ToList();
            for (int i = 0; i < partsInput.Count; i++)
            {
                if (Parse(partsInput[i]) != -1)
                {
                    values.Add(Parse(partsInput[i]));
                }
            }
            return values;
        }
        public static double Parse(string part)
        {
            if (!String.IsNullOrEmpty(part))
            {
                var number = Convert.ToDouble(part);
                return number;
            }
            else
            {
                return -1;
            } 
                
        }
        public static void AreaTriange(List<double> values)
        {
            if (values.Count == 0 || values.Count > 3)
            {
                Console.WriteLine("Try again!");
            }
            else
            {

                switch (values.Count)
                {
                    case 3:
                        {
                            double semiperimetr = (values[0] + values[1] + values[2]) / 2;
                            double area = Math.Sqrt(semiperimetr * (semiperimetr - values[0]) * (semiperimetr - values[1]) * (semiperimetr - values[2]));
                            Console.WriteLine(area);
                            break;
                        }
                    case 2:
                        {
                            double area = values[0] * values[1] / 2;
                            Console.WriteLine(area);
                            break;
                        }
                    case 1:
                        {
                            double area = ((Math.Pow(values[0], 2) * Math.Sqrt(3)) / 4);
                            Console.WriteLine(area);
                            break;
                        }
                }
            }
        }
    }
}
    
