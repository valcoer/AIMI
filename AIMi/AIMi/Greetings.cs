using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AIMind
{
    public class Greetings
    {


        // Data access object variable.
        DataAccess daobj;
        // constructor
        public Greetings()
        {
            // Create the DataAccess access object.
            daobj = new DataAccess("XMLgreetinglist.xml");

        }

        string[] _greet;
        
        //greeting list array
       // string[] _greet = { "hi", "hello", "greetings" };
        //function to get the xml list in a string array
        public void getwords()
        {

            _greet = daobj.RetrieveWords();


        }
        public string[] Greet
        {
            get { return _greet; }
        }
        public string this[int index]
        {
            get { return _greet[index]; }
        }
        // add new word to the xml list
        public void createNewWord(string word)
        {
            daobj.AddWord(word);
        }

    }
}
