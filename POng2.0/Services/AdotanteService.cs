using Dapper;
using POng2._0.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POng2._0.Services
{
    public class AdotanteService
    {

        ConexaoBD bd = new();
        public Adotante InserirAdotante(Adotante adotante)
        {
            var conn = bd.BuscarConexao();
            
            conn.Execute(Adotante.INSERT, adotante);
         
           
          
            return adotante;
        }
       
    }
}
