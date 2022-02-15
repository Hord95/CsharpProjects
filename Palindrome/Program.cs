namespace Palindrome
{
    class Palindrome
    {
        static void Main()
        {
            var word = Console.ReadLine();
            if (!string.IsNullOrWhiteSpace(word))
            {
                Console.WriteLine(MakePalindrome(word));
            }
        }
        static string MakePalindrome(string word)
        {
            int i, j;
            for (i = 0, j = word.Length - 1; i < word.Length / 2 && j > word.Length / 2 - 1; i++, j--)
            {
                if (word[i] != word[j])
                {
                    return "no";
                }
            }
            return "yes";
        }
    }
}