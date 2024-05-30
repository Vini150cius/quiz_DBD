using System;
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

namespace QuizDBD
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();

            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //HomeScreen hs = new HomeScreen();
            //hs.Close();
            
        }
    

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Não é necessário fazer nada aqui, pois as propriedades DisplayMember, ValueMember e DataSource já foram definidas no construtor
        }
    }
}