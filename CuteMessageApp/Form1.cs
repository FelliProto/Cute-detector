using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Diagnostics;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;
using static System.Windows.Forms.DataFormats;
using System.Numerics;
using System.IO;

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
            string name = textBox1.Text.ToLower(); //too many people on this list

            if (name == "aveyzan")
            {
                MessageBox.Show(this, "He is very very cute!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (name == "felli" || name== "felliproto")
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

            else if (name == "dave1285")
            {
                MessageBox.Show(this, "dave1285 is cute!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (name == "vadaladix" || name == "vad")
            {
                MessageBox.Show(this, "Yep he is very very cute!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (name == "eclipse")
            {
                MessageBox.Show(this, "Eclipse is cute!!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (name == "charlie" || name == "charlieslaw") //yea 
            {
                int randomNumber = random.Next(1, 101);
                string bttm = name + " is very very very cute!";

                if (randomNumber <= 5) // 5% chance 
                {
                    bttm = name + " is very very very cute and also a bottom"; //this is a joke guys dont take this serious
                }

                MessageBox.Show(this, bttm + "!", "Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void button2_Click(object sender, EventArgs e)
        {
            var form2 = new about();
            form2.Show();
        }
    }
}


//i miss the times i made this life was good people treated me well and all now everything is just crumbling i get treated like absolute shit over small mistakes i do i consntatly over think due to the past stuff that happened to me someone seems to hate me for it im paying so much for a therapist a month nothing helps i try to change i get blocked by someone who is really important to me how am i supposed to change like this? when everything that i fear happens to me i want to change im trying to change- tho is there even any point anymore im not sure he probably never wants to talk to me again. from the bottom of my heart im sorry for everoyne i dissapointed i dont expect forgiveness.