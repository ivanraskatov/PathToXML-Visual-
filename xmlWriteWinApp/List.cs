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
    /// Выполняет заполнение xml файла, фильтрация, сортировка, описание, все вызывается тут.
    /// </summary>
    class List
    {
        public static void GetList(string folderpath, List<String> filePathsList, XmlTextWriter xmlTextWriter, string replacePart)
        {

            string fileMask = "*.cs";
            DirectoryInfo directory = new DirectoryInfo(folderpath);
            foreach (var item in directory.GetDirectories())
            {
                if (Filter.FolderCheck(item.FullName))
                {
                    if (Folder.CheckFolder(item.FullName))
                    {

                        string path = PathChange.ReplaceName(item.FullName, replacePart);
                        filePathsList.Add(path);
                        Console.WriteLine("Folder  " + path);
                        xmlTextWriter.WriteStartElement("Folder");
                        xmlTextWriter.WriteAttributeString("Path", path);
                        xmlTextWriter.WriteAttributeString("Description", Description.Show(item.FullName) +".");
                        xmlTextWriter.WriteEndElement();


                        foreach (string filename in Directory.GetFiles(item.FullName, fileMask, SearchOption.TopDirectoryOnly))
                        {
                            string filenameNew = PathChange.ReplaceName(filename, replacePart);
                            filePathsList.Add(filenameNew);
                            Console.WriteLine("File  " + filenameNew);
                            xmlTextWriter.WriteStartElement("File");
                            xmlTextWriter.WriteAttributeString("Path", filenameNew);
                            xmlTextWriter.WriteAttributeString("Description","");
                            xmlTextWriter.WriteEndElement();
                        }
                    }
                }
                GetList(item.FullName, filePathsList, xmlTextWriter, replacePart);
            }

        }
    }
}
