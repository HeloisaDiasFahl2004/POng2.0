using Dapper;
using POng2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
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
      
        public List<Pet> SelectPet()
        {
            using (var conn = bd.BuscarConexao())
            {
                var pets = conn.Query<Pet>(Pet.SELECT);

                return (List<Pet>)pets;
            }
        }
      
        public Pet BuscarPet(int chip)
        {

            using (var conn = bd.BuscarConexao())
            {
                var pet = conn.QueryFirst<Pet>($"SELECT * FROM Pet WHERE chip ={chip}");

                return pet;
            }

        }

        public bool DeletPet(int chip)
        {
            int result = 0;
            using (var conn = bd.BuscarConexao())
            {
                result = conn.Execute($"DELETE FROM Pet WHERE CHIP={chip}");
            }
            return (result != 0 ? true : false);

        }
    }
}
