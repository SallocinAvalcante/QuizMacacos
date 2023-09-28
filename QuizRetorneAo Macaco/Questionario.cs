using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizRetorneAo_Macaco
{
    public partial class Questionario : Form
    {
        public Questionario()
        {
            InitializeComponent();
        }

        private void Questionario_Load(object sender, EventArgs e)
        {
            //Zerar as variaveis no inicio
            VariaveisGlobais.Acertos = 0;
            VariaveisGlobais.Erros = 0;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Aceitar iniciar o aplicativo
           
                
                Questionario_Q1_ Q1 = new Questionario_Q1_();
            //Fechar este e abrir o quiz
                this.Hide();
                Q1.ShowDialog();
            
        }

        private void consultarOsResultadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Consultar o resultado pelo MenuStrip
            Resultados rs = new Resultados();
            rs.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Fechar o app
            Application.Exit();
        }
    }
}
