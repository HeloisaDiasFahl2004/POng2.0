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
                Console.WriteLine("\t 2-Editar Adotante");
                Console.WriteLine("\t 3-Deletar Adotante");
                Console.WriteLine("\t 4-Exibir Adotante");
                Console.WriteLine("\t 5-Adotante já cadastrado");
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
                      
                        break;

                    //  case 2:
                    ////      bd.AtualizarCampoAdotante();
                    //      break;

                    //  case 3:
                    //  //    bd.DeletarAdotante();
                    //      break;

                    //  case 4:
                    //      adotante = new Adotante();
                    //      Console.WriteLine("Deseja: 1-Visualizar TODOS os adotantes 2- UM adotante em específico");
                    //      int resp = int.Parse(Console.ReadLine());

                    //  //    if (resp == 1) bd.VisualizarAdotantes(adotante);

                    //   //   else if (resp == 2) bd.BuscarAdotante(adotante);

                    //      else Console.WriteLine("Opção Inválida!");
                    //      break;
                    case 5:
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
                Console.WriteLine("\t<<< MENU ADOTADO >>>");
                Console.WriteLine("\t 0-Retornar ao menu principal");
                Console.WriteLine("\t 1-Cadastrar Adotado");
                Console.WriteLine("\t 2-Editar Adotado");
                Console.WriteLine("\t 3-Deletar Adotado");
                Console.WriteLine("\t 4-Exibir Adotado");
                Console.Write("\t Escolha uma opção: ");
                opc = int.Parse(Console.ReadLine());
                switch (opc)
                {
                    case 0:
                        Menu();
                        break;
                    case 1:
                       Pet pet  = new Pet();
                        PetController pe = new PetController();
                        pe.CadastrarPet(pet);
                        pe.InserirPet(pet);
                     
                        break;
                    //case 2:
                    //    bd.AtualizarCampoAdotado();
                    //    break;
                    //case 3:
                    //    bd.DeletarAdotado();
                    //    break;
                    //case 4:
                    //    adotado = new Adotado();
                    //    Console.WriteLine("Deseja exibir: 1-Todos os Adotados  2-Um Adotado em específico");
                    //    int opcao = int.Parse(Console.ReadLine());
                    //    if (opcao == 1) bd.VisualizarAdotados(adotado);
                    //    else if (opcao == 2) bd.BuscarAdotado(adotado);
                    //    else Console.WriteLine("Opção inválida!");
                    //    break;
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
