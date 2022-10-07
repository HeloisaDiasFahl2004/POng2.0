using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models
{
    internal class Adocao
    {
        //propriedades, método construtor , tostring
        public string CPF { get; set; }
        public int CHIP { get; set; }
        public DateTime DataAdocao { get; set; }

        public Adocao()
        {

        }
        public Adocao(string cpf, int chip, DateTime dataAdocao)
        {
            this.CPF = cpf;
            this.CHIP = chip;
            this.DataAdocao = DateTime.Now;
        }
        public override string ToString()
        {
            return "\nCPF: " + this.CPF +
                "\nCHIP: " + this.CHIP +
                "\nData Adoção: " + this.DataAdocao;

        }
    }
}
