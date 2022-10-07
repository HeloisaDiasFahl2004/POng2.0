using POng2._0.Models;
using POng2._0.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POng2._0.Controllers
{
   
        public class AdotanteController 
        {
            //métodos
            public Adotante InserirAdotante(Adotante adotante)
            {
                return new AdotanteService.InserirAdotante(adotante);
            }
        }
    
}
