using POng2._0.Controllers;
using POng2._0.Models;
using POng2._0.Services;
using System;
using System.Reflection.PortableExecutable;
using System.Threading;

namespace POng2._0
{
    internal class Program
    {
       static AdotanteController ad = new AdotanteController();
        static string ValidarEntrada()
        {
            Console.Write("Informe o CPF para prosseguir: ");
            try
            {
                string cpf = Console.ReadLine();
               
              
                if (ad.BuscarAdotante(cpf)!=null)
                {
                    return cpf;
                }
               

            }
            catch(Exception )
            {
                Console.WriteLine("CPF Inválido!");
                Console.ReadKey();
            }
            return null;
        }
        static void Menu()
        {
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("\t<<< MENU >>>");
                Console.WriteLine("\t 0-Sair do Menu");
                Console.WriteLine("\t 1-Menu Adotante");
                Console.WriteLine("\t 2-Menu Pet");
                Console.Write("\t Escolha uma opção: ");
                opc = int.Parse(Console.ReadLine());


                switch (opc)
                {
                    case 0:
                        Console.Write("Saindo . ");
                        Thread.Sleep(200);
                        Console.Write(" .");
                        Thread.Sleep(200);
                        Console.Write(" .");
                        Thread.Sleep(200);
                        Environment.Exit(0);
                        break;
                    case 1:
                        Console.Write("Encaminhando para o menu adotante . ");
                        Thread.Sleep(350);
                        Console.Write(" .");
                        Thread.Sleep(350);
                        Console.Write(" .");
                        Thread.Sleep(350);
                        MenuAdotante();
                        break;
                    case 2:
                        Console.Write("Encaminhando para o menu pet . ");
                        Thread.Sleep(350);
                        Console.Write(" .");
                        Thread.Sleep(350);
                        Console.Write(" .");
                        Thread.Sleep(350);
                        MenuPet();
                        break;
                    default:
                        Console.Write("Opção Inválida!");
                        break;

                }
            } while (opc != 0);
        } //4 opções -> sair/menu adotante/ menu adotado/adoção
        static void MenuAdotante()
        {
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("\t<<< MENU ADOTANTE >>>");
                Console.WriteLine("\t 0-Retornar ao menu principal");
                Console.WriteLine("\t 1-Cadastrar Adotante");
                Console.WriteLine("\t 2-Editar Adotante");//
                Console.WriteLine("\t 3-Deletar Adotante");
                Console.WriteLine("\t 4-Exibir todos Adotantes");// ok
                Console.WriteLine("\t 5-Adotante já cadastrado");// ok
                Console.Write("\t Escolha uma opção: ");
                opc = int.Parse(Console.ReadLine());

                switch (opc)
                {
                    case 0:
                        Menu();
                        break;
                    case 1:
                        Adotante adotante = new Adotante();//crio o objeto
                        AdotanteController ad = new AdotanteController();// utilizando design pattern command
                        ad.CadastrarAdotante(adotante);//cadastro esse objeto
                        ad.InserirAdotante(adotante);//insiro esse objeto no banco de dados
                        Console.WriteLine("Adotante inserido com sucesso!");
                        Console.WriteLine(">>> Retornando para o menu do adotante <<<");
                        Thread.Sleep(900);
                        break;

                    case 2:
                        ad = new AdotanteController();
                       
                        string cpf = ValidarEntrada();
                        if (cpf == null)
                        {
                            Console.WriteLine(">>> Retornando para o menu do adotante <<<");
                            Thread.Sleep(900);
                            MenuAdotante();
                        }
                        Console.Write("Informe o campo que deseja editar: 0-Cancelar Edição  1-Nome  2-Sexo  3-Data Nascimento  4-Endereço  5-Telefone  6-Chip do Animal");
                        int campo = int.Parse(Console.ReadLine());
                        switch (campo)
                        {
                            case 0:
                                return;
                            case 1:
                                Console.Write("Informe o Nome: ");
                                string nome = Console.ReadLine();
                                var resulte = ad.UpdateNomeAdotante(cpf,nome);
                                if (resulte)
                                {
                                    Console.WriteLine("Adotante atualizado com sucesso!");
                                    Console.ReadKey();
                                }
                                Console.WriteLine("Não foi possível atualizar!");
                                Console.WriteLine(">>> Retornando para o menu do adotante <<<");
                                Thread.Sleep(900);
                                break;
                            case 2:
                                Console.Write("Informe o Sexo: ");
                                char sexo = char.Parse(Console.ReadLine());
                                var resulta = ad.UpdateSexoAdotante(cpf, sexo);
                                if (resulta)
                                {
                                    Console.WriteLine("Adotante atualizado com sucesso!");
                                    Console.ReadKey();
                                }
                                Console.WriteLine("Não foi possível atualizar!");
                                Console.WriteLine(">>> Retornando para o menu do adotante <<<");
                                Thread.Sleep(900);
                                break;
                            case 3:
                                Console.Write("Informe a Data de Nascimento: ");
                                DateTime dataNasc=DateTime.Parse(Console.ReadLine());
                                var resultad = ad.UpdateDataNascimentoAdotante(cpf,dataNasc);
                                if (resultad)
                                {
                                    Console.WriteLine("Adotante atualizado com sucesso!");
                                    Console.ReadKey();
                                }
                                Console.WriteLine("Não foi possível atualizar!");
                                Console.WriteLine(">>> Retornando para o menu do adotante <<<");
                                Thread.Sleep(900);
                                break;
                            case 4:
                                Console.Write("Informe o que deseja editar do Endereço: 0-Cancelar Edição 1-Logradouro  2-CEP  3-Complemento  4-Numero  5-Bairro  6-Cidade  7-Estado ");
                                int r = int.Parse(Console.ReadLine());
                                switch (r)
                                {
                                    case 0:
                                        return;
                                    case 1:
                                        Console.Write("Informe o Logradouro: ");
                                        string logradouro = Console.ReadLine();
                                        var res = ad.UpdateLogradouroAdotante(cpf, logradouro);
                                        if (res)
                                        {
                                            Console.WriteLine("Adotante atualizado com sucesso!");
                                            Console.ReadKey();
                                        }
                                        Console.WriteLine("Não foi possível atualizar!");
                                        Console.WriteLine(">>> Retornando para o menu do adotante <<<");
                                        Thread.Sleep(900);
                                        break;
                                    case 2:
                                        Console.Write("Informe o CEP: ");
                                        string cep =Console.ReadLine();
                                        var resul = ad.UpdateCepAdotante(cpf, cep);
                                        if (resul)
                                        {
                                            Console.WriteLine("Adotante atualizado com sucesso!");
                                            Console.ReadKey();
                                        }
                                        Console.WriteLine("Não foi possível atualizar!");
                                        Console.WriteLine(">>> Retornando para o menu do adotante <<<");
                                        Thread.Sleep(900);
                                        break;
                                    case 3:
                                        Console.Write("Informe o Complemento: ");
                                        string complemento = Console.ReadLine();
                                        var re = ad.UpdateComplementoAdotante(cpf, complemento);
                                        if (re)
                                        {
                                            Console.WriteLine("Adotante atualizado com sucesso!");
                                            Console.ReadKey();
                                        }
                                        Console.WriteLine("Não foi possível atualizar!");
                                        Console.WriteLine(">>> Retornando para o menu do adotante <<<");
                                        Thread.Sleep(900);
                                        break;
                                    case 4:
                                        Console.Write("Informe o Numero: ");
                                        int num = int.Parse(Console.ReadLine());
                                        var respta = ad.UpdateNumeroAdotante(cpf,num);
                                        if (respta)
                                        {
                                            Console.WriteLine("Adotante atualizado com sucesso!");
                                            Console.ReadKey();
                                        }
                                        Console.WriteLine("Não foi possível atualizar!");
                                        Console.WriteLine(">>> Retornando para o menu do adotante <<<");
                                        Thread.Sleep(900);
                                        break;
                                    case 5:
                                        Console.Write("Informe o Bairro: ");
                                        string bairro = Console.ReadLine(); 
                                        var repta = ad.UpdateBairroAdotante(cpf,bairro);
                                        if (repta)
                                        {
                                            Console.WriteLine("Adotante atualizado com sucesso!");
                                            Console.ReadKey();
                                        }
                                        Console.WriteLine("Não foi possível atualizar!");
                                        Console.WriteLine(">>> Retornando para o menu do adotante <<<");
                                        Thread.Sleep(900);
                                        break;
                                    case 6:
                                        Console.Write("Informe a Cidade: ");
                                        string cidade = Console.ReadLine();
                                        var rpsta=ad.UpdateCidadeAdotante(cpf,cidade);
                                        if (rpsta)
                                        {
                                            Console.WriteLine("Adotante atualizado com sucesso!");
                                            Console.ReadKey();
                                        }
                                        Console.WriteLine("Não foi possível atualizar!");
                                        Console.WriteLine(">>> Retornando para o menu do adotante <<<");
                                        Thread.Sleep(900);
                                        break;
                                    case 7:
                                        Console.Write("Informe o Estado: ");
                                        string estado = Console.ReadLine();
                                        var rpta = ad.UpdateEstadoAdotante(cpf,estado);
                                        if (rpta)
                                        {
                                            Console.WriteLine("Adotante atualizado com sucesso!");
                                            Console.ReadKey();
                                        }
                                        Console.WriteLine("Não foi possível atualizar!");
                                        Console.WriteLine(">>> Retornando para o menu do adotante <<<");
                                        Thread.Sleep(900);
                                        break;
                                }
                                break;
                            case 5:
                                Console.Write("Informe o Telefone: ");
                                string telefone = Console.ReadLine();
                                var resultado = ad.UpdateTelefoneAdotante(cpf, telefone);
                                if (resultado)
                                {
                                    Console.WriteLine("Adotante atualizado com sucesso!");
                                    Console.ReadKey();
                                }
                                Console.WriteLine("Não foi possível atualizar!");
                                Console.WriteLine(">>> Retornando para o menu do adotante <<<");
                                Thread.Sleep(900);
                                break;
                            case 6:
                                bool prossiga = false;
                                do
                                {
                                    Console.WriteLine("Informe o Chip do Animal que deseja adotar: ");
                                    int chip = int.Parse(Console.ReadLine());
                                    PetController petController = new PetController();
                                    Pet pet = petController.BuscarPet(chip);
                                    if (pet.Situacao == 'D')
                                    {
                                        var resultados = ad.UpdateChipPet(cpf, chip);
                                        petController.UpdateSituacaoPet(chip);
                                        prossiga = true;
                                    }
                                    Console.WriteLine("Esse pet já possui um lar!\nForneça um lar para outro pet...");


                                } while (prossiga == false);
                                break;
                        }
                                break;
                    case 3:
                        ad = new AdotanteController();

                     
                        cpf = ValidarEntrada();
                        if (cpf == null)
                        {
                          
                            Console.WriteLine(">>> Retornando para o menu do adotante <<<");
                            Thread.Sleep(900);
                            break;
                        }
                     var result = ad.DeletAdotante(cpf);
                        if (result)
                        {
                            Console.WriteLine("Adotante excluído com sucesso!");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("Não foi possível deletar!"); 
                        Console.WriteLine(">>> Retornando para o menu do adotante <<<");
                        Thread.Sleep(900);
                        MenuAdotante();
                        break;

                    case 4:
                        Console.WriteLine(">>> INÍCIO IMPRESSÃO <<< ");
                        ad = new AdotanteController();
                        var adotantes = ad.SelectAdotante();
                        adotantes.ForEach(x => Console.WriteLine(x));
                        Console.WriteLine(">>> FIM IMPRESSÃO <<< ");
                        Console.ReadKey();
                        break;
                    case 5:
                        ad = new AdotanteController();
                        
                         cpf = ValidarEntrada();
                        if (cpf == null)
                        {
                            Console.WriteLine("CPF inexistente!");
                            Console.WriteLine(">>> Retornando para o menu do adotante <<<");
                            Thread.Sleep(900);
                            MenuAdotante();
                        }
                        Adotante adotant = ad.BuscarAdotante(cpf);
                        Console.WriteLine(adotant);
                        Console.ReadKey();
                        //"login" do adotante            
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;

                }
            } while (opc != 0);
        } // 5 opções  -> sair/cadastrar/editar/deletar/exibir
        static void MenuPet()
        {
            int opc;
            do
            {
                Console.Clear();
                Console.WriteLine("\t<<< MENU PET >>>");
                Console.WriteLine("\t 0-Retornar ao menu principal");
                Console.WriteLine("\t 1-Cadastrar Pet");
                Console.WriteLine("\t 2-Editar Pet");
                Console.WriteLine("\t 3-Deletar Pet");
                Console.WriteLine("\t 4-Exibir todos os Pet");
                Console.Write("\t Escolha uma opção: ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 0:
                        Menu();
                        break;
                    case 1:
                        Pet pet = new Pet();
                        PetController pe = new PetController();
                        pe.CadastrarPet(pet);
                        pe.InserirPet(pet);
                        Console.WriteLine("Pet inserido com sucesso!");
                        Console.WriteLine(">>> Retornando para o menu do pet <<<");
                        Thread.Sleep(900);
                        break;
                    case 2:
                        pe = new PetController();
                        Console.Write("Informe o chip do animal que deseja editar: ");
                        int chip = int.Parse(Console.ReadLine());
                        pe.BuscarPet(chip);
                        Console.Write("Informe o campo que deseja editar: 0-Cancelar Edição  1-Familia  2-Raça  3-Sexo  4-Nome ");
                        int campo = int.Parse(Console.ReadLine());
                        switch (campo) 
                        {
                            case 0:
                                return;
                            case 1:
                                Console.Write("Informe a Família: ");
                                string f = Console.ReadLine();
                                var resultado = pe.UpdateFamiliaPet(chip, f);
                                if (resultado)
                                {
                                    Console.WriteLine("Pet atualizado com sucesso!");
                                    Console.ReadKey();
                                    break;
                                }
                                Console.WriteLine("Não foi possível atualizar!");
                                Console.WriteLine(">>> Retornando para o menu do pet <<<");
                                Thread.Sleep(900);
                                break;
                            case 2:
                                Console.Write("Informe a Raca: ");
                                string r = Console.ReadLine();
                                var resulta = pe.UpdateRacaPet(chip, r);
                                if (resulta)
                                {
                                    Console.WriteLine("Pet atualizado com sucesso!");
                                    Console.ReadKey();
                                    break;
                                }
                                Console.WriteLine("Não foi possível atualizar!");
                                Console.WriteLine(">>> Retornando para o menu do pet <<<");
                                Thread.Sleep(900);
                                break;
                            case 3:
                                Console.Write("Informe o Sexo: ");
                                char Sexo = char.Parse(Console.ReadLine());
                                var respta = pe.UpdateSexoPet(chip, Sexo);
                                if (respta)
                                {
                                    Console.WriteLine("Pet atualizado com sucesso!");
                                    Console.ReadKey();
                                    break;
                                }
                                Console.WriteLine("Não foi possível atualizar!");
                                Console.WriteLine(">>> Retornando para o menu do pet <<<");
                                Thread.Sleep(900);
                                break;
                            case 4:
                                Console.Write("Informe o Nome: ");
                                string nome =Console.ReadLine();
                                var resp= pe.UpdateNomePet(chip, nome);
                                if (resp)
                                {
                                    Console.WriteLine("Pet atualizado com sucesso!");
                                    Console.ReadKey();
                                    break;
                                }
                                Console.WriteLine("Não foi possível atualizar!");
                                Console.WriteLine(">>> Retornando para o menu do pet <<<");
                                Thread.Sleep(900);
                                break;
                        }
                        break;
                    case 3:
                        pe = new PetController();
                        Console.WriteLine("Informe o CHIP: ");
                        chip = int.Parse(Console.ReadLine());
                        pe.BuscarPet(chip);
                        var result = pe.DeletPet(chip);
                        if (result)
                        {
                            Console.WriteLine("Pet excluído com sucesso!");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("Não foi possível deletar!");
                        Console.WriteLine(">>> Retornando para o menu do pet <<<");
                        Thread.Sleep(900);
                        break;
                    case 4:
                        Console.WriteLine(">>> INÍCIO IMPRESSÃO <<< ");
                        pe = new PetController();
                        var pets = pe.SelectPet();
                        pets.ForEach(x=>Console.WriteLine(x));
                        Console.WriteLine(">>> FIM IMPRESSÃO <<<");
                        Console.ReadKey();
                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }
            } while (opc != 0);
        }// 5 opções  -> sair/cadastrar/editar/deletar/exibir
        static void Main(string[] args)
        {
            //View 
            Menu();
        }

    }
}
