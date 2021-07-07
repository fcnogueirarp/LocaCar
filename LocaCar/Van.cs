using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LocaCar
{
    [System.Serializable]
    class Van : Veiculos , IAluguel
    {
        public Van(string Modelo, string Marca, string Ano, String Cor, float Valor, int Quantidade)
        {
            this.Modelo = Modelo;
            this.Marca = Marca;
            this.Ano = Ano;
            this.Cor = Cor;
            this.Valor = Valor;
            this.Quantidade = Quantidade;
        }

       
    }
}
