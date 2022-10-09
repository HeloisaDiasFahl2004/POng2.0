using POng2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POng2._0.Interface
{
    public interface IAdotanteController
    {
        #region Insert e Delete
        public Adotante InserirAdotante(Adotante adotante);
        public bool DeletAdotante(String cpf);
        #endregion

        #region Select
        public Adotante BuscarAdotante(String cpf);

        public List<Adotante> SelectAdotante();
        #endregion

        #region Update
        public bool UpdateNomeAdotante(string cpf, string nome);

        public bool UpdateSexoAdotante(string cpf, char sexo);

        public bool UpdateDataNascimentoAdotante(string cpf, DateTime dataNasc);

        public bool UpdateTelefoneAdotante(string cpf, string telefone);

        public bool UpdateLogradouroAdotante(string cpf, string logradouro);

        public bool UpdateComplementoAdotante(string cpf, string complemento);

        public bool UpdateNumeroAdotante(string cpf, int numero);

        public bool UpdateCepAdotante(string cpf, string cep);

        public bool UpdateCidadeAdotante(string cpf, string cidade);

        public bool UpdateEstadoAdotante(string cpf, string estado);

        public bool UpdateBairroAdotante(string cpf, string estado);

        public bool UpdateChipPet(string cpf, int chip);
        #endregion

        public void CadastrarAdotante(Adotante adotante);
    }
}
