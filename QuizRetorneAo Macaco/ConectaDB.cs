using MySql.Data.MySqlClient;

public class ConectaDB
{
    public static MySqlConnection conectar()
    {
        // Banco de Dados
        return new MySqlConnection("server=localhost; database=quiz; user id=root; password=''");
    }
}