using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AIMind;

namespace AIMind
{
    public partial class InOut : Form
    {
        public string salutation = "hello world";
        public string regret = "I do not understand";
        Greetings greetings = new Greetings();
       
        
        
        public InOut()
        {
            InitializeComponent();
            
        }
        

       
     

        private void inputWindow_TextChanged(object sender, EventArgs e)
        {

            greetings.getwords();
            foreach (string greeting in greetings.Greet)
            {
                bool resultant;
                resultant = this.inputWindow.Text.Contains(greeting);

                if (resultant == true)
                {
                    outputWindow.Text = greeting;
                    return;
                }
                else
                {
                    outputWindow.Text = "is this a greeting?";
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
    
}
