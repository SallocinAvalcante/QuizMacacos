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
    public partial class Resultados : Form
    {
        public Resultados()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
         
        }

        private void Resultados_Load(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear(); // Limpo meu Grid antes de levar
            QuestoesDAO qd = new QuestoesDAO(); //Instancia
           dataGridView1.DataSource = qd.consultarRespostas(); //Definimos que o nosso DataGrid Vai utilizar o Metodo de consulta
        }
    }
}
