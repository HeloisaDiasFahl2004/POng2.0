using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POng2._0.Models
{

    public class Pet
    {
        #region Constante
        public readonly static string INSERT = "INSERT INTO Pet (Familia,Raca,Sexo,Nome,Situacao)" +
            "Values(@Familia,@Raca,@Sexo,@Nome,@Situacao)";

        public readonly static string SELECT = "SELECT * FROM Pet";


        public readonly static string UPDATEsituacao = $"UPDATE Pet set Situacao = {'A'}  WHERE chip=@Chip;";// CAMPO -> CAMPO DESEJADO -> VER COMO FAZER


        #endregion



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
            this.Situacao = 'D';//Disponível
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
