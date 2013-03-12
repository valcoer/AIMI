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
                    label1.Text = greeting;
                    return;
                }
                else
                {
                    label1.Text = "is this a greeting?";
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
        string[] _greet;
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
