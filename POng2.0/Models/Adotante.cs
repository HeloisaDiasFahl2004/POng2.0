using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POng2._0.Models
{
    public class Adotante
    { //propriedade, método construtor,Tostring 
        #region Constante
        public readonly static string INSERT = "INSERT INTO ONGPet (CPF,Nome,Sexo,DataNascimento,Endereco,Telefone) VALUES(@Cpf,@Nome,@Sexo,@DataNascimento,@Endereco,@Telefone)"; //criando uma constante publica, somente de leitura, já passando o comando do banco de dados
        //serve pra já inserir no bd

        public readonly static string SELECT = "SELECT * FROM ONGPet";

        public readonly static string UPDATE = "UPDATE Adotante set CAMPO= @Campo  WHERE cpf=@CPF;";// CAMPO -> CAMPO DESEJADO -> VER COMO FAZER

        public readonly static string DELETE = "DELETE FROM Adotante WHERE CPF=@CPF;";
        #endregion
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
