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

        public Pet BuscarPet(int chip)
        {
            return new PetService().BuscarPet(chip);
        }

        public List<Pet> SelectPet()
        {
            return new PetService().SelectPet();
        }

        public bool DeletPet(int chip)
        {
            return new PetService().DeletPet(chip);
        }

        public bool UpdateNomePet(int chip, string nome)
        {
            return new PetService().UpdateNomePet(chip, nome);
        }

        public bool UpdateSexoPet(int chip, char sexo)
        {
            return new PetService().UpdateSexoPet(chip, sexo);
        }

        public bool UpdateRacaPet(int chip,string raca) 
        {
            return new PetService().UpdateRacaPet(chip, raca);
        }

        public bool UpdateFamiliaPet(int chip,string familia)
        {
            return new PetService().UpdateFamiliaPet(chip, familia);
        }

        public bool UpdateSituacaoPet(int chip)
        {
            return new PetService().UpdateSituacaoPet(chip);
        }

        public void CadastrarPet(Pet pet)
        {
            Console.WriteLine(" >>> INICIANDO CADASTRO Pet <<< ");
            Thread.Sleep(1000);

            Console.Write("Família: ");
            pet.Familia = Console.ReadLine();

            Console.Write("Raça: ");
            pet.Raca = Console.ReadLine();

            Console.Write("Sexo: ");
            pet.Sexo = char.Parse(Console.ReadLine());

            Console.Write("Nome: ");
            pet.Nome = Console.ReadLine();

            pet.Situacao = 'D';//Disponível para adoção
            Console.Write("A situação ficará como: " + pet.Situacao);
            Thread.Sleep(1000);

        }


    }
}
