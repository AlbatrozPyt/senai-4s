using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleDeInventario
{
    public class Produto
    {
        public string? NomeProduto { get; set; }

        public int Qtd { get; set; }

        public static List<Produto> AdicionarProduto(Produto prod, List<Produto> prods)
        {
            var busca = prods.FirstOrDefault(x => x.NomeProduto == prod.NomeProduto);

            if (busca == null)
            {
                prods.Add(prod);
            }
            else
            {
                busca.Qtd += prod.Qtd;
            }

            return prods;
        }
    }
}
