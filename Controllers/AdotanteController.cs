using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controllers
{
    public class AdotanteController
    {
        //métodos
        public Adotante InserirAdotante(Adotante adotante)
        {
            return new AdotanteServices.InserirAdotante(adotante);
        }
    }
}
