using System.Text;
namespace FileTree
{
    class FileTtree
    {
        static void Main()
        {
            Console.WriteLine("Enter root (example,C:\\):");
            var nameDir = Console.ReadLine();
            Console.WriteLine($"{new DirectoryInfo(@nameDir).Name}");
            if (nameDir.Contains(" -f"))
            {
                nameDir = nameDir.Replace(" -f", "");
                WithFlag(nameDir);
            }
            else
            {
                WithoutFlag(nameDir);
            }
        }

        static void WithFlag(string root, int down = 0)
        {
            var dir = new DirectoryInfo(@root);
            var space = Repeat("\t", down);
            foreach (var file in dir.GetFiles())
            {
                if (file.FullName == dir.GetFiles().Last().FullName)
                {
                    Console.WriteLine($"{space}└───{file.Name}({file.Length}b)");
                }
                else
                {
                    Console.WriteLine($"{space}├───{file.Name}({file.Length}b)");
                }
            }
            foreach (var folder in dir.GetDirectories())
            {
                if (folder.FullName == dir.GetDirectories().Last().FullName)
                {
                    Console.WriteLine(space + "└───" + folder.Name);
                }
                else
                {
                    Console.WriteLine(space + "├───" + folder.Name);
                }

                if (folder.Exists)
                {
                    down++;
                    WithFlag(folder.FullName, down);
                }
                down--;
            }
        }


        static void WithoutFlag(string root, int down = 0)
        {
            var dir = new DirectoryInfo(@root);
            var space = Repeat("\t", down);
            foreach (var folder in dir.GetDirectories())
            {
                if (folder.Exists)
                {
                    if (folder.FullName == dir.GetDirectories().Last().FullName)
                    {
                        Console.WriteLine(space + "└───" + folder.Name + down);
                    }
                    else
                    {
                        Console.WriteLine(space + "├───" + folder.Name + down);
                    }
                }
                if (folder.Exists)
                {
                    down++;
                    WithoutFlag(folder.FullName, down);
                }
                down--;
            }
        }
        static string Repeat(string word, int num)
        {
            var result = new StringBuilder();
            if (num > 0)
            {
                for (int i = 0; i < num; i++)
                {
                    result.Append("│\t");
                    result.Append(" ");
                }
            }
            return result.ToString();
        }
    }
}