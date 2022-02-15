namespace ReverseString
{
    class ReverseString
    {
        static void Main()
        {
            var text = Console.ReadLine();
            var reverseText = "";
            for (int i = text.Length - 1; i >= 0; i--)
            {
                reverseText += text[i];
            }
            Console.WriteLine(reverseText);
        }
    }
}