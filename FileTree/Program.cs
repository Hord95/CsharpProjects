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
            bool includeFiles = false;
            if (nameDir.Contains(" -f"))
            {
                nameDir = nameDir.Replace(" -f", "");
                includeFiles = true;
            }
           
            //foreach(var file in new DirectoryInfo(@nameDir).GetDirectories())
            //{
                Console.WriteLine(fileTree(nameDir, includeFiles));
            //}
            
        }

        static string fileTree(string root, bool includeFiles, int down = 0)
        {
            var dir = new DirectoryInfo(@root);
            var space = Repeat("\t", down);
            var result = new StringBuilder();
            if (includeFiles == true)
            {
                foreach (var file in dir.GetFiles())
                {
                    if (file.FullName == dir.GetFiles().Last().FullName)
                    {
                        result.Append($"{space}└───{file.Name}({file.Length}b)\n");
                    }
                    else
                    {
                        result.Append(space + "├───" + file.Name + "(" + file.Length + "b)\n");
                    }
                }
            }
           
                var folders = dir.GetDirectories();

                foreach (var folder in folders)
                {


                    if (folder.FullName == dir.GetDirectories().Last().FullName)
                    {
                        down++;
                        result.Append((space + "└───" + folder.Name + "\n") + fileTree(folder.FullName, includeFiles , down));
                   
                    
                    }
                    else
                    {
                        down++;
                        result.Append((space + "├───" + folder.Name + "\n" + fileTree(folder.FullName, includeFiles, down)));
                       down--;
                    }
                }
            
                    //down++;
                    //return fileTree(folder.FullName, includeFiles, result.ToString(), down);
                    //down--;
            return result.ToString();
            
            
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