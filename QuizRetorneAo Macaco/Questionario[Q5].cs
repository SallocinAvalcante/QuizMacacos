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
    public partial class Questionario_Q5_ : Form
    {
        public Questionario_Q5_()
        {
            InitializeComponent();
        }

        private void Questionario_Q5__Load(object sender, EventArgs e)
        {
            QuestoesDAO questdao = new QuestoesDAO();
            Questoes quest = new Questoes();
            quest.SetID(5);

            questdao.consultarId(quest);

            label1.Text = quest.GetID() + ". " + quest.GetDescricao();
            radioButton1.Text = quest.GetA1();
            radioButton2.Text = quest.GetA2();
            radioButton3.Text = quest.GetA3();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Instanciando
            Respostas resp = new Respostas();
            Questionario_Resultado_ Resultados = new Questionario_Resultado_();

            //Logica de respostas

            if (radioButton1.Checked == true)
            {
                VariaveisGlobais.Erros += 1;
                MessageBox.Show("Errou!");
                this.Hide();
                Resultados.ShowDialog();
            }
            else
            {
                if (radioButton2.Checked == true)
                {

                    VariaveisGlobais.Erros += 1;
                    MessageBox.Show("Errou!");
                    this.Hide();
                    Resultados.ShowDialog();

                }
                else
                {
                    if (radioButton3.Checked == true)
                    {
                        //Resposta certa vai somar
                        VariaveisGlobais.Acertos += 1;
                        MessageBox.Show("Acertou!");
                        this.Hide();
                        Resultados.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Escolha uma alternativa!");
                    }
                }
            }
        }
    }
}
