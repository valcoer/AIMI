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
       // of these only the interjection is commonly used alone.
       // such as Hello!
       // in this isntance the ! makes it an interjection.

      
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
