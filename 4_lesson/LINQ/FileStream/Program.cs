using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStream
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInformation();
            CreateNewDir();
            GetDirInfo();
            RemoveDir();
            DirectoryNewPath();


            Console.Read();
        }

        private static void DirectoryNewPath()
        {
            CreateNewDir();

            string oldPath = @"C:\SomeDirectory";
            string newPath = @"C:\SomeDir";

            DirectoryInfo dirInfo = new DirectoryInfo(oldPath);

            if (dirInfo.Exists && !Directory.Exists(newPath))
            {
                dirInfo.MoveTo(newPath);
            }

        }


        private static void RemoveDir()
        {
            string dirName = @"C:\SomeDirectory";

            try
            {
                DirectoryInfo dirInfo = new DirectoryInfo(dirName);
                dirInfo.Delete(true);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }


        private static void GetDirInfo()
        {
            string dirName = @"C:\Program Files";

            DirectoryInfo dirInfo = new DirectoryInfo(dirName);

            Console.WriteLine("Name {0}, FullName {1}, Creation Time {2}, Root {3}",
                dirInfo.Name, dirInfo.FullName, dirInfo.CreationTime, dirInfo.Root
                );       
        }

        private static void CreateNewDir()
        {
            string path = @"C:\SomeDirectory";

            DirectoryInfo dirInfo = new DirectoryInfo(path);

            if (!dirInfo.Exists)
            {
                dirInfo.Create();
            }
        }

        private static void DirectoryInformation()
        {
            string dirName = "C:\\";

            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Directory content:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (var s in dirs)
                {
                    Console.WriteLine(s);
                }

            }
        }
    }
}
