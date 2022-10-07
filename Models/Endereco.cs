using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Endereco
    { 
        //propriedade, método construtor,Tostring 
        public string Logradouro { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Endereco()
        {

        }

        public Endereco(string l, string cep, string comp, int num, string b, string c, string est)
        {
            this.Logradouro = l;
            this.Cep = cep;
            this.Complemento = comp;
            this.Numero = num;
            this.Bairro = b;
            this.Cidade = c;
            this.Estado = est;
        }
        public override string ToString()
        {
            return "\nLogradouro: " + this.Logradouro +
                "\nCEP: " + this.Cep +
                "\nComplemento: " + this.Complemento +
                "\nNúmero: " + this.Numero +
                "\nBairro: " + this.Bairro +
                "\nCidade: " + this.Cidade +
                "\nEstado: " + this.Estado;
        }
    }
}
