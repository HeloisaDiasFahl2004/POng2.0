using POng2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POng2._0.Interface
{
    internal interface IPetController
    {
        public Pet InserirPet(Pet pet);

        public Pet BuscarPet(int chip);

        public List<Pet> SelectPet();

        public bool DeletPet(int chip);

        public bool UpdateNomePet(int chip,string nome);

        public bool UpdateSexoPet(int chip, char sexo);

        public bool UpdateRacaPet(int chip,string raca);

        public bool UpdateFamiliaPet(int chip, string familia);

        public bool UpdateSituacaoPet(int chip);

        public void CadastrarPet(Pet pet);
    }
}
