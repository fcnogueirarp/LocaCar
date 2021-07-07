using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaCar

{
    [System.Serializable]
    class Carro : Veiculos, IAluguel
    {
        public int Portas;

        public Carro(string Modelo, string Marca, string Ano, string Cor, float Valor, int Portas, int Quantidade)
        {
            this.Portas = Portas;
            this.Modelo = Modelo;
            this.Marca = Marca;
            this.Ano = Ano;
            this.Cor = Cor;
            this.Valor = Valor;
            this.Quantidade = Quantidade;
        }

        public void Exibir()
        {
              Console.WriteLine($"Modelo { Modelo}");
              Console.WriteLine($"Marca { Marca}");
              Console.WriteLine($"Ano { Ano}");
              Console.WriteLine($"Cor { Cor}");
              Console.WriteLine($"Valor { Valor}");
              Console.WriteLine($"Portas { Portas}");
              Console.WriteLine($"Quantidade {Quantidade}");
              Console.WriteLine("=============================");
              Console.WriteLine();
        }
    }
}

