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

        // retrieve the words from the xml list
        public String[] RetrieveWords()
        {
            int x = 0;
            
            XmlNode root = doc.SelectSingleNode("//words");
            XmlNodeList nodelist = root.SelectNodes("word");
            foreach (XmlNode y in nodelist)
            {
                x++;
                Console.WriteLine(x);
            }
            string[] list = new string[x];
            foreach (XmlNode n in nodelist)
            {
                string w;
                w = n.SelectSingleNode("word").InnerText;
                insertWord(w, list, x);
            }
            return list;
        }

        public string[] insertWord(string word,string[] list,int x)
        {

            for (int i = 0; i >= x;i++ )
            {
                list[i] = word;
            }
            return list;

        }
        static void test(string word)
        {
            if(word == null)
            {
                return;
            }
            Console.WriteLine(word);
        }
    }
}
