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

namespace QuizDBD.Screen
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            string NomeUser = txtUserName.Text;
            User u = new User(NomeUser);
            if (string.IsNullOrEmpty(NomeUser))
            {
                MessageBox.Show("Caixa de texto inválida");
            }
            else
            {
                if (NomeUser.Length < 3 || NomeUser.Length > 10)
                {
                    MessageBox.Show("Nome do usuário deve ter entre 3 a 10 caracteres ");
                }
                else
                {
                    FormQ1 q1 = new FormQ1();

                    this.Hide();
                    q1.ShowDialog();
                    this.Dispose();
                }
            }
        }

        private void btnConvidado_Click(object sender, EventArgs e)
        {
            var confirm = MessageBox.Show(this, "Você tem certeza que deseja entrar sem nome de usuário? Você não íra parecer no ranking", "Confirmação", MessageBoxButtons.YesNo);
            if (confirm == DialogResult.Yes)
            {
                FormQ1 q1 = new FormQ1();

                this.Hide();
                q1.ShowDialog();
                this.Dispose();
            }
        }
    }
}
