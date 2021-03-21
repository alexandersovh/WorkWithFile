using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinalTask
{
    class Program
    {
        const string Path = @"C:\Users\alexandr\Desktop\Students.dat";
        static void Main(string[] args)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (var fs = new FileStream(Path, FileMode.Open))
                {
                    var newStud = (Student[])formatter.Deserialize(fs);
                    foreach (var s in newStud)
                    {
                        Console.WriteLine($"Group: {s.Group}; Имя: {s.Name}; Возраст: {s.DateOfBirth}");
                    }
                }
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }

            Console.ReadKey();
        }
    }
}
