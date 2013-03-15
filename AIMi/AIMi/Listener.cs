using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIMind
{
    /// <summary>
    /// 
    /// </summary>
   public class Listener
    {
       // declare member variables
      public XmlDataAccess m_nounList;
      public XmlDataAccess m_verbList;

        /// <summary>
        /// 
        /// </summary>
        public Listener()
        {
            //initialize member variables
            Console.WriteLine("listner entered");
            m_nounList = new XmlDataAccess("xmlNounList.xml");
            m_verbList = new XmlDataAccess("xmlVerbList.xml");
            Console.WriteLine("listener constructor finished");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="input_sentence"></param>
        public void parse_Sentence(string input_sentence)
        {

        }
    }
}
