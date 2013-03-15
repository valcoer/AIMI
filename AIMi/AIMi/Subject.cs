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
       public Predicate m_myAction;
       public bool m_imperative;
       public List<Noun> m_objects;

       public Subject()
       {
           m_myAction = new Predicate();
           m_objects = new List<Noun>() ;
       }


    }

   
}
