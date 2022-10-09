using Dapper;
using POng2._0.Models;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace POng2._0.Services
{
    public class PetService
    {
        ConexaoBD bd = new();
        #region Insert e Delete
        public Pet InserirPet(Pet pet)
        {
            var conn = bd.BuscarConexao();

            conn.Execute(Pet.INSERT, pet);//dapper

            return pet;
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
        #endregion

        #region Select
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

        #endregion

        #region Update
        public bool UpdateNomePet(int chip, string nome)
        {
            var query = "UPDATE Pet SET Nome=@Nome  WHERE Chip =@Chip";
            var parameters = new {@Nome=nome,@Chip=chip};
            int result = 0;
            using (var conn = bd.BuscarConexao())
            {
                result = conn.Execute(query,parameters);
            }
            return (result != 0 ? true : false);
        }

        public bool UpdateSexoPet(int chip, char sexo)
        {
            var query = "UPDATE Pet SET Sexo=@Sexo WHERE Chip=@Chip";
            var parameters = new { @Sexo = sexo, @Chip = chip };
            int result = 0;
            using (var conn = bd.BuscarConexao())
            {
                result = conn.Execute(query,parameters);
            }
            
            return (result != 0 ? true : false);
        }

        public bool UpdateRacaPet(int chip, string raca)
        {
            var query = "UPDATE Pet SET Raca=@Raca WHERE Chip=@Chip";
            var parameters = new { @Raca=raca, @Chip = chip };
            int result = 0;
            using (var conn = bd.BuscarConexao())
            {
                result = conn.Execute(query,parameters);
            }
            return (result != 0 ? true : false);
        }

        public bool UpdateFamiliaPet(int chip, string familia)
        {
            var query = "UPDATE Pet SET Familia=@Familia WHERE Chip=@Chip";
            var parameters = new { @Familia = familia, @Chip = chip };
            int result = 0;
            using (var conn = bd.BuscarConexao())
            {
                result = conn.Execute(query,parameters);
            }
            return (result != 0 ? true : false);
        }

        public bool UpdateSituacaoPet(int chip)
        {
            var query = "UPDATE Pet SET Situacao=@Situacao WHERE Chip=@Chip";
            var parameters = new { @Situacao='A', @Chip = chip };
            int result = 0;
            using (var conn = bd.BuscarConexao())
            {
                result = conn.Execute(query,parameters);
            }
            return (result != 0 ? true : false);
        }
        #endregion
    }
}
