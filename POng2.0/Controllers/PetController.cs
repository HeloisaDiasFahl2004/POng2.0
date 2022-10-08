using POng2._0.Interface;
using POng2._0.Models;
using POng2._0.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace POng2._0.Controllers
{
    public class PetController : IPetController
    {
        public Pet InserirPet(Pet pet)
        {
            return new PetService().InserirPet(pet);
        }

       

        public void CadastrarPet(Pet pet)
        {
            Console.WriteLine(" >>> INICIANDO CADASTRO Pet <<< ");
            Thread.Sleep(1000);

            Console.WriteLine("Família: ");
            pet.Familia = Console.ReadLine();

            Console.WriteLine("Raça: ");
            pet.Raca = Console.ReadLine();

            Console.WriteLine("Sexo: ");
            pet.Sexo = char.Parse(Console.ReadLine());

            Console.WriteLine("Nome: ");
            pet.Nome = Console.ReadLine();

            pet.Situacao = 'D';//Disponível para adoção
            Console.WriteLine("A situação ficará como: " + pet.Situacao);

        }
    }
}
