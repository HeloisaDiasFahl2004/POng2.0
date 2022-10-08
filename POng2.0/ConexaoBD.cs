using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POng2._0
{
    internal class ConexaoBD
    {
      
        string Conexao = "Data Source = 'localhost\\SQLSERVER'; Initial Catalog = OngPet;User Id = sa; Password= sqlservermeu;";
        private SqlConnection conn;
        public ConexaoBD()
        {

        }
        public string Caminho()
        {
            return Conexao;
        }
        public SqlConnection BuscarConexao()
        {
            if (conn == null) //tá fechada e tá sem instanciar, abro a conexao e retorno 
            {
                conn = new SqlConnection(Conexao);
                conn.Open();
                return conn;
            }
            if (conn.State == System.Data.ConnectionState.Open)
            {
                return conn;
            }
            conn.Open();
            return conn;

        }

    
    }
}
