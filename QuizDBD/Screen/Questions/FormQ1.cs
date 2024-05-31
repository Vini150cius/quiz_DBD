using System;
using QuizDBD;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;
using System.Runtime.InteropServices.ComTypes;
using System.Media;

namespace QuizDBD.Screen.Questions
{
    public partial class FormQ1 : Form
    {
        public int escolha = 0;
        private Timer timer;
        public FormQ1()
        {
            InitializeComponent();
            
        }

        public void FormQ1_Load(object sender, EventArgs e)
        {
            string nameUser = User.Instance.NameUser;
            int score = User.Instance.Score;

            lblScore.Text = score.ToString();
            lblUserName.Text = nameUser;
        }

        private void lblScore_Click(object sender, EventArgs e)
        {
          
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {
           
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            FormQ2 f = new FormQ2();
            if(escolha == 3)
            {
                User.Instance.Score++;

                try
                {
                    Stream somStream = Properties.Resources.correct_6033;
                    SoundPlayer player = new SoundPlayer(somStream);

                    player.Load();
                    player.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tocar o som: " + ex.Message);
                }
            }
            else
            {
                try
                {
                    Stream somStream = Properties.Resources.error_126627;
                    SoundPlayer player = new SoundPlayer(somStream);
                    player.Load();
                    player.Play();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao tocar o som: " + ex.Message);
                }
            }
            await Task.Delay(500);
            this.Hide();
            f.ShowDialog();
            this.Dispose();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(123)))), ((int)(((byte)(160)))));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            escolha = 1;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(123)))), ((int)(((byte)(160)))));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            escolha = 2;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(123)))), ((int)(((byte)(160)))));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            escolha = 3;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(123)))), ((int)(((byte)(160)))));
            escolha = 4;
        }


    }
}
