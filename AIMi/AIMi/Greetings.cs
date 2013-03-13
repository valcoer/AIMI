﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace AIMind
{
    class Greetings
    {
        string[] _greet;
        // Data access object variable.
        DataAccess daobj;
        // constructor
        public Greetings(DataAccess dataobject)
        {
            // Create the DataAccess access object.
            daobj = dataobject;
            getwords();
        }
        /// <summary>
        /// populate the Greet member from the data access object
        /// </summary>
        public void getwords()
        {
            _greet = daobj.RetrieveWords();
        }
        public string[] Greet
        {

            get
            {
                getwords();
                return _greet;
            }
        }
        public string this[int index]
        {
            get { return _greet[index]; }
        }

        public void createNewWord(string word)
        {
            daobj.AddWord(word);
            // now update our internal record of the words
            getwords();
        }
       
    }
}