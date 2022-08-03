using System.Data.Common;
using System.Data.SqlClient;

namespace ModuloAutenticacao.Classes
{
    internal class Conexao
    {
        public static SqlConnection _conn;

        //Propriedade Automática

        public static SqlConnection MinhaInstancia {//a chave da propriedade

            get
            { //chave do método get
            //se não existe conexão.
            if (_conn == null)
                { //chave do if

            //criar a conexão com SqlServer //nos parênteses -connection string

            _conn = new SqlConnection(@"Server = Lab206_5; Database = ProjetoEstoquev; Uid = sa; Pwd = teste*123;");
            }//fecha chave do if
            //retorna a conexão
            return _conn;
            }
            }


        /*public int numero;
        public double PI = 34.67;
        public int idade = 31;
        int bolsa = 10;
        double nota = 70.0;
        Aluno aluno;*/

    }

}
