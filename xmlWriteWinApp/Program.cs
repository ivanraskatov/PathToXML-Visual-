using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlTypes;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using System.Xml.Linq;

namespace xmlWriteWinApp
{
    static class Program
    {
        public static void xmlWrite(XmlTextWriter xmlTextWriter, string folderPath, string replacePart)
        {
            if (Helper.AllDirectorySharpCheck(folderPath))
            {
                //Корневая папка
                xmlTextWriter.WriteStartElement("Folder");
                xmlTextWriter.WriteAttributeString("Path", Helper.XmlPathFormat(folderPath, replacePart));
                xmlTextWriter.WriteAttributeString("Description", "Описание папки ур.1");
                xmlTextWriter.WriteEndElement();
                List<string> fileNamesSortedList = Helper.FindSortSharpFiles(folderPath, replacePart);

                if (Helper.DirectorySharpCheck(folderPath))
                {
                    //Файлы в корневой папке
                    foreach (string fileName in fileNamesSortedList)
                    {
                        xmlTextWriter.WriteStartElement("File");
                        xmlTextWriter.WriteAttributeString("Path", fileName);
                        xmlTextWriter.WriteAttributeString("Description", "");
                        xmlTextWriter.WriteEndElement();

                    }
                }

            }

            foreach (string folderName in Directory.GetDirectories(folderPath))
            {
                xmlWrite(xmlTextWriter, folderName, replacePart);
            }
        }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

        }
    }
}
