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
            comando.CommandText = "INSERT INTO Nivel(Nome)Values(@Nome)";
            //Adicionando parâmetros contra SQL Injection
            comando.Parameters.Add(new SqlParameter("@Nome",nome));
            //Esta tudo pronto! Vamos executar o comando.
            comando.ExecuteNonQuery();

            Conexao.MinhaInstancia.Close();

            return "Dados inseridos com sucesso!";
        }
        public void Atualizar()
        { 
        
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
        public void Deletar()
        { 
        
        }
        
    }
}
