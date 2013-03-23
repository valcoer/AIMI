using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIMind
{
    /// <summary>
    /// Predicates are defined as a verb or a set of verbs that work together to describe
    /// an action or state of being of the subject.  
    /// The predicate must contain a verb, and the verb requires, permits, or precludes other sentence elements to complete the predicate.
    /// These elements are: objects (direct, indirect, prepositional), predicatives, and adjuncts:
    /// </summary>
   public class Predicate
    {
        public List<Verb> m_valueList;
        public string m_adverb;
       //this would be the noun that is the object in the predicate.
        public string m_predicativeObject;
      
        public Predicate()
        {
          
            m_valueList = new List<Verb>();
        }
        
    }
}
