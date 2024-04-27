using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APSFactoryMethod.Classes
{
    public interface Roupas
    {
        string Tipo { get; set; }
        string Tamanho { get; set; }
        string Cor { get; set; }
        decimal Preco { get; set; }


        void ExibirDetalhes();
       
    }
}
