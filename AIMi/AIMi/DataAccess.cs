using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

namespace AIMind
{
    class DataAccess
    {
        private string _path;
        private string _localPath = @"";
        XmlDocument doc;
         
        public DataAccess(string xmlDocumentName)
        {
            _path = _localPath + xmlDocumentName;
            doc = new XmlDocument();
            doc.Load(_path);
        }
        public void AddWord(string word)
        {
           XmlNode newNode = doc.CreateNode(XmlNodeType.Text  , "word", "");

            newNode.InnerText = word;
            
            doc.SelectSingleNode("words").AppendChild(newNode);
            doc.Save(_path);
        }
    }
   
}
