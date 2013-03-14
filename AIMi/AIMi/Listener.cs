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
       XmlDataAccess m_nounList;
       XmlDataAccess m_verbList;

        /// <summary>
        /// 
        /// </summary>
        public Listener()
        {
            //initialize member variables
            m_nounList = new XmlDataAccess("xmlNounList.xml");
            m_verbList = new XmlDataAccess("xmlVerbList.xml");
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
