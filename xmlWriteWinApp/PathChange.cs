using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace xmlWriteWinApp
{
    class PathChange
    {
        /// <summary>
        /// Выполняет замену пути исходного для указанного пути на новый фиктивный путь, для красоты.
        /// </summary>
        /// <param name="folderpath"></param>
        /// <param name="replacePart"></param>
        /// <returns></returns>
        public static string ReplaceName(string folderpath, string replacePart)
        {
            string newPath;
            string fakePath = @"C:\Repositories";
            
            newPath = folderpath;
            newPath = newPath.Replace(replacePart, fakePath);
            return newPath;
        }
    }
}
