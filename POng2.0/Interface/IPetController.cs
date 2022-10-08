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
        public void CadastrarPet(Pet pet);
    }
}
