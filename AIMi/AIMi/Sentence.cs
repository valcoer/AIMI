using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AIMind
{
   public class Sentence
    {
       // there are 8 parts of speech that make up a sentence, these are
       // nouns, pronouns, verbs, adjectives, adverbs, conjunctions, prepositions, and interjections.
       // A sentence must have a subject and a verb but may also contain any other part of speech.

      
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
