using System;

namespace Models
{
    public class Pet
    {
        //propriedade, método construtor,tostring 
        public int CHIP { get; set; }
        public string Familia { get; set; }
        public string Raca { get; set; }
        public char Sexo { get; set; }
        public string Nome { get; set; }
        public char Situacao { get; set; }

        public Pet()
        {

        }
        public Pet(string f, string r, char s, string n, char sit)
        {

            this.Familia = f;
            this.Raca = r;
            this.Sexo = s;
            this.Nome = n;
            this.Situacao = sit;
        }

        public override string ToString()
        {
            return "\nCHIP: " + this.CHIP +
                "\nFamília: " + this.Familia +
                "\nRaca: " + this.Raca +
                "\nSexo: " + this.Sexo +
                "\nNome: " + this.Nome +
                "\nSituação: " + this.Situacao;
        }
    }
}
