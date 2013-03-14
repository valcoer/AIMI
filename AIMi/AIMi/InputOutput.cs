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
        public XmlDataAccess xmlDataAccess;
        public Greetings greetings;
        public Listener listener;
        public InOut()
        {
            xmlDataAccess = new XmlDataAccess("XMLGreetinglist.xml");
            listener = new Listener();
            InitializeComponent();
            greetings = new Greetings(xmlDataAccess);
        }
        

       
     

        private void inputWindow_EnterPressed(object sender, EventArgs e)
        {
             
            foreach (string greeting in xmlDataAccess.RetrieveWords())
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

            lblOutputLabel.Text = newGreeting;
            greetings.createNewWord(newGreeting);
            
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            
        }

        private void btnListVocabulary_Click(object sender, EventArgs e)
        {
            string[] temp = new string[xmlDataAccess.getNodelistSize()];    
            temp = xmlDataAccess.RetrieveWords();
            lblOutputLabel.Text = "";
            for (int x = 0; x < xmlDataAccess.getNodelistSize(); x++)
            {
                lblOutputLabel.Text += temp[x].ToString() + " ";
            }
        }

        private void inputWindow_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13) // 13 is the enter key
            {

                foreach (string greeting in xmlDataAccess.RetrieveWords())
                {
                    bool resultant;
                    resultant = this.inputWindow.Text.Contains(greeting);

                    if (resultant == true)
                    {
                        Random rnd = new Random();
                        int index = rnd.Next(1, xmlDataAccess.getNodelistSize()); // creates a number between 1 and the node list size
                        lblOutputLabel.Text = greetings.Greet[index].ToString();
                        YesButton.Visible = false;
                        noButton.Visible = false;
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

        }

        private void InOut_FormClosing(object sender, FormClosingEventArgs e)
        {
            xmlDataAccess.saveDoc();
        }

        private void parse_Click(object sender, EventArgs e)
        {
            string sentence = inputWindow.Text;
            listener.parse_Sentence(sentence);
        }

       


       
       
    }
  
}
