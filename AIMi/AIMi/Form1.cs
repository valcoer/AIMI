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
        public string salutation = "hello world";
        public string regret = "I do not understand";
        Greetings greetings = new Greetings();
        //data access object variable
        DataAccess dataAccess;
        
        public InOut()
        {
            dataAccess = new DataAccess("XMLGreetinglist.xml");
            InitializeComponent();
        }
        

       
     

        private void inputWindow_TextChanged(object sender, EventArgs e)
        {
             
            foreach (string greeting in greetings.Greet)
            {
                bool resultant;
                resultant = this.inputWindow.Text.Contains(greeting);

                if (resultant == true)
                {
                    lblOutputLabel.Text = greeting;
                    return;
                }
                else
                {
                    lblOutputLabel.Text = "is this a greeting?";
                    YesButton.Visible = true;
                    noButton.Visible = true;

                }
            }

           
            
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            string newGreeting = this.inputWindow.Text;
            
          //  this.label1.Text = newGreeting;
            greetings.createNewWord(newGreeting);
            
        }

        private void noButton_Click(object sender, EventArgs e)
        {

        }

        private void btnListVocabulary_Click(object sender, EventArgs e)
        {
            string[] temp = new string[dataAccess.getNodelistSize()];    
            temp = dataAccess.RetrieveWords();
            lblOutputLabel.Text = "";
            for (int x = 0; x < dataAccess.getNodelistSize(); x++)
            {
                lblOutputLabel.Text += temp[x].ToString() + " ";
            }
        }

      
      
       
    }
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
       // string[] _greet;
      // List<string> _greets = new List<string>();
        
        string[] _greet ={"hi","hello","greetings" };
       // public List<string> getwords()
        //{
           
           // _greets = daobj.RetrieveWords();
              
       // }
        public string[] Greet
        {
            get { return _greet; }
        }
        public string this[int index]
        {
            get { return _greet[index]; }
        }

         public void createNewWord(string word)
        {
          daobj.AddWord(word);
        }
       
    }
}
