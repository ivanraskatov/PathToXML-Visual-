using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.IO;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using System.Xml.Linq;
namespace xmlWriteWinApp
{
    class XmlWriter
    {
        public static XmlTextWriter Show(string path)
        {
            XmlTextWriter xmlTextWriter = new XmlTextWriter(path, Encoding.UTF8);
            return xmlTextWriter;
        }
    }
}
