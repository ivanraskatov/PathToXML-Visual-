using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Xml;
using System.Xml.Linq;

namespace xmlWriteWinApp
{
    class Folder
    {
        /// <summary>
        /// Проверяет наличие .cs файлов папке и в подпапках и возвращает True, если нашел.
        /// </summary>
        /// <param name="folderPath"></param>
        /// <returns></returns>
        public static Boolean CheckFolder(string folderPath)
        {

            List<string> filePathsList = new List<String>();
            string fileMask = @"*.cs";
            int i = 0;
            foreach (var item in Directory.EnumerateFiles(folderPath, fileMask, SearchOption.AllDirectories))
            {
                i++;
                filePathsList.Add(item);
            }

            if (i > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }
        
    }
}
