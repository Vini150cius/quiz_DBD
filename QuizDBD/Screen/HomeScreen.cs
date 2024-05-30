using QuizDBD.Screen;
using QuizDBD.Screen.Questions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizDBD
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
            //temporario para o desenvolvimento
            /*FormQ1 q1 = new FormQ1();
            
            this.Hide();
            q1.ShowDialog();
            this.Dispose();*/
        }

        private void HomeScreen_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void TitlePage_Click(object sender, EventArgs e)
        {
            
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Login l = new Login();
  
            this.Hide();
            l.ShowDialog();
            this.Dispose();
        }

        private void linkPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkPerfil.LinkVisited = true;
            System.Diagnostics.Process.Start("https://github.com/Vini150cius");
        }
    }
}
