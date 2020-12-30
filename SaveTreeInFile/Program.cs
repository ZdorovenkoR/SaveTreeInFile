using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
//Сохранить дерево каталогов и файлов по заданному пути в текстовый файл — с
//рекурсией и без.

namespace SaveTreeInFile
{
    class Program
    {
        static void Main(string[] args)
        {
            string link = @"C:\";
            StreamWriter userData = new StreamWriter("folders_and_files.txt", false);
            Links(link, userData);
            userData.Close();
        }
        static void Links(string rootFolder, StreamWriter stream)
        {
            string[] dirs = Directory.GetDirectories(rootFolder);
            for (int i = 0; i<dirs.Length; i++)
            {
                stream.WriteLine(dirs[i]);
                Files(dirs[i], stream);
                Links(dirs[i], stream);
            }
        }
        static void Files(string rootFolder, StreamWriter stream)
        {
            string[] files = Directory.GetFiles(rootFolder);
            for (int i = 0; i<files.Length; i++)
            {
                stream.WriteLine(files[i]);
            }
        }
    }
}

