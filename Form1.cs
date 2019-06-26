using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.Xml;
using System.Xml.Linq;

namespace xmlWriteWinApp
{
    public partial class Form1 : Form
    {
        int i = 1;
        public Form1()
        {
            
            InitializeComponent();
            
            button1.Text = @"Добавить репозиторий";
            button2.Text = "ПУСК";
            button3.Text = "Сохранить xml в...";
            button4.Text = "Удалить";
            label1.Text = "Выбранные репозитории";
            
        }

        public void button1_Click(object sender, EventArgs e)
        {
            String[] folderPaths = new string[17];
            String[] xmlPaths = new string[17];
            int[] index = new int[20];
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description= "Выберите папку репозитория";

            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            if (fbd.ShowDialog() == DialogResult.OK)
            {

                //MessageBox.Show(fbd.SelectedPath);
                listBox1.Items.Add(fbd.SelectedPath);
                folderPaths[i] = fbd.SelectedPath;
                string xmlPath = new DirectoryInfo(fbd.SelectedPath).Name;
                xmlPaths[i] = xmlPath;
                i++;
                index[i] = i;

            }


        }

        public void button3_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            fbd.Description = "Выберите папку для xml файлов";
            fbd.RootFolder = Environment.SpecialFolder.MyComputer;
            string xmlPathFirstPart;
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                //MessageBox.Show(fbd.SelectedPath);
                listBox2.Items.Clear();
                listBox2.Items.Add(fbd.SelectedPath);
                xmlPathFirstPart = fbd.SelectedPath;
               
            }

        }

        public void button4_Click(object sender, EventArgs e)
        {
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            
        }

        public void button2_Click(object sender, EventArgs e)
        {
            String[] folderPaths = new string[17];
            String[] xmlPaths = new string[17];
            i = 1;
            foreach (object item in listBox1.Items)
            {
                
                folderPaths[i] = item.ToString();
                string pathXML = item.ToString();
                
                string xmlPath = new DirectoryInfo(pathXML).Name;
                foreach (object item2 in listBox2.Items)
                {
                    string path = item2.ToString();
                    xmlPaths[i] = path + @"\\" + xmlPath + @".xml";
                    DirectoryInfo deleteDirFiles = new DirectoryInfo(path);
                    foreach (FileInfo file in deleteDirFiles.GetFiles())
                    {
                        file.Delete();
                    }
                }

            }

            for (int i = 1; i <= listBox1.Items.Count; i++)
            {
                string newPath = xmlPaths[i];
                newPath = newPath.Replace(@"\\", @"\");
                XmlTextWriter xmlTextWriter = XmlWriter.Show(newPath);
                xmlTextWriter.Formatting = Formatting.Indented;
                xmlTextWriter.WriteStartDocument();
                xmlTextWriter.WriteStartElement("Sources");
                xmlTextWriter.WriteStartElement("Module");

                string directoryName = new DirectoryInfo(folderPaths[i]).Name;
                xmlTextWriter.WriteAttributeString("Name", directoryName);
                List<string> filePathsList = new List<string>();
                string replacePart = Path.GetDirectoryName(folderPaths[i]);
                // Запись в xml файл
                List.GetList(folderPaths[i], filePathsList, xmlTextWriter, replacePart);
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.WriteEndElement();
                xmlTextWriter.Close();
                MessageBox.Show("ОК ВСЕ!");
            }

        }
    }
}
