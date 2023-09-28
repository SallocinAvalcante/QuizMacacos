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
    public partial class Questionario_Q1_ : Form
    {

      

        public Questionario_Q1_()
        {
            InitializeComponent();
        }

        private void Questionario_Q1__Load(object sender, EventArgs e)
        {
            //Instancio o Questoes e o QuestDAO
            QuestoesDAO questdao = new QuestoesDAO();
            Questoes quest = new Questoes();
            //Defino meu ID como 1
            quest.SetID(1);

            //Puxo meu metodo consultar ID
            questdao.consultarId(quest);
            //Defino qual opção seria o que de acordo com DB
            label1.Text = quest.GetID() + ". " + quest.GetDescricao();
            radioButton1.Text = quest.GetA1();
            radioButton2.Text = quest.GetA2();
            radioButton3.Text = quest.GetA3();

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Instanciando
            Respostas resp = new Respostas();
            Questionario_Q2_ Q2 = new Questionario_Q2_();
            
            //Logica de respostas

            if(radioButton1.Checked == true) //Resposta Falsa
            {
                MessageBox.Show("Errou!");
                VariaveisGlobais.Erros += 1; // Somo a variavel com mais um Erro
                this.Hide(); //Escondo este app
                Q2.ShowDialog(); //Passo para o prox forms
            }
            else
            {
                if(radioButton2.Checked == true) {

                    //Soma da variavel global erros
                    VariaveisGlobais.Erros += 1;
                    MessageBox.Show("Errou!");
                    this.Hide();
                    Q2.ShowDialog();
                }
            else
                {
                    if (radioButton3.Checked == true)
                    {
                        //Soma da variavel global acertos
                        VariaveisGlobais.Acertos += 1;
                        MessageBox.Show("Acertou!");
                        this.Hide();
                        Q2.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Escolha uma alternativa!"); //Caso não selecionem uma resposta
                    }
                }
            
            }
            
           

            
        }
    }
}
