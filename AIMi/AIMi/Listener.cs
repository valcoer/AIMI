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
        /// Sentence Parser interface routine
        /// </summary>
        /// <param name="input_sentence"></param>
        public Sentence parse_string_into_words(string input_sentence)
        {
            char[] delimiterChars = { ' ', ',', '.', ':', '\t' };
            //are there any other delimiters we need to be using?
            string[] words = input_sentence.Split(delimiterChars);

          // create the sentence
            Sentence temp_sentence = new Sentence();

            // add the word list to the sentence

            temp_sentence.wordlist = words;
            string[] nouns = m_nounList.RetrieveWords();
             string[] verbs = m_verbList.RetrieveWords();
            foreach (string s in words)
            {
               //TODO we need to identify each word in this array of words,
               // as it's sentence component type (right now either noun or verb)
               // and create a Sentence object (Define this class) that contains the entire list of
                // words stored as word objects (define this class)

                bool result = false;
                // verbs first
               
                // compare this particular s value to every t in the verbs list
                foreach (string t in verbs)
                {
                    result = s.Contains(t);
                    if (result)
                    {
                        Verb temp = new Verb();
                        temp.m_value = s;
                        temp_sentence.m_action.m_valueList.Add(temp);
                        result = false;
                    }
                }// end verbs
                // compare this particular s value to every t in the verbs list
                foreach (string n in nouns)
                {
                    result = false;
                    result = s.Contains(n);
                    if (result)
                    {
                        Noun temp = new Noun();
                        temp.m_value = s;
                        temp_sentence.m_subj.m_objects.Add(temp);
                    }
                }// end nouns
            }//end foreach word
            return temp_sentence;
        }// end function
    }//end class
}//end namespace
