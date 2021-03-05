using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyFirstProject
{
    public partial class introduction : Form
    {
        public introduction()
        {
            InitializeComponent();
        }

        private void messageButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello! My Name is Michael Finochio!");
        }

        private void answerColorButton_Click(object sender, EventArgs e)
        {
            answerColor.Text = "BLACK";
        }

        private void ageAnswerButton_Click(object sender, EventArgs e)
        {
            ageAnswer.Text = "26";
        }

        private void goodBye_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Have a nice Day!");
        }

        private void familyButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is my family!");
        }
    }
}
