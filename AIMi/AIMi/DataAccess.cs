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
            XmlNode newWords = doc.CreateElement("words");

            XmlNode newNode = doc.CreateElement("word");

            newNode.InnerText = word;
            newWords.AppendChild(newNode);


            doc.SelectSingleNode("//words").AppendChild(newNode);
            doc.Save(_path);
        }
        public List<string> RetrieveWords()
        {
            {
                List<string> list = new List<string>();
                XmlNode root = doc.SelectSingleNode("//words");
                XmlNodeList nodelist = root.SelectNodes("word");
                foreach (XmlNode n in nodelist)
                {
                    string w;
                    w = n.SelectSingleNode("word").InnerText;
                    list.Add(w);

                }

                return list;
            }


        }

    }
}
