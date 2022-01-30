namespace Discriminant
{
    class Discriminant
    {
        public static void Main()
        {
            var formula = Console.ReadLine();
            var a = 0d;
            var b = 0d;
            var c = 0d;
            double x1, x2;
            double discriminant;
            Input(formula, ref a,ref b,ref c);
            discriminant = Math.Pow(b,2) - 4 * a * c;
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
        public static void Input(string input, ref double a, ref double b, ref double c)
        {
            List<string> list = new List<string>();
            bool sign = false;
            string temp = "";
            for (int i = 0; i < input.Length; i++) 
            {

                if (i == 0)
                    temp += input[i];
                else if (input[i] == '-' || input[i] == '+')
                {
                    list.Add(temp);
                    temp = "";
                    temp += input[i];
                }
                else if (i == input.Length - 1)
                {
                    temp += input[i];
                    list.Add(temp);
                }
                else
                {
                    temp += input[i];
                }
            }
            for (int i = 0;i < list.Count;i++)
            {
                if (list[i].Contains("x^2"))
                {
                    
                    a=Convert.ToDouble(list[i].Replace("x^2","").Replace("+",""));
                }
                else if (list[i].Contains("x"))
                {
                    b=Convert.ToDouble(list[i].Replace("x", "").Replace("+", ""));
                }
                else
                {
                    c=Convert.ToDouble(list[i].Replace("+",""));
                }
            }
        }
    }
}