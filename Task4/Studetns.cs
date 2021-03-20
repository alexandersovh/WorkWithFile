using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
//using System.Collections.Generic;
//using System.Text;

namespace Task4
{
    class Studetns
    {
        static string Path = @"C:\Users\alexandr\Desktop\Students.dat";

        public static void WriteData()
        {
            string Grup;
            string Name;
            int IDateOfBirth;
            string SDateOfBirth;
            DateTime DateOfBirth;

            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (var fs = new FileStream(Path, FileMode.OpenOrCreate))
                using (var br = new BinaryReader(fs))
                {
                    Grup = br.ReadString();
                    Name = br.ReadString();
                    SDateOfBirth = br.ReadString();
                //    while (Grup != null && Name != null && SDateOfBirth != null)
                //{
                    Console.WriteLine("Group: " + Grup);
                    Console.WriteLine("Name: " + Name);
                    Console.WriteLine("Date of Birth: " + SDateOfBirth);
                //}
                }
                


                //using (FileStream fstream = File.OpenRead(Path))
                //{
                //    // преобразуем строку в байты
                //    byte[] array = new byte[fstream.Length];
                //    // считываем данные
                //    fstream.Read(array, 0, array.Length);
                //    // декодируем байты в строку
                //    string textFromFile = System.Text.Encoding.Default.GetString(array);
                //    Console.WriteLine($"Текст из файла: {textFromFile}");
                //}
            }
            catch (Exception e)
            {
                Console.WriteLine("Ошибка: " + e.Message);
            }
        }
    }

}
