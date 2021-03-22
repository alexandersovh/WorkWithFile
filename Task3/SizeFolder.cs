using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Task3
{
    class SizeFolder
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
            foreach (DirectoryInfo di in dirN)
            {
                size += DirSize(di);
            }
            return size;
        }
        public static long DirSizeDelit(DirectoryInfo d)
        {
            long size = 0;
            FileInfo[] fis = d.GetFiles();
            foreach (FileInfo f in fis)
            {
                size = Clining.Delete30min(f.FullName);
                
            }
            DirectoryInfo[] dirN = d.GetDirectories();
            foreach (DirectoryInfo di in dirN)
            {
                size += DirSizeDelit(di);
            }
            return size;
        }
    }
}
