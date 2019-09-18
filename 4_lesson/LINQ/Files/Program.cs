using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            GetFileInfo();
            ReadWriteFile();
            Seeking();
            StreamReaderExample();

            Console.Read();
        }

        private static void StreamReaderExample()
        {
            string path = @"C:\temp\test.txt";

            try
            {
                using (StreamReader sr = new StreamReader(path, Encoding.Default))
                {
                    Console.WriteLine(sr.ReadToEnd());
                }
            }
            catch(Exception ex)
            {

            }

        }

        private static void Seeking()
        {
            string text = "Hello World";

            using (FileStream fileStream = new FileStream(@"C:\temp\note.dat", FileMode.OpenOrCreate))
            {
                byte[] input = Encoding.Default.GetBytes(text);

                fileStream.Write(input, 0, input.Length);

                fileStream.Seek(-5, SeekOrigin.End);

                byte[] output = new byte[4];

                fileStream.Read(output, 0, output.Length);

                string textOutput = Encoding.Default.GetString(output);
                
                //--------------------------------//
                string replacedText = "Friend";

                fileStream.Seek(-5, SeekOrigin.End);

                input = Encoding.Default.GetBytes(replacedText);

                fileStream.Write(input, 0, input.Length);

                fileStream.Seek(0, SeekOrigin.Begin);

                output = new byte[fileStream.Length];
                fileStream.Read(output, 0, output.Length);

                textOutput = Encoding.Default.GetString(output);               
            }
        }


        private static void ReadWriteFile()
        {
            using (FileStream fileStream = new FileStream(@"C:\temp\test.txt", FileMode.OpenOrCreate))
            {
                byte[] array = Encoding.Default.GetBytes("hello world");

                fileStream.Write(array, 0, array.Length);
            }

            using (FileStream fileStream = File.OpenRead(@"C:\temp\test.txt"))
            {
                byte[] array = new byte[fileStream.Length];

                fileStream.Read(array, 0, array.Length);

                string text = Encoding.Default.GetString(array);

                Console.WriteLine(text);
            }              
        }


        private static void GetFileInfo()
        {
            string path = @"C:\temp\test.txt";

            FileInfo fileInfo = new FileInfo(path);

            if (fileInfo.Exists)
            {
                Console.WriteLine("Name {0}, Creation Time{1}, Length {2}",
                    fileInfo.Name, fileInfo.CreationTime, fileInfo.Length);
            }
        }
    }
}
