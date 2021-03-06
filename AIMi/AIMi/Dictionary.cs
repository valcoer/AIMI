﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Serialization;
using System.Text;


namespace AIMind
{
   public class Dictionary
    {
        // I probably did not need to clone the XmlDataAccess to this extent but I wanted to practice Im sure there are better ways to 
        // go about doing the sorting of words but this seemed to make sense to me so I am going to try it here.
      
       public string m_word;

        private string m_dictPath;
        private string m_nounPath;
        private string m_verbPath;
        private string m_greetPath;
        private string m_localPath = @"";
        XmlDocument m_nounDoc;
        XmlNodeList m_nounNodelist;
        XmlDocument m_verbDoc;
        XmlNodeList m_verbNodelist;
        XmlDocument m_greetDoc;
        XmlNodeList m_greetNodelist;
        XmlDocument m_dictDoc;
        XmlNodeList m_dictNodelist;
        XmlNodeList m_dictNodeTypeList;
        private string m_nounDocumentName;
        private string m_verbDocumentName;
        private string m_greetDocumentName;
        private string m_dictDocumentName;
        private string w;
        
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="xmlGreetingList"></param>
        /// <param name="xmlNounList"></param>
        /// <param name="xmlVerbList"></param>
        public Dictionary(string xmlGreetingList, string xmlNounList, string xmlVerbList)
        {

           
            // Get all the nouns
            m_nounPath = m_localPath + xmlNounList;
            m_nounDoc = new XmlDocument();
            m_nounDoc.Load(m_nounPath);
            populateNounNodeList();
            m_nounDocumentName = xmlNounList;

            // Get all the verbs
            m_verbPath = m_localPath + xmlVerbList;
            m_verbDoc = new XmlDocument();
            m_verbDoc.Load(m_verbPath);
            populateVerbNodeList();
            m_verbDocumentName = xmlVerbList;

            //Get all the greetings
            m_greetPath = m_localPath + xmlGreetingList;
            m_greetDoc = new XmlDocument();
            m_greetDoc.Load(m_greetPath);
            populateGreetNodeList();
            m_greetDocumentName = xmlGreetingList;

            //prep the dictionary
            string xmlDictList = ("Dictionary.xml");
            m_dictPath = m_localPath + xmlDictList;
            m_dictDoc = new XmlDocument();
            m_dictDoc.Load(m_dictPath);
            populateDictNodeList();
            m_dictDocumentName = xmlDictList;


        }
        
