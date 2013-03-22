using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace AIMind
{
    public partial class InOut : Form
    {

        //data access object variable
        public Dictionary currentDictionary;
        public XmlDataAccess xmlDataAccess;
        public Greetings greetings;
        public Listener listener;
        public Sentence currentSentence;
       
        public InOut()
        {
            // the Greetings Class is about outdated and needs to be removed and its functionality placed in a more 
            // logical location such as the sentence class as a type of interjection sentence that functions as a greeting
            // and access of its word list should go through listener just like nouns and verbs.

            //yes I probably could have used the xmlDataAccess Class instead of setting up the functionality of the Dictionary class
             
            currentSentence = new Sentence();
            xmlDataAccess = new XmlDataAccess("XMLGreetinglist.xml");
            listener = new Listener();
            InitializeComponent();
            greetings = new Greetings(xmlDataAccess);
          currentDictionary = new Dictionary("XMLGreetingList.xml","xmlNounList.xml","xmlVerbList.xml");
        }
        

       
     

       

        private void NounButton_Click(object sender, EventArgs e)
        {
            string newNoun = this.inputWindow.Text;

            lblOutputLabel.Text = newNoun;
            currentDictionary.createNewNoun(newNoun);
            listener.m_nounList.AddWord(newNoun);
            xmlDataAccess.AddWord(newNoun);
            
        }

        private void verbButton_Click(object sender, EventArgs e)
        {
            string newVerb = this.inputWindow.Text;
            lblOutputLabel.Text = newVerb;
            currentDictionary.createNewVerb(newVerb);
            listener.m_verbList.AddWord(newVerb);
            xmlDataAccess.AddWord(newVerb);
            
        }

        private void btnListVocabulary_Click(object sender, EventArgs e)
        {
            string[] temp = new string[currentDictionary.getNodelistSize()];    
            temp = currentDictionary.RetrieveWords();
            lblOutputLabel.Text = "";
            for (int x = 0; x < currentDictionary.getNodelistSize(); x++)
            {
                
                lblOutputLabel.Text += temp[x].ToString() + "  " + currentDictionary.RetrieveType(temp[x].ToString()).ToString() + ", ";
            }
        }

        private void inputWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            string statementS;
            string statementP;
            if (e.KeyChar == 13) // 13 is the enter key
            {

                foreach (string dictionary in currentDictionary.RetrieveWords())
                {
                    bool resultant;
                   
                    resultant = this.inputWindow.Text.Contains(dictionary);
                    bool result;
                    string WordType;
                    WordType = currentDictionary.RetrieveType(this.inputWindow.Text);
                    result = WordType.Contains("interjection");
                    if (resultant == true && result == true)
                    {
                        Random rnd = new Random();
                        int index = rnd.Next(1, xmlDataAccess.getNodelistSize()); // creates a number between 1 and the node list size
                        lblOutputLabel.Text = greetings.Greet[index].ToString();
                        nounButton.Visible = false;
                        verbButton.Visible = false;
                        greetingButton.Visible = false;
                        return;
                    }
                    else
                        if (resultant == true)
                        {
                            string sentence = inputWindow.Text;
                            currentSentence = listener.parse_string_into_words(sentence);
                            foreach (Noun n in currentSentence.m_subj.m_objects)
                            {
                                statementS = "there is a Subject";
                                lv_nouns.Items.Add(n.m_value);
                                subjectLabel.Text = n.m_value;
                                Console.WriteLine(statementS);

                            }
                            foreach (Verb v in currentSentence.m_action.m_valueList)
                            {
                                statementP = "there is a predicate";
                                lv_verbs.Items.Add(v.m_value);
                                predicateLabel.Text = v.m_value;

                                Console.WriteLine( statementP);
                            }
                            lblOutputLabel.Text = "this could be a sentence";
                            return;
                        }
                        else
                        {

                            statementS = "there is no subject";
                            statementP = "there is no predicate";
                            Console.WriteLine( statementS + " " + statementP);
                            nounButton.Visible = true;
                            verbButton.Visible = true;
                            greetingButton.Visible = true;
                            
                        }
                    
                }
                

            }
            


        }

        private void InOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            xmlDataAccess.saveDoc();
            currentDictionary.saveDoc();

        }

        private void parse_Click(object sender, EventArgs e)
        {
            string sentence = inputWindow.Text;
           currentSentence = listener.parse_string_into_words(sentence);

           try
           {

               foreach (string s in currentSentence.wordlist)
               {
                   lv_words.Items.Add(s);
               }
               foreach (Noun n in currentSentence.m_subj.m_objects)
               {
                   lv_nouns.Items.Add(n.m_value);
               }
               foreach (Verb v in currentSentence.m_action.m_valueList)
               {
                   lv_verbs.Items.Add(v.m_value);
               }
           }
           catch (Exception z)
           {
               //need to check all words in sentence before we load them into the catch statement so we can give the user the 
               // opportunity to add new words to the lists.
               MessageBox.Show("This is a sentence fragment, either nouns or verbs were null." + z.Message);
           }

        }

        private void greetingButton_Click(object sender, EventArgs e)
        {
            string newGreet = this.inputWindow.Text;
            lblOutputLabel.Text = newGreet;
            currentDictionary.createNewGreet(newGreet);
            xmlDataAccess.AddWord(newGreet);
        }

       

       


       
       
    }
  
}
