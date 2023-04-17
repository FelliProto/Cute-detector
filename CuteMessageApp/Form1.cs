using System;
using System.Windows.Forms;

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
            string name = textBox1.Text.ToLower(); //und hier kommt die liste mit zu viel leuten


            if (name == "aveyzan")
            {
                MessageBox.Show(this, "Why are you even trying? He isn't cute.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information); // additional message box when the name is "aveyzan"
            }
            else if (name == "felli")
            {
                MessageBox.Show(this, "I'm not cute. Why are you saying I'm cute?", "Message from Felli", MessageBoxButtons.OK, MessageBoxIcon.Error); // additional message box when the name is "felli"
            }
            else if (name == "max")
            {
                MessageBox.Show(this, "Stop! He isn't cute.", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information); // additional message box when the name is "max"
            }
            else if (name == "dizaster" || name == "dizasterman" || name == "diz")
            {
                MessageBox.Show(this, "Of course my love is cute!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(this, "he's a boykisser tho makes him even more cute", "Info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if (name == "dave1285")
            {
                MessageBox.Show(this, "dave1285 is cute!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information); // additional message box when the name is "dave1285"
            }
            else if (name == "vadaladix")
            {
                MessageBox.Show(this, "Of course he's cute, no need to detect it. He is cute 100%!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information); // additional message box when the name is "vadaladix"
            }
            else if (name == "eclipse")
            {
                MessageBox.Show(this, "Eclipse is cute!! (Help I'm being forced to write this into the code)", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information); // additional message box when the name is "eclipse"
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
