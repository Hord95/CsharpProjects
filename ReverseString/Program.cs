namespace ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            var text = Console.ReadLine();
            Console.WriteLine(Reverse(text));
        }
        public static string Reverse(string input)
        {
            var chars = input.ToArray();
            Array.Reverse(chars);
            return new string(chars);
        }
    }
}