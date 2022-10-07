using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Adotante
    {
        //propriedade, método construtor,Tostring 
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public char Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public Endereco Endereco { get; set; }
        public string Telefone { get; set; }
        public Adotante()
        {

        }
        public Adotante(string n, string cpf, char sexo, DateTime dn, Endereco e, string t)
        {
            this.Nome = n;
            this.Cpf = cpf;
            this.Sexo = sexo;
            this.DataNascimento = dn;
            this.Endereco = e;
            this.Telefone = t;
        }
        public override string ToString()
        {
            return "\nCPF: " + this.Cpf +
                "\nNome: " + this.Nome +
                "\nSexo: " + this.Sexo +
                "\nData Nascimento: " + this.DataNascimento +
                "\nEndereco: " + this.Endereco +
                "\nTelefone: " + this.Telefone;

        }

    }
}
