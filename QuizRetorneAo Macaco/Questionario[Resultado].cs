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
    public partial class Questionario_Resultado_ : Form
    {
        public int test;
        public Questionario_Resultado_()
        {
            InitializeComponent();
        }

        private void Questionario_Resultado__Load(object sender, EventArgs e)
        {
            Respostas resp = new Respostas(); // Instancia

            //Nós dois estou exibindo o valor da variavel para o usuario nas labels ocultas
            label5.Text = VariaveisGlobais.Acertos.ToString(); 
            label6.Text = VariaveisGlobais.Erros.ToString();



        }

        private void button1_Click(object sender, EventArgs e) // Ao clicar para exibir "Meus resultados
        {
            if(textBox1.Text == string.Empty) { //Se estiver vazio o nome ele pede para preencher
                MessageBox.Show("Preencha o seu Nome");

            }
            else
            {
                if(textBox2.Text == string.Empty) //Se estiver vazio o RGM ele pede para preencher
                {
                    MessageBox.Show("Preencha o seu RGM");
                }
                else //Se estiver tudo certo
                {
                    //Torno as labels exibindo resultado visiveis para meu usuario
                    label5.Visible = true; 
                    label6.Visible = true;
                    //
                    //Instanciando as classes
                    QuestoesDAO qd = new QuestoesDAO();
                    Respostas resp = new Respostas();
                    //
                    //Setando todos atributos do "Resposta"
                    resp.SetNome(textBox1.Text);
                    resp.SetRGM(textBox2.Text);
                    resp.SetTotalAcerto(VariaveisGlobais.Acertos);
                    resp.SetTotalErro(VariaveisGlobais.Erros);
                    //
                    //Enviando para o DB
                    qd.Cadastrar(resp);
                    //
                    //Tornando o botão de retornar ao menu visivel
                    button2.Visible = true;

                }
            }
        }

        private void button2_Click(object sender, EventArgs e) // Botao voltar menu
        {
            //Voltar ao menu(Fechar este forms e abrir o menu)
            Questionario Principal = new Questionario();
            this.Hide();
            Principal.ShowDialog();

        }
    }
}
