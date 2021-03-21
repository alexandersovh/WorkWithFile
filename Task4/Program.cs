using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinalTask
{
    class Program
    {
        const string CreateFolder = "Students";
        const string PathDesctop = @"C:\Users\alexandr\Desktop\";
        static void Main(string[] args)
        {

            SortStudentToFile(PathDesctop);
            Console.ReadKey();
        }

        /// <summary>
        /// Дисериализация файла
        /// </summary>
        /// <returns> массив студентов </returns>
        static Student[] ReadFile(string peth)
        {
            BinaryFormatter formatter = new BinaryFormatter();
            using (var fs = new FileStream(peth, FileMode.Open))
            {
                var newStud = (Student[])formatter.Deserialize(fs);
                return newStud;
            }
        }
        static void SortStudentToFile(string path)
        {
            
            Student[] stud = ReadFile(path + "Students.dat");
            Directory.CreateDirectory(path + CreateFolder);

            foreach (Student arrGrop in stud)
            {
                string studGroup = Path.Combine(path,CreateFolder,arrGrop.Group + ".txt");
                if (!File.Exists(studGroup)) 
                {
                    using (StreamWriter sw = File.CreateText(studGroup))
                    {
                        foreach(Student arrStud in stud)
                        {
                            if (arrStud.Group == arrGrop.Group)
                            {
                                sw.WriteLine($"Имя: {arrStud.Name}, Дата раждения: {arrStud.DateOfBirth.Date}," +
                                    $" их группа,{arrStud.Group} \n________________________________________________");
                            }
                        }
                    }
                }

            }
        }
    }
}