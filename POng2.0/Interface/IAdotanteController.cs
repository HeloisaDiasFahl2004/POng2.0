﻿using POng2._0.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POng2._0.Interface
{
    public interface IAdotanteController
    {
        public Adotante InserirAdotante(Adotante adotante);

        public Adotante BuscarAdotante(String cpf);

        public List<Adotante> SelectAdotante();

        public bool DeletAdotante(String cpf);

        public void CadastrarAdotante(Adotante adotante);
    }
}
