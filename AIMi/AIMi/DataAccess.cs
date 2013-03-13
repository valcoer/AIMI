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
        /// <summary>
        /// Class variables
        /// </summary>
        private string m_path;
        private string m_localPath = @"";
        XmlDocument m_doc;
        XmlNodeList m_nodelist;



        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="xmlDocumentName"></param>
        public DataAccess(string xmlDocumentName)
        {
            m_path = m_localPath + xmlDocumentName;
            m_doc = new XmlDocument();
            m_doc.Load(m_path);
            populateNodeList();
        }

     /// <summary>
     /// Add a word to the node list
     /// </summary>
     /// <param name="word"></param>
        public void AddWord(string word)
        {

            XmlNode newNode = m_doc.CreateElement("word");
            newNode.InnerText = word;
            m_doc.SelectSingleNode("//words").AppendChild(newNode);
            m_nodelist = null;
            populateNodeList();
        }

        /// <summary>
        /// retrieve the words from the xml list
        /// </summary>
        /// <returns>String[]</returns>
        public String[] RetrieveWords()
        {
           
            string[] list = new string[m_nodelist.Count ];
            int x = 0;
            foreach (XmlNode n in m_nodelist)
            {   
                string w;
                w = n.InnerText.ToString();
                list[x] = w;
                x++;
            }

            return list;
            
        }
        /// <summary>
        /// interface to get the nodelist size
        /// </summary>
        /// <returns></returns>
       public int getNodelistSize()
        {
            return m_nodelist.Count;
        }
        /// <summary>
        /// populate the internal nodelist
        /// </summary>
       void populateNodeList()
       {
            XmlNode root = m_doc.SelectSingleNode("//words");
            m_nodelist = root.SelectNodes("word");
        }
/// <summary>
/// deprecated
/// </summary>
/// <param name="word"></param>
/// <param name="list"></param>
/// <param name="x"></param>
/// <returns></returns>
        public string[] insertWord(string word,string[] list,int x)
        {

            for (int i = 0; i >= x;i++ )
            {
                list[i] = word;
            }
            return list;
        }
        /// <summary>
        /// Utility function for debugging
        /// </summary>
        /// <param name="word"></param>
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
