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
    /// <summary>
    /// Выполняет фильтрацию папок/файлов по наличию запрещенных сочетаний в пути к файлу/папке. 
    /// </summary>
    public class Filter
    {
        public static bool FolderCheck(string folderPath)
        {
            bool folderChecked = true;
            string folderName = new DirectoryInfo(folderPath).Name;
            if (folderPath.Contains("Debug") || folderPath.Contains("debug"))
            {
                return false;
            }
            if (folderPath.IndexOf("test", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return false;
            }
            if (folderPath.IndexOf("obj", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return false;
            }
            if (folderPath.IndexOf("samples", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return false;
            }
            if (folderPath.IndexOf("examples", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return false;
            }
            if (folderPath.IndexOf(".vs", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return false;
            }
            if (folderPath.IndexOf(".git", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return false;
            }
            if (folderPath.IndexOf("sample", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return false;
            }
            if (folderPath.IndexOf(".git", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return false;
            }
            if (folderPath.IndexOf("tutorial", StringComparison.OrdinalIgnoreCase) >= 0)
            {
                return false;
            }
            return folderChecked;
        }
    }
}
