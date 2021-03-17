using System;
using System.IO;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {    
                string path = Console.ReadLine();
                DirectoryInfo dirInf = new DirectoryInfo(path);

                if (dirInf.Exists)
                {
                    string[] dir = Directory.GetDirectories(path);
                    string[] file = Directory.GetFiles(path);
                    Console.WriteLine("\nDiriktory");
                    Delete30min(dir);
                    Console.WriteLine("\nFile");
                    Delete30min(file);
                }
            else
            {
                Console.WriteLine("неправльно введен путь");
            }
            }
            catch (Exception e)
            {
                Console.WriteLine("Возникла проблема:" + e.Message);
            }
            Console.ReadKey();
        }
        public static void Delete30min(string[] file)
        {

            foreach (string f in file)
            {
               var difTA = Directory.GetLastAccessTime(f);

                TimeSpan interval = DateTime.Now - difTA;
                Console.WriteLine(f);
                Console.WriteLine("последнее использование: " + interval.TotalMinutes);

                if (interval > TimeSpan.FromMinutes(30))
                {
                    FileInfo dirInfo = new FileInfo(f);
                    dirInfo.Delete();
                    Console.WriteLine("File delete");
                }
                else
                {
                    
                    Console.WriteLine("this OK");
                }
            }
        }
    }
}