        void populateNounNodeList()
        {
            XmlNode root = m_nounDoc.SelectSingleNode("//words");
            m_nounNodelist = root.SelectNodes("word");
        }
        void populateVerbNodeList()
        {
            XmlNode root = m_verbDoc.SelectSingleNode("//words");
            m_verbNodelist = root.SelectNodes("word");
        }
        void populateGreetNodeList()
        {
            XmlNode root = m_greetDoc.SelectSingleNode("//words");
            m_greetNodelist = root.SelectNodes("word");
        }
        void populateDictNodeList()
        {
            XmlNode root = m_dictDoc.SelectSingleNode("//words");
            m_dictNodelist = root.SelectNodes("word");
            m_dictNodeTypeList = root.SelectNodes("PoS");
        }
        public void AddNoun(string word)
        {

            XmlNode newWordNode = m_dictDoc.CreateElement("word");
            XmlNode newNoun = m_nounDoc.CreateElement("word");
            newNoun.InnerText = word;
            newWordNode.InnerText = word;
            m_dictDoc.SelectSingleNode("//words").AppendChild(newWordNode);
            XmlNode newNounNode = m_dictDoc.CreateElement("PoS");
            newNounNode.InnerText = "noun";
            m_dictDoc.SelectSingleNode("//words").AppendChild(newNounNode);
            m_nounDoc.SelectSingleNode("//words").AppendChild(newNoun);
            m_dictNodelist = null;
            m_nounNodelist = null;
            populateNounNodeList();
            populateDictNodeList();
        }
          public void AddVerb(string word)
        {

            XmlNode newWordNode = m_dictDoc.CreateElement("word");
            XmlNode newVerb = m_verbDoc.CreateElement("word");
            newWordNode.InnerText = word;
            newVerb.InnerText = word;
            m_dictDoc.SelectSingleNode("//words").AppendChild(newWordNode);
            m_verbDoc.SelectSingleNode("//words").AppendChild(newVerb);
            XmlNode newVerbNode = m_dictDoc.CreateElement("PoS");
            newVerbNode.InnerText = "verb";
            m_dictDoc.SelectSingleNode("//words").AppendChild(newVerbNode);
            m_dictNodelist = null;
            m_verbNodelist = null;
            populateVerbNodeList();
            populateDictNodeList();
        }
          public void AddGreeting(string word)
        {

            XmlNode newWordNode = m_dictDoc.CreateElement("word");
            XmlNode newGreeting = m_greetDoc.CreateElement("word");
            newWordNode.InnerText = word;
            newGreeting.InnerText = word;
            m_dictDoc.SelectSingleNode("//words").AppendChild(newWordNode);
            m_greetDoc.SelectSingleNode("//words").AppendChild(newGreeting);
            XmlNode newGreetNode = m_dictDoc.CreateElement("PoS");
            newGreetNode.InnerText = "interjection";
            m_dictDoc.SelectSingleNode("//words").AppendChild(newGreetNode);
            m_dictNodelist = null;
            m_greetNodelist = null;
            populateGreetNodeList();
            populateDictNodeList();
        }
          public string RetrieveType(string word)
          {
             // string[] types = new string[m_dictNodeTypeList.Count];
              int a = 0;
              int index = 0;
              int x = 0;
              string type;
              foreach (XmlNode n in m_dictNodelist)
              {
                  w = n.InnerText.ToString();
                  if (word == w)
                  {
                      index = a;
                      Console.WriteLine("inside retrieve type. index for word found: " + index + "" + "index found for: " +  word);

                      break;
                  }
                  else
                  {
                      
                      a++;
                      
                  }
                  
              }
              string[] list = new string[m_dictNodelist.Count];
            

              foreach (XmlNode m in m_dictNodeTypeList)
              {


                  w = m.InnerText.ToString();
                  list[x] = w;
                  
                  x++;
              }
              
              type = list[index].ToString();
              Console.WriteLine("output for retrieve type:  " + type);

              return type;

             
          }
          public String[] RetrieveWords()
          {
              
              string[] list = new string[m_dictNodelist.Count];
              int x = 0;
              
              foreach (XmlNode n in m_dictNodelist )
              {
                  
                  
                  w = n.InnerText.ToString();
                  list[x] = w;
                 
                  x++;
              }
           
              
              return list;

          }
          public int getNodelistSize()
          {
              return m_dictNodelist.Count;
          }
          public void saveDoc()
          {
              m_dictDoc.Save(m_dictDocumentName);
              m_nounDoc.Save(m_nounDocumentName);
              m_verbDoc.Save(m_verbDocumentName);
              m_greetDoc.Save(m_greetDocumentName);
          }



          public void createNewNoun(string newNoun)
          {
              int a = 0;

              foreach (XmlNode n in m_dictNodelist)
              {
                  w = n.InnerText.ToString();
                  if (newNoun == w)
                  {
                      a++;
                      return;
                  }
                  else
                  {

                  }

              }
              if (a < 1)
              {
                  AddNoun(newNoun);
              }
            
          }
          public void createNewVerb(string newVerb)
          {
              int a = 0;

              foreach (XmlNode n in m_dictNodelist)
              {
               w = n.InnerText.ToString();
                  if (newVerb == w)
                  {
                      a++;
                      return;
                  }
                  else
                  {
                      
                  }
                 
              }
              if (a < 1)
              {
                  AddVerb(newVerb);
              }
              
          }

          public void createNewGreet(string newGreet)
          {
              int a = 0;
             
              foreach (XmlNode n in m_dictNodelist)
              {

                  w = n.InnerText.ToString();
                  if (newGreet == w)
                  {
                      a++;
                      return;
                  }
                  else
                  {
                      
                  }
                 
              }
              if (a < 1)
              {
                  AddGreeting(newGreet);
              }
          }
      
    }
}
