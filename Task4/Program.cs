using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace FinalTask
{
    class Program
    {
        const string FolderStud = "Students";
        const string PathDesctop = @"C:\Users\alexandr\Desktop\";

        static void Main(string[] args)
        {

            try
            {
                CheckFolder(PathDesctop);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Oшибка: " + ex.Message);
            }

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
        /// <summary>
        /// Проверяет наличие папки в указанной дериктории
        /// </summary>
        /// <param name="path"></param>
        static void CheckFolder(string path)
        {
            string pathStud = Path.Combine(path, FolderStud);
            DirectoryInfo dirInf = new DirectoryInfo(pathStud);
            if (dirInf.Exists)
            {
                dirInf.Delete(true);
                Console.WriteLine("Обновление Файла 'Student'");
            }
            Console.WriteLine("Создани фаил 'Student'");
            dirInf.Create();
            SortStudentToFile(pathStud);
            

        }
        static void SortStudentToFile(string path)
        {
            string getFile= Path.Combine(PathDesctop + "Students.dat");
            Student[] stud = ReadFile(getFile);

            foreach (Student arrGrop in stud)
            {
                string studGroup = Path.Combine(path, arrGrop.Group + ".txt");
                if (!File.Exists(studGroup))
                {
                    using (StreamWriter sw = File.CreateText(studGroup))
                    {
                        foreach (Student arrStud in stud)
                        {
                            if (arrStud.Group == arrGrop.Group)
                            {
                                sw.WriteLine($"Имя: {arrStud.Name}\t| Дата раждения: {arrStud.DateOfBirth.ToShortDateString()}");
                            }
                        }
                    }
                }

            }
            Console.WriteLine("Студенты pасформированы по группам");
        }
    }
}
