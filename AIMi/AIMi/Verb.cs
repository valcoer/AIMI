using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIMind
{
    public class Verb
    {
        public string m_value;
        //verbs that take objects are transitive verbs
        //verbs that do not take objects are intransitive verbs
        public string m_transitive;
        public string m_intransitive;
        public string m_linking;
        public Verb()
        {

        }
    }
}
