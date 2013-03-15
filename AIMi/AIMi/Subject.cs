using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIMind
{
    /// <summary>
    /// A Subject is the noun in a sentence that is DOING the action.Plus specific behavior
    /// that only a subject would need.
    /// </summary>
   public class Subject
    {
       //what does m_imperative control?
       public Predicate m_myAction;
       public bool m_imperative;
       public List<Noun> m_objects;

       public Subject()
       {
           //why do we need the predicates in the subject class?
           // what is the signifacance of using two different structures for the subject and predicates classes?
           m_myAction = new Predicate();
           m_objects = new List<Noun>() ;
       }


    }

   
}
