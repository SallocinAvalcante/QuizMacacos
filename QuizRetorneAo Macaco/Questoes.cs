using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




   public class Questoes
    {
        //Atributos
        private int ID;
        private String Descricao;
        private String A1;
        private String A2;
        private String A3;
        private String Resposta;

        //Classe Bob(Construtor)

        public Questoes(int p_id, String p_descricao, String p_A1, String p_A2, String p_A3, String p_Resposta)
        {
            this.ID = p_id;
            this.Descricao = p_descricao;
            this.A1 = p_A1;
            this.A2 = p_A2;
            this.A3 = p_A3;
            this.Resposta = p_Resposta;
        }

    //The real Bob Construtor

    public Questoes ()
    {

    }

        //Metodos Getter´s / Setter´s

        //Get´s

        public int GetID() { return this.ID; }
        public String GetDescricao() { return this.Descricao; }
        public String GetA1() { return this.A1; }
        public String GetA2() { return this.A2; }
        public String GetA3() { return this.A3; }
        public String GetResposta() { return this.Resposta; }

        //Set´s

        public void SetID(int p_id) { this.ID = p_id; }
        public void SetDescricao(String p_descr) { this.Descricao = p_descr; }
        public void SetA1(String p_a1) { this.A1 = p_a1; }
        public void SetA2(String p_a2) { this.A2 = p_a2; }
        public void SetA3(String p_a3) { this.A3 = p_a3; }
        public void SetResposta(String p_resp) { this.Resposta = p_resp; }
    }

