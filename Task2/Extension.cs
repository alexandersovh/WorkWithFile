using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Task2
{
    public static class Extension
    {
        public static long DirSize(DirectoryInfo d)
        {
            long size = 0;

            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo f in fis)
            {
                size += f.Length;
            }
            DirectoryInfo[] dirN = d.GetDirectories();
            foreach(DirectoryInfo di in dirN)
            {
                size += DirSize(di);
            }
            return size;
        }
    }
}
