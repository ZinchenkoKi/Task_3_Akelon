using System;
using System.IO;


namespace Task_3_working_Excel_document
{
    internal class FilePath
    {
        public string Path()
        {
            string path = RequestingFilePath();
            CheckingExistenceFile(path);
            return path;
        }

        private string RequestingFilePath()
        {
            Console.WriteLine("Введите путь к файлу: ");
            string path = Console.ReadLine();
            return path;
        }

        private void CheckingExistenceFile(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);
            if (fileInfo.Exists)
            {
                Console.WriteLine("Файл найден");
            }
            else
            {
                Console.WriteLine("Файл не найден!");
                CheckingExistenceFile(RequestingFilePath());
            }
        }
    }
}
