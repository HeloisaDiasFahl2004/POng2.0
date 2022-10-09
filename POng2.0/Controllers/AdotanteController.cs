using POng2._0.Interface;
using POng2._0.Models;
using POng2._0.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POng2._0.Controllers
{

    public class AdotanteController : IAdotanteController
    {
        //métodos
        #region Insert e Delete
        public Adotante InserirAdotante(Adotante adotante)
        {
            return new AdotanteService().InserirAdotante(adotante);
        }
        public bool DeletAdotante(String cpf)
        {
            return new AdotanteService().DeletAdotante(cpf);
        }
        #endregion

        #region Select
        public Adotante BuscarAdotante(String cpf)
        {
            return new AdotanteService().BuscarAdotante(cpf);
        }
      
        public List<Adotante> SelectAdotante()
        {
            return new AdotanteService().SelectAdotante();
        }

        #endregion

        #region Update
        public bool UpdateNomeAdotante(string cpf, string nome)
        {
            return new AdotanteService().UpdateNomeAdotante(cpf,nome);
        }

        public bool UpdateSexoAdotante(string cpf, char sexo)
        {
            return new AdotanteService().UpdateSexoAdotante(cpf, sexo);
        }

        public bool UpdateDataNascimentoAdotante(string cpf, DateTime dataNasc)
        {
            return new AdotanteService().UpdateDataNascimentoAdotante(cpf, dataNasc);
        }

        public bool UpdateTelefoneAdotante(string cpf, string telefone)
        {
            return new AdotanteService().UpdateTelefoneAdotante(cpf, telefone);
        }

        public bool UpdateLogradouroAdotante(string cpf, string logradouro)
        {
            return new AdotanteService().UpdateLogradouroAdotante(cpf, logradouro);
        }

        public bool UpdateComplementoAdotante(string cpf, string complemento)
        {
            return new AdotanteService().UpdateComplementoAdotante(cpf, complemento);
        }

        public bool UpdateNumeroAdotante(string cpf, int numero)
        {
            return new AdotanteService().UpdateNumeroAdotante(cpf, numero);
        }

        public bool UpdateCepAdotante(string cpf, string cep)
        {
            return new AdotanteService().UpdateCepAdotante(cpf, cep);
        }

        public bool UpdateCidadeAdotante(string cpf, string cidade)
        {
            return new AdotanteService().UpdateCidadeAdotante(cpf, cidade);
        }

        public bool UpdateEstadoAdotante(string cpf, string estado)
        {
            return new AdotanteService().UpdateEstadoAdotante(cpf, estado);
        }

        public bool UpdateBairroAdotante(string cpf, string bairro)
        {
            return new AdotanteService().UpdateBairroAdotante(cpf, bairro);
        }

        public bool UpdateChipPet(string cpf, int chip)
        {
            return new AdotanteService().UpdateChipPet(cpf, chip);
        }
        
        #endregion

        public void CadastrarAdotante(Adotante adotante)
        {

            Console.WriteLine(" >>> INICIANDO CADASTRO ADOTANTE <<< ");
            Thread.Sleep(1000);

            Console.Write("Nome: ");
            adotante.Nome = Console.ReadLine();

            Console.Write("CPF: ");
            adotante.Cpf = Console.ReadLine();

            Console.Write("Sexo: (M/F)");
            adotante.Sexo = char.Parse(Console.ReadLine().ToUpper());

            Console.Write("Data Nascimento: ");
            adotante.DataNascimento = DateTime.Parse(Console.ReadLine());

            Console.Write("Telefone: ");
            adotante.Telefone = Console.ReadLine();

            Console.Write("Logradouro: ");
            adotante.Logradouro = Console.ReadLine();

            Console.Write("CEP: ");
            adotante.Cep= Console.ReadLine();

            Console.Write("Complemento: ");
           adotante.Complemento = Console.ReadLine();

            Console.Write("Número: ");
           adotante.Numero= int.Parse(Console.ReadLine());

            Console.Write("Bairro: ");
            adotante.Bairro = Console.ReadLine();

            Console.Write("Cidade: ");
            adotante.Cidade = Console.ReadLine();

            Console.Write("Estado: ");
            adotante.Estado = Console.ReadLine();

            bool prossiga = false;
            do {
               
                Console.WriteLine("Chip Animal: ");
                int chip = int.Parse(Console.ReadLine());
                PetController petController = new PetController();
                Pet pet = petController.BuscarPet(chip);
                if (pet.Situacao == 'D')
                {
                    adotante.Chip = pet.CHIP;
                    petController.UpdateSituacaoPet(chip);
                    prossiga = true;
                }
                Console.WriteLine("Esse pet já possui um lar!\nForneça um lar para outro pet...");
                

            } while (prossiga==false);
            Console.WriteLine("Data Adoção");
            adotante.DataAdocao = System.DateTime.Now;

         


        } //cadastro adotante
    }
    
}
