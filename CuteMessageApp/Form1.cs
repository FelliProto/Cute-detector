using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace CuteMessageApp
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
            button1.Enabled = false;
            AcceptButton = button1;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            button1.Enabled = !string.IsNullOrWhiteSpace(textBox1.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = textBox1.Text.ToLower(); //to many people on this list

            if (name.Contains("æ"))
            { //im bored dont ask
                string[] messages = { "æ", "Uh oh, something went wrong! Please Report it to Felli", "æ is good but bah is better max is gonna be pissed seeing this", "Unexpected error occurred. Report it to Felli", "bah is kinda better then æ sorry", "idk what to put here" };

                int index = random.Next(messages.Length); 
                MessageBox.Show(this, messages[index], "Unable to fetch Result", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }
            else if (name == "aveyzan")
            {
                MessageBox.Show(this, "Why are you even trying? He isn't cute.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else if (name == "felli")
            {
                int retryCount = 0;

                while (retryCount < 5)
                {
                    DialogResult result = MessageBox.Show(this, "I'm not cute. Why are you saying I'm cute?", "Result", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                    if (result == DialogResult.Retry)
                    {
                        retryCount++;
                    }
                    else
                    {
                        return;
                    }
                }

                MessageBox.Show(this, "Why are you even trying? I'm not cute!", "Why?", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (name == "max")
            {
                MessageBox.Show(this, "Stop! He isn't cute.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else if (name == "dizaster" || name == "dizasterman" || name == "diz")
            {
                MessageBox.Show(this, "Of course my love is cute!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(this, "he's a boykisser tho makes him even more cute", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (name == "dave1285")
            {
                MessageBox.Show(this, "dave1285 is cute!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else if (name == "vadaladix" || name == "vad")
            {
                MessageBox.Show(this, "Of course he's cute, no need to detect it. He is cute 100%!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else if (name == "eclipse")
            {
                MessageBox.Show(this, "Eclipse is cute!! (Help I'm being forced to write this into the code)", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information); 
            }
            else if (name == "macaroni" || name == "marco91107r5") //macroni real
            {
                MessageBox.Show(this, "He's very cute!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(this, "You Felli fell of the train", "Macaroni quotes", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (name == "pãothesequal" || name == "pao")
            {
                MessageBox.Show(this, "Very cute!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information); // additional message box when the name is "pãothesequal"

            }
            else
            {

                {
                    int randomNumber = random.Next(1, 101);
                    string message = name + " is not cute!";

                    if (randomNumber <= 60) // 60% chance 
                    {
                        message = name + " is cute!";
                    }

                    MessageBox.Show(this, message + "!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
    }
}
