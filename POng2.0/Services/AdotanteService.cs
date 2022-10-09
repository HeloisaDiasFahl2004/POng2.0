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

        #region Insert e Delete
        public Adotante InserirAdotante(Adotante adotante)
        {
            var conn = bd.BuscarConexao();

            conn.Execute(Adotante.INSERT, adotante);//dapper

            return adotante;
        }
        public bool DeletAdotante(String cpf)
        {
            int result = 0;
            using (var conn = bd.BuscarConexao())
            {
                result = conn.Execute($"DELETE FROM Adotante WHERE CPF={cpf}");
            }
            return (result != 0 ? true : false);

        }

        #endregion

        #region Select
        public List<Adotante> SelectAdotante()
        {
            using (var conn = bd.BuscarConexao())
            {
                var adotantes = conn.Query<Adotante>(Adotante.SELECT);

                return (List<Adotante>)adotantes;
            }
        }

        public Adotante BuscarAdotante(String cpf)
        {

            using (var conn = bd.BuscarConexao())
            {
                var adotantes = conn.QueryFirst<Adotante>($"SELECT * FROM Adotante WHERE cpf ={cpf}");

                return adotantes;
            }

        }
        #endregion

        #region Update 
        public bool UpdateNomeAdotante(string cpf, string nome)
        {
            var query = "UPDATE Adotante SET Nome=@Nome WHERE Cpf=@Cpf";

            var parameters = new { @Nome = nome, @Cpf = cpf };
            int result = 0;
            using (var conn = bd.BuscarConexao())
            {
                result = conn.Execute(query, parameters);
            }
            return (result != 0 ? true : false);
        }

        public bool UpdateSexoAdotante(string cpf, char sexo)
        {
            var query = "UPDATE Adotante SET Sexo=@Sexo WHERE Cpf=@Cpf";
            var parameters = new { @Sexo = sexo, @Cpf = cpf };
            int result = 0;
            using (var conn = bd.BuscarConexao())
            {
                result = conn.Execute(query, parameters);
            }
            return (result != 0 ? true : false);
        }

        public bool UpdateDataNascimentoAdotante(string cpf, DateTime dataNasc)
        {
            var query = "UPDATE Adotante SET DataNascimento=@DataNascimento WHERE Cpf=@Cpf";
            var parameters = new { @DataNascimento = dataNasc, @Cpf = cpf };
            int result = 0;
            using (var conn = bd.BuscarConexao())
            {
                result = conn.Execute(query, parameters);
            }
            return (result != 0 ? true : false);
        }

        public bool UpdateTelefoneAdotante(string cpf, string telefone)
        {
            var query = "UPDATE Adotante SET Telefone = @Telefone WHERE Cpf=@Cpf";
            var parameters = new { @Telefone = telefone, @Cpf = cpf };
            int result = 0;
            using (var conn = bd.BuscarConexao())
            {
                result = conn.Execute(query, parameters);
            }
            return (result != 0 ? true : false);
        }

        public bool UpdateLogradouroAdotante(string cpf, string logradouro)
        {
            var query = "UPDATE Adotante SET Logradouro=@Logradouro WHERE Cpf=@cpf";
            var parameters = new { @Logragouro = logradouro, @Cpf = cpf };
            int result = 0;
            using (var conn = bd.BuscarConexao())
            {
                result = conn.Execute(query, parameters);
            }
            return (result != 0 ? true : false);
        }

        public bool UpdateComplementoAdotante(string cpf, string complemento)
        {
            var query = "UPDATE Adotante SET Complemento=@Complemento WHERE Cpf=@Cpf";
            var parameters = new { @Complemento = complemento, @Cpf = cpf };
            int result = 0;
            using (var conn = bd.BuscarConexao())
            {
                result = conn.Execute(query, parameters);
            }
            return (result != 0 ? true : false);
        }

        public bool UpdateNumeroAdotante(string cpf, int numero)
        {
            var query = "UPDATE Adotante SET Numero=@Numero WHERE Cpf=@Cpf";
            var parameters = new { @Numero = numero, @Cpf = cpf };
            int result = 0;
            using (var conn = bd.BuscarConexao())
            {
                result = conn.Execute(query, parameters);
            }
            return (result != 0 ? true : false);
        }

        public bool UpdateCepAdotante(string cpf, string cep)
        {
            var query = "UPDATE Adotante SET Cep=@Cep WHERE Cpf=@Cpf";
            var parameters = new { @Cep = cep, @Cpf = cpf };
            int result = 0;
            using (var conn = bd.BuscarConexao())
            {
                result = conn.Execute(query, parameters);
            }
            return (result != 0 ? true : false);
        }

        public bool UpdateCidadeAdotante(string cpf, string cidade)
        {
            var query = "UPDATE Adotante SET Cidade=@Cidade WHERE Cpf=@Cpf";
            var parameters = new { @Cidade = cidade, @Cpf = cpf };
            int result = 0;
            using (var conn = bd.BuscarConexao())
            {
                result = conn.Execute(query, parameters);
            }
            return (result != 0 ? true : false);
        }

        public bool UpdateEstadoAdotante(string cpf, string estado)
        {
            var query = "UPDATE Adotante SET Estado=@Estado WHERE Cpf=@Cpf";
            var parameters = new { @Estado = estado, @Cpf = cpf };
            int result = 0;
            using (var conn = bd.BuscarConexao())
            {
                result = conn.Execute(query, parameters);
            }
            return (result != 0 ? true : false);
        }

        public bool UpdateBairroAdotante(string cpf, string bairro)
        {
            var query = "UPDATE Adotante SET Bairro=@Bairro WHERE Cpf=@Cpf";
            var parameters = new { @Bairro = bairro, @Cpf = cpf };
            int result = 0;
            using (var conn = bd.BuscarConexao())
            {
                result = conn.Execute(query, parameters);
            }
            return (result != 0 ? true : false);
        }

        public bool UpdateChipPet(string cpf, int chip)
        {
            var query = "UPDATE Adotante SET Chip=@Chip WHERE Cpf=@Cpf";
            var parameters = new { @Chip = chip, @Cpf = cpf };
            int result = 0;
            using (var conn = bd.BuscarConexao())
            {
                result = conn.Execute(query, parameters);
            }
            return (result != 0 ? true : false);
        }
        #endregion

    }
}
