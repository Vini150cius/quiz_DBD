using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizDBD.Screen.Questions
{
    public partial class FormQ2 : Form
    {
        public string Score;
        public FormQ2()
        {
            InitializeComponent();
            User u = User.Instance;
            Score = Convert.ToString(u.Score);
            lblScore.Text = Convert.ToString(u.Score);
            lblUserName.Text = u.NameUser;
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {

        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(Score);
        }
    }
}
