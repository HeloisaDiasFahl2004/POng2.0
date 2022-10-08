using Dapper;
using POng2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POng2._0.Services
{
    public class PetService
    {
        ConexaoBD bd = new();
        public Pet InserirPet(Pet pet)
        {
            var conn = bd.BuscarConexao();

            conn.Execute(Pet.INSERT, pet);//dapper

            return pet;
        }
    }
}
