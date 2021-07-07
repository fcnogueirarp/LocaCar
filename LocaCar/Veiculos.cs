using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaCar
{
    [System.Serializable]
    abstract public class Veiculos
    {
        public string Modelo;
        public string Marca;
        public string Ano;
        public string Cor;
        public float Valor;
        public int Quantidade;
        public string data;

        public void Alugar()
        {

            if (Quantidade > 0)
            {
                Quantidade -= 1;
                Console.WriteLine("Reserva efetuada com sucesso");

                Console.WriteLine("Informe a data que utilizará o veiculo - dd//mm/aa ");
                data = (Console.ReadLine());

                Console.WriteLine(data);
            }
            else
            {
                Console.WriteLine("Veículo Indisponível");
            }
        }

        public void Devolver()
        {
            Quantidade += 1;
        }

        public void Exibir()
        {
            Console.WriteLine($"Modelo: { Modelo}");
            Console.WriteLine($"Marca: { Marca}");
            Console.WriteLine($"Ano: { Ano}");
            Console.WriteLine($"Cor: { Cor}");
            Console.WriteLine($"Valor: { Valor}");
            Console.WriteLine($"Quantidade: { Quantidade}");
            Console.WriteLine("=============================");
            Console.WriteLine();
        }

    }
}
