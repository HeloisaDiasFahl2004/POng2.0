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
            
            conn.Execute(Adotante.INSERT, adotante);//dapper
        
            return adotante;
        }
        public List<Adotante> SelectAdotante()
        {
            using (var conn = bd.BuscarConexao())
            {
                var adotantes = conn.Query<Adotante>(Adotante.SELECT);

                return (List<Adotante>)adotantes;
            }
        }
        public String BuscarAdotante(string cpf)
        {
            var conn = bd.BuscarConexao();

            conn.Execute(Adotante.SELECTONE, cpf);//dapper

            return cpf;
        }
      
       
    }
}
