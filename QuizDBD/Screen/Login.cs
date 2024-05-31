using Newtonsoft.Json;
using QuizDBD.Screen.Questions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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
            int Score = 0;
            

            
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
                    User.Instance.NameUser = NomeUser;
                    User.Instance.Score = Score;
                    MessageBox.Show($"Nome: {User.Instance.NameUser}");

                    //isso vai para a ultima tela no futuro
                    string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "data.json");

                    // Carrega o conteúdo do arquivo JSON existente
                    string jsonData = File.ReadAllText(filePath);

                    // Cria um novo objeto JSON
                    var newData = new { score = Score, nameUser = NomeUser };

                    // Serializa o novo objeto JSON em uma string
                    string newJsonData = JsonConvert.SerializeObject(newData);

                    // Verifica se o arquivo já contém algum dado JSON
                    if (!string.IsNullOrEmpty(jsonData))
                    {
                        // Remove a última vírgula do arquivo existente
                        jsonData = jsonData.TrimEnd(';');

                        // Adiciona uma vírgula para separar os objetos JSON
                        jsonData += ";";
                    }

                    // Adiciona o novo objeto JSON à string
                    jsonData += newJsonData;

                    // Salva a string atualizada no arquivo JSON
                    File.WriteAllText(filePath, jsonData);
                    //ate aqui tem que mandar pra ultima tela

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
