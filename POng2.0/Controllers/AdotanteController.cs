using POng2._0.Interface;
using POng2._0.Models;
using POng2._0.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POng2._0.Controllers
{

    public class AdotanteController : IAdotanteController
    {
        //métodos
        public Adotante InserirAdotante(Adotante adotante)
        {
            return new AdotanteService().InserirAdotante(adotante);
        }

        public Adotante BuscarAdotante(String cpf)
        {
            return new AdotanteService().BuscarAdotante(cpf);
        }
      
        public List<Adotante> SelectAdotante()
        {
            return new AdotanteService().SelectAdotante();
        }

        public bool DeletAdotante(String cpf)
        {
            return new AdotanteService().DeletAdotante(cpf);
        }

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

            Console.WriteLine("Chip Animal: ");
            adotante.Chip = int.Parse(Console.ReadLine());

            Console.WriteLine("Data Adoção");
            adotante.DataAdocao = System.DateTime.Now;



        } //cadastro adotante
    }
    
}
