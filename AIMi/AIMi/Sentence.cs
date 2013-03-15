using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIMind
{
   public class Sentence
    {
       public Predicate  m_action;
       public Subject   m_subj;
       public string[] wordlist;

       public Sentence()
       {
           m_action = new Predicate();
           m_subj = new Subject();
           wordlist = new string[100];
       }
    }
}
