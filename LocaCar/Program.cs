using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace LocaCar
{
    class Program
    {


        static List<IAluguel> veiculos = new List<IAluguel>();
        enum Menu {Listar = 1, Cadastrar, Remover, Alugar,  Devolucao, Sair };
        static void Main(string[] args)
        {
            Carregar();
            Cabecalho();


            bool apertouSair = false;

            while (apertouSair == false)
            {
                Console.Clear();
                Cabecalho();

                Console.WriteLine($"1-Listar\n2-Cadastrar\n3-Remover\n4-Alugar\n5-Devolução\n6-Sair");
                int op = int.Parse(Console.ReadLine());
                Menu operacao = (Menu)op;

                switch (operacao)
                {
                    case Menu.Listar:
                        Console.Clear();
                        Cabecalho();
                        Listar();
                        break;
                        
                    case Menu.Cadastrar:
                        Console.Clear();
                        Cabecalho();
                        Cadastrar();
                        break;
                    case Menu.Remover:
                        Console.Clear();
                        Cabecalho();
                        Remover();
                        break;
                    case Menu.Alugar:
                        AlugarVeiculo();
                        break;
                    case Menu.Devolucao:
                        Console.Clear();
                        Cabecalho();
                        DevolverVeiculo();
                        break;
                    case Menu.Sair:
                        apertouSair = true;
                        break;
                    default:
                        break;
                }

            }
            Console.Clear();
        }

        public static void Cabecalho()
        {
            Console.WriteLine("*************************************************************************************");
            Console.WriteLine("                                     LoCAR                                           ");
            Console.WriteLine("*************************************************************************************");
        }

        public static void Carregar()
        {
            FileStream arquivo = new FileStream("Information.txt", FileMode.OpenOrCreate);
            BinaryFormatter codificador = new BinaryFormatter();
             try
            {
                veiculos = (List<IAluguel>)codificador.Deserialize(arquivo);
                if (veiculos == null)
                {
                    veiculos = new List<IAluguel>();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Um novo Banco de dados foi criado");
                veiculos = new List<IAluguel>();
            }

            arquivo.Close();

        }

        public static void Salvar()
        {
            FileStream arquivo = new FileStream("Information.txt", FileMode.OpenOrCreate);
            BinaryFormatter codificador = new BinaryFormatter();
            codificador.Serialize(arquivo, veiculos);

            arquivo.Close();
        }

        public static void Listar()
        {
            Console.Clear();
            Cabecalho();

            int id = 0;
            foreach(IAluguel veiculo in veiculos)
            {
                Console.WriteLine($"ID {id}");
                veiculo.Exibir();
                id++;
            }
           
            Console.ReadLine();
        }

        static void Remover()
        {
            Listar();
            Console.WriteLine($"0-Voltar ao Menu\n1-Continuar");
            int valorDigitado = int.Parse(Console.ReadLine());

            if (valorDigitado == 1)
            {
                Listar();
                Console.WriteLine("Digite o ID referente ao veiculo que queira remover");
                int id = int.Parse(Console.ReadLine());

                veiculos.RemoveAt(id);
                Salvar();
                Console.WriteLine();
                Console.WriteLine("Pressione Enter para retornar ao Menu");
                Console.ReadLine();
            }
            
        }

        public static void Cadastrar()
        {
            Console.Clear();
            Cabecalho();

            Console.WriteLine($"1-Carros\n2-Motos\n3-Van\n4-Voltar ao Menu");
            int valorDigitado = int.Parse(Console.ReadLine());

            bool apertouSair = false;

            switch (valorDigitado)
            {
                case 1:
                    CadastrarCarro();
                    break;
                case 2:
                    CadastrarMoto();
                    break;
                case 3:
                    CadastrarVan();
                    break;
                case 4:
                    Console.WriteLine("Programa finalizado");
                    apertouSair = true;
                    break;
                default:
                    Console.WriteLine("Numero invalido\nPressiona ENTER para continuar");
                    break;

            }
        }

        public static void CadastrarCarro()
        {
            Console.Clear();
            Cabecalho();

            Console.WriteLine("Digite o modelo do Veículo");
            string Modelo = Console.ReadLine();
            Console.WriteLine("Informe a Marca do Veículo ");
            string Marca = Console.ReadLine();
            Console.WriteLine("Informe o Ano do Veículo");
            string Ano = Console.ReadLine();
            Console.WriteLine("Informe a cor do veículo");
            string Cor = Console.ReadLine();
            Console.WriteLine("Informe a quantidade de portas do veículo");
            int Portas = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o preço do veículo");
            float Valor = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade do veículo");
            int Quantidade = int.Parse(Console.ReadLine());


            Carro carro = new Carro(Modelo, Marca, Ano, Cor, Valor, Portas, Quantidade);
            veiculos.Add(carro);
            Salvar();

            Console.WriteLine();
            Console.WriteLine("Pressione Enter para retornar ao Menu");
            Console.ReadLine();            
            Console.Clear();
        }

        public static void CadastrarMoto()
        {
            Console.Clear();
            Cabecalho();

            Console.WriteLine("Digite o modelo do Veículo");
            string Modelo = Console.ReadLine();
            Console.WriteLine("Informe a Marca do Veículo ");
            string Marca = Console.ReadLine();
            Console.WriteLine("Informe o Ano do Veículo");
            string Ano = Console.ReadLine();
            Console.WriteLine("Informe a cor do veículo");
            string Cor = Console.ReadLine();
            Console.WriteLine("Informe o preço do veículo");
            float Valor = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade do veículo");
            int Quantidade = int.Parse(Console.ReadLine());

            Moto moto = new Moto(Modelo, Marca, Ano, Cor, Valor, Quantidade);
            veiculos.Add(moto);
            Salvar();


            Console.WriteLine();
            Console.Clear();
        }
        public static void CadastrarVan()
        {
            Console.Clear();
            Cabecalho();

            Console.WriteLine("Digite o modelo do Veículo");
            string Modelo = Console.ReadLine();
            Console.WriteLine("Informe a Marca do Veículo ");
            string Marca = Console.ReadLine();
            Console.WriteLine("Informe o Ano do Veículo");
            string Ano = Console.ReadLine();
            Console.WriteLine("Informe a cor do veículo");
            string Cor = Console.ReadLine();
            Console.WriteLine("Informe o preço do veículo");
            float Valor = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe a quantidade do veículo");
            int Quantidade = int.Parse(Console.ReadLine());

            Van van = new Van(Modelo, Marca, Ano, Cor, Valor, Quantidade);
            veiculos.Add(van);
            Salvar();

            Console.WriteLine();
            Console.Clear();
        }

        public static void AlugarVeiculo()
        {
            Listar();
            Console.WriteLine("Digite o número do ID referente ao veiculo que queira alugar");
            int i = int.Parse(Console.ReadLine());

            veiculos[i].Alugar();
           
            Salvar();

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadLine();
        }

        public static void DevolverVeiculo()
        {

            Listar();
            Console.WriteLine("Digite o número do ID referente ao veiculo que queira alugar");
            int i = int.Parse(Console.ReadLine());

            veiculos[i].Devolver();

            Salvar();

            Console.WriteLine();
            Console.WriteLine("Pressione ENTER para continuar");
            Console.ReadLine();
        }
    }
}
