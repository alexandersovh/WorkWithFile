using System;
using System.IO;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = Console.ReadLine();
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            
                var folders = dirInfo.GetDirectories();

                WriteFolderInfo(folders);
            
            Console.ReadKey();
        }

        public static void WriteFolderInfo(DirectoryInfo[] folders)
        {
            Console.WriteLine("Folder:\n");

            foreach(var folder in folders)
            {
                try
                {
                    Console.WriteLine(folder.Name + $" - {Extension.DirSize(folder)}байт");

                }
                catch (Exception e)
                {
                    Console.WriteLine(folder.Name + $" - невышло: ");

                }
                
            }
        }
    }
}
