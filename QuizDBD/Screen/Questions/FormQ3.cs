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
    public partial class FormQ3 : Form
    {
        public FormQ3()
        {
            InitializeComponent();

            Timer timer = new Timer();
            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            timer.Start();


        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Timer timer = (Timer)sender;
            timer.Stop();

            string nameUser = User.Instance.NameUser;
            int score = User.Instance.Score;

            lblScore.Text = score.ToString();
           
        }

        private void lblScore_Click(object sender, EventArgs e)
        {

        }
    }
}
