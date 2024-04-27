using APSFactoryMethod.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSFactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaRoupas fabrica;

            fabrica = new FabricaCamiseta();
            Roupas camiseta = fabrica.CriarRoupa();
            camiseta.Tipo = "Lacoste";
            camiseta.Tamanho = "M";
            camiseta.Cor = "Azul";
            camiseta.Preco = 49.99m;
            camiseta.ExibirDetalhes();

            fabrica = new FabricaCalca();
            Roupas calca = fabrica.CriarRoupa();
            calca.Tipo = "Jeans";
            calca.Tamanho = "40";
            calca.Cor = "Preto";
            calca.Preco = 79.90m;
            calca.ExibirDetalhes();

            fabrica = new FabricaJaqueta();
            Roupas jaqueta = fabrica.CriarRoupa();
            jaqueta.Tipo = "Couro";
            jaqueta.Tamanho = "G";
            jaqueta.Cor = "Marrom";
            jaqueta.Preco = 199.99m;
            jaqueta.ExibirDetalhes();
        }
    }
}
