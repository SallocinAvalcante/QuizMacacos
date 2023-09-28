using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

public class QuestoesDAO
{
    //Conexão para questões
    public Questoes consultarId(Questoes quest)
    {
        String sql_SELECT = @"SELECT * FROM questões WHERE ID = ?";

        //Database
        try
        {
            MySqlConnection conexao = ConectaDB.conectar();
            conexao.Open();
            MySqlCommand sql_comando = new MySqlCommand(sql_SELECT, conexao);
            sql_comando.Parameters.AddWithValue("@ID", quest.GetID());

            MySqlDataReader dataReader = sql_comando.ExecuteReader();
            dataReader.Read();

            // Atualiza - set
            quest.SetDescricao(dataReader.GetValue(1).ToString());
            quest.SetA1(dataReader.GetValue(2).ToString());
            quest.SetA2(dataReader.GetValue(3).ToString());
            quest.SetA3(dataReader.GetValue(4).ToString());
            quest.SetResposta(dataReader.GetValue(5).ToString());
            conexao.Close();
        }
        catch (Exception exc)
        {
            MessageBox.Show("Erro: " + exc);
        }
        return quest;
    }
    //Conexão para Respostas

    //Cadastrar
    public bool Cadastrar(Respostas resp)
    {
        //Cadastrar - Insert
        string sql_INSERT = @"INSERT INTO resposta (Nome, RGM, TotalAcerto, TotalErro) VALUES(?, ?, ?, ?)";

        //Database
        try
        {
            MySqlConnection conexao = ConectaDB.conectar();
            conexao.Open();
            MySqlCommand sql_comando = new MySqlCommand(sql_INSERT, conexao);

            sql_comando.Parameters.AddWithValue("@Nome", resp.GetNome());
            sql_comando.Parameters.AddWithValue("@RGM", resp.GetRGM());
            sql_comando.Parameters.AddWithValue("@TotalAcerto", resp.GetTotalAcerto());
            sql_comando.Parameters.AddWithValue("@TotalErro", resp.GetTotalErro());


            sql_comando.ExecuteNonQuery();
            conexao.Close();
            return true;

        }
        catch (Exception exc)
        {
            MessageBox.Show("Erro: " + exc);
            return false;
        }


    }

    //Puxar para visualizar

    public DataTable consultarRespostas()
    {
        DataTable dt = new DataTable();
        String sql_SELECT = @"SELECT * FROM resposta";

        //Database
        try
        {
            MySqlConnection conexao = ConectaDB.conectar();
            conexao.Open();

            //Ajustar os dados
            MySqlDataAdapter da = new MySqlDataAdapter(sql_SELECT, conexao);

            using (da)
            {
                da.Fill(dt);
            }
            conexao.Close();
        }
        catch (Exception exc)
        {
            MessageBox.Show("Erro: " + exc);
        }
        return dt;
    }
}

