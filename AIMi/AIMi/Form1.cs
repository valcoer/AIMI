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
    public partial class Form1 : Form
    {
        public string salutation = "hello world";
        public string regret = "I do not understand";
        Greetings greetings = new Greetings();
        
        public Form1()
        {
            InitializeComponent();
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "you have my attention";
            this.button1.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
             
            foreach (string greeting in greetings.Greet)
            {
                bool resultant;
                resultant = this.textBox1.Text.Contains(greeting);

                if (resultant == true)
                {
                    label1.Text = greeting;
                    return;
                }
                else
                {
                    label1.Text = "is this a greeting?";
                    button2.Visible = true;
                    button3.Visible = true;

                }
            }

           
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string newGreeting = this.textBox1.Text;
            
          //  this.label1.Text = newGreeting;
            greetings.createNewWord(newGreeting);
            
        }

        private void button3_Click(object sender, EventArgs e)
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
        string[] _greet = { "hi", "hello", "greetings" };
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
