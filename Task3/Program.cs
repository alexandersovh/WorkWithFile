using System;
using System.IO;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\User\luft";
            Console.WriteLine("директория: " + path);
            DirectoryInfo dirInfo = new DirectoryInfo(path);
            Console.WriteLine($"Размер директории: {SizeFolder.DirSize(dirInfo)} байт");
            Console.WriteLine($"места очищено: {SizeFolder.DirSizeDelit(dirInfo)} байт");
            Console.WriteLine($"текущий размер директории: {SizeFolder.DirSize(dirInfo)} байт");
            Console.ReadKey();
        }
    }
}
