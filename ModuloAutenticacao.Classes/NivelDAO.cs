using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuloAutenticacao.Classes
{
    public class NivelDAO
    {
        
        public string Inserir(string nome) 
        {
            //abrindo a conexão
            Conexao.MinhaInstancia.Open();
            //Definindo o comando
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            //Definindo o tipo de comando
            comando.CommandType = System.Data.CommandType.Text;
            //Iniciando a DML
            comando.CommandText = ("insert into Nivel (Nome) Values (@Nome);");
            //Adicionando parâmetros contra SQL Injection
            comando.Parameters.Add(new SqlParameter("@Nome",nome));
            //Esta tudo pronto! Vamos executar o comando.
            comando.ExecuteNonQuery();

            Conexao.MinhaInstancia.Close();

            return "Dados inseridos com sucesso!";
        }
        public string Atualizar(string ID, string nome)
        {
            Conexao.MinhaInstancia.Open();
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = ("update Nivel set Nome=@Nome where Codigo=@ID;");
            comando.Parameters.AddWithValue("@ID", ID);
            comando.Parameters.AddWithValue("@Nome", nome);
            comando.ExecuteNonQuery();

            Conexao.MinhaInstancia.Close();

            return "Atualizado com Sucesso!";
        }
        public DataTable Pesquisar()
        {
            Conexao.MinhaInstancia.Open();
            //Definindo o comando
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            //Definindo o tipo de comando
            comando.CommandType = System.Data.CommandType.Text;
            //Iniciando a DML
            comando.CommandText = "select * from nivel";

            //DataTable (banco de dados na memória)
            DataTable dataTable = new DataTable();
            SqlDataReader reader = comando.ExecuteReader();
            dataTable.Load(reader);
            Conexao.MinhaInstancia.Close();

            return dataTable;
        }
        //sobrecarga de método-mesmo nome
        //overload
        public string Pesquisar(string nome) 
        {

            return $"Olá:{nome}";
        }
        public string Deletar(string ID)
        {
            Conexao.MinhaInstancia.Open();
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = ("DELETE Nivel WHERE codigo=@ID;");
            comando.Parameters.AddWithValue("@ID", ID);
            comando.ExecuteNonQuery();

            Conexao.MinhaInstancia.Close();
            return "Deletado com Sucesso!";
        }

        public DataTable PesquisarPorNome(string nome)
        {
            Conexao.MinhaInstancia.Open();
            SqlCommand comando = Conexao.MinhaInstancia.CreateCommand();
            comando.CommandType = System.Data.CommandType.Text;
            comando.CommandText = ("SELECT * from Nivel where Nome=@Nome;");
            comando.Parameters.AddWithValue("@Nome", nome);
            DataTable dataTable = new DataTable();
            SqlDataReader reader = comando.ExecuteReader();
            dataTable.Load(reader);
            Conexao.MinhaInstancia.Close();

            return dataTable;
        }
        
    }
}
