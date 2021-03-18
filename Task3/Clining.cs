using System.IO;
using System;
using System.Collections.Generic;
using System.Text;


namespace Task3
{
    class Clining
    {
        public static long Delete30min(string file)
        {
            FileInfo fileInfo = new FileInfo(file);
            var fd = Directory.GetLastAccessTime(file);
            long i = 0;
            TimeSpan interval = DateTime.Now - fd;
            if (interval > TimeSpan.FromMinutes(30))
            {
                i = fileInfo.Length;
                fileInfo.Delete();
                Console.WriteLine("File delete");
            }
            return i;
        }
    }
}
