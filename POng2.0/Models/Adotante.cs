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
        public readonly static string INSERT = "INSERT INTO Adotante (CPF,Nome,Sexo,DataNascimento,Telefone," +
            "Logradouro,CEP,Complemento,Numero,Bairro,Cidade,Estado) " +
            "VALUES(@Cpf,@Nome,@Sexo,@DataNascimento,@Telefone," +
            "@Logradouro,@CEP,@Complemento,@Numero,@Bairro,@Cidade,@Estado)";
        //criando uma constante publica, somente de leitura, já passando o comando do banco de dados

        //serve pra já inserir no bd

        public readonly static string SELECT = "SELECT * FROM Adotante a inner join Endereco e on e.CPF = a.CPF;";

        public readonly static string UPDATE = "UPDATE Adotante set CAMPO= @Campo  WHERE cpf=@CPF;";// CAMPO -> CAMPO DESEJADO -> VER COMO FAZER

        public readonly static string DELETE = "DELETE FROM Adotante WHERE CPF=@CPF;";
        #endregion
        public string Cpf { get; set; }
        public string Nome { get; set; }
        public char Sexo { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Telefone { get; set; }
        public string Logradouro { get; set; }
        public string Cep { get; set; }
        public string Complemento { get; set; }
        public int Numero { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }

        public Adotante()
        {

        }
        public Adotante(string n, string cpf, char sexo, DateTime dn, string t, string l, string cep, string comp, int num, string b, string c, string est)
        {
            this.Nome = n;
            this.Cpf = cpf;
            this.Sexo = sexo;
            this.DataNascimento = dn;
            this.Telefone = t;
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
            return "\nCPF: " + this.Cpf +
                "\nNome: " + this.Nome +
                "\nSexo: " + this.Sexo +
                "\nData Nascimento: " + this.DataNascimento +
                "\nTelefone: " + this.Telefone +
                "\nLogradouro: " + this.Logradouro +
                "\nCEP: " + this.Cep +
                "\nComplemento: " + this.Complemento +
                "\nNúmero: " + this.Numero +
                "\nBairro: " + this.Bairro +
                "\nCidade: " + this.Cidade +
                "\nEstado: " + this.Estado;

        }
    }
}
