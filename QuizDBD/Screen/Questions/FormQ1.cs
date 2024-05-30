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

namespace QuizDBD.Screen.Questions
{
    public partial class FormQ1 : Form
    {
        public int escolha = 0;
        public FormQ1()
        {
            InitializeComponent();
            
        }

        public void FormQ1_Load(object sender, EventArgs e)
        {
            User u = User.Instance;
            lblScore.Text = Convert.ToString(u.Score);
            lblUserName.Text = u.NameUser;
            /*string jsonData = JsonConvert.SerializeObject(new { score = u.Score, nameUser = u.NameUser });
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "data.json");
            File.WriteAllText(filePath, jsonData);*/
            string filePath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments), "data.json");

            // Carrega o conteúdo do arquivo JSON existente
            string jsonData = File.ReadAllText(filePath);

            // Cria um novo objeto JSON
            var newData = new { score = u.Score, nameUser = u.NameUser };

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

        }

        private void lblScore_Click(object sender, EventArgs e)
        {
          
        }

        private void lblUserName_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User u = new User();
            
            FormQ2 f = new FormQ2();
            if(escolha == 3)
            {
                u.AdicionarPontos();
            }
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
