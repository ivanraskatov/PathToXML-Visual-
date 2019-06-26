using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Xml;

namespace xmlWriteWinApp
{
    public class Helper
    {

        /// <summary>
        /// Получает лист адресов C# файлов в папке.  
        /// Сортирует их по алфавиту и возвращает сортированный лист адресов C# файлов в папке.
        /// </summary>
        /// <param name="filePathsList"></param>
        /// <returns></returns>
        public static List<string> PrepareSharpFiles(List<string> filePathsList)
        {
            List<string> fileNamesSortedList = new List<String>();  // создаем лист пустой, потом его наполним и выведем. 
                                                                    // сортировка получаемого листа адресов по алфавиту
            foreach (string fileName in filePathsList)             // цикл наполненния пустого листа адресами из отсортированного
            {
                if(Filter.FolderCheck(fileName))
                {
                    fileNamesSortedList.Add(fileName);
                }
                                  
            }
            filePathsList.Sort();
            return fileNamesSortedList;                             // возвращаем лист сортированных адресов
        }

        /// <summary>
        /// Находит все C# файлы в указанной папке. Возвращает лист string адресов этих файлов
        /// </summary>
        /// <param name="folderPath"></param>
        /// <returns></returns>
        public static List<string> FindSortSharpFiles(string folderPath, string replacePart)
        {
            
            List<string> filePathsList = new List<String>();   // Создаем пустой лист
            string fileMask = @"*.cs";                         // Объявляем переменную с форматом маски для поиска

            foreach (string fileName in Directory.GetFiles(folderPath, fileMask, SearchOption.TopDirectoryOnly))
            {
                if (Filter.FolderCheck(fileName))
                {
                    filePathsList.Add(fileName);                   // Наполняем лист адресами найденных C# файлов              
                    Console.WriteLine(fileName);
                }
            }
            Console.WriteLine("================================================================================");
            filePathsList.Sort();
            foreach (string fileName in filePathsList)
            {
               Console.WriteLine(fileName);
            }
            // Ниже вызываем метод, который заменяет часть адреса на фиктивный для красоты
            List<string> newFormatList = new List<string>();
            foreach (string newPath in Helper.XmlPathFormat(filePathsList, folderPath, replacePart))
            {
                newFormatList.Add(newPath);

            }
            return newFormatList;                              // Возвращаем полученный лист адресов 
        }

        public static void xmlStartNewFile(string xmlFilesPath, string folderPath)
        {
            string xmlFileName = "xmlDescriptionFile";
            string parentFolderName = @"xmlDescription";
            string parentFolderPath = Path.Combine(folderPath, parentFolderName);
            if (Directory.Exists(parentFolderPath) == false)
            {
                Directory.CreateDirectory(parentFolderPath);
            }
            XmlTextWriter xmlTextWriter = new XmlTextWriter(Path.Combine(parentFolderPath, xmlFileName), Encoding.UTF8);

        }

        public static Boolean AllDirectorySharpCheck(string folderPath)
        {
            string fileMask = @"*.cs";
            List<String> fileList = new List<string>();
            foreach (string fileName in Directory.GetFiles(folderPath, fileMask, SearchOption.AllDirectories))
            {
                fileList.Add(fileName);                   // Наполняем лист адресами найденных C# файлов              
            }
            if (fileList.Count >= 1)
            {
                return true;
            }

            return false;
        }
        public static Boolean DirectorySharpCheck(string folderPath)
        {
            string fileMask = @"*.cs";
            List<String> fileList = new List<string>();
            foreach (string fileName in Directory.GetFiles(folderPath, fileMask, SearchOption.TopDirectoryOnly))
            {
                fileList.Add(fileName);                   // Наполняем лист адресами найденных C# файлов              
            }
            if (fileList.Count >= 1)
            {
                return true;
            }

            return false;
        }

        public static string XmlPathFormat(string basePath, string replacePart)
        {
            string fakePath = @"C:\Repositories";
            string directoryName = new DirectoryInfo(basePath).Name;
            string newPath;
            newPath = basePath.Replace(replacePart, fakePath);
            return newPath;
        }

        public static string GetPathReplacePart(string basePath)
        {
            string replacePart = Path.GetDirectoryName(basePath);

            return replacePart;
        }

        public static List<string> XmlPathFormat(List<string> filePathsList, string basePath, string replacePart)
        {
            List<string> formattedPathList = new List<string>();
            string fakePath = @"C:\Repositories";
            string directoryName = basePath.Remove(0, Path.GetDirectoryName(basePath).Length);
            //string replacePart = Path.GetDirectoryName(basePath).Remove(0,3);

            string newPath;
            int countBasePath = basePath.Length;
            int countFolder = directoryName.Length;

            int removeAmount = countBasePath - countFolder-3;
            foreach (string path in filePathsList)
            {
                newPath = path;
                newPath = newPath.Replace(replacePart, fakePath);
                formattedPathList.Add(newPath);
            }
            return formattedPathList;
        }

    }
}
