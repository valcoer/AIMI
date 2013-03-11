using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Serialization;

namespace AIMind
{
    public partial class Form1 : Form
    {
        public string salutation = "hello world";
        public string regret = "I do not understand";
        
        
        public Form1()
        {
            InitializeComponent();
        }
        

      

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
              Greetings greetings = new Greetings();
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
            
            this.label1.Text = newGreeting;
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

      
      
       
    }
    public class Greetings
    {
        string[] _greet = { "hi", "hello", "greetings" };
        public string[] Greet
        {
            get { return _greet; }
        }
        public string this[int index]
        {
            get { return _greet[index]; }
        }


       
    }
}
